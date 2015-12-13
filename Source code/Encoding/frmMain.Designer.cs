namespace Encoding
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.pictureValidKey = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new Encoding.MenuButton();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblLengthText = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.richTxtSource = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.richTxtDestination = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearAllDes = new System.Windows.Forms.Button();
            this.btnCopyAllDes = new System.Windows.Forms.Button();
            this.btnSelectAllDes = new System.Windows.Forms.Button();
            this.btnCopyDes = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTitle.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureValidKey)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(157)))), ((int)(((byte)(202)))));
            this.pnlTitle.Controls.Add(this.pnlKey);
            this.pnlTitle.Controls.Add(this.btnSelect);
            this.pnlTitle.Controls.Add(this.btnInfo);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(705, 38);
            this.pnlTitle.TabIndex = 2;
            // 
            // pnlKey
            // 
            this.pnlKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.pnlKey.Controls.Add(this.pictureValidKey);
            this.pnlKey.Controls.Add(this.panel4);
            this.pnlKey.Controls.Add(this.label2);
            this.pnlKey.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlKey.Location = new System.Drawing.Point(307, 0);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(255, 38);
            this.pnlKey.TabIndex = 7;
            // 
            // pictureValidKey
            // 
            this.pictureValidKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pictureValidKey.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureValidKey.Image = global::Encoding.Properties.Resources.icon_valid_24;
            this.pictureValidKey.Location = new System.Drawing.Point(225, 0);
            this.pictureValidKey.Name = "pictureValidKey";
            this.pictureValidKey.Size = new System.Drawing.Size(30, 38);
            this.pictureValidKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureValidKey.TabIndex = 3;
            this.pictureValidKey.TabStop = false;
            this.toolTip.SetToolTip(this.pictureValidKey, "Clear key");
            this.pictureValidKey.Click += new System.EventHandler(this.pictureValidKey_Click);
            this.pictureValidKey.MouseLeave += new System.EventHandler(this.pictureValidKey_MouseLeave);
            this.pictureValidKey.MouseHover += new System.EventHandler(this.pictureValidKey_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panel4.Controls.Add(this.txtKey);
            this.panel4.Location = new System.Drawing.Point(41, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 38);
            this.panel4.TabIndex = 2;
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKey.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.txtKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKey.Location = new System.Drawing.Point(6, 8);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(176, 23);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = "hEllOwOrLd!12345";
            this.toolTip.SetToolTip(this.txtKey, "Input your key. The key contains only ASCII character");
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(177)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(562, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(99, 38);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "MD5";
            this.toolTip.SetToolTip(this.btnSelect, "Select algorithm");
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(186)))), ((int)(((byte)(223)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(177)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::Encoding.Properties.Resources.icon_info_24;
            this.btnInfo.Location = new System.Drawing.Point(661, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(44, 38);
            this.btnInfo.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnInfo, "About");
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encoding";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.panel3.Controls.Add(this.btnDecode);
            this.panel3.Controls.Add(this.btnEncode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 46);
            this.panel3.TabIndex = 6;
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.btnDecode.FlatAppearance.BorderSize = 0;
            this.btnDecode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btnDecode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(158)))));
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDecode.ForeColor = System.Drawing.Color.Black;
            this.btnDecode.Location = new System.Drawing.Point(572, 8);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(121, 32);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "&Decode";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.btnEncode.FlatAppearance.BorderSize = 0;
            this.btnEncode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(98)))), ((int)(((byte)(115)))));
            this.btnEncode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(158)))));
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEncode.ForeColor = System.Drawing.Color.Black;
            this.btnEncode.Location = new System.Drawing.Point(445, 8);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(121, 32);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "&Encode";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(157)))), ((int)(((byte)(202)))));
            this.pnlStatus.Controls.Add(this.lblLengthText);
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.ForeColor = System.Drawing.Color.White;
            this.pnlStatus.Location = new System.Drawing.Point(0, 482);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(705, 25);
            this.pnlStatus.TabIndex = 5;
            // 
            // lblLengthText
            // 
            this.lblLengthText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLengthText.Location = new System.Drawing.Point(445, 0);
            this.lblLengthText.Name = "lblLengthText";
            this.lblLengthText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLengthText.Size = new System.Drawing.Size(260, 25);
            this.lblLengthText.TabIndex = 2;
            this.lblLengthText.Text = "<length> ";
            this.lblLengthText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(705, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "<status>";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 38);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.richTxtSource);
            this.splitContainer.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.richTxtDestination);
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Size = new System.Drawing.Size(705, 398);
            this.splitContainer.SplitterDistance = 191;
            this.splitContainer.TabIndex = 7;
            // 
            // richTxtSource
            // 
            this.richTxtSource.AcceptsTab = true;
            this.richTxtSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtSource.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTxtSource.Location = new System.Drawing.Point(36, 0);
            this.richTxtSource.Name = "richTxtSource";
            this.richTxtSource.Size = new System.Drawing.Size(669, 191);
            this.richTxtSource.TabIndex = 1;
            this.richTxtSource.Text = "";
            this.richTxtSource.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            this.richTxtSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Controls.Add(this.btnCopyAll);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnCut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 191);
            this.panel1.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Image = global::Encoding.Properties.Resources.icon_clearall_24;
            this.btnClearAll.Location = new System.Drawing.Point(0, 160);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(36, 32);
            this.btnClearAll.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnClearAll, "Clear all");
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAllEvent);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopyAll.FlatAppearance.BorderSize = 0;
            this.btnCopyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyAll.Image = global::Encoding.Properties.Resources.icon_copyall_24;
            this.btnCopyAll.Location = new System.Drawing.Point(0, 128);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(36, 32);
            this.btnCopyAll.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnCopyAll, "Copy all source text");
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.CopyAllEvent);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Image = global::Encoding.Properties.Resources.icon_selectall_24;
            this.btnSelectAll.Location = new System.Drawing.Point(0, 96);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(36, 32);
            this.btnSelectAll.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnSelectAll, "Select all source text");
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.SelectAllEvent);
            // 
            // btnPaste
            // 
            this.btnPaste.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Image = global::Encoding.Properties.Resources.icon_paste_24;
            this.btnPaste.Location = new System.Drawing.Point(0, 64);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(36, 32);
            this.btnPaste.TabIndex = 8;
            this.toolTip.SetToolTip(this.btnPaste, "Paste");
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.PasteEvent);
            // 
            // btnCopy
            // 
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Image = global::Encoding.Properties.Resources.icon_copy_24;
            this.btnCopy.Location = new System.Drawing.Point(0, 32);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(36, 32);
            this.btnCopy.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnCopy, "Copy");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.CopyEvent);
            // 
            // btnCut
            // 
            this.btnCut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCut.FlatAppearance.BorderSize = 0;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.Image = global::Encoding.Properties.Resources.icon_cut_24;
            this.btnCut.Location = new System.Drawing.Point(0, 0);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(36, 32);
            this.btnCut.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnCut, "Cut");
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.CutEvent);
            // 
            // richTxtDestination
            // 
            this.richTxtDestination.AcceptsTab = true;
            this.richTxtDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtDestination.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTxtDestination.Location = new System.Drawing.Point(36, 0);
            this.richTxtDestination.Name = "richTxtDestination";
            this.richTxtDestination.ReadOnly = true;
            this.richTxtDestination.Size = new System.Drawing.Size(669, 203);
            this.richTxtDestination.TabIndex = 2;
            this.richTxtDestination.Text = "";
            this.richTxtDestination.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            this.richTxtDestination.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.btnClearAllDes);
            this.panel2.Controls.Add(this.btnCopyAllDes);
            this.panel2.Controls.Add(this.btnSelectAllDes);
            this.panel2.Controls.Add(this.btnCopyDes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 203);
            this.panel2.TabIndex = 1;
            // 
            // btnClearAllDes
            // 
            this.btnClearAllDes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearAllDes.FlatAppearance.BorderSize = 0;
            this.btnClearAllDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllDes.Image = global::Encoding.Properties.Resources.icon_clearall_24;
            this.btnClearAllDes.Location = new System.Drawing.Point(0, 96);
            this.btnClearAllDes.Name = "btnClearAllDes";
            this.btnClearAllDes.Size = new System.Drawing.Size(36, 32);
            this.btnClearAllDes.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnClearAllDes, "Clear all destination text");
            this.btnClearAllDes.UseVisualStyleBackColor = true;
            this.btnClearAllDes.Click += new System.EventHandler(this.ClearAllEvent);
            // 
            // btnCopyAllDes
            // 
            this.btnCopyAllDes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopyAllDes.FlatAppearance.BorderSize = 0;
            this.btnCopyAllDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyAllDes.Image = global::Encoding.Properties.Resources.icon_copyall_24;
            this.btnCopyAllDes.Location = new System.Drawing.Point(0, 64);
            this.btnCopyAllDes.Name = "btnCopyAllDes";
            this.btnCopyAllDes.Size = new System.Drawing.Size(36, 32);
            this.btnCopyAllDes.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnCopyAllDes, "Copy all destination text");
            this.btnCopyAllDes.UseVisualStyleBackColor = true;
            this.btnCopyAllDes.Click += new System.EventHandler(this.CopyAllEvent);
            // 
            // btnSelectAllDes
            // 
            this.btnSelectAllDes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectAllDes.FlatAppearance.BorderSize = 0;
            this.btnSelectAllDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAllDes.Image = global::Encoding.Properties.Resources.icon_selectall_24;
            this.btnSelectAllDes.Location = new System.Drawing.Point(0, 32);
            this.btnSelectAllDes.Name = "btnSelectAllDes";
            this.btnSelectAllDes.Size = new System.Drawing.Size(36, 32);
            this.btnSelectAllDes.TabIndex = 10;
            this.toolTip.SetToolTip(this.btnSelectAllDes, "Select all destination text");
            this.btnSelectAllDes.UseVisualStyleBackColor = true;
            this.btnSelectAllDes.Click += new System.EventHandler(this.SelectAllEvent);
            // 
            // btnCopyDes
            // 
            this.btnCopyDes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopyDes.FlatAppearance.BorderSize = 0;
            this.btnCopyDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyDes.Image = global::Encoding.Properties.Resources.icon_copy_24;
            this.btnCopyDes.Location = new System.Drawing.Point(0, 0);
            this.btnCopyDes.Name = "btnCopyDes";
            this.btnCopyDes.Size = new System.Drawing.Size(36, 32);
            this.btnCopyDes.TabIndex = 8;
            this.toolTip.SetToolTip(this.btnCopyDes, "Copy");
            this.btnCopyDes.UseVisualStyleBackColor = true;
            this.btnCopyDes.Click += new System.EventHandler(this.CopyEvent);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 507);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(514, 237);
            this.Name = "frmMain";
            this.Text = "Encoding";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureValidKey)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        internal System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox richTxtSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTxtDestination;
        private System.Windows.Forms.Panel panel2;
        internal Encoding.MenuButton btnSelect;
        private System.Windows.Forms.Panel pnlKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.PictureBox pictureValidKey;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnCopyAllDes;
        private System.Windows.Forms.Button btnSelectAllDes;
        private System.Windows.Forms.Button btnCopyDes;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearAllDes;
        private System.Windows.Forms.Label lblLengthText;
    }
}

