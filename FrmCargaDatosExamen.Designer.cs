﻿namespace TrabajoFinal_
{
    partial class FrmCargaDatosExamen
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
            btnEmpezarExamen = new Button();
            btnVolver = new Button();
            lblCarrera = new Label();
            lblAsignatura = new Label();
            cmbCarrera = new ComboBox();
            cmbAsignatura = new ComboBox();
            SuspendLayout();
            // 
            // btnEmpezarExamen
            // 
            btnEmpezarExamen.Location = new Point(257, 253);
            btnEmpezarExamen.Name = "btnEmpezarExamen";
            btnEmpezarExamen.Size = new Size(112, 23);
            btnEmpezarExamen.TabIndex = 0;
            btnEmpezarExamen.Text = "Empezar Examen";
            btnEmpezarExamen.UseVisualStyleBackColor = true;
            btnEmpezarExamen.Click += btnCargar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(391, 253);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(251, 132);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 4;
            lblCarrera.Text = "Carrera";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(251, 178);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 5;
            lblAsignatura.Text = "Asignatura";
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(377, 132);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(121, 23);
            cmbCarrera.TabIndex = 6;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(377, 175);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(121, 23);
            cmbAsignatura.TabIndex = 7;
            // 
            // FrmCargaDatosExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 411);
            Controls.Add(cmbAsignatura);
            Controls.Add(cmbCarrera);
            Controls.Add(lblAsignatura);
            Controls.Add(lblCarrera);
            Controls.Add(btnVolver);
            Controls.Add(btnEmpezarExamen);
            Name = "FrmCargaDatosExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargar Carrera y Asignatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpezarExamen;
        private Button btnVolver;
        private Label lblCarrera;
        private Label lblAsignatura;
        private ComboBox cmbCarrera;
        private ComboBox cmbAsignatura;
    }
}