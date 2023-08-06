namespace C969_Symmonds_winform
{
    partial class MainForm
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
            this.MainFormGrid = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Actions = new System.Windows.Forms.Label();
            this.Customer_Button = new System.Windows.Forms.Button();
            this.Appointment_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reports_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormGrid
            // 
            this.MainFormGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainFormGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Title,
            this.Description,
            this.Location,
            this.StartTime});
            this.MainFormGrid.Location = new System.Drawing.Point(156, 59);
            this.MainFormGrid.Name = "MainFormGrid";
            this.MainFormGrid.RowHeadersWidth = 51;
            this.MainFormGrid.Size = new System.Drawing.Size(642, 389);
            this.MainFormGrid.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Width = 125;
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
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointments";
            // 
            // Actions
            // 
            this.Actions.AutoSize = true;
            this.Actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actions.Location = new System.Drawing.Point(36, 45);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(84, 25);
            this.Actions.TabIndex = 4;
            this.Actions.Text = "Actions";
            // 
            // Customer_Button
            // 
            this.Customer_Button.Location = new System.Drawing.Point(13, 19);
            this.Customer_Button.Name = "Customer_Button";
            this.Customer_Button.Size = new System.Drawing.Size(99, 85);
            this.Customer_Button.TabIndex = 2;
            this.Customer_Button.Text = "Customer";
            this.Customer_Button.UseVisualStyleBackColor = true;
            this.Customer_Button.Click += new System.EventHandler(this.Customer_Button_Click);
            // 
            // Appointment_Button
            // 
            this.Appointment_Button.Location = new System.Drawing.Point(13, 135);
            this.Appointment_Button.Name = "Appointment_Button";
            this.Appointment_Button.Size = new System.Drawing.Size(99, 85);
            this.Appointment_Button.TabIndex = 3;
            this.Appointment_Button.Text = "Appointment";
            this.Appointment_Button.UseVisualStyleBackColor = true;
            this.Appointment_Button.Click += new System.EventHandler(this.Appointment_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reports_Button);
            this.groupBox1.Controls.Add(this.Appointment_Button);
            this.groupBox1.Controls.Add(this.Customer_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 375);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Reports_Button
            // 
            this.Reports_Button.Location = new System.Drawing.Point(13, 247);
            this.Reports_Button.Name = "Reports_Button";
            this.Reports_Button.Size = new System.Drawing.Size(99, 85);
            this.Reports_Button.TabIndex = 4;
            this.Reports_Button.Text = "Reports";
            this.Reports_Button.UseVisualStyleBackColor = true;
            this.Reports_Button.Click += new System.EventHandler(this.Reports_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainFormGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainFormGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainFormGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Actions;
        private System.Windows.Forms.Button Customer_Button;
        private System.Windows.Forms.Button Appointment_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Reports_Button;
    }
}