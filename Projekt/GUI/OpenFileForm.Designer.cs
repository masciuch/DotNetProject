namespace Projekt.GUI
{
    partial class OpenFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenFileForm));
            this.uiTbPath = new System.Windows.Forms.TextBox();
            this.uiBtnBrowse = new System.Windows.Forms.Button();
            this.uiLblPath = new System.Windows.Forms.Label();
            this.uiLblPassword = new System.Windows.Forms.Label();
            this.uiTbPassword = new System.Windows.Forms.TextBox();
            this.uiBtnLoad = new System.Windows.Forms.Button();
            this.uiBtnCreateNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTbPath
            // 
            this.uiTbPath.Enabled = false;
            this.uiTbPath.Location = new System.Drawing.Point(94, 242);
            this.uiTbPath.Name = "uiTbPath";
            this.uiTbPath.Size = new System.Drawing.Size(353, 20);
            this.uiTbPath.TabIndex = 0;
            // 
            // uiBtnBrowse
            // 
            this.uiBtnBrowse.Location = new System.Drawing.Point(453, 240);
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
            this.uiLblPath.Location = new System.Drawing.Point(10, 245);
            this.uiLblPath.Name = "uiLblPath";
            this.uiLblPath.Size = new System.Drawing.Size(48, 13);
            this.uiLblPath.TabIndex = 2;
            this.uiLblPath.Text = "Scieżka:";
            // 
            // uiLblPassword
            // 
            this.uiLblPassword.AutoSize = true;
            this.uiLblPassword.Location = new System.Drawing.Point(10, 272);
            this.uiLblPassword.Name = "uiLblPassword";
            this.uiLblPassword.Size = new System.Drawing.Size(39, 13);
            this.uiLblPassword.TabIndex = 3;
            this.uiLblPassword.Text = "Hasło:";
            // 
            // uiTbPassword
            // 
            this.uiTbPassword.Location = new System.Drawing.Point(94, 269);
            this.uiTbPassword.Name = "uiTbPassword";
            this.uiTbPassword.PasswordChar = '*';
            this.uiTbPassword.Size = new System.Drawing.Size(353, 20);
            this.uiTbPassword.TabIndex = 4;
            // 
            // uiBtnLoad
            // 
            this.uiBtnLoad.Enabled = false;
            this.uiBtnLoad.Location = new System.Drawing.Point(453, 267);
            this.uiBtnLoad.Name = "uiBtnLoad";
            this.uiBtnLoad.Size = new System.Drawing.Size(75, 23);
            this.uiBtnLoad.TabIndex = 5;
            this.uiBtnLoad.Text = "Wczytaj";
            this.uiBtnLoad.UseVisualStyleBackColor = true;
            this.uiBtnLoad.Click += new System.EventHandler(this.uiBtnLoad_Click);
            // 
            // uiBtnCreateNew
            // 
            this.uiBtnCreateNew.Location = new System.Drawing.Point(10, 208);
            this.uiBtnCreateNew.Name = "uiBtnCreateNew";
            this.uiBtnCreateNew.Size = new System.Drawing.Size(515, 23);
            this.uiBtnCreateNew.TabIndex = 6;
            this.uiBtnCreateNew.Text = "Utwórz nowy";
            this.toolTip1.SetToolTip(this.uiBtnCreateNew, "Utwórz nowy plik przechowujący hasła.");
            this.uiBtnCreateNew.UseVisualStyleBackColor = true;
            this.uiBtnCreateNew.Click += new System.EventHandler(this.uiBtnCreateNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(222, 307);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub Repository";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // OpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 329);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiBtnCreateNew);
            this.Controls.Add(this.uiBtnLoad);
            this.Controls.Add(this.uiTbPassword);
            this.Controls.Add(this.uiLblPassword);
            this.Controls.Add(this.uiLblPath);
            this.Controls.Add(this.uiBtnBrowse);
            this.Controls.Add(this.uiTbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OpenFileForm";
            this.Text = "Otwórz plik";
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
        private System.Windows.Forms.Button uiBtnLoad;
        private System.Windows.Forms.Button uiBtnCreateNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

