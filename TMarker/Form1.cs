using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace TMarker
{
    public partial class Form1 : Form
    {
        string prevImage        = "";
        string selectedPath     = "";
        StringAlignment halign  = StringAlignment.Center;
        StringAlignment valign  = StringAlignment.Center;
        List<string> imgTyp     = new List<string>() { ".jpg", ".png", ".bmp", ".gif" };

        public Form1()
        {
            InitializeComponent();
            cbPosition.SelectedIndex = 0;
        }


        //Write the Watermark on all Files of the List
        private void btStart_Click(object sender, EventArgs e)
        {
            if (tbExportPfad.Text.Length > 0)
            {
                foreach (object img in lbItems.Items)
                {
                    //create Bitmap Object
                    Bitmap myBitmap;
                    myBitmap = new Bitmap(img.ToString());

                    //Resize
                    if (cbResize.Checked)
                    {
                        int Height          = Convert.ToInt32(tbHeight.Text);
                        int Width           = Convert.ToInt32(tbWidth.Text);

                        if (Height == 0 && Width > 0)
                        {
                            double hpx      = Convert.ToDouble(Width) / Convert.ToDouble(myBitmap.Width) * myBitmap.Height;
                            int new_height  = Convert.ToInt32(hpx);
                            myBitmap        = new Bitmap(myBitmap, new Size(Width, new_height));
                        }
                        else if (Height > 0 && Width == 0)
                        {
                            double wpx      = Convert.ToDouble(Height) / Convert.ToDouble(myBitmap.Height) * myBitmap.Width;
                            int new_width   = Convert.ToInt32(wpx);
                            myBitmap        = new Bitmap(myBitmap, new Size(new_width, Height));
                        }
                        else if (Height == 0 && Width == 0)
                            myBitmap        = new Bitmap(myBitmap, myBitmap.Width, myBitmap.Height);
                        else
                            myBitmap        = new Bitmap(myBitmap, Width, Height);
                    }

                    //Create graphics object
                    Graphics pic                = Graphics.FromImage(myBitmap);

                    // Antialiasing
                    if(cbAntiA.Checked)
                        pic.TextRenderingHint   = System.Drawing.Text.TextRenderingHint.AntiAlias;


                    //String ausrichten
                    StringFormat strFormat      = new StringFormat();
                    strFormat.Alignment         = halign;
                    strFormat.LineAlignment     = valign;

                    //Tansparenz und Farbe in Brush einfügen
                    int tranz   = Convert.ToInt32(tbOpcity.Text);
                    Brush brush = new SolidBrush(Color.FromArgb(tranz, colorDialog1.Color));

                    //String zeichnen
                    pic.DrawString(tbWaterMark.Text, fontDialog1.Font, brush, new RectangleF(Convert.ToInt32(offsetX.Text), Convert.ToInt32(offsetY.Text), myBitmap.Width, myBitmap.Height), strFormat);

                    //Speicherpfad erstellen
                    string pfad;
                    if (selectedPath.Length > 0)
                        pfad = Path.GetFullPath(tbExportPfad.Text + img.ToString().Replace(selectedPath, "").Replace(@"\", @"\\"));
                    else
                        pfad = Path.GetFullPath(tbExportPfad.Text+ "\\" + Path.GetFileName(img.ToString().Replace(@"\", @"\\")));

                    string folderpath = Path.GetDirectoryName(pfad).Replace(@"\", @"\\");

                    //Abspeichern
                    if (!Directory.Exists(folderpath))
                        Directory.CreateDirectory(folderpath);
                    myBitmap.Save(pfad);

                }
                MessageBox.Show("Finished. Opening folder...");
                OpenExplorer(@tbExportPfad.Text);
            }
            else
            {
                MessageBox.Show("Please select an Export-Path first.");
            }
        }

        //Draws a String on the Preview Image and Updates the Preview
        private void updatePreview()
        {
            Bitmap myBitmap;
            // Load Bitmap from Selected Picture or from included default
            if(prevImage.Length > 0)
                myBitmap = new Bitmap(prevImage);
            else
                myBitmap = new Bitmap(TMarker.Properties.Resources.Tha02047_1024);

            //Resize
            if (cbResize.Checked)
            {
                int Height  = Convert.ToInt32(tbHeight.Text);
                int Width   = Convert.ToInt32(tbWidth.Text);

                if (Height == 0 && Width > 0)
                {
                    double hpx = Convert.ToDouble(Width) / Convert.ToDouble(myBitmap.Width) * myBitmap.Height;
                    int new_height = Convert.ToInt32(hpx);
                    myBitmap = new Bitmap(myBitmap, new Size(Width, new_height));
                }
                else if (Height > 0 && Width == 0)
                {
                    double wpx = Convert.ToDouble(Height) / Convert.ToDouble(myBitmap.Height) * myBitmap.Width;
                    int new_width = Convert.ToInt32(wpx);
                    myBitmap = new Bitmap(myBitmap, new Size(new_width, Height));
                }
                else if (Height == 0 && Width == 0)
                    myBitmap = new Bitmap(myBitmap, myBitmap.Width, myBitmap.Height);
                else
                    myBitmap = new Bitmap(myBitmap, Width, Height);
            }
            Graphics pic = Graphics.FromImage(myBitmap);

           

            //Activate Antialiasing
            if(cbAntiA.Checked)
                pic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            //Set the Alignment of the Watermark
            StringFormat strFormat  = new StringFormat();
            strFormat.Alignment     = halign;
            strFormat.LineAlignment = valign;

            //Get the Opacity and include it into a Brush with the selected Font Color
            int tranz = Convert.ToInt32(tbOpcity.Text);
            Brush brush = new SolidBrush(Color.FromArgb(tranz, colorDialog1.Color));
            
            //Draw the String on the Picture
            pic.DrawString(tbWaterMark.Text, fontDialog1.Font, brush, new RectangleF(Convert.ToInt32(offsetX.Text),Convert.ToInt32(offsetY.Text),myBitmap.Width, myBitmap.Height), strFormat);
            
            //Put it in the PictureBox again
            pbPreview.Image = myBitmap;
            pbPreview.Refresh();
        }



        //Opens the Windows Explorer at a selected Path
        private static  void OpenExplorer(string path)
        {
            if (Directory.Exists(path))
                Process.Start("explorer.exe", path);
        }

        //Recursivly Searches through directorys and add Image Files to the List
        private         void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    addImageFiles(d);
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        //Add allowed Image Files to List from a dir
        private void addImageFiles(string dir)
        {
            foreach (string ftype in imgTyp)
            {
                foreach (string f in Directory.GetFiles(dir, "*"+ftype))
                {
                    lbItems.Items.Add(f);
                }
            }
        }




        //##################Events##################
        //Settings Stuff
        //Resize Checkbox Event
        private void cbResize_CheckedChanged(object sender, EventArgs e)
        {
            lHeight.Enabled     = cbResize.Checked;
            lWidth.Enabled      = cbResize.Checked;
            tbHeight.Enabled    = cbResize.Checked;
            tbWidth.Enabled     = cbResize.Checked;
            updatePreview();
        }

        //Values Changes of Offset Textboxes
        private void offsetX_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(offsetX.Text);
                updatePreview();
            }
            catch
            {
                MessageBox.Show("Please insert a number.");
                offsetX.Text = "0";
            }
        }

        private void offsetY_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(offsetY.Text);
                updatePreview();
            }
            catch
            {
                MessageBox.Show("Please insert a number.");
                offsetY.Text = "0";
            }
        }

        //Opacity Value Changed
        private void tbOpcity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tbOpcity.Text);
                updatePreview();
            }
            catch
            {
                MessageBox.Show("Please insert a number between 0 and 255.");
                tbOpcity.Text = "0";
            }
        }

        //Button to Change to Font Type clicked
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                this.tbWaterMark.Font = new Font(font.FontFamily, 15);
            }
            updatePreview();
        }

        //Button to Change the Color clicked
        private void btFarbe_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbWaterMark.ForeColor = colorDialog1.Color;
            }

            updatePreview();
        }

        //Selected Position of Watermark Changed
        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbPosition.Text) == "Center")
            {
                halign = StringAlignment.Center;
                valign = StringAlignment.Center;
            }

            if (Convert.ToString(cbPosition.Text) == "Top")
            {
                halign = StringAlignment.Center;
                valign = StringAlignment.Near;
            }

            if (Convert.ToString(cbPosition.Text) == "Bottom")
            {
                halign = StringAlignment.Center;
                valign = StringAlignment.Far;
            }

            if (Convert.ToString(cbPosition.Text) == "Left")
            {
                halign = StringAlignment.Near;
                valign = StringAlignment.Center;
            }

            if (Convert.ToString(cbPosition.Text) == "Right")
            {
                halign = StringAlignment.Far;
                valign = StringAlignment.Center;
            }

            if (Convert.ToString(cbPosition.Text) == "TopLeft")
            {
                halign = StringAlignment.Near;
                valign = StringAlignment.Near;
            }

            if (Convert.ToString(cbPosition.Text) == "TopRight")
            {
                halign = StringAlignment.Far;
                valign = StringAlignment.Near;
            }

            if (Convert.ToString(cbPosition.Text) == "BottomLeft")
            {
                halign = StringAlignment.Near;
                valign = StringAlignment.Far;
            }

            if (Convert.ToString(cbPosition.Text) == "BottomRight")
            {
                halign = StringAlignment.Far;
                valign = StringAlignment.Far;
            }

            updatePreview();
        }

        //Text of WaterMark has Changed
        private void tbWaterMark_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }

        //Folderdialog for Exportpath
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbExportPfad.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //Button to add Copyright Char to Textbox
        private void button1_Click(object sender, EventArgs e)
        {
            tbWaterMark.Text += "©";
            updatePreview();
        }

        //New Width of Picture Changed
        private void tbWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tbWidth.Text);
                updatePreview();
            }
            catch
            {
                MessageBox.Show("Please insert a positive number.");
                tbWidth.Text = "0";
            }
        }

        //New Height of Picture Changed
        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tbHeight.Text);
                updatePreview();
            }
            catch
            {
                MessageBox.Show("Please insert a positive number.");
                tbWidth.Text = "0";
            }
        }

        //List Stuff
        //Event for clicking the Button to add Folders
        private void btAddFolder_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btAddFile.Enabled   = false;
                btAddFolder.Enabled = false;
                selectedPath        = dlg.SelectedPath;

                addImageFiles(selectedPath);
                DirSearch(selectedPath);
            }
        }

        //Event for clicking the Button to add Files
        private void btAddFile_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";
            dlg.FilterIndex = 1;
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btAddFolder.Enabled = false;
                foreach (string file in dlg.FileNames)
                {
                    lbItems.Items.Add(file);
                }
            }
        }

        //Event for clicking the Button to clear the Selected Images
        private void btItemsClear_Click(object sender, EventArgs e)
        {
            lbItems.Items.Clear();
            selectedPath        = "";
            btAddFolder.Enabled = true;
            btAddFile.Enabled   = true;
            prevImage           = "";
            updatePreview();
        }

        //Event for Changing the Preview to selected Image in List
        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            prevImage = lbItems.SelectedItem.ToString();
            updatePreview();
        }

        private void cbAntiA_CheckedChanged(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void DonateBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=MEL64BHWWF6A6");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com/tobbi007/TMarker");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Process.Start("mailto://tobiasviertmann@gmail.com");
        }


    }
}
