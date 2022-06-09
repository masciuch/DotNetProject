using PasswordMeter;
using Projekt.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt.GUI
{
    public partial class ApplicationWindow : Form
    {
        private bool _formOpened;

        public ApplicationWindow()
        {
            InitializeComponent();
        }

        private void ApplicationWindow_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            using (var openFileForm = new OpenFileForm())
            {
                openFileForm.StartPosition = FormStartPosition.CenterScreen;
                openFileForm.ShowDialog(this);

                if (openFileForm.DialogResult == DialogResult.OK)
                {
                    _formOpened = true;
                }
            }

            if (_formOpened)
            {
                uiDGV.AutoGenerateColumns = true;
                uiDGV.AutoSize = true;
                uiDGV.DataSource = PasswdTable.Instance.Passwords;
                uiDGV.Columns[0].HeaderText = "Serwis";
                uiDGV.Columns[1].HeaderText = "Login";
                uiDGV.Columns[2].HeaderText = "Hasło";
                uiDGV.Columns[3].ReadOnly = true;
                uiDGV.Columns[3].HeaderText = "Siła hasła";
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                uiDGV.Columns.Add(btn);
                btn.HeaderText = "Kopiuj";
                btn.Text = "Kopiuj";
                btn.UseColumnTextForButtonValue = true;
            }
            else
            {
                this.Close();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (uiDGV.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    string asd = uiDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Clipboard.SetText(asd);
                }
            }
        }

        private void ApplicationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_formOpened)
            {
                Core.PersistenceService.SaveFile(PasswdTable.Instance, Core.UserManager.Instance.Password, Core.UserManager.Instance.Path);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 2) && e.Value != null)
            {
                uiDGV.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (uiDGV.CurrentCell.ColumnIndex == 2)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
            else
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        private void uiDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (uiDGV.Rows[e.RowIndex].Cells.Count == 4)
                {
                    if (uiDGV.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        PasswordStrength pwdStrength = new PasswordStrength();
                        pwdStrength.SetPassword(uiDGV.Rows[e.RowIndex].Cells[2].Value.ToString());
                        int score = pwdStrength.GetPasswordScore();
                        string ScoreDescription = pwdStrength.GetPasswordStrength();
                        uiDGV.Rows[e.RowIndex].Cells[3].Value = ScoreDescription;
                        uiDGV.Rows[e.RowIndex].Cells[3].Style.BackColor = GetColor(score);
                    }
                }
            }
        }

        private Color GetColor(int nScore)
        {
            if (nScore >= 0 && nScore < 20) { return Color.Red; }
            else if (nScore >= 20 && nScore < 40) { return Color.Orange; }
            else if (nScore >= 40 && nScore < 60) { return Color.Yellow; }
            else if (nScore >= 60 && nScore < 80) { return Color.LightGreen; }
            else if (nScore >= 80 && nScore <= 100) { return Color.Cyan; }
            else { return Color.White; }
        }

        private void uiDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (uiDGV.Rows[e.RowIndex].Cells.Count == 5)
                {
                    if (uiDGV.Rows[e.RowIndex].Cells[2].Value != null)
                    {
                        PasswordStrength pwdStrength = new PasswordStrength();
                        pwdStrength.SetPassword(uiDGV.Rows[e.RowIndex].Cells[2].Value.ToString());
                        int score = pwdStrength.GetPasswordScore();
                        string ScoreDescription = pwdStrength.GetPasswordStrength();
                        uiDGV.Rows[e.RowIndex].Cells[3].Value = ScoreDescription;
                        uiDGV.Rows[e.RowIndex].Cells[3].Style.BackColor = GetColor(score);
                    }
                }
            }
        }
    }
}
