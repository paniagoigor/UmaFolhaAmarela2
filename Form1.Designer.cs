﻿namespace UmaFolhaAmarela2
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
            btnFinalizador = new Button();
            btnAleatorio = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFinalizador
            // 
            btnFinalizador.BackColor = Color.FromArgb(0, 192, 0);
            btnFinalizador.FlatStyle = FlatStyle.Flat;
            btnFinalizador.Location = new Point(166, 248);
            btnFinalizador.Name = "btnFinalizador";
            btnFinalizador.Size = new Size(140, 43);
            btnFinalizador.TabIndex = 1;
            btnFinalizador.Text = "SIM";
            btnFinalizador.UseVisualStyleBackColor = false;
            btnFinalizador.Click += btnFinalizador_Click;
            // 
            // btnAleatorio
            // 
            btnAleatorio.BackColor = Color.Red;
            btnAleatorio.FlatStyle = FlatStyle.Flat;
            btnAleatorio.Location = new Point(494, 248);
            btnAleatorio.Name = "btnAleatorio";
            btnAleatorio.Size = new Size(140, 43);
            btnAleatorio.TabIndex = 2;
            btnAleatorio.Text = "NÃO";
            btnAleatorio.UseVisualStyleBackColor = false;
            btnAleatorio.MouseEnter += btnAleatorio_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(288, 101);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 3;
            label1.Text = "Deseja confirmar a ação?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAleatorio);
            Controls.Add(btnFinalizador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinalizador;
        private Button btnAleatorio;
        private Label label1;
    }
}