namespace EmeraldRestaurant
{
    partial class LoginForm
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
            this.labelTittle = new System.Windows.Forms.Label();
            this.newaccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioEmployeeButton = new System.Windows.Forms.RadioButton();
            this.radioManagerButton = new System.Windows.Forms.RadioButton();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelTittle.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTittle.Location = new System.Drawing.Point(517, 25);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(147, 52);
            this.labelTittle.TabIndex = 16;
            this.labelTittle.Text = "LOGIN";
            // 
            // newaccountButton
            // 
            this.newaccountButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newaccountButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newaccountButton.Location = new System.Drawing.Point(436, 285);
            this.newaccountButton.Name = "newaccountButton";
            this.newaccountButton.Size = new System.Drawing.Size(302, 45);
            this.newaccountButton.TabIndex = 13;
            this.newaccountButton.Text = "Activate New Account";
            this.newaccountButton.UseVisualStyleBackColor = false;
            this.newaccountButton.Click += new System.EventHandler(this.newaccountButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(436, 234);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(302, 45);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(384, 96);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(389, 31);
            this.txtBoxEmail.TabIndex = 10;
            this.txtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEmail_KeyPress);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(385, 165);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(388, 31);
            this.txtBoxPassword.TabIndex = 11;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radioEmployeeButton
            // 
            this.radioEmployeeButton.AutoSize = true;
            this.radioEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.radioEmployeeButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioEmployeeButton.Location = new System.Drawing.Point(651, 202);
            this.radioEmployeeButton.Name = "radioEmployeeButton";
            this.radioEmployeeButton.Size = new System.Drawing.Size(87, 23);
            this.radioEmployeeButton.TabIndex = 20;
            this.radioEmployeeButton.TabStop = true;
            this.radioEmployeeButton.Text = "Employee";
            this.radioEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // radioManagerButton
            // 
            this.radioManagerButton.AutoSize = true;
            this.radioManagerButton.BackColor = System.Drawing.Color.Transparent;
            this.radioManagerButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioManagerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioManagerButton.Location = new System.Drawing.Point(436, 202);
            this.radioManagerButton.Name = "radioManagerButton";
            this.radioManagerButton.Size = new System.Drawing.Size(82, 23);
            this.radioManagerButton.TabIndex = 19;
            this.radioManagerButton.TabStop = true;
            this.radioManagerButton.Text = "Manager";
            this.radioManagerButton.UseVisualStyleBackColor = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.BackgroundImage = global::EmeraldRestaurant.Properties.Resources.exit_icon_4609;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exitbutton.Location = new System.Drawing.Point(732, 1);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(40, 39);
            this.Exitbutton.TabIndex = 18;
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmeraldRestaurant.Properties.Resources.z3473898342290_99bd72a0260eb01dee8a6b3c6e975f94;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // passIcon
            // 
            this.passIcon.BackColor = System.Drawing.Color.Transparent;
            this.passIcon.Enabled = false;
            this.passIcon.Image = global::EmeraldRestaurant.Properties.Resources.passwordicon;
            this.passIcon.Location = new System.Drawing.Point(384, 165);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(42, 30);
            this.passIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passIcon.TabIndex = 17;
            this.passIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.Enabled = false;
            this.userIcon.Image = global::EmeraldRestaurant.Properties.Resources.usericon;
            this.userIcon.Location = new System.Drawing.Point(384, 96);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(42, 30);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 15;
            this.userIcon.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Exitbutton;
            this.ClientSize = new System.Drawing.Size(782, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.newaccountButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.radioEmployeeButton);
            this.Controls.Add(this.radioManagerButton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Button newaccountButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox passIcon;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.RadioButton radioEmployeeButton;
        public System.Windows.Forms.RadioButton radioManagerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

