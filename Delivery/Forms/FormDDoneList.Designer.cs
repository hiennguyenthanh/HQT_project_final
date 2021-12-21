
namespace Delivery.Forms
{
    partial class FormDDoneList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDDoneList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnScrollNotDone = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.gridDone = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDone)).BeginInit();
            this.SuspendLayout();
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
            this.btnScrollNotDone.Location = new System.Drawing.Point(821, 110);
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
            this.btnScrollNotDone.Size = new System.Drawing.Size(19, 246);
            this.btnScrollNotDone.SmallChange = 1;
            this.btnScrollNotDone.TabIndex = 3;
            this.btnScrollNotDone.ThumbColor = System.Drawing.Color.Gray;
            this.btnScrollNotDone.ThumbLength = 24;
            this.btnScrollNotDone.ThumbMargin = 1;
            this.btnScrollNotDone.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.btnScrollNotDone.Value = 0;
            this.btnScrollNotDone.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.btnScrollNotDone_Scroll);
            // 
            // gridDone
            // 
            this.gridDone.AllowUserToOrderColumns = true;
            this.gridDone.AllowUserToResizeColumns = false;
            this.gridDone.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.gridDone.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            this.gridDone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDone.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDone.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDone.ColumnHeadersHeight = 35;
            this.gridDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridDone.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDone.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridDone.EnableHeadersVisualStyles = false;
            this.gridDone.Location = new System.Drawing.Point(11, 65);
            this.gridDone.Name = "gridDone";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(98)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDone.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDone.RowHeadersVisible = false;
            this.gridDone.RowHeadersWidth = 50;
            this.gridDone.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDone.RowTemplate.Height = 50;
            this.gridDone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDone.Size = new System.Drawing.Size(804, 291);
            this.gridDone.TabIndex = 2;
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(24)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
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
            // FormDDoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 503);
            this.Controls.Add(this.btnScrollNotDone);
            this.Controls.Add(this.gridDone);
            this.Name = "FormDDoneList";
            this.Text = "Đơn hàng hoàn thành";
            ((System.ComponentModel.ISupportInitialize)(this.gridDone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuVScrollBar btnScrollNotDone;
        private System.Windows.Forms.DataGridView gridDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}