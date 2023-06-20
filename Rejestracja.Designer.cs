namespace KomisAplikacja
{
    partial class Rejestracja
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nazwa użytkownika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hasło:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Numer telefonu:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(66, 26);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(165, 20);
            this.nameTxt.TabIndex = 4;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(66, 75);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(165, 20);
            this.passTxt.TabIndex = 5;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(66, 128);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(165, 20);
            this.emailTxt.TabIndex = 6;
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(66, 181);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(165, 20);
            this.telTxt.TabIndex = 7;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(66, 223);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(162, 26);
            this.Register.TabIndex = 8;
            this.Register.Text = "Zarejestruj się";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Rejestracja
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button RagisterButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Button Register;
    }
}