namespace _3Harder_Problem_Program
{
    partial class Login_Form
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
            this.Username_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Password_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Login_Button_Label = new System.Windows.Forms.Button();
            this.Forgot_Password_Label = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username_Box
            // 
            this.Username_Box.Location = new System.Drawing.Point(44, 46);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(183, 20);
            this.Username_Box.TabIndex = 0;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(44, 98);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(183, 20);
            this.Password_Box.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(105, 82);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 3;
            this.Password_Label.Text = "Password";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(105, 30);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(55, 13);
            this.Username_Label.TabIndex = 4;
            this.Username_Label.Text = "Username";
            // 
            // Login_Button_Label
            // 
            this.Login_Button_Label.Location = new System.Drawing.Point(44, 124);
            this.Login_Button_Label.Name = "Login_Button_Label";
            this.Login_Button_Label.Size = new System.Drawing.Size(75, 23);
            this.Login_Button_Label.TabIndex = 5;
            this.Login_Button_Label.Text = "Login";
            this.Login_Button_Label.UseVisualStyleBackColor = true;
            // 
            // Forgot_Password_Label
            // 
            this.Forgot_Password_Label.Location = new System.Drawing.Point(125, 124);
            this.Forgot_Password_Label.Name = "Forgot_Password_Label";
            this.Forgot_Password_Label.Size = new System.Drawing.Size(102, 23);
            this.Forgot_Password_Label.TabIndex = 6;
            this.Forgot_Password_Label.Text = "Forgot Password";
            this.Forgot_Password_Label.UseVisualStyleBackColor = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Forgot_Password_Label);
            this.Controls.Add(this.Login_Button_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Username_Box);
            this.Name = "Login_Form";
            this.RightToLeftLayout = true;
            this.Text = "Problem Program Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Button Login_Button_Label;
        private System.Windows.Forms.Button Forgot_Password_Label;
    }
}

