﻿
namespace Funktionen
{
    partial class SollHaben
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHaben = new System.Windows.Forms.TextBox();
            this.txtSoll = new System.Windows.Forms.TextBox();
            this.l_Haben = new System.Windows.Forms.Label();
            this.l_Soll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHaben
            // 
            this.txtHaben.ForeColor = System.Drawing.Color.Red;
            this.txtHaben.Location = new System.Drawing.Point(142, 46);
            this.txtHaben.Name = "txtHaben";
            this.txtHaben.Size = new System.Drawing.Size(120, 20);
            this.txtHaben.TabIndex = 7;
            this.txtHaben.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoll
            // 
            this.txtSoll.Location = new System.Drawing.Point(16, 46);
            this.txtSoll.Name = "txtSoll";
            this.txtSoll.Size = new System.Drawing.Size(120, 20);
            this.txtSoll.TabIndex = 6;
            // 
            // l_Haben
            // 
            this.l_Haben.AutoSize = true;
            this.l_Haben.Location = new System.Drawing.Point(227, 21);
            this.l_Haben.Name = "l_Haben";
            this.l_Haben.Size = new System.Drawing.Size(39, 13);
            this.l_Haben.TabIndex = 5;
            this.l_Haben.Text = "Haben";
            // 
            // l_Soll
            // 
            this.l_Soll.AutoSize = true;
            this.l_Soll.Location = new System.Drawing.Point(16, 21);
            this.l_Soll.Name = "l_Soll";
            this.l_Soll.Size = new System.Drawing.Size(24, 13);
            this.l_Soll.TabIndex = 4;
            this.l_Soll.Text = "Soll";
            // 
            // SollHaben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHaben);
            this.Controls.Add(this.txtSoll);
            this.Controls.Add(this.l_Haben);
            this.Controls.Add(this.l_Soll);
            this.Name = "SollHaben";
            this.Size = new System.Drawing.Size(281, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHaben;
        private System.Windows.Forms.TextBox txtSoll;
        private System.Windows.Forms.Label l_Haben;
        private System.Windows.Forms.Label l_Soll;
    }
}
