namespace EmeraldRestaurant
{
    partial class ManagerMainForm
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
            this.tabPageCalculate = new System.Windows.Forms.TabPage();
            this.resetSalaryButton = new System.Windows.Forms.Button();
            this.dataGridViewCalculateSalary = new System.Windows.Forms.DataGridView();
            this.calculateSalaryButton = new System.Windows.Forms.Button();
            this.labelTotalEmp = new System.Windows.Forms.Label();
            this.tabPageManageEmployee = new System.Windows.Forms.TabPage();
            this.lockAccountButton = new System.Windows.Forms.Button();
            this.resetTimeForEmployee = new System.Windows.Forms.Button();
            this.dataGridViewListEmployee = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.buttonChiaCa = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelXuyet2 = new System.Windows.Forms.Label();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.labelXuyet1 = new System.Windows.Forms.Label();
            this.labelEditInfo = new System.Windows.Forms.Label();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureImage = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelTableButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDinnerTableID = new System.Windows.Forms.TextBox();
            this.labelQuantityCustomer = new System.Windows.Forms.Label();
            this.labelDinnerTableName = new System.Windows.Forms.Label();
            this.textBoxDinnerQuantityCustomer = new System.Windows.Forms.TextBox();
            this.textBoxDinnerTableName = new System.Windows.Forms.TextBox();
            this.removeDinnerTableButton = new System.Windows.Forms.Button();
            this.editDinnerTableButton = new System.Windows.Forms.Button();
            this.addDinnerTableButton = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelDateTime = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.kitchenButton = new System.Windows.Forms.Button();
            this.tabPageCalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalculateSalary)).BeginInit();
            this.tabPageManageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.flowLayoutPanelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageCalculate
            // 
            this.tabPageCalculate.Controls.Add(this.resetSalaryButton);
            this.tabPageCalculate.Controls.Add(this.dataGridViewCalculateSalary);
            this.tabPageCalculate.Controls.Add(this.calculateSalaryButton);
            this.tabPageCalculate.Location = new System.Drawing.Point(4, 30);
            this.tabPageCalculate.Name = "tabPageCalculate";
            this.tabPageCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalculate.Size = new System.Drawing.Size(1349, 672);
            this.tabPageCalculate.TabIndex = 2;
            this.tabPageCalculate.Text = "Calculate Salary For Employee";
            this.tabPageCalculate.UseVisualStyleBackColor = true;
            // 
            // resetSalaryButton
            // 
            this.resetSalaryButton.Image = global::EmeraldRestaurant.Properties.Resources.z3477823622444_6619e4431f3de697d70be174eb089ca3;
            this.resetSalaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetSalaryButton.Location = new System.Drawing.Point(980, 7);
            this.resetSalaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetSalaryButton.Name = "resetSalaryButton";
            this.resetSalaryButton.Size = new System.Drawing.Size(355, 34);
            this.resetSalaryButton.TabIndex = 3;
            this.resetSalaryButton.Text = "Reset Salary For New Week";
            this.resetSalaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetSalaryButton.UseVisualStyleBackColor = true;
            this.resetSalaryButton.Click += new System.EventHandler(this.resetSalaryButton_Click);
            // 
            // dataGridViewCalculateSalary
            // 
            this.dataGridViewCalculateSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCalculateSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalculateSalary.Location = new System.Drawing.Point(8, 48);
            this.dataGridViewCalculateSalary.Name = "dataGridViewCalculateSalary";
            this.dataGridViewCalculateSalary.RowHeadersWidth = 51;
            this.dataGridViewCalculateSalary.RowTemplate.Height = 24;
            this.dataGridViewCalculateSalary.Size = new System.Drawing.Size(1327, 613);
            this.dataGridViewCalculateSalary.TabIndex = 2;
            // 
            // calculateSalaryButton
            // 
            this.calculateSalaryButton.Image = global::EmeraldRestaurant.Properties.Resources.ShiftIcon;
            this.calculateSalaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculateSalaryButton.Location = new System.Drawing.Point(7, 7);
            this.calculateSalaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateSalaryButton.Name = "calculateSalaryButton";
            this.calculateSalaryButton.Size = new System.Drawing.Size(313, 34);
            this.calculateSalaryButton.TabIndex = 1;
            this.calculateSalaryButton.Text = "Calculate Employee Salary";
            this.calculateSalaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calculateSalaryButton.UseVisualStyleBackColor = true;
            this.calculateSalaryButton.Click += new System.EventHandler(this.calculateSalaryButton_Click);
            // 
            // labelTotalEmp
            // 
            this.labelTotalEmp.AutoSize = true;
            this.labelTotalEmp.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.labelTotalEmp.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelTotalEmp.Location = new System.Drawing.Point(946, 554);
            this.labelTotalEmp.Name = "labelTotalEmp";
            this.labelTotalEmp.Size = new System.Drawing.Size(222, 31);
            this.labelTotalEmp.TabIndex = 33;
            this.labelTotalEmp.Text = "Total Employee: 00";
            // 
            // tabPageManageEmployee
            // 
            this.tabPageManageEmployee.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabPageManageEmployee.Controls.Add(this.lockAccountButton);
            this.tabPageManageEmployee.Controls.Add(this.labelTotalEmp);
            this.tabPageManageEmployee.Controls.Add(this.resetTimeForEmployee);
            this.tabPageManageEmployee.Controls.Add(this.dataGridViewListEmployee);
            this.tabPageManageEmployee.Controls.Add(this.removeButton);
            this.tabPageManageEmployee.Controls.Add(this.buttonChiaCa);
            this.tabPageManageEmployee.Controls.Add(this.searchButton);
            this.tabPageManageEmployee.Controls.Add(this.txtBoxSearch);
            this.tabPageManageEmployee.Controls.Add(this.addButton);
            this.tabPageManageEmployee.Location = new System.Drawing.Point(4, 30);
            this.tabPageManageEmployee.Name = "tabPageManageEmployee";
            this.tabPageManageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageEmployee.Size = new System.Drawing.Size(1349, 672);
            this.tabPageManageEmployee.TabIndex = 0;
            this.tabPageManageEmployee.Text = "Manage Employee";
            // 
            // lockAccountButton
            // 
            this.lockAccountButton.BackColor = System.Drawing.Color.Teal;
            this.lockAccountButton.BackgroundImage = global::EmeraldRestaurant.Properties.Resources._1486506252_lock_protected_safe_privacy_password_security_81486;
            this.lockAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lockAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lockAccountButton.ForeColor = System.Drawing.Color.White;
            this.lockAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lockAccountButton.Location = new System.Drawing.Point(1213, 401);
            this.lockAccountButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lockAccountButton.Name = "lockAccountButton";
            this.lockAccountButton.Size = new System.Drawing.Size(84, 66);
            this.lockAccountButton.TabIndex = 35;
            this.lockAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lockAccountButton.UseVisualStyleBackColor = false;
            this.lockAccountButton.Click += new System.EventHandler(this.lockAccountButton_Click);
            // 
            // resetTimeForEmployee
            // 
            this.resetTimeForEmployee.BackColor = System.Drawing.Color.Teal;
            this.resetTimeForEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetTimeForEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetTimeForEmployee.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetTimeForEmployee.ForeColor = System.Drawing.Color.LemonChiffon;
            this.resetTimeForEmployee.Image = global::EmeraldRestaurant.Properties.Resources.reset_icon_217000;
            this.resetTimeForEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetTimeForEmployee.Location = new System.Drawing.Point(851, 99);
            this.resetTimeForEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetTimeForEmployee.Name = "resetTimeForEmployee";
            this.resetTimeForEmployee.Size = new System.Drawing.Size(317, 45);
            this.resetTimeForEmployee.TabIndex = 31;
            this.resetTimeForEmployee.Text = "Reset Time For Employee";
            this.resetTimeForEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.resetTimeForEmployee.UseVisualStyleBackColor = false;
            this.resetTimeForEmployee.Click += new System.EventHandler(this.resetTimeForEmployee_Click);
            // 
            // dataGridViewListEmployee
            // 
            this.dataGridViewListEmployee.AllowUserToAddRows = false;
            this.dataGridViewListEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewListEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEmployee.Location = new System.Drawing.Point(20, 169);
            this.dataGridViewListEmployee.Name = "dataGridViewListEmployee";
            this.dataGridViewListEmployee.ReadOnly = true;
            this.dataGridViewListEmployee.RowHeadersWidth = 62;
            this.dataGridViewListEmployee.RowTemplate.Height = 28;
            this.dataGridViewListEmployee.Size = new System.Drawing.Size(1148, 365);
            this.dataGridViewListEmployee.TabIndex = 30;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Teal;
            this.removeButton.BackgroundImage = global::EmeraldRestaurant.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.Location = new System.Drawing.Point(1213, 272);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(84, 66);
            this.removeButton.TabIndex = 29;
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // buttonChiaCa
            // 
            this.buttonChiaCa.BackColor = System.Drawing.Color.Teal;
            this.buttonChiaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiaCa.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiaCa.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonChiaCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChiaCa.Location = new System.Drawing.Point(608, 100);
            this.buttonChiaCa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChiaCa.Name = "buttonChiaCa";
            this.buttonChiaCa.Size = new System.Drawing.Size(237, 45);
            this.buttonChiaCa.TabIndex = 28;
            this.buttonChiaCa.Text = "Split work shift";
            this.buttonChiaCa.UseVisualStyleBackColor = false;
            this.buttonChiaCa.Click += new System.EventHandler(this.buttonChiaCa_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Teal;
            this.searchButton.BackgroundImage = global::EmeraldRestaurant.Properties.Resources.business_man_usersearch_thesearch_theclient_2356;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(24, 77);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 67);
            this.searchButton.TabIndex = 26;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.White;
            this.txtBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearch.Location = new System.Drawing.Point(123, 100);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Multiline = true;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(468, 44);
            this.txtBoxSearch.TabIndex = 25;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Teal;
            this.addButton.BackgroundImage = global::EmeraldRestaurant.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(1213, 169);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 66);
            this.addButton.TabIndex = 24;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.labelLogOut.Location = new System.Drawing.Point(499, 91);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(74, 24);
            this.labelLogOut.TabIndex = 7;
            this.labelLogOut.Text = "Log Out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.labelLogOut);
            this.panel1.Controls.Add(this.labelXuyet2);
            this.panel1.Controls.Add(this.labelRefresh);
            this.panel1.Controls.Add(this.labelXuyet1);
            this.panel1.Controls.Add(this.labelEditInfo);
            this.panel1.Controls.Add(this.labelGreeting);
            this.panel1.Controls.Add(this.labelHello);
            this.panel1.Controls.Add(this.pictureImage);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Peru;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 127);
            this.panel1.TabIndex = 7;
            // 
            // labelXuyet2
            // 
            this.labelXuyet2.AutoSize = true;
            this.labelXuyet2.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.labelXuyet2.Location = new System.Drawing.Point(463, 91);
            this.labelXuyet2.Name = "labelXuyet2";
            this.labelXuyet2.Size = new System.Drawing.Size(17, 24);
            this.labelXuyet2.TabIndex = 6;
            this.labelXuyet2.Text = "|";
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.labelRefresh.Location = new System.Drawing.Point(375, 91);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(75, 24);
            this.labelRefresh.TabIndex = 5;
            this.labelRefresh.Text = "Refresh";
            this.labelRefresh.Click += new System.EventHandler(this.labelRefresh_Click);
            // 
            // labelXuyet1
            // 
            this.labelXuyet1.AutoSize = true;
            this.labelXuyet1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.labelXuyet1.Location = new System.Drawing.Point(343, 91);
            this.labelXuyet1.Name = "labelXuyet1";
            this.labelXuyet1.Size = new System.Drawing.Size(17, 24);
            this.labelXuyet1.TabIndex = 4;
            this.labelXuyet1.Text = "|";
            // 
            // labelEditInfo
            // 
            this.labelEditInfo.AutoSize = true;
            this.labelEditInfo.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.labelEditInfo.Location = new System.Drawing.Point(150, 91);
            this.labelEditInfo.Name = "labelEditInfo";
            this.labelEditInfo.Size = new System.Drawing.Size(175, 24);
            this.labelEditInfo.TabIndex = 3;
            this.labelEditInfo.Text = "Edit My Information";
            this.labelEditInfo.Click += new System.EventHandler(this.labelEditInfo_Click);
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.ForeColor = System.Drawing.Color.Khaki;
            this.labelGreeting.Location = new System.Drawing.Point(151, 48);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(219, 27);
            this.labelGreeting.TabIndex = 2;
            this.labelGreeting.Text = "Have a nice day ^_^ !";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.CadetBlue;
            this.labelHello.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.Gold;
            this.labelHello.Location = new System.Drawing.Point(148, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(199, 35);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Hello Full Name";
            // 
            // pictureImage
            // 
            this.pictureImage.Location = new System.Drawing.Point(1, 3);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Size = new System.Drawing.Size(143, 122);
            this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImage.TabIndex = 0;
            this.pictureImage.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageManageEmployee);
            this.tabControl1.Controls.Add(this.tabPageCalculate);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1357, 706);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabPage1.Controls.Add(this.kitchenButton);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cancelTableButton);
            this.tabPage1.Controls.Add(this.bookButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxDinnerTableID);
            this.tabPage1.Controls.Add(this.labelQuantityCustomer);
            this.tabPage1.Controls.Add(this.labelDinnerTableName);
            this.tabPage1.Controls.Add(this.textBoxDinnerQuantityCustomer);
            this.tabPage1.Controls.Add(this.textBoxDinnerTableName);
            this.tabPage1.Controls.Add(this.removeDinnerTableButton);
            this.tabPage1.Controls.Add(this.editDinnerTableButton);
            this.tabPage1.Controls.Add(this.addDinnerTableButton);
            this.tabPage1.Controls.Add(this.dataGridViewTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1349, 672);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Manage Table";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmeraldRestaurant.Properties.Resources.z3478642442951_9d0fcbb7926acf3379f4f18bcd837d63;
            this.pictureBox1.Location = new System.Drawing.Point(182, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 153;
            this.pictureBox1.TabStop = false;
            // 
            // cancelTableButton
            // 
            this.cancelTableButton.BackColor = System.Drawing.Color.Teal;
            this.cancelTableButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.cancelTableButton.Location = new System.Drawing.Point(682, 599);
            this.cancelTableButton.Name = "cancelTableButton";
            this.cancelTableButton.Size = new System.Drawing.Size(235, 55);
            this.cancelTableButton.TabIndex = 152;
            this.cancelTableButton.Text = "Cancel Table";
            this.cancelTableButton.UseVisualStyleBackColor = false;
            this.cancelTableButton.Click += new System.EventHandler(this.cancelTableButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.Teal;
            this.bookButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.bookButton.Location = new System.Drawing.Point(381, 599);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(235, 55);
            this.bookButton.TabIndex = 151;
            this.bookButton.Text = "Book Table";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(122, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 150;
            this.label4.Text = "Table ID:";
            // 
            // textBoxDinnerTableID
            // 
            this.textBoxDinnerTableID.BackColor = System.Drawing.Color.White;
            this.textBoxDinnerTableID.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDinnerTableID.ForeColor = System.Drawing.Color.Black;
            this.textBoxDinnerTableID.Location = new System.Drawing.Point(247, 239);
            this.textBoxDinnerTableID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDinnerTableID.Name = "textBoxDinnerTableID";
            this.textBoxDinnerTableID.Size = new System.Drawing.Size(245, 31);
            this.textBoxDinnerTableID.TabIndex = 149;
            this.textBoxDinnerTableID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDinnerTableID_KeyPress);
            // 
            // labelQuantityCustomer
            // 
            this.labelQuantityCustomer.AutoSize = true;
            this.labelQuantityCustomer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityCustomer.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelQuantityCustomer.Location = new System.Drawing.Point(27, 343);
            this.labelQuantityCustomer.Name = "labelQuantityCustomer";
            this.labelQuantityCustomer.Size = new System.Drawing.Size(204, 29);
            this.labelQuantityCustomer.TabIndex = 147;
            this.labelQuantityCustomer.Text = "Quantity Customer:";
            // 
            // labelDinnerTableName
            // 
            this.labelDinnerTableName.AutoSize = true;
            this.labelDinnerTableName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDinnerTableName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelDinnerTableName.Location = new System.Drawing.Point(93, 291);
            this.labelDinnerTableName.Name = "labelDinnerTableName";
            this.labelDinnerTableName.Size = new System.Drawing.Size(138, 29);
            this.labelDinnerTableName.TabIndex = 146;
            this.labelDinnerTableName.Text = "Table Name:";
            // 
            // textBoxDinnerQuantityCustomer
            // 
            this.textBoxDinnerQuantityCustomer.BackColor = System.Drawing.Color.White;
            this.textBoxDinnerQuantityCustomer.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDinnerQuantityCustomer.ForeColor = System.Drawing.Color.Black;
            this.textBoxDinnerQuantityCustomer.Location = new System.Drawing.Point(247, 341);
            this.textBoxDinnerQuantityCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDinnerQuantityCustomer.Name = "textBoxDinnerQuantityCustomer";
            this.textBoxDinnerQuantityCustomer.Size = new System.Drawing.Size(245, 31);
            this.textBoxDinnerQuantityCustomer.TabIndex = 144;
            this.textBoxDinnerQuantityCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDinnerQuantityCustomer_KeyPress);
            // 
            // textBoxDinnerTableName
            // 
            this.textBoxDinnerTableName.BackColor = System.Drawing.Color.White;
            this.textBoxDinnerTableName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDinnerTableName.ForeColor = System.Drawing.Color.Black;
            this.textBoxDinnerTableName.Location = new System.Drawing.Point(247, 289);
            this.textBoxDinnerTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDinnerTableName.Name = "textBoxDinnerTableName";
            this.textBoxDinnerTableName.Size = new System.Drawing.Size(245, 31);
            this.textBoxDinnerTableName.TabIndex = 143;
            // 
            // removeDinnerTableButton
            // 
            this.removeDinnerTableButton.BackColor = System.Drawing.Color.Teal;
            this.removeDinnerTableButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.removeDinnerTableButton.Location = new System.Drawing.Point(917, 528);
            this.removeDinnerTableButton.Name = "removeDinnerTableButton";
            this.removeDinnerTableButton.Size = new System.Drawing.Size(235, 55);
            this.removeDinnerTableButton.TabIndex = 142;
            this.removeDinnerTableButton.Text = "Remove Table";
            this.removeDinnerTableButton.UseVisualStyleBackColor = false;
            this.removeDinnerTableButton.Click += new System.EventHandler(this.removeDinnerTableButton_Click);
            // 
            // editDinnerTableButton
            // 
            this.editDinnerTableButton.BackColor = System.Drawing.Color.Teal;
            this.editDinnerTableButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.editDinnerTableButton.Location = new System.Drawing.Point(540, 528);
            this.editDinnerTableButton.Name = "editDinnerTableButton";
            this.editDinnerTableButton.Size = new System.Drawing.Size(235, 55);
            this.editDinnerTableButton.TabIndex = 141;
            this.editDinnerTableButton.Text = "Edit Table";
            this.editDinnerTableButton.UseVisualStyleBackColor = false;
            this.editDinnerTableButton.Click += new System.EventHandler(this.editDinnerTableButton_Click);
            // 
            // addDinnerTableButton
            // 
            this.addDinnerTableButton.BackColor = System.Drawing.Color.Teal;
            this.addDinnerTableButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.addDinnerTableButton.Location = new System.Drawing.Point(163, 528);
            this.addDinnerTableButton.Name = "addDinnerTableButton";
            this.addDinnerTableButton.Size = new System.Drawing.Size(235, 55);
            this.addDinnerTableButton.TabIndex = 140;
            this.addDinnerTableButton.Text = "Add Table";
            this.addDinnerTableButton.UseVisualStyleBackColor = false;
            this.addDinnerTableButton.Click += new System.EventHandler(this.addDinnerTableButton_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(565, 52);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.RowHeadersWidth = 62;
            this.dataGridViewTable.RowTemplate.Height = 28;
            this.dataGridViewTable.Size = new System.Drawing.Size(759, 411);
            this.dataGridViewTable.TabIndex = 139;
            this.dataGridViewTable.Click += new System.EventHandler(this.dataGridViewListTable_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanelDateTime
            // 
            this.flowLayoutPanelDateTime.Controls.Add(this.labelTime);
            this.flowLayoutPanelDateTime.Controls.Add(this.labelDate);
            this.flowLayoutPanelDateTime.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelDateTime.Location = new System.Drawing.Point(958, 12);
            this.flowLayoutPanelDateTime.Name = "flowLayoutPanelDateTime";
            this.flowLayoutPanelDateTime.Size = new System.Drawing.Size(384, 71);
            this.flowLayoutPanelDateTime.TabIndex = 10;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Khaki;
            this.labelTime.Location = new System.Drawing.Point(278, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(103, 29);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "23:59:59";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Khaki;
            this.labelDate.Location = new System.Drawing.Point(45, 29);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(336, 29);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Wednesday, November 30, 2022";
            // 
            // kitchenButton
            // 
            this.kitchenButton.BackColor = System.Drawing.Color.Teal;
            this.kitchenButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.kitchenButton.Location = new System.Drawing.Point(1017, 599);
            this.kitchenButton.Name = "kitchenButton";
            this.kitchenButton.Size = new System.Drawing.Size(235, 55);
            this.kitchenButton.TabIndex = 154;
            this.kitchenButton.Text = "Kitchen";
            this.kitchenButton.UseVisualStyleBackColor = false;
            this.kitchenButton.Click += new System.EventHandler(this.kitchenButton_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1354, 832);
            this.Controls.Add(this.flowLayoutPanelDateTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Main Form";
            this.Load += new System.EventHandler(this.Manager_Main_Form_Load);
            this.tabPageCalculate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalculateSalary)).EndInit();
            this.tabPageManageEmployee.ResumeLayout(false);
            this.tabPageManageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.flowLayoutPanelDateTime.ResumeLayout(false);
            this.flowLayoutPanelDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageCalculate;
        private System.Windows.Forms.Label labelTotalEmp;
        private System.Windows.Forms.TabPage tabPageManageEmployee;
        private System.Windows.Forms.Button resetTimeForEmployee;
        private System.Windows.Forms.DataGridView dataGridViewListEmployee;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button buttonChiaCa;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelXuyet2;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Label labelXuyet1;
        private System.Windows.Forms.Label labelEditInfo;
        private System.Windows.Forms.Label labelGreeting;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button lockAccountButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDateTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button calculateSalaryButton;
        private System.Windows.Forms.DataGridView dataGridViewCalculateSalary;
        private System.Windows.Forms.Button resetSalaryButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDinnerTableID;
        private System.Windows.Forms.Label labelQuantityCustomer;
        private System.Windows.Forms.Label labelDinnerTableName;
        private System.Windows.Forms.TextBox textBoxDinnerQuantityCustomer;
        private System.Windows.Forms.TextBox textBoxDinnerTableName;
        private System.Windows.Forms.Button removeDinnerTableButton;
        private System.Windows.Forms.Button editDinnerTableButton;
        private System.Windows.Forms.Button addDinnerTableButton;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button cancelTableButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kitchenButton;
    }
}