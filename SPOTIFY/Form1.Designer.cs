namespace SPOTIFY
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            UserLogin = new TextBox();
            PwdLogin = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 138);
            label1.Name = "label1";
            label1.Size = new Size(202, 21);
            label1.TabIndex = 0;
            label1.Text = "Inicio de Sesion";
            label1.Click += label1_Click;
            // 
            // UserLogin
            // 
            UserLogin.Location = new Point(265, 188);
            UserLogin.Name = "UserLogin";
            UserLogin.PlaceholderText = "Ingresa su username";
            UserLogin.Size = new Size(249, 23);
            UserLogin.TabIndex = 1;
            UserLogin.TextChanged += UserLogin_TextChanged;
            // 
            // PwdLogin
            // 
            PwdLogin.Location = new Point(265, 229);
            PwdLogin.Name = "PwdLogin";
            PwdLogin.PlaceholderText = "Ingresa su contraseña";
            PwdLogin.Size = new Size(249, 23);
            PwdLogin.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(304, 276);
            button1.Name = "button1";
            button1.Size = new Size(160, 36);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(304, 327);
            button2.Name = "button2";
            button2.Size = new Size(160, 36);
            button2.TabIndex = 4;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PwdLogin);
            Controls.Add(UserLogin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UserLogin;
        private TextBox PwdLogin;
        private Button button1;
        private Button button2;
    }
}