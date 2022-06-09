namespace Projekt.GUI
{
    partial class ApplicationWindow
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
            this.uiDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDGV
            // 
            this.uiDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDGV.Location = new System.Drawing.Point(0, 0);
            this.uiDGV.Name = "uiDGV";
            this.uiDGV.Size = new System.Drawing.Size(800, 450);
            this.uiDGV.TabIndex = 0;
            this.uiDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.uiDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDGV_CellEndEdit);
            this.uiDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.uiDGV.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.uiDGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.uiDGV_RowsAdded);
            // 
            // ApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiDGV);
            this.Name = "ApplicationWindow";
            this.Text = "Password Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicationWindow_FormClosing);
            this.Load += new System.EventHandler(this.ApplicationWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiDGV;
    }
}