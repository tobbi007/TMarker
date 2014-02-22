namespace TMarker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WaterMark = new System.Windows.Forms.TabPage();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lHeight = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lWidth = new System.Windows.Forms.Label();
            this.cbResize = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOpcity = new System.Windows.Forms.TextBox();
            this.btFarbe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.offsetY = new System.Windows.Forms.TextBox();
            this.offsetX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExportPfad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbWaterMark = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Import = new System.Windows.Forms.TabPage();
            this.btAddFile = new System.Windows.Forms.Button();
            this.btAddFolder = new System.Windows.Forms.Button();
            this.btItemsClear = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbAntiA = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DonateBox = new System.Windows.Forms.PictureBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.WaterMark.SuspendLayout();
            this.Import.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preview:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WaterMark);
            this.tabControl1.Controls.Add(this.Import);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 475);
            this.tabControl1.TabIndex = 2;
            // 
            // WaterMark
            // 
            this.WaterMark.Controls.Add(this.cbAntiA);
            this.WaterMark.Controls.Add(this.tbHeight);
            this.WaterMark.Controls.Add(this.lHeight);
            this.WaterMark.Controls.Add(this.tbWidth);
            this.WaterMark.Controls.Add(this.lWidth);
            this.WaterMark.Controls.Add(this.cbResize);
            this.WaterMark.Controls.Add(this.label8);
            this.WaterMark.Controls.Add(this.label7);
            this.WaterMark.Controls.Add(this.tbOpcity);
            this.WaterMark.Controls.Add(this.btFarbe);
            this.WaterMark.Controls.Add(this.label6);
            this.WaterMark.Controls.Add(this.offsetY);
            this.WaterMark.Controls.Add(this.offsetX);
            this.WaterMark.Controls.Add(this.label5);
            this.WaterMark.Controls.Add(this.cbPosition);
            this.WaterMark.Controls.Add(this.label4);
            this.WaterMark.Controls.Add(this.btStart);
            this.WaterMark.Controls.Add(this.button3);
            this.WaterMark.Controls.Add(this.label3);
            this.WaterMark.Controls.Add(this.tbExportPfad);
            this.WaterMark.Controls.Add(this.button2);
            this.WaterMark.Controls.Add(this.tbWaterMark);
            this.WaterMark.Controls.Add(this.button1);
            this.WaterMark.Controls.Add(this.label2);
            this.WaterMark.Location = new System.Drawing.Point(4, 22);
            this.WaterMark.Name = "WaterMark";
            this.WaterMark.Padding = new System.Windows.Forms.Padding(3);
            this.WaterMark.Size = new System.Drawing.Size(337, 449);
            this.WaterMark.TabIndex = 0;
            this.WaterMark.Text = "WaterMark";
            this.WaterMark.UseVisualStyleBackColor = true;
            // 
            // tbHeight
            // 
            this.tbHeight.Enabled = false;
            this.tbHeight.Location = new System.Drawing.Point(263, 360);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(52, 20);
            this.tbHeight.TabIndex = 24;
            this.tbHeight.Text = "0";
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Enabled = false;
            this.lHeight.Location = new System.Drawing.Point(219, 363);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(41, 13);
            this.lHeight.TabIndex = 23;
            this.lHeight.Text = "Height:";
            // 
            // tbWidth
            // 
            this.tbWidth.Enabled = false;
            this.tbWidth.Location = new System.Drawing.Point(135, 360);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(52, 20);
            this.tbWidth.TabIndex = 22;
            this.tbWidth.Text = "0";
            this.tbWidth.TextChanged += new System.EventHandler(this.tbWidth_TextChanged);
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Enabled = false;
            this.lWidth.Location = new System.Drawing.Point(91, 363);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(38, 13);
            this.lWidth.TabIndex = 21;
            this.lWidth.Text = "Width:";
            // 
            // cbResize
            // 
            this.cbResize.AutoSize = true;
            this.cbResize.Location = new System.Drawing.Point(94, 327);
            this.cbResize.Name = "cbResize";
            this.cbResize.Size = new System.Drawing.Size(58, 17);
            this.cbResize.TabIndex = 20;
            this.cbResize.Text = "Resize";
            this.cbResize.UseVisualStyleBackColor = true;
            this.cbResize.CheckedChanged += new System.EventHandler(this.cbResize_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Opacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "0-255";
            // 
            // tbOpcity
            // 
            this.tbOpcity.Location = new System.Drawing.Point(94, 293);
            this.tbOpcity.Name = "tbOpcity";
            this.tbOpcity.Size = new System.Drawing.Size(195, 20);
            this.tbOpcity.TabIndex = 16;
            this.tbOpcity.Text = "128";
            this.tbOpcity.TextChanged += new System.EventHandler(this.tbOpcity_TextChanged);
            // 
            // btFarbe
            // 
            this.btFarbe.Font = new System.Drawing.Font("Arial", 9F);
            this.btFarbe.Location = new System.Drawing.Point(94, 186);
            this.btFarbe.Name = "btFarbe";
            this.btFarbe.Size = new System.Drawing.Size(221, 23);
            this.btFarbe.TabIndex = 15;
            this.btFarbe.Text = "Font Color";
            this.btFarbe.UseVisualStyleBackColor = true;
            this.btFarbe.Click += new System.EventHandler(this.btFarbe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y:";
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(213, 258);
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(102, 20);
            this.offsetY.TabIndex = 13;
            this.offsetY.Text = "0";
            this.offsetY.Leave += new System.EventHandler(this.offsetY_Leave);
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(94, 258);
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(93, 20);
            this.offsetX.TabIndex = 12;
            this.offsetX.Text = "0";
            this.offsetX.Leave += new System.EventHandler(this.offsetX_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Offset X:";
            // 
            // cbPosition
            // 
            this.cbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Center",
            "Top",
            "Bottom",
            "Left",
            "Right",
            "TopLeft",
            "TopRight",
            "BottomLeft",
            "BottomRight"});
            this.cbPosition.Location = new System.Drawing.Point(94, 218);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(221, 21);
            this.cbPosition.TabIndex = 10;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Position:";
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Arial", 9F);
            this.btStart.Location = new System.Drawing.Point(94, 416);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(221, 23);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(36, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Export to:";
            // 
            // tbExportPfad
            // 
            this.tbExportPfad.Location = new System.Drawing.Point(94, 389);
            this.tbExportPfad.Name = "tbExportPfad";
            this.tbExportPfad.Size = new System.Drawing.Size(195, 20);
            this.tbExportPfad.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F);
            this.button2.Location = new System.Drawing.Point(94, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Font Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbWaterMark
            // 
            this.tbWaterMark.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.tbWaterMark.Location = new System.Drawing.Point(94, 26);
            this.tbWaterMark.Multiline = false;
            this.tbWaterMark.Name = "tbWaterMark";
            this.tbWaterMark.Size = new System.Drawing.Size(221, 96);
            this.tbWaterMark.TabIndex = 3;
            this.tbWaterMark.Text = "© TMarker";
            this.tbWaterMark.TextChanged += new System.EventHandler(this.tbWaterMark_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert ©";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "WaterMark:";
            // 
            // Import
            // 
            this.Import.Controls.Add(this.btAddFile);
            this.Import.Controls.Add(this.btAddFolder);
            this.Import.Controls.Add(this.btItemsClear);
            this.Import.Controls.Add(this.lbItems);
            this.Import.Location = new System.Drawing.Point(4, 22);
            this.Import.Name = "Import";
            this.Import.Padding = new System.Windows.Forms.Padding(3);
            this.Import.Size = new System.Drawing.Size(337, 449);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import Files";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // btAddFile
            // 
            this.btAddFile.Location = new System.Drawing.Point(119, 16);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(107, 23);
            this.btAddFile.TabIndex = 3;
            this.btAddFile.Text = "Add Files";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // btAddFolder
            // 
            this.btAddFolder.Location = new System.Drawing.Point(6, 16);
            this.btAddFolder.Name = "btAddFolder";
            this.btAddFolder.Size = new System.Drawing.Size(107, 23);
            this.btAddFolder.TabIndex = 2;
            this.btAddFolder.Text = "Add Folder";
            this.btAddFolder.UseVisualStyleBackColor = true;
            this.btAddFolder.Click += new System.EventHandler(this.btAddFolder_Click);
            // 
            // btItemsClear
            // 
            this.btItemsClear.Location = new System.Drawing.Point(256, 16);
            this.btItemsClear.Name = "btItemsClear";
            this.btItemsClear.Size = new System.Drawing.Size(75, 23);
            this.btItemsClear.TabIndex = 1;
            this.btItemsClear.Text = "Clear List";
            this.btItemsClear.UseVisualStyleBackColor = true;
            this.btItemsClear.Click += new System.EventHandler(this.btItemsClear_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(6, 45);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(325, 394);
            this.lbItems.TabIndex = 0;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Arial", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbAntiA
            // 
            this.cbAntiA.AutoSize = true;
            this.cbAntiA.Checked = true;
            this.cbAntiA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAntiA.Location = new System.Drawing.Point(222, 327);
            this.cbAntiA.Name = "cbAntiA";
            this.cbAntiA.Size = new System.Drawing.Size(79, 17);
            this.cbAntiA.TabIndex = 26;
            this.cbAntiA.Text = "Antialiasing";
            this.cbAntiA.UseVisualStyleBackColor = true;
            this.cbAntiA.CheckedChanged += new System.EventHandler(this.cbAntiA_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.DonateBox);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(337, 449);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "TMarker Image Wartermarker";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "by Tobias Viertmann";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Written in C# in 2014";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "THIS SOFTWARE IS FREE TO USE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "You can get the SourceCode at:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(16, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "http://github.com/tobbi007/TMarker";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(214, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "If you have paid for it, please contact me at:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(15, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "tobiasviertmann@gmail.com";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(13, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 117);
            this.label18.TabIndex = 10;
            this.label18.Text = "If you like the software, a small amount donation is very appreciated\r\n";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DonateBox
            // 
            this.DonateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DonateBox.Image = global::TMarker.Properties.Resources.paypal;
            this.DonateBox.Location = new System.Drawing.Point(156, 319);
            this.DonateBox.Name = "DonateBox";
            this.DonateBox.Size = new System.Drawing.Size(159, 117);
            this.DonateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DonateBox.TabIndex = 9;
            this.DonateBox.TabStop = false;
            this.DonateBox.Click += new System.EventHandler(this.DonateBox_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Image = global::TMarker.Properties.Resources.Tha02047_1024;
            this.pbPreview.Location = new System.Drawing.Point(354, 18);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(600, 459);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(982, 521);
            this.MinimumSize = new System.Drawing.Size(982, 521);
            this.Name = "Form1";
            this.Text = "TMarker";
            this.tabControl1.ResumeLayout(false);
            this.WaterMark.ResumeLayout(false);
            this.WaterMark.PerformLayout();
            this.Import.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WaterMark;
        private System.Windows.Forms.TabPage Import;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox tbWaterMark;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExportPfad;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox offsetY;
        private System.Windows.Forms.TextBox offsetX;
        private System.Windows.Forms.Button btFarbe;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOpcity;
        private System.Windows.Forms.Button btItemsClear;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.Button btAddFolder;
        private System.Windows.Forms.CheckBox cbResize;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.CheckBox cbAntiA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox DonateBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
    }
}

