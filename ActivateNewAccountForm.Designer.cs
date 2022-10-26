namespace EmeraldRestaurant
{
    partial class ActivateNewAccountForm
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
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoginIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activateButton = new System.Windows.Forms.Button();
            this.txtBoxVertificationCode = new System.Windows.Forms.TextBox();
            this.labelVertificationCode = new System.Windows.Forms.Label();
            this.sendEmailButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(472, 186);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(278, 31);
            this.txtBoxPassword.TabIndex = 99;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(374, 193);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 24);
            this.labelPassword.TabIndex = 100;
            this.labelPassword.Text = "Password:";
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BackColor = System.Drawing.Color.White;
            this.PictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxImage.Location = new System.Drawing.Point(12, 90);
            this.PictureBoxImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(279, 220);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImage.TabIndex = 102;
            this.PictureBoxImage.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(407, 97);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 24);
            this.labelEmail.TabIndex = 97;
            this.labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(472, 90);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(278, 31);
            this.txtBoxEmail.TabIndex = 98;
            this.txtBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxEmail_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 42);
            this.label1.TabIndex = 103;
            this.label1.Text = "Activate New Account";
            // 
            // labelLoginIn
            // 
            this.labelLoginIn.AutoSize = true;
            this.labelLoginIn.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelLoginIn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginIn.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelLoginIn.Location = new System.Drawing.Point(599, 313);
            this.labelLoginIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginIn.Name = "labelLoginIn";
            this.labelLoginIn.Size = new System.Drawing.Size(48, 19);
            this.labelLoginIn.TabIndex = 105;
            this.labelLoginIn.Text = "Log In";
            this.labelLoginIn.Click += new System.EventHandler(this.labelLoginIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 104;
            this.label2.Text = "Already activated?";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(472, 233);
            this.txtBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(278, 31);
            this.txtBoxConfirmPassword.TabIndex = 106;
            this.txtBoxConfirmPassword.UseSystemPasswordChar = true;
            this.txtBoxConfirmPassword.Validated += new System.EventHandler(this.txtBoxConfirmPassword_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 107;
            this.label3.Text = "Comfirm Password:";
            // 
            // activateButton
            // 
            this.activateButton.BackColor = System.Drawing.Color.Teal;
            this.activateButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.activateButton.Location = new System.Drawing.Point(306, 276);
            this.activateButton.Margin = new System.Windows.Forms.Padding(4);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(444, 34);
            this.activateButton.TabIndex = 108;
            this.activateButton.Text = "Activate";
            this.activateButton.UseVisualStyleBackColor = false;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // txtBoxVertificationCode
            // 
            this.txtBoxVertificationCode.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVertificationCode.Location = new System.Drawing.Point(472, 137);
            this.txtBoxVertificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxVertificationCode.Name = "txtBoxVertificationCode";
            this.txtBoxVertificationCode.Size = new System.Drawing.Size(192, 31);
            this.txtBoxVertificationCode.TabIndex = 111;
            this.txtBoxVertificationCode.Validated += new System.EventHandler(this.txtBoxVertificationCode_Validated);
            // 
            // labelVertificationCode
            // 
            this.labelVertificationCode.AutoSize = true;
            this.labelVertificationCode.BackColor = System.Drawing.Color.Transparent;
            this.labelVertificationCode.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVertificationCode.Location = new System.Drawing.Point(309, 144);
            this.labelVertificationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVertificationCode.Name = "labelVertificationCode";
            this.labelVertificationCode.Size = new System.Drawing.Size(155, 24);
            this.labelVertificationCode.TabIndex = 110;
            this.labelVertificationCode.Text = "Verification Code:";
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.Teal;
            this.sendEmailButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.sendEmailButton.Location = new System.Drawing.Point(672, 137);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(75, 34);
            this.sendEmailButton.TabIndex = 109;
            this.sendEmailButton.Text = "Send";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // ActivateNewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(758, 346);
            this.Controls.Add(this.txtBoxVertificationCode);
            this.Controls.Add(this.labelVertificationCode);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLoginIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.PictureBoxImage);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtBoxEmail);
            this.Name = "ActivateNewAccountForm";
            this.Text = "ActivateNewAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoginIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.TextBox txtBoxVertificationCode;
        private System.Windows.Forms.Label labelVertificationCode;
        private System.Windows.Forms.Button sendEmailButton;
    }
}