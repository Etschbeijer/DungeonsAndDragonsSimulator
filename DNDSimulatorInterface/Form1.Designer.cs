

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
            this.CharakterChooseBox = new System.Windows.Forms.ComboBox();
            this.ActionChooseBox = new System.Windows.Forms.ComboBox();
            this.CharakterList = new System.Windows.Forms.ListBox();
            this.CharakterListButton = new System.Windows.Forms.Button();
            this.CharakterSheet = new System.Windows.Forms.ListBox();
            this.ShowColumnsButton = new System.Windows.Forms.Button();
            this.CheckedActionList = new System.Windows.Forms.CheckedListBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.UnCheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // charakterCreateButton
            // 
            this.charakterCreateButton.Location = new System.Drawing.Point(279, 167);
            this.charakterCreateButton.Name = "charakterCreateButton";
            this.charakterCreateButton.Size = new System.Drawing.Size(150, 30);
            this.charakterCreateButton.TabIndex = 0;
            this.charakterCreateButton.Text = "Create new charakter";
            this.charakterCreateButton.UseVisualStyleBackColor = true;
            // 
            // charakterCreateButtonLabel
            // 
            this.charakterCreateButtonLabel.AutoSize = true;
            this.charakterCreateButtonLabel.Location = new System.Drawing.Point(331, 200);
            this.charakterCreateButtonLabel.Name = "charakterCreateButtonLabel";
            this.charakterCreateButtonLabel.Size = new System.Drawing.Size(39, 13);
            this.charakterCreateButtonLabel.TabIndex = 1;
            this.charakterCreateButtonLabel.Text = "Label1";
            // 
            // charakterNameTextBox
            // 
            this.charakterNameTextBox.BackColor = System.Drawing.Color.White;
            this.charakterNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.charakterNameTextBox.Location = new System.Drawing.Point(301, 216);
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
            this.onlyNumberTextBox.Location = new System.Drawing.Point(301, 141);
            this.onlyNumberTextBox.Name = "onlyNumberTextBox";
            this.onlyNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.onlyNumberTextBox.TabIndex = 3;
            // 
            // CharakterChooseBox
            // 
            this.CharakterChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharakterChooseBox.FormattingEnabled = true;
            this.CharakterChooseBox.Location = new System.Drawing.Point(435, 173);
            this.CharakterChooseBox.Name = "CharakterChooseBox";
            this.CharakterChooseBox.Size = new System.Drawing.Size(121, 21);
            this.CharakterChooseBox.TabIndex = 4;
            // 
            // ActionChooseBox
            // 
            this.ActionChooseBox.FormattingEnabled = true;
            this.ActionChooseBox.Location = new System.Drawing.Point(563, 173);
            this.ActionChooseBox.Name = "ActionChooseBox";
            this.ActionChooseBox.Size = new System.Drawing.Size(121, 21);
            this.ActionChooseBox.TabIndex = 5;
            // 
            // CharakterList
            // 
            this.CharakterList.BackColor = System.Drawing.Color.Aqua;
            this.CharakterList.ForeColor = System.Drawing.Color.Black;
            this.CharakterList.FormattingEnabled = true;
            this.CharakterList.Location = new System.Drawing.Point(153, 173);
            this.CharakterList.Name = "CharakterList";
            this.CharakterList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.CharakterList.Size = new System.Drawing.Size(120, 95);
            this.CharakterList.TabIndex = 6;
            // 
            // CharakterListButton
            // 
            this.CharakterListButton.Location = new System.Drawing.Point(173, 274);
            this.CharakterListButton.Name = "CharakterListButton";
            this.CharakterListButton.Size = new System.Drawing.Size(75, 23);
            this.CharakterListButton.TabIndex = 7;
            this.CharakterListButton.Text = "Show elements in charakter list";
            this.CharakterListButton.UseVisualStyleBackColor = true;
            // 
            // CharakterSheet
            // 
            this.CharakterSheet.FormattingEnabled = true;
            this.CharakterSheet.Location = new System.Drawing.Point(27, 173);
            this.CharakterSheet.Name = "CharakterSheet";
            this.CharakterSheet.Size = new System.Drawing.Size(120, 95);
            this.CharakterSheet.TabIndex = 8;
            // 
            // ShowColumnsButton
            // 
            this.ShowColumnsButton.Location = new System.Drawing.Point(145, 303);
            this.ShowColumnsButton.Name = "ShowColumnsButton";
            this.ShowColumnsButton.Size = new System.Drawing.Size(150, 23);
            this.ShowColumnsButton.TabIndex = 9;
            this.ShowColumnsButton.Text = "Show Columns";
            this.ShowColumnsButton.UseVisualStyleBackColor = true;
            // 
            // CheckedActionList
            // 
            this.CheckedActionList.FormattingEnabled = true;
            this.CheckedActionList.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday"});
            this.CheckedActionList.Items.Add("Wednesday", CheckState.Checked);
            this.CheckedActionList.Items.Add("Thursday", CheckState.Unchecked);
            this.CheckedActionList.Items.Add("Friday", CheckState.Indeterminate);
            this.CheckedActionList.Location = new System.Drawing.Point(407, 216);
            this.CheckedActionList.Name = "CheckedActionList";
            this.CheckedActionList.Size = new System.Drawing.Size(120, 94);
            this.CheckedActionList.TabIndex = 10;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(533, 216);
            this.CheckButton.Name = "Check";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 11;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // UnCheck
            // 
            this.UnCheckButton.Location = new System.Drawing.Point(533, 245);
            this.UnCheckButton.Name = "UnCheck";
            this.UnCheckButton.Size = new System.Drawing.Size(75, 23);
            this.UnCheckButton.TabIndex = 12;
            this.UnCheckButton.Text = "UnCheck";
            this.UnCheckButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 422);
            this.Controls.Add(this.UnCheckButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.CheckedActionList);
            this.Controls.Add(this.ShowColumnsButton);
            this.Controls.Add(this.CharakterSheet);
            this.Controls.Add(this.CharakterListButton);
            this.Controls.Add(this.CharakterList);
            this.Controls.Add(this.ActionChooseBox);
            this.Controls.Add(this.CharakterChooseBox);
            this.Controls.Add(this.onlyNumberTextBox);
            this.Controls.Add(this.charakterNameTextBox);
            this.Controls.Add(this.charakterCreateButtonLabel);
            this.Controls.Add(this.charakterCreateButton);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button charakterCreateButton;
        private System.Windows.Forms.Label charakterCreateButtonLabel;
        private System.Windows.Forms.TextBox charakterNameTextBox;
        private System.Windows.Forms.TextBox onlyNumberTextBox;
        private ComboBox CharakterChooseBox;
        private ComboBox ActionChooseBox;
        private ListBox CharakterList;
        private Button CharakterListButton;
        private ListBox CharakterSheet;
        private Button ShowColumnsButton;
        private CheckedListBox CheckedActionList;
        private Button CheckButton;
        private Button UnCheckButton;
    }
}

