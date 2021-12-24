
namespace Delivery.Forms.Customer
{
    partial class MainCustomer
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
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCExit = new System.Windows.Forms.Button();
            this.btnCSupport = new System.Windows.Forms.Button();
            this.btnCOrder = new System.Windows.Forms.Button();
            this.btnCAcc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCCloseChild = new System.Windows.Forms.Button();
            this.lblCTitle = new System.Windows.Forms.Label();
            this.panelCDesktop = new System.Windows.Forms.Panel();
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
            this.panelMenu.Size = new System.Drawing.Size(257, 503);
            this.panelMenu.TabIndex = 1;
            // 
            // panelDMenu
            // 
            this.panelDMenu.Controls.Add(this.btnCart);
            this.panelDMenu.Controls.Add(this.btnCExit);
            this.panelDMenu.Controls.Add(this.btnCSupport);
            this.panelDMenu.Controls.Add(this.btnCOrder);
            this.panelDMenu.Controls.Add(this.btnCAcc);
            this.panelDMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDMenu.Location = new System.Drawing.Point(0, 124);
            this.panelDMenu.Name = "panelDMenu";
            this.panelDMenu.Size = new System.Drawing.Size(257, 333);
            this.panelDMenu.TabIndex = 9;
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCart.Image = global::Delivery.Properties.Resources.Pass_Fail;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 200);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCart.Size = new System.Drawing.Size(257, 50);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "   Giỏ hàng";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnCExit
            // 
            this.btnCExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCExit.FlatAppearance.BorderSize = 0;
            this.btnCExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCExit.Image = global::Delivery.Properties.Resources.Door_Closed;
            this.btnCExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCExit.Location = new System.Drawing.Point(0, 150);
            this.btnCExit.Name = "btnCExit";
            this.btnCExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCExit.Size = new System.Drawing.Size(257, 50);
            this.btnCExit.TabIndex = 12;
            this.btnCExit.Text = "   Đăng xuất";
            this.btnCExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCExit.UseVisualStyleBackColor = true;
            // 
            // btnCSupport
            // 
            this.btnCSupport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCSupport.FlatAppearance.BorderSize = 0;
            this.btnCSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSupport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSupport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCSupport.Image = global::Delivery.Properties.Resources.Task_Completed;
            this.btnCSupport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSupport.Location = new System.Drawing.Point(0, 100);
            this.btnCSupport.Name = "btnCSupport";
            this.btnCSupport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCSupport.Size = new System.Drawing.Size(257, 50);
            this.btnCSupport.TabIndex = 11;
            this.btnCSupport.Text = "   Hỗ trợ";
            this.btnCSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCSupport.UseVisualStyleBackColor = true;
            // 
            // btnCOrder
            // 
            this.btnCOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCOrder.FlatAppearance.BorderSize = 0;
            this.btnCOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCOrder.Image = global::Delivery.Properties.Resources.Pass_Fail;
            this.btnCOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCOrder.Location = new System.Drawing.Point(0, 50);
            this.btnCOrder.Name = "btnCOrder";
            this.btnCOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCOrder.Size = new System.Drawing.Size(257, 50);
            this.btnCOrder.TabIndex = 10;
            this.btnCOrder.Text = "  Xem danh sách đơn hàng";
            this.btnCOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCOrder.UseVisualStyleBackColor = true;
            // 
            // btnCAcc
            // 
            this.btnCAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCAcc.FlatAppearance.BorderSize = 0;
            this.btnCAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAcc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCAcc.Image = global::Delivery.Properties.Resources.Male_User__1_;
            this.btnCAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCAcc.Location = new System.Drawing.Point(0, 0);
            this.btnCAcc.Name = "btnCAcc";
            this.btnCAcc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCAcc.Size = new System.Drawing.Size(257, 50);
            this.btnCAcc.TabIndex = 9;
            this.btnCAcc.Text = "   Thông tin tài khoản";
            this.btnCAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCAcc.UseVisualStyleBackColor = true;
            this.btnCAcc.Click += new System.EventHandler(this.btnCAcc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 124);
            this.panel1.TabIndex = 0;
            // 
            // btnCInfo
            // 
            this.btnCInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCInfo.FlatAppearance.BorderSize = 0;
            this.btnCInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCInfo.Image = global::Delivery.Properties.Resources.user;
            this.btnCInfo.Location = new System.Drawing.Point(0, 27);
            this.btnCInfo.Name = "btnCInfo";
            this.btnCInfo.Size = new System.Drawing.Size(257, 97);
            this.btnCInfo.TabIndex = 1;
            this.btnCInfo.Text = "username";
            this.btnCInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btnCCloseChild);
            this.panel2.Controls.Add(this.lblCTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 72);
            this.panel2.TabIndex = 2;
            // 
            // btnCCloseChild
            // 
            this.btnCCloseChild.FlatAppearance.BorderSize = 0;
            this.btnCCloseChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCloseChild.Image = global::Delivery.Properties.Resources.icons8_x_48;
            this.btnCCloseChild.Location = new System.Drawing.Point(17, 20);
            this.btnCCloseChild.Name = "btnCCloseChild";
            this.btnCCloseChild.Size = new System.Drawing.Size(24, 24);
            this.btnCCloseChild.TabIndex = 1;
            this.btnCCloseChild.UseVisualStyleBackColor = true;
            this.btnCCloseChild.Click += new System.EventHandler(this.btnCCloseChild_Click);
            // 
            // lblCTitle
            // 
            this.lblCTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCTitle.AutoSize = true;
            this.lblCTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCTitle.Location = new System.Drawing.Point(68, 21);
            this.lblCTitle.Name = "lblCTitle";
            this.lblCTitle.Size = new System.Drawing.Size(150, 25);
            this.lblCTitle.TabIndex = 0;
            this.lblCTitle.Text = "Giao diện chính";
            // 
            // panelCDesktop
            // 
            this.panelCDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCDesktop.Location = new System.Drawing.Point(257, 72);
            this.panelCDesktop.Name = "panelCDesktop";
            this.panelCDesktop.Size = new System.Drawing.Size(598, 431);
            this.panelCDesktop.TabIndex = 3;
            // 
            // MainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 503);
            this.Controls.Add(this.panelCDesktop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainCustomer";
            this.Text = "Giao diện khách hàng";
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
        private System.Windows.Forms.Button btnCExit;
        private System.Windows.Forms.Button btnCSupport;
        private System.Windows.Forms.Button btnCOrder;
        private System.Windows.Forms.Button btnCAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCCloseChild;
        private System.Windows.Forms.Label lblCTitle;
        private System.Windows.Forms.Panel panelCDesktop;
        private System.Windows.Forms.Button btnCart;
    }
}