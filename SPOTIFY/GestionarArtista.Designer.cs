namespace SPOTIFY
{
    partial class GestionarArtista
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
            label2 = new Label();
            label1 = new Label();
            nombreArtista = new TextBox();
            NacionalidadA = new TextBox();
            label3 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(284, 9);
            label2.Name = "label2";
            label2.Size = new Size(214, 21);
            label2.TabIndex = 23;
            label2.Text = "GESTIONAR ARTISTA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 156);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 24;
            label1.Text = "Nombre";
            // 
            // nombreArtista
            // 
            nombreArtista.Location = new Point(243, 178);
            nombreArtista.Name = "nombreArtista";
            nombreArtista.Size = new Size(302, 23);
            nombreArtista.TabIndex = 25;
            // 
            // NacionalidadA
            // 
            NacionalidadA.Location = new Point(243, 232);
            NacionalidadA.Name = "NacionalidadA";
            NacionalidadA.Size = new Size(302, 23);
            NacionalidadA.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(243, 209);
            label3.Name = "label3";
            label3.Size = new Size(115, 16);
            label3.TabIndex = 26;
            label3.Text = "Nacionalidad";
            // 
            // button1
            // 
            button1.Location = new Point(293, 264);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 28;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(243, 342);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 23);
            comboBox1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(293, 388);
            button2.Name = "button2";
            button2.Size = new Size(189, 29);
            button2.TabIndex = 30;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GestionarArtista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(NacionalidadA);
            Controls.Add(label3);
            Controls.Add(nombreArtista);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "GestionarArtista";
            Text = "GestionarArtista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox nombreArtista;
        private TextBox NacionalidadA;
        private Label label3;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
    }
}