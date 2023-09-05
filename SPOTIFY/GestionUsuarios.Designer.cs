namespace SPOTIFY
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            usersList = new ComboBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(294, 9);
            label2.Name = "label2";
            label2.Size = new Size(202, 21);
            label2.TabIndex = 22;
            label2.Text = "ELIMINAR USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(128, 179);
            label1.Name = "label1";
            label1.Size = new Size(169, 16);
            label1.TabIndex = 24;
            label1.Text = "Seleccione Usuario";
            // 
            // usersList
            // 
            usersList.FormattingEnabled = true;
            usersList.Location = new Point(128, 201);
            usersList.Name = "usersList";
            usersList.Size = new Size(506, 23);
            usersList.TabIndex = 26;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(324, 392);
            button5.Name = "button5";
            button5.Size = new Size(160, 36);
            button5.TabIndex = 27;
            button5.Text = "Borrar usuario";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(usersList);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "GestionUsuarios";
            Text = "GestionUsuarios";
            Load += GestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private ComboBox usersList;
        private Button button5;
    }
}