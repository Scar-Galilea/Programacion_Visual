namespace Practica5.Vista
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
            button1CerrarSesion = new Button();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // button1CerrarSesion
            // 
            button1CerrarSesion.BackColor = Color.Firebrick;
            button1CerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            button1CerrarSesion.Location = new Point(571, 49);
            button1CerrarSesion.Name = "button1CerrarSesion";
            button1CerrarSesion.Size = new Size(124, 23);
            button1CerrarSesion.TabIndex = 0;
            button1CerrarSesion.Text = "Cerrar Sesion";
            button1CerrarSesion.UseVisualStyleBackColor = false;
            button1CerrarSesion.Click += button1CerrarSesionClick;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(327, 151);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombre);
            Controls.Add(button1CerrarSesion);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1CerrarSesion;
        private Label lblNombre;
    }
}