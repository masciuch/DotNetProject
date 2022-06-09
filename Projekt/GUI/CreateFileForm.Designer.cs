namespace Projekt.GUI
{
    partial class CreateFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFileForm));
            this.uiTbPath = new System.Windows.Forms.TextBox();
            this.uiBtnBrowse = new System.Windows.Forms.Button();
            this.uiLblPath = new System.Windows.Forms.Label();
            this.uiLblPassword = new System.Windows.Forms.Label();
            this.uiTbPassword = new System.Windows.Forms.TextBox();
            this.uiBtnCreate = new System.Windows.Forms.Button();
            this.uiTbRepeatPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTbPath
            // 
            this.uiTbPath.Enabled = false;
            this.uiTbPath.Location = new System.Drawing.Point(97, 232);
            this.uiTbPath.Name = "uiTbPath";
            this.uiTbPath.Size = new System.Drawing.Size(353, 20);
            this.uiTbPath.TabIndex = 0;
            // 
            // uiBtnBrowse
            // 
            this.uiBtnBrowse.Location = new System.Drawing.Point(456, 230);
            this.uiBtnBrowse.Name = "uiBtnBrowse";
            this.uiBtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.uiBtnBrowse.TabIndex = 1;
            this.uiBtnBrowse.Text = "Przeglądaj";
            this.uiBtnBrowse.UseVisualStyleBackColor = true;
            this.uiBtnBrowse.Click += new System.EventHandler(this.uiBtnBrowse_Click);
            // 
            // uiLblPath
            // 
            this.uiLblPath.AutoSize = true;
            this.uiLblPath.Location = new System.Drawing.Point(13, 235);
            this.uiLblPath.Name = "uiLblPath";
            this.uiLblPath.Size = new System.Drawing.Size(68, 13);
            this.uiLblPath.TabIndex = 2;
            this.uiLblPath.Text = "Nazwa pliku:";
            // 
            // uiLblPassword
            // 
            this.uiLblPassword.AutoSize = true;
            this.uiLblPassword.Location = new System.Drawing.Point(13, 262);
            this.uiLblPassword.Name = "uiLblPassword";
            this.uiLblPassword.Size = new System.Drawing.Size(39, 13);
            this.uiLblPassword.TabIndex = 3;
            this.uiLblPassword.Text = "Hasło:";
            // 
            // uiTbPassword
            // 
            this.uiTbPassword.Location = new System.Drawing.Point(97, 259);
            this.uiTbPassword.Name = "uiTbPassword";
            this.uiTbPassword.PasswordChar = '*';
            this.uiTbPassword.Size = new System.Drawing.Size(353, 20);
            this.uiTbPassword.TabIndex = 4;
            // 
            // uiBtnCreate
            // 
            this.uiBtnCreate.Enabled = false;
            this.uiBtnCreate.Location = new System.Drawing.Point(456, 283);
            this.uiBtnCreate.Name = "uiBtnCreate";
            this.uiBtnCreate.Size = new System.Drawing.Size(75, 23);
            this.uiBtnCreate.TabIndex = 5;
            this.uiBtnCreate.Text = "Utwórz";
            this.uiBtnCreate.UseVisualStyleBackColor = true;
            this.uiBtnCreate.Click += new System.EventHandler(this.uiBtnLoad_Click);
            // 
            // uiTbRepeatPassword
            // 
            this.uiTbRepeatPassword.Location = new System.Drawing.Point(97, 285);
            this.uiTbRepeatPassword.Name = "uiTbRepeatPassword";
            this.uiTbRepeatPassword.PasswordChar = '*';
            this.uiTbRepeatPassword.Size = new System.Drawing.Size(353, 20);
            this.uiTbRepeatPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Powtórz hasło:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CreateFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiTbRepeatPassword);
            this.Controls.Add(this.uiBtnCreate);
            this.Controls.Add(this.uiTbPassword);
            this.Controls.Add(this.uiLblPassword);
            this.Controls.Add(this.uiLblPath);
            this.Controls.Add(this.uiBtnBrowse);
            this.Controls.Add(this.uiTbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateFileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiTbPath;
        private System.Windows.Forms.Button uiBtnBrowse;
        private System.Windows.Forms.Label uiLblPath;
        private System.Windows.Forms.Label uiLblPassword;
        private System.Windows.Forms.TextBox uiTbPassword;
        private System.Windows.Forms.Button uiBtnCreate;
        private System.Windows.Forms.TextBox uiTbRepeatPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

