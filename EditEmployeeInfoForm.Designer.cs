namespace EmeraldRestaurant
{
    partial class EditEmployeeInfoForm
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
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.txtBoxLname = new System.Windows.Forms.TextBox();
            this.txtBoxFname = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.labelEmailNote = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(556, 250);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(86, 28);
            this.RadioButtonFemale.TabIndex = 5;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonMale.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.Location = new System.Drawing.Point(436, 250);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(69, 28);
            this.RadioButtonMale.TabIndex = 5;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = false;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.ForeColor = System.Drawing.Color.Black;
            this.txtBoxAddress.Location = new System.Drawing.Point(436, 321);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(277, 66);
            this.txtBoxAddress.TabIndex = 7;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhone.Location = new System.Drawing.Point(436, 284);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(277, 31);
            this.txtBoxPhone.TabIndex = 6;
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPhone_KeyPress);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.lblGender.Location = new System.Drawing.Point(354, 254);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 24);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.labelPhone.Location = new System.Drawing.Point(366, 291);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(62, 24);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.labelAddress.Location = new System.Drawing.Point(347, 321);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(81, 24);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(436, 206);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 24, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1975, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(277, 31);
            this.DateTimePicker1.TabIndex = 4;
            this.DateTimePicker1.Value = new System.DateTime(1975, 12, 24, 0, 0, 0, 0);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthDate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.lblBirthDate.Location = new System.Drawing.Point(334, 213);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(94, 24);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "BirthDate:";
            // 
            // changeImageButton
            // 
            this.changeImageButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.changeImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeImageButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeImageButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.changeImageButton.Location = new System.Drawing.Point(12, 251);
            this.changeImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changeImageButton.Size = new System.Drawing.Size(280, 27);
            this.changeImageButton.TabIndex = 8;
            this.changeImageButton.Text = "Change Profile Image";
            this.changeImageButton.UseVisualStyleBackColor = false;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // txtBoxLname
            // 
            this.txtBoxLname.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLname.Location = new System.Drawing.Point(436, 170);
            this.txtBoxLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxLname.Name = "txtBoxLname";
            this.txtBoxLname.Size = new System.Drawing.Size(278, 31);
            this.txtBoxLname.TabIndex = 3;
            this.txtBoxLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLname_KeyPress);
            // 
            // txtBoxFname
            // 
            this.txtBoxFname.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFname.Location = new System.Drawing.Point(436, 135);
            this.txtBoxFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxFname.Name = "txtBoxFname";
            this.txtBoxFname.Size = new System.Drawing.Size(277, 31);
            this.txtBoxFname.TabIndex = 2;
            this.txtBoxFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFname_KeyPress);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(328, 177);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(100, 24);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(324, 142);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(104, 24);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.editButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.editButton.Location = new System.Drawing.Point(328, 400);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(385, 44);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // labelEmailNote
            // 
            this.labelEmailNote.AutoSize = true;
            this.labelEmailNote.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailNote.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailNote.Location = new System.Drawing.Point(386, 71);
            this.labelEmailNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailNote.Name = "labelEmailNote";
            this.labelEmailNote.Size = new System.Drawing.Size(328, 18);
            this.labelEmailNote.TabIndex = 0;
            this.labelEmailNote.Text = "You need to use this email in case of password reset.";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(371, 44);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 24);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Enabled = false;
            this.txtBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(436, 37);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(278, 31);
            this.txtBoxEmail.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxIcon.Image = global::EmeraldRestaurant.Properties.Resources.waiters_man_avatar_waiter_barman_icon_210167;
            this.pictureBoxIcon.Location = new System.Drawing.Point(76, 301);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(163, 123);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 108;
            this.pictureBoxIcon.TabStop = false;
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BackColor = System.Drawing.Color.White;
            this.PictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxImage.Location = new System.Drawing.Point(13, 27);
            this.PictureBoxImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(279, 220);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImage.TabIndex = 96;
            this.PictureBoxImage.TabStop = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(436, 100);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(278, 31);
            this.txtBoxPassword.TabIndex = 1;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(338, 107);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(90, 24);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Info;
            this.cancelButton.BackgroundImage = global::EmeraldRestaurant.Properties.Resources.return_48_45247;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cancelButton.ForeColor = System.Drawing.Color.Transparent;
            this.cancelButton.Location = new System.Drawing.Point(742, 12);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(54, 48);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditEmployeeInfoForm
            // 
            this.AcceptButton = this.editButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(809, 460);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.changeImageButton);
            this.Controls.Add(this.PictureBoxImage);
            this.Controls.Add(this.txtBoxLname);
            this.Controls.Add(this.txtBoxFname);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.labelEmailNote);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.pictureBoxIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmployeeInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Employee Info Form";
            this.Load += new System.EventHandler(this.EditEmployeeInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Button changeImageButton;
        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.TextBox txtBoxLname;
        private System.Windows.Forms.TextBox txtBoxFname;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label labelEmailNote;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button cancelButton;
    }
}