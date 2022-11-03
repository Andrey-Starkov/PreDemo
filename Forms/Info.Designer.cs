
namespace PreDemo.Forms
{
    partial class Info
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
            this.Service = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Service)).BeginInit();
            this.SuspendLayout();
            // 
            // Service
            // 
            this.Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Service.Location = new System.Drawing.Point(43, 12);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(1257, 272);
            this.Service.TabIndex = 0;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 450);
            this.Controls.Add(this.Service);
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.Service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Service;
    }
}