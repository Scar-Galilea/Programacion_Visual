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
            passwordtext = new TextBox();
            Usuariotext = new TextBox();
            label1 = new Label();
            button1IniciarSesion = new Button();
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
            // passwordtext
            // 
            passwordtext.Location = new Point(330, 243);
            passwordtext.Name = "passwordtext";
            passwordtext.PlaceholderText = "Ingrese contraseña";
            passwordtext.Size = new Size(141, 23);
            passwordtext.TabIndex = 9;
            passwordtext.UseSystemPasswordChar = true;
            // 
            // Usuariotext
            // 
            Usuariotext.Location = new Point(330, 182);
            Usuariotext.Name = "Usuariotext";
            Usuariotext.PlaceholderText = "Ingrese usuaio:";
            Usuariotext.Size = new Size(141, 23);
            Usuariotext.TabIndex = 8;
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
            // button1IniciarSesion
            // 
            button1IniciarSesion.Location = new Point(348, 290);
            button1IniciarSesion.Name = "button1IniciarSesion";
            button1IniciarSesion.Size = new Size(108, 23);
            button1IniciarSesion.TabIndex = 6;
            button1IniciarSesion.Text = "Iniciar Sesión";
            button1IniciarSesion.UseVisualStyleBackColor = true;
            button1IniciarSesion.Click += button1IniciarSesionClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordtext);
            Controls.Add(Usuariotext);
            Controls.Add(label1);
            Controls.Add(button1IniciarSesion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox passwordtext;
        private TextBox Usuariotext;
        private Label label1;
        private Button button1IniciarSesion;
    }
}