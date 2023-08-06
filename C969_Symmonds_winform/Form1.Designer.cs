
namespace C969_Symmonds_winform
{
    partial class Form1
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
            this.Username_Text = new System.Windows.Forms.TextBox();
            this.Pwd_Text = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_Text
            // 
            this.Username_Text.Location = new System.Drawing.Point(404, 145);
            this.Username_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(132, 22);
            this.Username_Text.TabIndex = 0;
            // 
            // Pwd_Text
            // 
            this.Pwd_Text.Location = new System.Drawing.Point(404, 191);
            this.Pwd_Text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pwd_Text.Name = "Pwd_Text";
            this.Pwd_Text.Size = new System.Drawing.Size(132, 22);
            this.Pwd_Text.TabIndex = 1;
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(420, 236);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(100, 28);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Pwd_Text);
            this.Controls.Add(this.Username_Text);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Text;
        private System.Windows.Forms.TextBox Pwd_Text;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

