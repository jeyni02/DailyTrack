namespace DailyTrack.Forms
{
    partial class Administration
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbShowpass = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnforgetPass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbShowpassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese sus datos ";
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(337, 115);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(206, 31);
            this.tbUser.TabIndex = 1;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(337, 169);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(206, 31);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // pbShowpass
            // 
            this.pbShowpass.Image = global::DailyTrack.Properties.Resources.usuario__3_;
            this.pbShowpass.Location = new System.Drawing.Point(288, 115);
            this.pbShowpass.Name = "pbShowpass";
            this.pbShowpass.Size = new System.Drawing.Size(36, 31);
            this.pbShowpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowpass.TabIndex = 4;
            this.pbShowpass.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DailyTrack.Properties.Resources.candado;
            this.pictureBox3.Location = new System.Drawing.Point(288, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(256, 232);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(479, 232);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 36);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Ingresar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnforgetPass
            // 
            this.btnforgetPass.BackColor = System.Drawing.Color.LightCoral;
            this.btnforgetPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnforgetPass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforgetPass.Location = new System.Drawing.Point(323, 274);
            this.btnforgetPass.Name = "btnforgetPass";
            this.btnforgetPass.Size = new System.Drawing.Size(196, 36);
            this.btnforgetPass.TabIndex = 8;
            this.btnforgetPass.Text = "Olvidé mi contraseña";
            this.btnforgetPass.UseVisualStyleBackColor = false;
            this.btnforgetPass.Click += new System.EventHandler(this.btnforgetPass_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BackgroundImage = global::DailyTrack.Properties.Resources.Daily_removebg_preview__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 467);
            this.panel1.TabIndex = 9;
            // 
            // pbShowpassword
            // 
            this.pbShowpassword.Image = global::DailyTrack.Properties.Resources.ojo;
            this.pbShowpassword.Location = new System.Drawing.Point(549, 169);
            this.pbShowpassword.Name = "pbShowpassword";
            this.pbShowpassword.Size = new System.Drawing.Size(39, 31);
            this.pbShowpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowpassword.TabIndex = 10;
            this.pbShowpassword.TabStop = false;
            this.pbShowpassword.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DailyTrack.Properties.Resources.Premium_Vector___Line_background_wave_gradient_template_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.pbShowpassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnforgetPass);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbShowpass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbShowpass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnforgetPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbShowpassword;
    }
}