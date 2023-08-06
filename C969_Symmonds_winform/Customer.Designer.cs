namespace C969_Symmonds_winform
{
    partial class Customer
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
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Address_Text = new System.Windows.Forms.TextBox();
            this.Phone_Text = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Modify_button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Search_Text = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustId_Text = new System.Windows.Forms.TextBox();
            this.Country_Text = new System.Windows.Forms.TextBox();
            this.City_Text = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Prev_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(108, 82);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(100, 22);
            this.Name_Text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // Address_Text
            // 
            this.Address_Text.Location = new System.Drawing.Point(108, 127);
            this.Address_Text.Name = "Address_Text";
            this.Address_Text.Size = new System.Drawing.Size(100, 22);
            this.Address_Text.TabIndex = 4;
            // 
            // Phone_Text
            // 
            this.Phone_Text.Location = new System.Drawing.Point(108, 253);
            this.Phone_Text.Name = "Phone_Text";
            this.Phone_Text.Size = new System.Drawing.Size(100, 22);
            this.Phone_Text.TabIndex = 5;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(108, 308);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(112, 34);
            this.Add_button.TabIndex = 6;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Modify_button
            // 
            this.Modify_button.Location = new System.Drawing.Point(336, 368);
            this.Modify_button.Name = "Modify_button";
            this.Modify_button.Size = new System.Drawing.Size(112, 34);
            this.Modify_button.TabIndex = 7;
            this.Modify_button.Text = "Modify";
            this.Modify_button.UseVisualStyleBackColor = true;
            this.Modify_button.Click += new System.EventHandler(this.Modify_button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(501, 368);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(112, 34);
            this.Delete_Button.TabIndex = 8;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Search_Text
            // 
            this.Search_Text.Location = new System.Drawing.Point(454, 99);
            this.Search_Text.Name = "Search_Text";
            this.Search_Text.Size = new System.Drawing.Size(100, 22);
            this.Search_Text.TabIndex = 9;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(567, 99);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(112, 22);
            this.Search_button.TabIndex = 10;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.Address,
            this.Phone});
            this.CustomerGridView.Location = new System.Drawing.Point(250, 127);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowHeadersWidth = 51;
            this.CustomerGridView.RowTemplate.Height = 24;
            this.CustomerGridView.Size = new System.Drawing.Size(429, 229);
            this.CustomerGridView.TabIndex = 11;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            this.CustomerId.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer Id";
            // 
            // CustId_Text
            // 
            this.CustId_Text.Enabled = false;
            this.CustId_Text.Location = new System.Drawing.Point(108, 48);
            this.CustId_Text.MaxLength = 3700;
            this.CustId_Text.Name = "CustId_Text";
            this.CustId_Text.ReadOnly = true;
            this.CustId_Text.Size = new System.Drawing.Size(100, 22);
            this.CustId_Text.TabIndex = 14;
            // 
            // Country_Text
            // 
            this.Country_Text.Location = new System.Drawing.Point(108, 210);
            this.Country_Text.Name = "Country_Text";
            this.Country_Text.Size = new System.Drawing.Size(100, 22);
            this.Country_Text.TabIndex = 15;
            // 
            // City_Text
            // 
            this.City_Text.Location = new System.Drawing.Point(108, 165);
            this.City_Text.Name = "City_Text";
            this.City_Text.Size = new System.Drawing.Size(100, 22);
            this.City_Text.TabIndex = 16;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(34, 210);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(52, 16);
            this.Country.TabIndex = 17;
            this.Country.Text = "Country";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(36, 168);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(29, 16);
            this.City.TabIndex = 18;
            this.City.Text = "City";
            // 
            // Prev_Button
            // 
            this.Prev_Button.Location = new System.Drawing.Point(680, 409);
            this.Prev_Button.Name = "Prev_Button";
            this.Prev_Button.Size = new System.Drawing.Size(108, 29);
            this.Prev_Button.TabIndex = 19;
            this.Prev_Button.Text = "PREV";
            this.Prev_Button.UseVisualStyleBackColor = true;
            this.Prev_Button.Click += new System.EventHandler(this.Prev_Button_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prev_Button);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.City_Text);
            this.Controls.Add(this.Country_Text);
            this.Controls.Add(this.CustId_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_Text);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Modify_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Phone_Text);
            this.Controls.Add(this.Address_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_Text);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Address_Text;
        private System.Windows.Forms.TextBox Phone_Text;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Modify_button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox Search_Text;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustId_Text;
        private System.Windows.Forms.TextBox Country_Text;
        private System.Windows.Forms.TextBox City_Text;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button Prev_Button;
    }
}