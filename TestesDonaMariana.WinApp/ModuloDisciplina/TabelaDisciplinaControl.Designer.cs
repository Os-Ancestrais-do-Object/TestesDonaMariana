﻿namespace TestesDonaMariana.WinApp.ModuloDisciplina
{
    partial class TabelaDisciplinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridDisciplina = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDisciplina).BeginInit();
            SuspendLayout();
            // 
            // gridDisciplina
            // 
            gridDisciplina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDisciplina.Location = new Point(51, 67);
            gridDisciplina.Name = "gridDisciplina";
            gridDisciplina.RowTemplate.Height = 25;
            gridDisciplina.Size = new Size(240, 150);
            gridDisciplina.TabIndex = 0;
            // 
            // TabelaDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridDisciplina);
            Name = "TabelaDisciplinaControl";
            Size = new Size(353, 293);
            ((System.ComponentModel.ISupportInitialize)gridDisciplina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridDisciplina;
    }
}
