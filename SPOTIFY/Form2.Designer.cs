namespace SPOTIFY
{
    partial class Form2
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
            button2 = new Button();
            button1 = new Button();
            UserRegister = new TextBox();
            NameRegister = new TextBox();
            label1 = new Label();
            PwdRegister = new TextBox();
            Pwd2Register = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(316, 302);
            button2.Name = "button2";
            button2.Size = new Size(160, 36);
            button2.TabIndex = 9;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(316, 344);
            button1.Name = "button1";
            button1.Size = new Size(160, 36);
            button1.TabIndex = 8;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserRegister
            // 
            UserRegister.Location = new Point(273, 174);
            UserRegister.Name = "UserRegister";
            UserRegister.PlaceholderText = "Ingresa su username";
            UserRegister.Size = new Size(249, 23);
            UserRegister.TabIndex = 7;
            // 
            // NameRegister
            // 
            NameRegister.Location = new Point(273, 133);
            NameRegister.Name = "NameRegister";
            NameRegister.PlaceholderText = "Ingresa su nombre";
            NameRegister.Size = new Size(249, 23);
            NameRegister.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(273, 81);
            label1.Name = "label1";
            label1.Size = new Size(250, 21);
            label1.TabIndex = 5;
            label1.Text = "REGISTRO DE USUARIOS";
            // 
            // PwdRegister
            // 
            PwdRegister.Location = new Point(273, 215);
            PwdRegister.Name = "PwdRegister";
            PwdRegister.PlaceholderText = "Ingresa su contraseña";
            PwdRegister.Size = new Size(249, 23);
            PwdRegister.TabIndex = 10;
            // 
            // Pwd2Register
            // 
            Pwd2Register.Location = new Point(273, 258);
            Pwd2Register.Name = "Pwd2Register";
            Pwd2Register.PlaceholderText = "Confirma su contraseña";
            Pwd2Register.Size = new Size(249, 23);
            Pwd2Register.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pwd2Register);
            Controls.Add(PwdRegister);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UserRegister);
            Controls.Add(NameRegister);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox UserRegister;
        private TextBox NameRegister;
        private Label label1;
        private TextBox PwdRegister;
        private TextBox Pwd2Register;
    }
}