﻿
namespace Delivery.Admin
{
    partial class HopDong
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
            this.dgv_hopdong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hopdong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hopdong
            // 
            this.dgv_hopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hopdong.Location = new System.Drawing.Point(0, 114);
            this.dgv_hopdong.Name = "dgv_hopdong";
            this.dgv_hopdong.RowHeadersWidth = 51;
            this.dgv_hopdong.RowTemplate.Height = 24;
            this.dgv_hopdong.Size = new System.Drawing.Size(758, 358);
            this.dgv_hopdong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(253, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý hợp đồng";
            // 
            // HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(758, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hopdong);
            this.Name = "HopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hợp đồng";
            this.Load += new System.EventHandler(this.HopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hopdong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hopdong;
        private System.Windows.Forms.Label label1;
    }
}