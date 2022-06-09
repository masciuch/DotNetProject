using Projekt.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.GUI
{
    public partial class CreateFileForm : Form
    {
        public CreateFileForm()
        {
            InitializeComponent();
        }

        private void uiBtnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "sav files (*.sav)|*.sav";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uiTbPath.Text = saveFileDialog1.FileName;
                uiBtnCreate.Enabled = true;
            }
        }

        private void uiBtnLoad_Click(object sender, EventArgs e)
        {
            if(uiTbPassword.Text != uiTbRepeatPassword.Text)
            {
                MessageBox.Show("Hasła się nie zgadzają!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserManager.Instance.Path = uiTbPath.Text;
            UserManager.Instance.Password = uiTbPassword.Text;
            PersistenceService.SaveFile(Model.PasswdTable.Instance, UserManager.Instance.Password, UserManager.Instance.Path);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/masciuch/DotNetProject");
        }
    }
}
