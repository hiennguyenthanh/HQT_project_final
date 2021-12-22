
namespace Delivery
{
    partial class MainTX
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
            this.btnDExit = new System.Windows.Forms.Button();
            this.btnDDoneList = new System.Windows.Forms.Button();
            this.btnDList = new System.Windows.Forms.Button();
            this.btnDAcc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDCloseChildForm = new System.Windows.Forms.Button();
            this.lblDTitle = new System.Windows.Forms.Label();
            this.panelDDesktop = new System.Windows.Forms.Panel();
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
            this.panelMenu.Size = new System.Drawing.Size(257, 495);
            this.panelMenu.TabIndex = 0;
            // 
            // panelDMenu
            // 
            this.panelDMenu.Controls.Add(this.btnDExit);
            this.panelDMenu.Controls.Add(this.btnDDoneList);
            this.panelDMenu.Controls.Add(this.btnDList);
            this.panelDMenu.Controls.Add(this.btnDAcc);
            this.panelDMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDMenu.Location = new System.Drawing.Point(0, 124);
            this.panelDMenu.Name = "panelDMenu";
            this.panelDMenu.Size = new System.Drawing.Size(257, 333);
            this.panelDMenu.TabIndex = 9;
            // 
            // btnDExit
            // 
            this.btnDExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDExit.FlatAppearance.BorderSize = 0;
            this.btnDExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDExit.Image = global::Delivery.Properties.Resources.Door_Closed;
            this.btnDExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDExit.Location = new System.Drawing.Point(0, 150);
            this.btnDExit.Name = "btnDExit";
            this.btnDExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDExit.Size = new System.Drawing.Size(257, 50);
            this.btnDExit.TabIndex = 12;
            this.btnDExit.Text = "   Đăng xuất";
            this.btnDExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDExit.UseVisualStyleBackColor = true;
            this.btnDExit.Click += new System.EventHandler(this.btnDExit_Click);
            // 
            // btnDDoneList
            // 
            this.btnDDoneList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDDoneList.FlatAppearance.BorderSize = 0;
            this.btnDDoneList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDDoneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDoneList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDDoneList.Image = global::Delivery.Properties.Resources.Task_Completed;
            this.btnDDoneList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDDoneList.Location = new System.Drawing.Point(0, 100);
            this.btnDDoneList.Name = "btnDDoneList";
            this.btnDDoneList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDDoneList.Size = new System.Drawing.Size(257, 50);
            this.btnDDoneList.TabIndex = 11;
            this.btnDDoneList.Text = "   Đơn hàng hoàn thành";
            this.btnDDoneList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDDoneList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDDoneList.UseVisualStyleBackColor = true;
            this.btnDDoneList.Click += new System.EventHandler(this.btnDDoneList_Click);
            // 
            // btnDList
            // 
            this.btnDList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDList.FlatAppearance.BorderSize = 0;
            this.btnDList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDList.Image = global::Delivery.Properties.Resources.Pass_Fail;
            this.btnDList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDList.Location = new System.Drawing.Point(0, 50);
            this.btnDList.Name = "btnDList";
            this.btnDList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDList.Size = new System.Drawing.Size(257, 50);
            this.btnDList.TabIndex = 10;
            this.btnDList.Text = "   Danh sách đơn hàng";
            this.btnDList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDList.UseVisualStyleBackColor = true;
            this.btnDList.Click += new System.EventHandler(this.btnDList_Click);
            // 
            // btnDAcc
            // 
            this.btnDAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDAcc.FlatAppearance.BorderSize = 0;
            this.btnDAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDAcc.Image = global::Delivery.Properties.Resources.Male_User__1_;
            this.btnDAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDAcc.Location = new System.Drawing.Point(0, 0);
            this.btnDAcc.Name = "btnDAcc";
            this.btnDAcc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDAcc.Size = new System.Drawing.Size(257, 50);
            this.btnDAcc.TabIndex = 9;
            this.btnDAcc.Text = "   Thông tin tài khoản";
            this.btnDAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDAcc.UseVisualStyleBackColor = true;
            this.btnDAcc.Click += new System.EventHandler(this.btnDAcc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 124);
            this.panel1.TabIndex = 0;
            // 
            // btnDInfo
            // 
            this.btnDInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDInfo.FlatAppearance.BorderSize = 0;
            this.btnDInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDInfo.Image = global::Delivery.Properties.Resources.user;
            this.btnDInfo.Location = new System.Drawing.Point(0, 27);
            this.btnDInfo.Name = "btnDInfo";
            this.btnDInfo.Size = new System.Drawing.Size(257, 97);
            this.btnDInfo.TabIndex = 1;
            this.btnDInfo.Text = "username";
            this.btnDInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDInfo.UseVisualStyleBackColor = true;
            this.btnDInfo.Click += new System.EventHandler(this.btnDInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btnDCloseChildForm);
            this.panel2.Controls.Add(this.lblDTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 71);
            this.panel2.TabIndex = 1;
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
            this.btnDCloseChildForm.Click += new System.EventHandler(this.btnDCloseChildForm_Click);
            // 
            // lblDTitle
            // 
            this.lblDTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDTitle.AutoSize = true;
            this.lblDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDTitle.Location = new System.Drawing.Point(68, 20);
            this.lblDTitle.Name = "lblDTitle";
            this.lblDTitle.Size = new System.Drawing.Size(303, 24);
            this.lblDTitle.TabIndex = 0;
            this.lblDTitle.Text = "Danh sách đơn hàng chưa giao";
            // 
            // panelDDesktop
            // 
            this.panelDDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDDesktop.Location = new System.Drawing.Point(257, 71);
            this.panelDDesktop.Name = "panelDDesktop";
            this.panelDDesktop.Size = new System.Drawing.Size(698, 424);
            this.panelDDesktop.TabIndex = 2;
            // 
            // MainTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 495);
            this.Controls.Add(this.panelDDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainTX";
            this.Text = "Giao diện tài xế";
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
        private System.Windows.Forms.Button btnDExit;
        private System.Windows.Forms.Button btnDDoneList;
        private System.Windows.Forms.Button btnDList;
        private System.Windows.Forms.Button btnDAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDTitle;
        private System.Windows.Forms.Button btnDCloseChildForm;
        private System.Windows.Forms.Panel panelDDesktop;
    }
}

