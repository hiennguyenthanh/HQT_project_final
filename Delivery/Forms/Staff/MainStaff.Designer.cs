
namespace Delivery.Forms.Staff
{
    partial class MainStaff
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnContractList = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDCloseChildForm = new System.Windows.Forms.Button();
            this.lblSSTitle = new System.Windows.Forms.Label();
            this.panelStaffDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelDMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.panelMenu.Controls.Add(this.panelDMenu);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(257, 509);
            this.panelMenu.TabIndex = 1;
            // 
            // panelDMenu
            // 
            this.panelDMenu.Controls.Add(this.btnExit);
            this.panelDMenu.Controls.Add(this.btnContractList);
            this.panelDMenu.Controls.Add(this.btnAcc);
            this.panelDMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDMenu.Location = new System.Drawing.Point(0, 124);
            this.panelDMenu.Name = "panelDMenu";
            this.panelDMenu.Size = new System.Drawing.Size(257, 333);
            this.panelDMenu.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::Delivery.Properties.Resources.Door_Closed;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(257, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "   Đăng xuất";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnContractList
            // 
            this.btnContractList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContractList.FlatAppearance.BorderSize = 0;
            this.btnContractList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContractList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContractList.Image = global::Delivery.Properties.Resources.Pass_Fail;
            this.btnContractList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContractList.Location = new System.Drawing.Point(0, 50);
            this.btnContractList.Name = "btnContractList";
            this.btnContractList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContractList.Size = new System.Drawing.Size(257, 50);
            this.btnContractList.TabIndex = 10;
            this.btnContractList.Text = "   Danh sách hợp đồng";
            this.btnContractList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContractList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContractList.UseVisualStyleBackColor = true;
            this.btnContractList.Click += new System.EventHandler(this.btnContractList_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcc.FlatAppearance.BorderSize = 0;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAcc.Image = global::Delivery.Properties.Resources.Male_User__1_;
            this.btnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.Location = new System.Drawing.Point(0, 0);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAcc.Size = new System.Drawing.Size(257, 50);
            this.btnAcc.TabIndex = 9;
            this.btnAcc.Text = "   Thông tin tài khoản";
            this.btnAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 124);
            this.panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.Image = global::Delivery.Properties.Resources.user;
            this.btnInfo.Location = new System.Drawing.Point(0, 27);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(257, 97);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "username";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btnDCloseChildForm);
            this.panel2.Controls.Add(this.lblSSTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 71);
            this.panel2.TabIndex = 2;
            // 
            // btnDCloseChildForm
            // 
            this.btnDCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnDCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDCloseChildForm.Image = global::Delivery.Properties.Resources.icons8_x_48;
            this.btnDCloseChildForm.Location = new System.Drawing.Point(17, 20);
            this.btnDCloseChildForm.Name = "btnDCloseChildForm";
            this.btnDCloseChildForm.Size = new System.Drawing.Size(24, 24);
            this.btnDCloseChildForm.TabIndex = 1;
            this.btnDCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // lblSSTitle
            // 
            this.lblSSTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSSTitle.AutoSize = true;
            this.lblSSTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSSTitle.Location = new System.Drawing.Point(79, 20);
            this.lblSSTitle.Name = "lblSSTitle";
            this.lblSSTitle.Size = new System.Drawing.Size(301, 25);
            this.lblSSTitle.TabIndex = 0;
            this.lblSSTitle.Text = "Danh sách hợp đồng sắp hết hạn";
            // 
            // panelStaffDesktop
            // 
            this.panelStaffDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStaffDesktop.Location = new System.Drawing.Point(257, 71);
            this.panelStaffDesktop.Name = "panelStaffDesktop";
            this.panelStaffDesktop.Size = new System.Drawing.Size(696, 438);
            this.panelStaffDesktop.TabIndex = 3;
            // 
            // MainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 509);
            this.Controls.Add(this.panelStaffDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainStaff";
            this.Text = "MainStaff";
            this.panelMenu.ResumeLayout(false);
            this.panelDMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnContractList;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDCloseChildForm;
        private System.Windows.Forms.Label lblSSTitle;
        private System.Windows.Forms.Panel panelStaffDesktop;
    }
}