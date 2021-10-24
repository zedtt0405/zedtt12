namespace Lab_4
{
    partial class frmFalculty
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxGS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataFalculty = new System.Windows.Forms.DataGridView();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongSoGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFalculty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.textBoxGS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxTenKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMaKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 195);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(192, 195);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(106, 195);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(70, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxGS
            // 
            this.textBoxGS.Location = new System.Drawing.Point(80, 90);
            this.textBoxGS.Name = "textBoxGS";
            this.textBoxGS.Size = new System.Drawing.Size(182, 20);
            this.textBoxGS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng số GS";
            // 
            // textBoxTenKhoa
            // 
            this.textBoxTenKhoa.Location = new System.Drawing.Point(80, 57);
            this.textBoxTenKhoa.Name = "textBoxTenKhoa";
            this.textBoxTenKhoa.Size = new System.Drawing.Size(182, 20);
            this.textBoxTenKhoa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khoa";
            // 
            // textBoxMaKhoa
            // 
            this.textBoxMaKhoa.Location = new System.Drawing.Point(80, 26);
            this.textBoxMaKhoa.Name = "textBoxMaKhoa";
            this.textBoxMaKhoa.Size = new System.Drawing.Size(182, 20);
            this.textBoxMaKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa:";
            // 
            // dataFalculty
            // 
            this.dataFalculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFalculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFalculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKhoa,
            this.colTenKhoa,
            this.colTongSoGS});
            this.dataFalculty.Location = new System.Drawing.Point(339, 35);
            this.dataFalculty.Name = "dataFalculty";
            this.dataFalculty.Size = new System.Drawing.Size(457, 331);
            this.dataFalculty.TabIndex = 3;
            this.dataFalculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFalculty_CellClick);
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.DataPropertyName = "colMaKhoa";
            this.colMaKhoa.HeaderText = "Mã Khoa";
            this.colMaKhoa.Name = "colMaKhoa";
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.DataPropertyName = "colTenKhoa";
            this.colTenKhoa.HeaderText = "Tên Khoa";
            this.colTenKhoa.Name = "colTenKhoa";
            // 
            // colTongSoGS
            // 
            this.colTongSoGS.DataPropertyName = "colTongSoGS";
            this.colTongSoGS.HeaderText = "Tổng số GS";
            this.colTongSoGS.Name = "colTongSoGS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFalculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 399);
            this.Controls.Add(this.dataFalculty);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFalculty";
            this.Text = "Quản lý khoa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFalculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxGS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataFalculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongSoGS;
        private System.Windows.Forms.Button button1;
    }
}