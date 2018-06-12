namespace ThiWinfrom
{
    partial class Frm_DSSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbo_dm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_QuantityPro = new System.Windows.Forms.Label();
            this.lbl_ProID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.col_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_dm
            // 
            this.cbo_dm.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dm.FormattingEnabled = true;
            this.cbo_dm.Location = new System.Drawing.Point(256, 9);
            this.cbo_dm.Name = "cbo_dm";
            this.cbo_dm.Size = new System.Drawing.Size(259, 33);
            this.cbo_dm.TabIndex = 0;
            this.cbo_dm.SelectedIndexChanged += new System.EventHandler(this.cbo_dm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Check,
            this.col_ProID,
            this.col_ProName,
            this.col_ProDescription,
            this.col_CatID,
            this.col_CatName,
            this.col_ProStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(803, 223);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(256, 106);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(525, 33);
            this.txt_name.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(359, 196);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 38);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_QuantityPro
            // 
            this.lbl_QuantityPro.AutoSize = true;
            this.lbl_QuantityPro.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuantityPro.Location = new System.Drawing.Point(251, 238);
            this.lbl_QuantityPro.Name = "lbl_QuantityPro";
            this.lbl_QuantityPro.Size = new System.Drawing.Size(66, 25);
            this.lbl_QuantityPro.TabIndex = 5;
            this.lbl_QuantityPro.Text = "label2";
            // 
            // lbl_ProID
            // 
            this.lbl_ProID.AutoSize = true;
            this.lbl_ProID.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProID.Location = new System.Drawing.Point(251, 58);
            this.lbl_ProID.Name = "lbl_ProID";
            this.lbl_ProID.Size = new System.Drawing.Size(66, 25);
            this.lbl_ProID.TabIndex = 6;
            this.lbl_ProID.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mô tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã sản phẩm";
            // 
            // txt_des
            // 
            this.txt_des.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.Location = new System.Drawing.Point(256, 145);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(525, 33);
            this.txt_des.TabIndex = 12;
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(521, 196);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 38);
            this.btn_Del.TabIndex = 13;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewReport.Location = new System.Drawing.Point(359, 240);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(237, 36);
            this.btn_ViewReport.TabIndex = 14;
            this.btn_ViewReport.Text = "Xem báo cáo";
            this.btn_ViewReport.UseVisualStyleBackColor = true;
            this.btn_ViewReport.Click += new System.EventHandler(this.btn_ViewReport_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(440, 196);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 38);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // col_Check
            // 
            this.col_Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Check.Frozen = true;
            this.col_Check.HeaderText = "Check";
            this.col_Check.Name = "col_Check";
            // 
            // col_ProID
            // 
            this.col_ProID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ProID.DataPropertyName = "ProID";
            this.col_ProID.Frozen = true;
            this.col_ProID.HeaderText = "ProID";
            this.col_ProID.Name = "col_ProID";
            this.col_ProID.ReadOnly = true;
            this.col_ProID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ProID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_ProName
            // 
            this.col_ProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ProName.DataPropertyName = "ProName";
            this.col_ProName.Frozen = true;
            this.col_ProName.HeaderText = "ProName";
            this.col_ProName.Name = "col_ProName";
            this.col_ProName.ReadOnly = true;
            this.col_ProName.Width = 200;
            // 
            // col_ProDescription
            // 
            this.col_ProDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ProDescription.DataPropertyName = "ProDescription";
            this.col_ProDescription.HeaderText = "ProDesciption";
            this.col_ProDescription.Name = "col_ProDescription";
            this.col_ProDescription.ReadOnly = true;
            // 
            // col_CatID
            // 
            this.col_CatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CatID.DataPropertyName = "CatID";
            this.col_CatID.HeaderText = "CatID";
            this.col_CatID.Name = "col_CatID";
            this.col_CatID.ReadOnly = true;
            this.col_CatID.Width = 80;
            // 
            // col_CatName
            // 
            this.col_CatName.DataPropertyName = "CatName";
            this.col_CatName.HeaderText = "CatName";
            this.col_CatName.Name = "col_CatName";
            this.col_CatName.Visible = false;
            // 
            // col_ProStatus
            // 
            this.col_ProStatus.DataPropertyName = "ProStatus";
            this.col_ProStatus.HeaderText = "col_ProStatus";
            this.col_ProStatus.Name = "col_ProStatus";
            this.col_ProStatus.Visible = false;
            // 
            // Frm_DSSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 519);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_ViewReport);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ProID);
            this.Controls.Add(this.lbl_QuantityPro);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_dm);
            this.Name = "Frm_DSSP";
            this.Text = "Frm_DSSP";
            this.Load += new System.EventHandler(this.Frm_DSSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_dm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_QuantityPro;
        private System.Windows.Forms.Label lbl_ProID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProStatus;
    }
}