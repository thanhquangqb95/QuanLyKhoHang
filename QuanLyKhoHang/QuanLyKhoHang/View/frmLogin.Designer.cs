namespace QuanLyKhoHang.View
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.bttLogin = new System.Windows.Forms.Button();
            this.txtPassUser = new System.Windows.Forms.TextBox();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.lblPassUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPassUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.bttLogin);
            this.panel1.Controls.Add(this.txtPassUser);
            this.panel1.Controls.Add(this.txtIDUser);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 224);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(270, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // bttLogin
            // 
            this.bttLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogin.Location = new System.Drawing.Point(64, 169);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(114, 36);
            this.bttLogin.TabIndex = 2;
            this.bttLogin.Text = "Đăng Nhập";
            this.bttLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassUser
            // 
            this.txtPassUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassUser.Location = new System.Drawing.Point(164, 107);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.PasswordChar = '*';
            this.txtPassUser.Size = new System.Drawing.Size(241, 23);
            this.txtPassUser.TabIndex = 1;
            // 
            // txtIDUser
            // 
            this.txtIDUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUser.Location = new System.Drawing.Point(164, 55);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(241, 23);
            this.txtIDUser.TabIndex = 0;
            // 
            // lblPassUser
            // 
            this.lblPassUser.AutoSize = true;
            this.lblPassUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassUser.Location = new System.Drawing.Point(26, 110);
            this.lblPassUser.Name = "lblPassUser";
            this.lblPassUser.Size = new System.Drawing.Size(76, 17);
            this.lblPassUser.TabIndex = 5;
            this.lblPassUser.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phần mềm quản lý kho hàng";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 246);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.TextBox txtPassUser;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassUser;
    }
}