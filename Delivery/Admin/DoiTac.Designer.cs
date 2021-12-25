
namespace Delivery.Admin
{
    partial class DoiTac
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
            this.dgv_doitac = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doitac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_doitac
            // 
            this.dgv_doitac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doitac.Location = new System.Drawing.Point(0, 111);
            this.dgv_doitac.Name = "dgv_doitac";
            this.dgv_doitac.RowHeadersWidth = 51;
            this.dgv_doitac.RowTemplate.Height = 24;
            this.dgv_doitac.Size = new System.Drawing.Size(758, 362);
            this.dgv_doitac.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(269, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý đối tác";
            // 
            // DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(758, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_doitac);
            this.Name = "DoiTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đối tác";
            this.Load += new System.EventHandler(this.DoiTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doitac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_doitac;
        private System.Windows.Forms.Label label1;
    }
}