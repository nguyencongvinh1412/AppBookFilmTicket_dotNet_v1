namespace DatVeXemPhim
{
    partial class DoiMK
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatVeXemPhim.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.btnCancel);
            this.gbContent.Controls.Add(this.btnOK);
            this.gbContent.Controls.Add(this.label3);
            this.gbContent.Controls.Add(this.label2);
            this.gbContent.Controls.Add(this.label1);
            this.gbContent.Controls.Add(this.txtPassNew);
            this.gbContent.Controls.Add(this.txtPassOld);
            this.gbContent.Controls.Add(this.txtName);
            this.gbContent.Location = new System.Drawing.Point(175, 12);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(307, 170);
            this.gbContent.TabIndex = 0;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "Information";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(210, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOK.Location = new System.Drawing.Point(20, 137);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu Mới : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu Cũ : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(105, 89);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(180, 20);
            this.txtPassNew.TabIndex = 5;
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(105, 54);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Size = new System.Drawing.Size(180, 20);
            this.txtPassOld.TabIndex = 3;
            this.txtPassOld.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 19);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 1;
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(498, 194);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMK";
            this.Load += new System.EventHandler(this.DoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbContent.ResumeLayout(false);
            this.gbContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}