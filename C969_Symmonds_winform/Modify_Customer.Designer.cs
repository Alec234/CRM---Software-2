namespace C969_Symmonds_winform
{
    partial class Modify_Customer
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
            this.CustId_Text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Address_Text = new System.Windows.Forms.TextBox();
            this.Phone_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.prevScreen_button = new System.Windows.Forms.Button();
            this.MainPage_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustId_Text
            // 
            this.CustId_Text.Enabled = false;
            this.CustId_Text.Location = new System.Drawing.Point(292, 108);
            this.CustId_Text.MaxLength = 3700;
            this.CustId_Text.Name = "CustId_Text";
            this.CustId_Text.ReadOnly = true;
            this.CustId_Text.Size = new System.Drawing.Size(120, 22);
            this.CustId_Text.TabIndex = 0;
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(292, 150);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(120, 22);
            this.Name_Text.TabIndex = 1;
            // 
            // Address_Text
            // 
            this.Address_Text.Location = new System.Drawing.Point(292, 197);
            this.Address_Text.Name = "Address_Text";
            this.Address_Text.Size = new System.Drawing.Size(120, 22);
            this.Address_Text.TabIndex = 2;
            // 
            // Phone_Text
            // 
            this.Phone_Text.Location = new System.Drawing.Point(292, 248);
            this.Phone_Text.Name = "Phone_Text";
            this.Phone_Text.Size = new System.Drawing.Size(120, 22);
            this.Phone_Text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(292, 298);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 74);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // prevScreen_button
            // 
            this.prevScreen_button.Location = new System.Drawing.Point(700, 415);
            this.prevScreen_button.Name = "prevScreen_button";
            this.prevScreen_button.Size = new System.Drawing.Size(96, 32);
            this.prevScreen_button.TabIndex = 9;
            this.prevScreen_button.Text = "Prev";
            this.prevScreen_button.UseVisualStyleBackColor = true;
            this.prevScreen_button.Click += new System.EventHandler(this.prevScreen_button_Click);
            // 
            // MainPage_Button
            // 
            this.MainPage_Button.Location = new System.Drawing.Point(584, 415);
            this.MainPage_Button.Name = "MainPage_Button";
            this.MainPage_Button.Size = new System.Drawing.Size(110, 32);
            this.MainPage_Button.TabIndex = 10;
            this.MainPage_Button.Text = "MainPage";
            this.MainPage_Button.UseVisualStyleBackColor = true;
            this.MainPage_Button.Click += new System.EventHandler(this.MainPage_Button_Click);
            // 
            // Modify_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPage_Button);
            this.Controls.Add(this.prevScreen_button);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone_Text);
            this.Controls.Add(this.Address_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.CustId_Text);
            this.Name = "Modify_Customer";
            this.Text = "Modify_Customer";
            this.Load += new System.EventHandler(this.Modify_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustId_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox Address_Text;
        private System.Windows.Forms.TextBox Phone_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button prevScreen_button;
        private System.Windows.Forms.Button MainPage_Button;
    }
}