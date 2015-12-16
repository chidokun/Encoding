/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System;
using System.Drawing;
using System.Windows.Forms;
using Encoding.Cipher;
using Encoding.Hash;
using Encoding.Properties;


namespace Encoding
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeSelectMenu();
            InitializeContextMenu();
        }

        #region Status Bar
        /// <summary>
        /// Type of status
        /// </summary>
        public enum Status { Complete, Warning, Error, Information }

        public Color COLOR_BLUE = Color.FromArgb(38, 157, 202),
                     COLOR_ORANGE = Color.FromArgb(202, 81, 0),
                     COLOR_RED = Color.FromArgb(240, 0, 0),
                     COLOR_GREEN = Color.FromArgb(34, 177, 76);

        /// <summary>
        /// Set default status
        /// </summary>
        public void SetStatus()
        {
            SetStatus("Ready", Status.Information);
        }

        /// <summary>
        /// Set status
        /// </summary>
        /// <param name="content">Content of status</param>
        /// <param name="sttType">Type of status</param>
        public void SetStatus(string content, Status sttType)
        {
            switch (sttType)
            {
                case Status.Complete:
                    pnlStatus.BackColor = COLOR_GREEN;
                    lblStatus.Text = content;
                    break;
                case Status.Warning:
                    pnlStatus.BackColor = COLOR_ORANGE;
                    lblStatus.Text = content;
                    break;
                case Status.Error:
                    pnlStatus.BackColor = COLOR_RED;
                    lblStatus.Text = content;
                    break;
                case Status.Information:
                    pnlStatus.BackColor = COLOR_BLUE;
                    lblStatus.Text = content;
                    break;
            }
        }

        /// <summary>
        /// Update length of text in source, destination and key
        /// </summary>
        private void UpdateLength()
        {
            if (indexSelect > 5)
                lblLengthText.Text = "Key   " + txtKey.Text.Length
                    + "    |  Source   " + richTxtSource.Text.Length
                    + "    |  Result   " + richTxtDestination.Text.Length + "   ";
            else
                lblLengthText.Text = "Source   " + richTxtSource.Text.Length
                    + "    |  Result   " + richTxtDestination.Text.Length + "   ";
        }

        #endregion

        #region Select Menu
        private int indexSelect = 0;

        /// <summary>
        /// Initialize menu for Select Menu
        /// </summary>
        private void InitializeSelectMenu()
        {
            btnSelect.Menu = new ContextMenuStrip();
            btnSelect.Menu.Items.Add("MD5", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add("SHA1", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add("SHA256", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add("SHA384", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add("SHA512", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add(new ToolStripSeparator());
            btnSelect.Menu.Items.Add("DES", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add("Triple DES", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add("AES", null, MenuSelectEvent);
            btnSelect.Menu.Items.Add("RC2", null, MenuSelectEvent);

            //Default selection
            btnSelect.Text = btnSelect.Menu.Items[indexSelect].Text;
            pnlKey.Visible = btnDecode.Enabled = false;
            InitializeCrypto();
        }

        /// <summary>
        /// Event for each menuitem selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuSelectEvent(object sender, EventArgs e)
        {
            indexSelect = btnSelect.Menu.Items.IndexOf((ToolStripItem)sender);
            btnSelect.Text = ((ToolStripItem)sender).Text;
            pnlKey.Visible = btnDecode.Enabled = indexSelect > 5;
            richTxtDestination.Text = "";
            InitializeCrypto();
        }

        /// <summary>
        /// Initialize instance of cryptoHash or cryptoSymmetric
        /// </summary>
        private void InitializeCrypto()
        {
            switch (indexSelect)
            {
                case 0:
                    cryptoHash = new MD5(); break;
                case 1:
                    cryptoHash = new SHA(); break;
                case 2:
                    cryptoHash = new SHA256(); break;
                case 3:
                    cryptoHash = new SHA384(); break;
                case 4:
                    cryptoHash = new SHA512(); break;
                case 6:
                    cryptoSymmetric = new DES(); break;
                case 7:
                    cryptoSymmetric = new TripleDES(); break;
                case 8:
                    cryptoSymmetric = new AES(); break;
                case 9:
                    cryptoSymmetric = new RC2(); break;
                default:
                    indexSelect = 0; break;
            }
            SetStatus();
            if (indexSelect > 5) CheckValidKey();
        }
        #endregion

        #region Key
        /// <summary>
        /// Check a Key string is valid or not
        /// </summary>
        private void CheckValidKey()
        {
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                txtKey.Text = System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(txtKey.Text));
                cryptoSymmetric.Key = txtKey.Text;
                try
                {
                    if (cryptoSymmetric.ValidKey())
                    {
                        pictureValidKey.Image = Resources.icon_valid_24;
                        SetStatus("Valid key", Status.Information);
                    }
                    else
                    {
                        pictureValidKey.Image = Resources.icon_invalid_24;
                        SetStatus("Invalid key. Key is weak or not valid size", Status.Warning);
                    }
                }
                catch
                {
                    pictureValidKey.Image = Resources.icon_invalid_24;
                    SetStatus("Invalid key. Key is weak or not valid size", Status.Warning);
                }
            }
            else
                SetStatus("Please enter valid key", Status.Information);
            UpdateLength();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            CheckValidKey();
        }

        private void pictureValidKey_MouseHover(object sender, EventArgs e)
        {
            pictureValidKey.Image = Resources.icon_clearkey_24;
        }

        private void pictureValidKey_MouseLeave(object sender, EventArgs e)
        {
            CheckValidKey();
        }

        private void pictureValidKey_Click(object sender, EventArgs e)
        {
            txtKey.Text = "";
            txtKey.Focus();
        }
        #endregion

        #region Encode and Decode
        Symmetric cryptoSymmetric = null;
        Hash.Hash cryptoHash = null;

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexSelect < 5)
                {
                    cryptoHash.Source = richTxtSource.Text;
                    richTxtDestination.Text = cryptoHash.Encode();
                }
                else
                {
                    cryptoSymmetric.Source = richTxtSource.Text;
                    cryptoSymmetric.Key = txtKey.Text;
                    richTxtDestination.Text = cryptoSymmetric.Encode();
                }
                SetStatus("Complete", Status.Information);
            }
            catch (ArgumentNullException)
            {
                SetStatus("The string which needs to be encrypted can not be null", Status.Warning);
                richTxtDestination.Text = "";
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                cryptoSymmetric.Source = richTxtSource.Text;
                richTxtDestination.Text = cryptoSymmetric.Decode();
                SetStatus("Complete", Status.Information);
            }
            catch (ArgumentNullException)
            {
                SetStatus("The string which needs to be decrypted can not be null", Status.Warning);
                richTxtDestination.Text = "";
            }
            catch
            {
                SetStatus("Failure to decode. Please check your Key and source string.", Status.Error);
                richTxtDestination.Text = "";
            }
        }
        #endregion

        #region Toolbar
        /// <summary>
        /// A reference to RichTextBox that is being used
        /// </summary>
        RichTextBox currRtf;
        private void CutEvent(object sender, EventArgs e)
        {          
            if(sender is Button)
            {
                if (((Button)sender).Parent == panel1)
                    currRtf = richTxtSource;
                else
                    currRtf = richTxtDestination;
            }

            currRtf.Cut();
            currRtf.Focus();
        }

        private void CopyEvent(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (((Button)sender).Parent == panel1)
                    currRtf = richTxtSource;
                else
                    currRtf = richTxtDestination;
            }

            currRtf.Copy();
            currRtf.Focus();
        }

        private void CopyAllEvent(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (((Button)sender).Parent == panel1)
                    currRtf = richTxtSource;
                else
                    currRtf = richTxtDestination;
            }

            currRtf.SelectAll();
            currRtf.Copy();
            currRtf.Focus();

        }

        private void ClearAllEvent(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (((Button)sender).Parent == panel1)
                    currRtf = richTxtSource;
                else
                    currRtf = richTxtDestination;
            }

            currRtf.Text = "";
            currRtf.Focus();
        }

        private void PasteEvent(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (((Button)sender).Parent == panel1)
                    currRtf = richTxtSource;
                else
                    currRtf = richTxtDestination;
            }

            currRtf.Paste();
            currRtf.Focus();
        }

        private void SelectAllEvent(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (((Button)sender).Parent == panel1)
                    currRtf = richTxtSource;
                else
                    currRtf = richTxtDestination;
            }

            currRtf.SelectAll();
            currRtf.Focus();
        }
        #endregion

        #region Event
        private void frmMain_Load(object sender, EventArgs e)
        {
            richTxtSource.Focus();
            SetStatus();
            UpdateLength();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLength();
        }

        #endregion

        #region Right Click context menu
        /// <summary>
        /// A reference to right-click context menu in RichTextBox
        /// </summary>
        ContextMenu menu;
       
        /// <summary>
        /// Initialize right-click context menu
        /// </summary>
        public void InitializeContextMenu()
        {
            menu = new ContextMenu();
            menu.MenuItems.Add("Cut", CutEvent);
            menu.MenuItems.Add("Copy", CopyEvent);
            menu.MenuItems.Add("Paste", PasteEvent);
            menu.MenuItems.Add("-");
            menu.MenuItems.Add("Undo",UndoEvent);
            menu.MenuItems.Add("Redo",RedoEvent);
            menu.MenuItems.Add("-");
            menu.MenuItems.Add("Copy all", CopyAllEvent);
            menu.MenuItems.Add("Select all", SelectAllEvent);
        }

        /// <summary>
        /// Update context menu
        /// </summary>
        /// <param name="sender">Current RichTextBox</param>
        public void UpdateContextMenu(object sender)
        {
            RichTextBox richText = (RichTextBox)sender;
            menu.MenuItems[0].Enabled = !(richText.SelectedText == "" || richText.ReadOnly);
            menu.MenuItems[1].Enabled = !(richText.SelectedText == "");
            menu.MenuItems[2].Enabled = richText.CanPaste(DataFormats.GetFormat(DataFormats.Text));
            menu.MenuItems[4].Enabled = richText.CanUndo;
            menu.MenuItems[5].Enabled = richText.CanRedo;            
        }

        private void UndoEvent(object sender, EventArgs e)
        {
            richTxtSource.Undo();
            richTxtSource.Focus();
        }

        private void RedoEvent(object sender, EventArgs e)
        {
            richTxtSource.Redo();
            richTxtSource.Focus();
        }

        
        private void RichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateContextMenu(sender);
            currRtf = (RichTextBox)sender;
            if (e.Button == MouseButtons.Right)
                menu.Show(currRtf, e.Location);
        }
        #endregion
    }
}
