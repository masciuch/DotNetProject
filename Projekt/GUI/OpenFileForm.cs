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
    public partial class OpenFileForm : Form
    {
        public OpenFileForm()
        {
            InitializeComponent();
        }

        private void uiBtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "sav files (*.sav)|*.sav";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uiTbPath.Text = openFileDialog1.FileName;
                uiBtnLoad.Enabled = true;
            }
        }

        private void uiBtnCreateNew_Click(object sender, EventArgs e)
        {
            this.Hide();

            using(CreateFileForm createFileForm = new CreateFileForm())
            {
                createFileForm.StartPosition = FormStartPosition.CenterScreen;
                createFileForm.ShowDialog(this);

                if(createFileForm.DialogResult == DialogResult.OK)
                {
                   DialogResult = DialogResult.OK;
                }
            }

            this.Close();
        }

        private void uiBtnLoad_Click(object sender, EventArgs e)
        {
            if(uiTbPassword.Text != string.Empty && uiTbPath.Text != string.Empty)
            {
                try
                {
                    Model.PasswdTable.Instance = Core.PersistenceService.OpenFile(uiTbPath.Text, uiTbPassword.Text);
                    Core.UserManager.Instance.Path = uiTbPath.Text;
                    Core.UserManager.Instance.Password = uiTbPassword.Text;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Błędne hasło lub nieprawidłowy plik.");
                }
            }
        }
    }
} 
