namespace DatVeXemPhim
{
    partial class ThongTinAcc
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
            this.slcThongTinAcc = new System.Windows.Forms.SplitContainer();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLichSuTruyCap = new System.Windows.Forms.TextBox();
            this.txtTenAcc = new System.Windows.Forms.TextBox();
            this.dgvTTA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.slcThongTinAcc)).BeginInit();
            this.slcThongTinAcc.Panel1.SuspendLayout();
            this.slcThongTinAcc.Panel2.SuspendLayout();
            this.slcThongTinAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTA)).BeginInit();
            this.SuspendLayout();
            // 
            // slcThongTinAcc
            // 
            this.slcThongTinAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcThongTinAcc.Location = new System.Drawing.Point(0, 0);
            this.slcThongTinAcc.Name = "slcThongTinAcc";
            // 
            // slcThongTinAcc.Panel1
            // 
            this.slcThongTinAcc.Panel1.Controls.Add(this.btnDangXuat);
            this.slcThongTinAcc.Panel1.Controls.Add(this.label1);
            this.slcThongTinAcc.Panel1.Controls.Add(this.txtLichSuTruyCap);
            this.slcThongTinAcc.Panel1.Controls.Add(this.txtTenAcc);
            // 
            // slcThongTinAcc.Panel2
            // 
            this.slcThongTinAcc.Panel2.Controls.Add(this.dgvTTA);
            this.slcThongTinAcc.Size = new System.Drawing.Size(753, 108);
            this.slcThongTinAcc.SplitterDistance = 251;
            this.slcThongTinAcc.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDangXuat.Location = new System.Drawing.Point(49, 74);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên:";
            // 
            // txtLichSuTruyCap
            // 
            this.txtLichSuTruyCap.Location = new System.Drawing.Point(49, 47);
            this.txtLichSuTruyCap.Name = "txtLichSuTruyCap";
            this.txtLichSuTruyCap.ReadOnly = true;
            this.txtLichSuTruyCap.Size = new System.Drawing.Size(193, 20);
            this.txtLichSuTruyCap.TabIndex = 0;
            // 
            // txtTenAcc
            // 
            this.txtTenAcc.Location = new System.Drawing.Point(49, 12);
            this.txtTenAcc.Name = "txtTenAcc";
            this.txtTenAcc.ReadOnly = true;
            this.txtTenAcc.Size = new System.Drawing.Size(193, 20);
            this.txtTenAcc.TabIndex = 0;
            // 
            // dgvTTA
            // 
            this.dgvTTA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTA.Location = new System.Drawing.Point(0, 0);
            this.dgvTTA.Name = "dgvTTA";
            this.dgvTTA.Size = new System.Drawing.Size(498, 108);
            this.dgvTTA.TabIndex = 0;
            this.dgvTTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTA_CellContentClick);
            // 
            // ThongTinAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(753, 108);
            this.Controls.Add(this.slcThongTinAcc);
            this.Name = "ThongTinAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinAcc";
            this.Load += new System.EventHandler(this.ThongTinAcc_Load);
            this.slcThongTinAcc.Panel1.ResumeLayout(false);
            this.slcThongTinAcc.Panel1.PerformLayout();
            this.slcThongTinAcc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slcThongTinAcc)).EndInit();
            this.slcThongTinAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer slcThongTinAcc;
        private System.Windows.Forms.TextBox txtLichSuTruyCap;
        private System.Windows.Forms.TextBox txtTenAcc;
        private System.Windows.Forms.DataGridView dgvTTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
    }
}