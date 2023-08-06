namespace C969_Symmonds_winform
{
    partial class Reports
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
            this.MonthlyAppointments = new System.Windows.Forms.Button();
            this.ConsultantSchedule = new System.Windows.Forms.Button();
            this.AppUserCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthlyAppointments
            // 
            this.MonthlyAppointments.Location = new System.Drawing.Point(182, 89);
            this.MonthlyAppointments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MonthlyAppointments.Name = "MonthlyAppointments";
            this.MonthlyAppointments.Size = new System.Drawing.Size(224, 36);
            this.MonthlyAppointments.TabIndex = 0;
            this.MonthlyAppointments.Text = "Appointment Types by Month";
            this.MonthlyAppointments.UseVisualStyleBackColor = true;
            this.MonthlyAppointments.Click += new System.EventHandler(this.MonthlyAppointments_Click);
            // 
            // ConsultantSchedule
            // 
            this.ConsultantSchedule.Location = new System.Drawing.Point(182, 152);
            this.ConsultantSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConsultantSchedule.Name = "ConsultantSchedule";
            this.ConsultantSchedule.Size = new System.Drawing.Size(224, 36);
            this.ConsultantSchedule.TabIndex = 1;
            this.ConsultantSchedule.Text = "Schedule by Consultant";
            this.ConsultantSchedule.UseVisualStyleBackColor = true;
            this.ConsultantSchedule.Click += new System.EventHandler(this.ConsultantSchedule_Click);
            // 
            // AppUserCount
            // 
            this.AppUserCount.Location = new System.Drawing.Point(182, 208);
            this.AppUserCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AppUserCount.Name = "AppUserCount";
            this.AppUserCount.Size = new System.Drawing.Size(224, 36);
            this.AppUserCount.TabIndex = 2;
            this.AppUserCount.Text = "Number of Application Users";
            this.AppUserCount.UseVisualStyleBackColor = true;
            this.AppUserCount.Click += new System.EventHandler(this.AppUserCount_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.AppUserCount);
            this.Controls.Add(this.ConsultantSchedule);
            this.Controls.Add(this.MonthlyAppointments);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MonthlyAppointments;
        private System.Windows.Forms.Button ConsultantSchedule;
        private System.Windows.Forms.Button AppUserCount;
    }
}