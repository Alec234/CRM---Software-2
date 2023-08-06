namespace C969_Symmonds_winform
{
    partial class ConsultantSchedule
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
            this.find_Button = new System.Windows.Forms.Button();
            this.find_Text = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.Label();
            this.consultantGridView = new System.Windows.Forms.DataGridView();
            this.prev_button = new System.Windows.Forms.Button();
            this.ConsultantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.consultantGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // find_Button
            // 
            this.find_Button.Location = new System.Drawing.Point(99, 96);
            this.find_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.find_Button.Name = "find_Button";
            this.find_Button.Size = new System.Drawing.Size(56, 19);
            this.find_Button.TabIndex = 0;
            this.find_Button.Text = "Find";
            this.find_Button.UseVisualStyleBackColor = true;
            this.find_Button.Click += new System.EventHandler(this.find_Button_Click);
            // 
            // find_Text
            // 
            this.find_Text.Location = new System.Drawing.Point(141, 52);
            this.find_Text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.find_Text.Name = "find_Text";
            this.find_Text.Size = new System.Drawing.Size(76, 20);
            this.find_Text.TabIndex = 1;
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Location = new System.Drawing.Point(46, 52);
            this.custName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(82, 13);
            this.custName.TabIndex = 2;
            this.custName.Text = "Customer Name";
            // 
            // consultantGridView
            // 
            this.consultantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultantGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultantName,
            this.Type,
            this.startTime,
            this.endTime});
            this.consultantGridView.Location = new System.Drawing.Point(215, 110);
            this.consultantGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.consultantGridView.Name = "consultantGridView";
            this.consultantGridView.RowHeadersWidth = 51;
            this.consultantGridView.RowTemplate.Height = 24;
            this.consultantGridView.Size = new System.Drawing.Size(361, 228);
            this.consultantGridView.TabIndex = 3;
            // 
            // prev_button
            // 
            this.prev_button.Location = new System.Drawing.Point(20, 319);
            this.prev_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(56, 19);
            this.prev_button.TabIndex = 4;
            this.prev_button.Text = "Prev";
            this.prev_button.UseVisualStyleBackColor = true;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            // 
            // ConsultantName
            // 
            this.ConsultantName.HeaderText = "Consultant Name";
            this.ConsultantName.MinimumWidth = 6;
            this.ConsultantName.Name = "ConsultantName";
            this.ConsultantName.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start";
            this.startTime.MinimumWidth = 6;
            this.startTime.Name = "startTime";
            this.startTime.Width = 125;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "End";
            this.endTime.MinimumWidth = 6;
            this.endTime.Name = "endTime";
            this.endTime.Width = 125;
            // 
            // ConsultantSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.prev_button);
            this.Controls.Add(this.consultantGridView);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.find_Text);
            this.Controls.Add(this.find_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultantSchedule";
            this.Text = "ConsultantSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.consultantGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find_Button;
        private System.Windows.Forms.TextBox find_Text;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.DataGridView consultantGridView;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
    }
}