using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDSimulatorInterface
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            charakterCreateButtonLabel.Text         = "Leads to charakter creation menu";
            charakterCreateButtonLabel.BorderStyle  = BorderStyle.FixedSingle;
            charakterCreateButtonLabel.TextAlign    = ContentAlignment.MiddleCenter;

            charakterCreateButton.Click += new EventHandler(ShowMessage);
            charakterNameTextBox.KeyDown += new KeyEventHandler(charakterNameTextBox_KeyDown);
            charakterNameTextBox.TextChanged += new EventHandler(charakterNameTextBox_TextChanged);
            onlyNumberTextBox.TextChanged += new EventHandler(onlyNumberTextBox_TextChanged);
            onlyNumberTextBox.KeyPress += new KeyPressEventHandler(onlyNumberTextBox_KeyPress);
            

            Controls.Add(charakterCreateButton);
            Controls.Add(charakterNameTextBox);
            Controls.Add(onlyNumberTextBox);

            //int i;
            //i = int.Parse(charakterNameTextBox.Text);
            //float f;
            //f = float.Parse(charakterNameTextBox.Text);
            //double d;
            //d = float.Parse(charakterNameTextBox.Text);
        }

        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click");
        }

        private void charakterNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string var;
                var = charakterNameTextBox.Text;
                MessageBox.Show(var);
            }

            if (e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("You pressed Capslock");
            }
        }

        private void charakterNameTextBox_TextChanged(object sender, EventArgs e)
        {
            charakterCreateButtonLabel.Text = charakterNameTextBox.Text;            
        }

        private void onlyNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(onlyNumberTextBox.Text, "  ^ [0-9]"))
            {
                onlyNumberTextBox.Text = "";
            }
        }
        private void onlyNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
