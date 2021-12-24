
namespace Delivery.Forms.Staff
{
    partial class fContract
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainBack = new System.Windows.Forms.Label();
            this.panelContractChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(83)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblMainBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(779, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 469);
            this.panel1.TabIndex = 0;
            // 
            // lblMainBack
            // 
            this.lblMainBack.AutoSize = true;
            this.lblMainBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMainBack.Location = new System.Drawing.Point(3, 225);
            this.lblMainBack.Name = "lblMainBack";
            this.lblMainBack.Size = new System.Drawing.Size(64, 25);
            this.lblMainBack.TabIndex = 0;
            this.lblMainBack.Text = "MAIN";
            this.lblMainBack.Click += new System.EventHandler(this.lblMainBack_Click);
            // 
            // panelContractChild
            // 
            this.panelContractChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContractChild.Location = new System.Drawing.Point(0, 0);
            this.panelContractChild.Name = "panelContractChild";
            this.panelContractChild.Size = new System.Drawing.Size(779, 469);
            this.panelContractChild.TabIndex = 1;
            // 
            // fContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 469);
            this.Controls.Add(this.panelContractChild);
            this.Controls.Add(this.panel1);
            this.Name = "fContract";
            this.Text = "fContractOverdue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMainBack;
        private System.Windows.Forms.Panel panelContractChild;
    }
}