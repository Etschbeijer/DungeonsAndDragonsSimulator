

using System;
using System.Drawing;
using System.Windows.Forms;

namespace DNDSimulatorInterface
{
    partial class MainMenu
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.charakterCreateButton = new System.Windows.Forms.Button();
            this.charakterCreateButtonLabel = new System.Windows.Forms.Label();
            this.charakterNameTextBox = new System.Windows.Forms.TextBox();
            this.onlyNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // charakterCreateButton
            // 
            this.charakterCreateButton.Location = new System.Drawing.Point(293, 185);
            this.charakterCreateButton.Name = "charakterCreateButton";
            this.charakterCreateButton.Size = new System.Drawing.Size(150, 30);
            this.charakterCreateButton.TabIndex = 0;
            this.charakterCreateButton.Text = "Create new charakter";
            this.charakterCreateButton.UseVisualStyleBackColor = true;
            // 
            // charakterCreateButtonLabel
            // 
            this.charakterCreateButtonLabel.AutoSize = true;
            this.charakterCreateButtonLabel.Location = new System.Drawing.Point(345, 218);
            this.charakterCreateButtonLabel.Name = "charakterCreateButtonLabel";
            this.charakterCreateButtonLabel.Size = new System.Drawing.Size(39, 13);
            this.charakterCreateButtonLabel.TabIndex = 1;
            this.charakterCreateButtonLabel.Text = "Label1";
            // 
            // charakterNameTextBox
            // 
            this.charakterNameTextBox.BackColor = System.Drawing.Color.White;
            this.charakterNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.charakterNameTextBox.Location = new System.Drawing.Point(315, 234);
            this.charakterNameTextBox.Multiline = true;
            this.charakterNameTextBox.Name = "charakterNameTextBox";
            this.charakterNameTextBox.PasswordChar = '*';
            this.charakterNameTextBox.Size = new System.Drawing.Size(100, 100);
            this.charakterNameTextBox.TabIndex = 2;
            // 
            // onlyNumberTextBox
            // 
            this.onlyNumberTextBox.BackColor = System.Drawing.Color.White;
            this.onlyNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.onlyNumberTextBox.Location  = new System.Drawing.Point(315, 105);
            this.onlyNumberTextBox.Name      = "onlyNumberTextBox";
            this.onlyNumberTextBox.Size      = new System.Drawing.Size(100, 100);
            this.onlyNumberTextBox.TabIndex  = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 422);
            this.Controls.Add(this.onlyNumberTextBox);
            this.Controls.Add(this.charakterNameTextBox);
            this.Controls.Add(this.charakterCreateButtonLabel);
            this.Controls.Add(this.charakterCreateButton);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button charakterCreateButton;
        private System.Windows.Forms.Label charakterCreateButtonLabel;
        private System.Windows.Forms.TextBox charakterNameTextBox;
        private System.Windows.Forms.TextBox onlyNumberTextBox;
    }
}

