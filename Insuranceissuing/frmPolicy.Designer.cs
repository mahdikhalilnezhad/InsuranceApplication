namespace Insuranceissuing
{
    partial class frmPolicy
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
            this.dataGridViewPolicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPolicy
            // 
            this.dataGridViewPolicy.AllowUserToAddRows = false;
            this.dataGridViewPolicy.AllowUserToDeleteRows = false;
            this.dataGridViewPolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolicy.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPolicy.Name = "dataGridViewPolicy";
            this.dataGridViewPolicy.ReadOnly = true;
            this.dataGridViewPolicy.RowTemplate.Height = 25;
            this.dataGridViewPolicy.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewPolicy.TabIndex = 0;
            // 
            // frmPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPolicy);
            this.Name = "frmPolicy";
            this.Text = "frmPolicy";
            this.Load += new System.EventHandler(this.frmPolicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewPolicy;
    }
}