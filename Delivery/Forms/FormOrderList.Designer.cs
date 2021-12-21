
namespace Delivery.Forms
{
    partial class FormOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelOrderDesktop = new System.Windows.Forms.Panel();
            this.btnAreaOrder = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnScrollNotDone = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOrderDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOrderDesktop
            // 
            this.panelOrderDesktop.Controls.Add(this.btnAreaOrder);
            this.panelOrderDesktop.Controls.Add(this.lblArea);
            this.panelOrderDesktop.Controls.Add(this.btnScrollNotDone);
            this.panelOrderDesktop.Controls.Add(this.gridOrder);
            this.panelOrderDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelOrderDesktop.Name = "panelOrderDesktop";
            this.panelOrderDesktop.Size = new System.Drawing.Size(855, 503);
            this.panelOrderDesktop.TabIndex = 0;
            // 
            // btnAreaOrder
            // 
            this.btnAreaOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAreaOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btnAreaOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(67)))), ((int)(((byte)(30)))));
            this.btnAreaOrder.Location = new System.Drawing.Point(625, 408);
            this.btnAreaOrder.Name = "btnAreaOrder";
            this.btnAreaOrder.Size = new System.Drawing.Size(190, 40);
            this.btnAreaOrder.TabIndex = 5;
            this.btnAreaOrder.Text = "Phường";
            this.btnAreaOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreaOrder.UseVisualStyleBackColor = false;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblArea.Location = new System.Drawing.Point(523, 416);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(96, 25);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Khu vực:";
            // 
            // btnScrollNotDone
            // 
            this.btnScrollNotDone.AllowCursorChanges = true;
            this.btnScrollNotDone.AllowHomeEndKeysDetection = false;
            this.btnScrollNotDone.AllowIncrementalClickMoves = true;
            this.btnScrollNotDone.AllowMouseDownEffects = true;
            this.btnScrollNotDone.AllowMouseHoverEffects = true;
            this.btnScrollNotDone.AllowScrollingAnimations = true;
            this.btnScrollNotDone.AllowScrollKeysDetection = true;
            this.btnScrollNotDone.AllowScrollOptionsMenu = true;
            this.btnScrollNotDone.AllowShrinkingOnFocusLost = false;
            this.btnScrollNotDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScrollNotDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btnScrollNotDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScrollNotDone.BackgroundImage")));
            this.btnScrollNotDone.BindingContainer = null;
            this.btnScrollNotDone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btnScrollNotDone.BorderRadius = 14;
            this.btnScrollNotDone.BorderThickness = 1;
            this.btnScrollNotDone.DurationBeforeShrink = 2000;
            this.btnScrollNotDone.LargeChange = 10;
            this.btnScrollNotDone.Location = new System.Drawing.Point(824, 101);
            this.btnScrollNotDone.Maximum = 100;
            this.btnScrollNotDone.Minimum = 0;
            this.btnScrollNotDone.MinimumThumbLength = 18;
            this.btnScrollNotDone.Name = "btnScrollNotDone";
            this.btnScrollNotDone.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.btnScrollNotDone.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.btnScrollNotDone.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.btnScrollNotDone.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btnScrollNotDone.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btnScrollNotDone.ShrinkSizeLimit = 3;
            this.btnScrollNotDone.Size = new System.Drawing.Size(19, 255);
            this.btnScrollNotDone.SmallChange = 1;
            this.btnScrollNotDone.TabIndex = 3;
            this.btnScrollNotDone.ThumbColor = System.Drawing.Color.Gray;
            this.btnScrollNotDone.ThumbLength = 25;
            this.btnScrollNotDone.ThumbMargin = 1;
            this.btnScrollNotDone.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.btnScrollNotDone.Value = 0;
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToOrderColumns = true;
            this.gridOrder.AllowUserToResizeColumns = false;
            this.gridOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.gridOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.gridOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridOrder.ColumnHeadersHeight = 35;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridOrder.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridOrder.EnableHeadersVisualStyles = false;
            this.gridOrder.Location = new System.Drawing.Point(11, 65);
            this.gridOrder.Name = "gridOrder";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridOrder.RowHeadersVisible = false;
            this.gridOrder.RowHeadersWidth = 50;
            this.gridOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridOrder.RowTemplate.Height = 40;
            this.gridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrder.Size = new System.Drawing.Size(804, 291);
            this.gridOrder.TabIndex = 2;
            this.gridOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrder_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Mã đơn hàng";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Tình trạng đơn hàng";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 152.2843F;
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 503);
            this.Controls.Add(this.panelOrderDesktop);
            this.Name = "FormOrderList";
            this.Text = "Danh sách đơn hàng";
            this.panelOrderDesktop.ResumeLayout(false);
            this.panelOrderDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrderDesktop;
        private Bunifu.UI.WinForms.BunifuVScrollBar btnScrollNotDone;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnAreaOrder;
        private System.Windows.Forms.Label lblArea;
    }
}