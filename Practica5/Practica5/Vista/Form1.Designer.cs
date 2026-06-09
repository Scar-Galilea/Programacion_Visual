namespace Practica5.Vista
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
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            Usuario = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 225);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 164);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Usuaio";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 243);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese contraseña";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 9;
            textBox1.UseSystemPasswordChar = true;
            // 
            // Usuario
            // 
            Usuario.Location = new Point(330, 182);
            Usuario.Name = "Usuario";
            Usuario.PlaceholderText = "Ingrese usuaio:";
            Usuario.Size = new Size(141, 23);
            Usuario.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 138);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 7;
            label1.Text = "Iniciar Sesión";
            // 
            // button1
            // 
            button1.Location = new Point(348, 290);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 6;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(Usuario);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private TextBox Usuario;
        private Label label1;
        private Button button1;
    }
}