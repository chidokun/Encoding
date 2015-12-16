/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System;
using System.Windows.Forms;

namespace Encoding
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version: " + Application.ProductVersion + " (Release)";
            try
            {
                richTextBox.LoadFile("EncodingHelp.rtf");
            }
            catch
            {
                richTextBox.Text = "Không tìm thấy file EncodingHelp.rtf";
            }
        }
    }
}
