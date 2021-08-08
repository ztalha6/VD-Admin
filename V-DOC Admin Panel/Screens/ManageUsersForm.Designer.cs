namespace V_DOC_Admin_Panel.Screens
{
    partial class ManageUsersForm
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
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.AddMechbtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Deluser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CarsGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TrackersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.MechanicsGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.NotiLogGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.NotificationsGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.UserSearchtxt = new System.Windows.Forms.TextBox();
            this.CarSearchtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackerSearchtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MechanicSearchtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NotiLogsSearchtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NotificationSearchtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackersGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicsGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotiLogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersGridView
            // 
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Location = new System.Drawing.Point(18, 63);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.Size = new System.Drawing.Size(912, 298);
            this.UsersGridView.TabIndex = 0;
            // 
            // AddMechbtn
            // 
            this.AddMechbtn.Location = new System.Drawing.Point(760, 367);
            this.AddMechbtn.Name = "AddMechbtn";
            this.AddMechbtn.Size = new System.Drawing.Size(170, 42);
            this.AddMechbtn.TabIndex = 1;
            this.AddMechbtn.Text = "+ Add Mechanic";
            this.AddMechbtn.UseVisualStyleBackColor = true;
            this.AddMechbtn.Click += new System.EventHandler(this.AddUserbtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(28, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 441);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UserSearchtxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Deluser);
            this.tabPage1.Controls.Add(this.UsersGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Deluser
            // 
            this.Deluser.Location = new System.Drawing.Point(760, 367);
            this.Deluser.Name = "Deluser";
            this.Deluser.Size = new System.Drawing.Size(170, 42);
            this.Deluser.TabIndex = 2;
            this.Deluser.Text = "- Delete User";
            this.Deluser.UseVisualStyleBackColor = true;
            this.Deluser.Click += new System.EventHandler(this.Deluser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CarSearchtxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.CarsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cars";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CarsGridView
            // 
            this.CarsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsGridView.Location = new System.Drawing.Point(18, 68);
            this.CarsGridView.Name = "CarsGridView";
            this.CarsGridView.Size = new System.Drawing.Size(912, 341);
            this.CarsGridView.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TrackerSearchtxt);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.TrackersGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(949, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tackers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TrackersGridView
            // 
            this.TrackersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrackersGridView.Location = new System.Drawing.Point(18, 68);
            this.TrackersGridView.Name = "TrackersGridView";
            this.TrackersGridView.Size = new System.Drawing.Size(912, 332);
            this.TrackersGridView.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.MechanicSearchtxt);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.MechanicsGridView);
            this.tabPage4.Controls.Add(this.AddMechbtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(949, 415);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mecahincs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MechanicsGridView
            // 
            this.MechanicsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MechanicsGridView.Location = new System.Drawing.Point(18, 67);
            this.MechanicsGridView.Name = "MechanicsGridView";
            this.MechanicsGridView.Size = new System.Drawing.Size(912, 294);
            this.MechanicsGridView.TabIndex = 1;
            this.MechanicsGridView.DoubleClick += new System.EventHandler(this.MechanicsGridView_DoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.NotiLogsSearchtxt);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.NotiLogGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(949, 415);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Notification Logs";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // NotiLogGridView
            // 
            this.NotiLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotiLogGridView.Location = new System.Drawing.Point(18, 66);
            this.NotiLogGridView.Name = "NotiLogGridView";
            this.NotiLogGridView.Size = new System.Drawing.Size(912, 336);
            this.NotiLogGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(188, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Better way to mange your car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehicle Doctor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Mileage Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::V_DOC_Admin_Panel.Properties.Resources.mini2;
            this.pictureBox1.Location = new System.Drawing.Point(34, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.NotificationSearchtxt);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.NotificationsGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(949, 415);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Notifications";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // NotificationsGridView
            // 
            this.NotificationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotificationsGridView.Location = new System.Drawing.Point(18, 69);
            this.NotificationsGridView.Name = "NotificationsGridView";
            this.NotificationsGridView.Size = new System.Drawing.Size(912, 333);
            this.NotificationsGridView.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search: ";
            // 
            // UserSearchtxt
            // 
            this.UserSearchtxt.Location = new System.Drawing.Point(68, 24);
            this.UserSearchtxt.Name = "UserSearchtxt";
            this.UserSearchtxt.Size = new System.Drawing.Size(245, 20);
            this.UserSearchtxt.TabIndex = 4;
            this.UserSearchtxt.TextChanged += new System.EventHandler(this.UserSearchtxt_TextChanged);
            // 
            // CarSearchtxt
            // 
            this.CarSearchtxt.Location = new System.Drawing.Point(68, 25);
            this.CarSearchtxt.Name = "CarSearchtxt";
            this.CarSearchtxt.Size = new System.Drawing.Size(245, 20);
            this.CarSearchtxt.TabIndex = 6;
            this.CarSearchtxt.TextChanged += new System.EventHandler(this.CarSearchtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search: ";
            // 
            // TrackerSearchtxt
            // 
            this.TrackerSearchtxt.Location = new System.Drawing.Point(68, 27);
            this.TrackerSearchtxt.Name = "TrackerSearchtxt";
            this.TrackerSearchtxt.Size = new System.Drawing.Size(245, 20);
            this.TrackerSearchtxt.TabIndex = 6;
            this.TrackerSearchtxt.TextChanged += new System.EventHandler(this.TrackerSearchtxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search: ";
            // 
            // MechanicSearchtxt
            // 
            this.MechanicSearchtxt.Location = new System.Drawing.Point(71, 28);
            this.MechanicSearchtxt.Name = "MechanicSearchtxt";
            this.MechanicSearchtxt.Size = new System.Drawing.Size(245, 20);
            this.MechanicSearchtxt.TabIndex = 6;
            this.MechanicSearchtxt.TextChanged += new System.EventHandler(this.MechanicSearchtxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search: ";
            // 
            // NotiLogsSearchtxt
            // 
            this.NotiLogsSearchtxt.Location = new System.Drawing.Point(70, 30);
            this.NotiLogsSearchtxt.Name = "NotiLogsSearchtxt";
            this.NotiLogsSearchtxt.Size = new System.Drawing.Size(245, 20);
            this.NotiLogsSearchtxt.TabIndex = 6;
            this.NotiLogsSearchtxt.TextChanged += new System.EventHandler(this.NotiLogsSearchtxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Search: ";
            // 
            // NotificationSearchtxt
            // 
            this.NotificationSearchtxt.Location = new System.Drawing.Point(71, 25);
            this.NotificationSearchtxt.Name = "NotificationSearchtxt";
            this.NotificationSearchtxt.Size = new System.Drawing.Size(245, 20);
            this.NotificationSearchtxt.TabIndex = 6;
            this.NotificationSearchtxt.TextChanged += new System.EventHandler(this.NotificationSearchtxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Search: ";
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(997, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageUsersForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackersGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicsGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotiLogGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.Button AddMechbtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView CarsGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView TrackersGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView MechanicsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Deluser;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView NotiLogGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView NotificationsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserSearchtxt;
        private System.Windows.Forms.TextBox CarSearchtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TrackerSearchtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MechanicSearchtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NotiLogsSearchtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NotificationSearchtxt;
        private System.Windows.Forms.Label label8;
    }
}