
namespace Delivery.Forms
{
    partial class FormDDList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDDList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAreaAll = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnScrollNotDone = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.gridAllOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAreaAll
            // 
            this.btnAreaAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAreaAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.btnAreaAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(67)))), ((int)(((byte)(30)))));
            this.btnAreaAll.Location = new System.Drawing.Point(625, 434);
            this.btnAreaAll.Name = "btnAreaAll";
            this.btnAreaAll.Size = new System.Drawing.Size(190, 40);
            this.btnAreaAll.TabIndex = 7;
            this.btnAreaAll.Text = "Phường";
            this.btnAreaAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreaAll.UseVisualStyleBackColor = false;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.lblArea.Location = new System.Drawing.Point(523, 441);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(96, 25);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Khu vực:";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
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
            this.btnScrollNotDone.Location = new System.Drawing.Point(821, 101);
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
            this.btnScrollNotDone.TabIndex = 5;
            this.btnScrollNotDone.ThumbColor = System.Drawing.Color.Gray;
            this.btnScrollNotDone.ThumbLength = 25;
            this.btnScrollNotDone.ThumbMargin = 1;
            this.btnScrollNotDone.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.btnScrollNotDone.Value = 0;
            // 
            // gridAllOrder
            // 
            this.gridAllOrder.AllowUserToOrderColumns = true;
            this.gridAllOrder.AllowUserToResizeRows = false;
            this.gridAllOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAllOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAllOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.gridAllOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAllOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAllOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAllOrder.ColumnHeadersHeight = 35;
            this.gridAllOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridAllOrder.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAllOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridAllOrder.EnableHeadersVisualStyles = false;
            this.gridAllOrder.Location = new System.Drawing.Point(11, 65);
            this.gridAllOrder.Name = "gridAllOrder";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAllOrder.RowHeadersVisible = false;
            this.gridAllOrder.RowHeadersWidth = 50;
            this.gridAllOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAllOrder.RowTemplate.Height = 40;
            this.gridAllOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAllOrder.Size = new System.Drawing.Size(804, 291);
            this.gridAllOrder.TabIndex = 4;
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
            // FormDDList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 503);
            this.Controls.Add(this.btnAreaAll);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnScrollNotDone);
            this.Controls.Add(this.gridAllOrder);
            this.Name = "FormDDList";
            this.Text = "Danh sách đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gridAllOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAreaAll;
        private System.Windows.Forms.Label lblArea;
        private Bunifu.UI.WinForms.BunifuVScrollBar btnScrollNotDone;
        private System.Windows.Forms.DataGridView gridAllOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}