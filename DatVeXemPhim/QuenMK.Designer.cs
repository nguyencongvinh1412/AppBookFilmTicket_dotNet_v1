namespace DatVeXemPhim
{
    partial class QuenMK
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelQuenMK = new System.Windows.Forms.Button();
            this.btnOKQuenMK = new System.Windows.Forms.Button();
            this.txtNhapCodeQuenMK = new System.Windows.Forms.TextBox();
            this.txtCodeQuenMK = new System.Windows.Forms.TextBox();
            this.btnLayMaDN = new System.Windows.Forms.Button();
            this.txtMaDN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picReLoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelQuenMK);
            this.groupBox1.Controls.Add(this.btnOKQuenMK);
            this.groupBox1.Controls.Add(this.picReLoad);
            this.groupBox1.Controls.Add(this.txtNhapCodeQuenMK);
            this.groupBox1.Controls.Add(this.txtCodeQuenMK);
            this.groupBox1.Controls.Add(this.btnLayMaDN);
            this.groupBox1.Controls.Add(this.txtMaDN);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Location = new System.Drawing.Point(176, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quên mật khẩu";
            // 
            // btnCancelQuenMK
            // 
            this.btnCancelQuenMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelQuenMK.Location = new System.Drawing.Point(236, 132);
            this.btnCancelQuenMK.Name = "btnCancelQuenMK";
            this.btnCancelQuenMK.Size = new System.Drawing.Size(75, 23);
            this.btnCancelQuenMK.TabIndex = 6;
            this.btnCancelQuenMK.Text = "CANCEL";
            this.btnCancelQuenMK.UseVisualStyleBackColor = false;
            this.btnCancelQuenMK.Click += new System.EventHandler(this.btnCancelQuenMK_Click);
            // 
            // btnOKQuenMK
            // 
            this.btnOKQuenMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOKQuenMK.Location = new System.Drawing.Point(50, 132);
            this.btnOKQuenMK.Name = "btnOKQuenMK";
            this.btnOKQuenMK.Size = new System.Drawing.Size(75, 23);
            this.btnOKQuenMK.TabIndex = 5;
            this.btnOKQuenMK.Text = "OK";
            this.btnOKQuenMK.UseVisualStyleBackColor = false;
            this.btnOKQuenMK.Click += new System.EventHandler(this.btnOKQuenMK_Click);
            // 
            // txtNhapCodeQuenMK
            // 
            this.txtNhapCodeQuenMK.Location = new System.Drawing.Point(168, 95);
            this.txtNhapCodeQuenMK.Name = "txtNhapCodeQuenMK";
            this.txtNhapCodeQuenMK.Size = new System.Drawing.Size(100, 20);
            this.txtNhapCodeQuenMK.TabIndex = 4;
            // 
            // txtCodeQuenMK
            // 
            this.txtCodeQuenMK.Location = new System.Drawing.Point(50, 95);
            this.txtCodeQuenMK.Name = "txtCodeQuenMK";
            this.txtCodeQuenMK.ReadOnly = true;
            this.txtCodeQuenMK.Size = new System.Drawing.Size(100, 20);
            this.txtCodeQuenMK.TabIndex = 3;
            // 
            // btnLayMaDN
            // 
            this.btnLayMaDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLayMaDN.Location = new System.Drawing.Point(254, 26);
            this.btnLayMaDN.Name = "btnLayMaDN";
            this.btnLayMaDN.Size = new System.Drawing.Size(75, 23);
            this.btnLayMaDN.TabIndex = 1;
            this.btnLayMaDN.Text = "Lấy Mã DN";
            this.btnLayMaDN.UseVisualStyleBackColor = false;
            this.btnLayMaDN.Click += new System.EventHandler(this.btnLayMaDN_Click);
            // 
            // txtMaDN
            // 
            this.txtMaDN.Location = new System.Drawing.Point(50, 61);
            this.txtMaDN.Name = "txtMaDN";
            this.txtMaDN.ReadOnly = true;
            this.txtMaDN.Size = new System.Drawing.Size(198, 20);
            this.txtMaDN.TabIndex = 2;
            this.txtMaDN.Text = "Mã đăng nhập.........";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "UserName/SDT..............";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picReLoad
            // 
            this.picReLoad.Image = global::DatVeXemPhim.Properties.Resources.reload;
            this.picReLoad.Location = new System.Drawing.Point(287, 91);
            this.picReLoad.Name = "picReLoad";
            this.picReLoad.Size = new System.Drawing.Size(24, 24);
            this.picReLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picReLoad.TabIndex = 3;
            this.picReLoad.TabStop = false;
            this.picReLoad.Click += new System.EventHandler(this.picReLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatVeXemPhim.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QuenMK
            // 
            this.AcceptButton = this.btnOKQuenMK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(523, 196);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMK";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picReLoad;
        private System.Windows.Forms.TextBox txtNhapCodeQuenMK;
        private System.Windows.Forms.TextBox txtCodeQuenMK;
        private System.Windows.Forms.Button btnLayMaDN;
        private System.Windows.Forms.TextBox txtMaDN;
        private System.Windows.Forms.Button btnCancelQuenMK;
        private System.Windows.Forms.Button btnOKQuenMK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtEmail;
    }
}