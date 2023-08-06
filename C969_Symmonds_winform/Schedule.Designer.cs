
namespace C969_Symmonds_winform
{
    partial class Schedule
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
            this.ScheduleGridView = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.Prev_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerName_Text = new System.Windows.Forms.TextBox();
            this.Title_Text = new System.Windows.Forms.TextBox();
            this.Description_Text = new System.Windows.Forms.TextBox();
            this.Location_Text = new System.Windows.Forms.TextBox();
            this.StartTime_Text = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Modify_Button = new System.Windows.Forms.Button();
            this.Date_Value = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Type_DropDown = new System.Windows.Forms.ComboBox();
            this.appointmentId_Text = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleGridView
            // 
            this.ScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.AppointmentId,
            this.customerName,
            this.Title,
            this.Description,
            this.Location,
            this.startTime,
            this.Type});
            this.ScheduleGridView.Location = new System.Drawing.Point(332, 241);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.RowHeadersWidth = 51;
            this.ScheduleGridView.RowTemplate.Height = 24;
            this.ScheduleGridView.Size = new System.Drawing.Size(677, 291);
            this.ScheduleGridView.TabIndex = 2;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "customerId";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            this.CustomerId.Width = 125;
            // 
            // AppointmentId
            // 
            this.AppointmentId.HeaderText = "AppointmentId";
            this.AppointmentId.MinimumWidth = 6;
            this.AppointmentId.Name = "AppointmentId";
            this.AppointmentId.Visible = false;
            this.AppointmentId.Width = 125;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 125;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start Time";
            this.startTime.MinimumWidth = 6;
            this.startTime.Name = "startTime";
            this.startTime.Width = 125;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(747, 20);
            this.monthCalendar2.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // Prev_Button
            // 
            this.Prev_Button.Location = new System.Drawing.Point(12, 508);
            this.Prev_Button.Name = "Prev_Button";
            this.Prev_Button.Size = new System.Drawing.Size(112, 34);
            this.Prev_Button.TabIndex = 8;
            this.Prev_Button.Text = "PREV";
            this.Prev_Button.UseVisualStyleBackColor = true;
            this.Prev_Button.Click += new System.EventHandler(this.Prev_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Start Time";
            // 
            // CustomerName_Text
            // 
            this.CustomerName_Text.Location = new System.Drawing.Point(174, 20);
            this.CustomerName_Text.Name = "CustomerName_Text";
            this.CustomerName_Text.Size = new System.Drawing.Size(148, 22);
            this.CustomerName_Text.TabIndex = 14;
            // 
            // Title_Text
            // 
            this.Title_Text.Location = new System.Drawing.Point(174, 58);
            this.Title_Text.Name = "Title_Text";
            this.Title_Text.Size = new System.Drawing.Size(148, 22);
            this.Title_Text.TabIndex = 15;
            // 
            // Description_Text
            // 
            this.Description_Text.Location = new System.Drawing.Point(174, 98);
            this.Description_Text.Name = "Description_Text";
            this.Description_Text.Size = new System.Drawing.Size(148, 22);
            this.Description_Text.TabIndex = 16;
            // 
            // Location_Text
            // 
            this.Location_Text.Location = new System.Drawing.Point(174, 141);
            this.Location_Text.Name = "Location_Text";
            this.Location_Text.Size = new System.Drawing.Size(148, 22);
            this.Location_Text.TabIndex = 17;
            // 
            // StartTime_Text
            // 
            this.StartTime_Text.Location = new System.Drawing.Point(174, 190);
            this.StartTime_Text.Name = "StartTime_Text";
            this.StartTime_Text.Size = new System.Drawing.Size(148, 22);
            this.StartTime_Text.TabIndex = 18;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(141, 339);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 19;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Modify_Button
            // 
            this.Modify_Button.Location = new System.Drawing.Point(237, 339);
            this.Modify_Button.Name = "Modify_Button";
            this.Modify_Button.Size = new System.Drawing.Size(75, 23);
            this.Modify_Button.TabIndex = 20;
            this.Modify_Button.Text = "Modify";
            this.Modify_Button.UseVisualStyleBackColor = true;
            this.Modify_Button.Click += new System.EventHandler(this.Modify_Button_Click);
            // 
            // Date_Value
            // 
            this.Date_Value.Location = new System.Drawing.Point(78, 283);
            this.Date_Value.Name = "Date_Value";
            this.Date_Value.Size = new System.Drawing.Size(244, 22);
            this.Date_Value.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Start Time must be formatted 24:00 in 24 hour format";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Type";
            // 
            // Type_DropDown
            // 
            this.Type_DropDown.FormattingEnabled = true;
            this.Type_DropDown.Items.AddRange(new object[] {
            "Presentation",
            "Scrum",
            "General"});
            this.Type_DropDown.Location = new System.Drawing.Point(174, 226);
            this.Type_DropDown.Name = "Type_DropDown";
            this.Type_DropDown.Size = new System.Drawing.Size(148, 24);
            this.Type_DropDown.TabIndex = 25;
            // 
            // appointmentId_Text
            // 
            this.appointmentId_Text.Location = new System.Drawing.Point(399, 95);
            this.appointmentId_Text.Name = "appointmentId_Text";
            this.appointmentId_Text.Size = new System.Drawing.Size(100, 22);
            this.appointmentId_Text.TabIndex = 26;
            this.appointmentId_Text.Visible = false;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(237, 384);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.appointmentId_Text);
            this.Controls.Add(this.Type_DropDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Date_Value);
            this.Controls.Add(this.Modify_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.StartTime_Text);
            this.Controls.Add(this.Location_Text);
            this.Controls.Add(this.Description_Text);
            this.Controls.Add(this.Title_Text);
            this.Controls.Add(this.CustomerName_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prev_Button);
            this.Controls.Add(this.ScheduleGridView);
            this.Controls.Add(this.monthCalendar2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ScheduleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button Prev_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerName_Text;
        private System.Windows.Forms.TextBox Title_Text;
        private System.Windows.Forms.TextBox Description_Text;
        private System.Windows.Forms.TextBox Location_Text;
        private System.Windows.Forms.TextBox StartTime_Text;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Modify_Button;
        private System.Windows.Forms.DateTimePicker Date_Value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Type_DropDown;
        private System.Windows.Forms.TextBox appointmentId_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button deleteButton;
    }
}