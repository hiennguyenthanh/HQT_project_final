
namespace Delivery.Forms.Customer
{
    partial class fDisplayProduct
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
            this.panelBackMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMainChild = new System.Windows.Forms.Panel();
            this.panelBackMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackMain
            // 
            this.panelBackMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            this.panelBackMain.Controls.Add(this.label1);
            this.panelBackMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBackMain.Location = new System.Drawing.Point(833, 0);
            this.panelBackMain.Name = "panelBackMain";
            this.panelBackMain.Size = new System.Drawing.Size(79, 527);
            this.panelBackMain.TabIndex = 0;
            this.panelBackMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackMain_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(13, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMainChild
            // 
            this.panelMainChild.BackColor = System.Drawing.Color.Silver;
            this.panelMainChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainChild.Location = new System.Drawing.Point(0, 0);
            this.panelMainChild.Name = "panelMainChild";
            this.panelMainChild.Size = new System.Drawing.Size(833, 527);
            this.panelMainChild.TabIndex = 1;
            // 
            // fDisplayProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 527);
            this.Controls.Add(this.panelMainChild);
            this.Controls.Add(this.panelBackMain);
            this.Name = "fDisplayProduct";
            this.Text = "Giao diện chính";
            this.panelBackMain.ResumeLayout(false);
            this.panelBackMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMainChild;
    }
}