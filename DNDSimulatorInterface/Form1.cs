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
    public partial class Form1 : Form
    {
        List<string> fQ = new List<string>();
        List<string> sQ = new List<string>();

        public Form1()
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
            CharakterChooseBox.SelectedIndexChanged += new EventHandler(CharakterChooseBox_SelectedIndexChanged);
            CharakterList.DoubleClick += new EventHandler(charakterListElement_Click);
            //CharakterList.SelectedIndexChanged += new EventHandler(CharakterList_SelectedIndexChanged);
            CharakterListButton.Click += new EventHandler(CharakterListButton_Click_1);
            CharakterListButton.Click += new EventHandler(CharakterListButton_Click_2);
            ShowColumnsButton.Click += new EventHandler(CharakterListButton_Click_3);
            CheckButton.Click += new EventHandler(CheckAllitems);
            UnCheckButton.Click += new EventHandler(UncheckAllitems);

            Controls.Add(charakterCreateButton);
            Controls.Add(charakterNameTextBox);
            Controls.Add(onlyNumberTextBox);
            Controls.Add(CharakterChooseBox);
            Controls.Add(CharakterList);
            Controls.Add(CharakterListButton);
            Controls.Add(ShowColumnsButton);
            Controls.Add(CheckButton);
            Controls.Add(UnCheckButton);

            //int i;
            //i = int.Parse(charakterNameTextBox.Text);
            //float f;
            //f = float.Parse(charakterNameTextBox.Text);
            //double d;
            //d = float.Parse(charakterNameTextBox.Text);

            string var;
            var = CharakterChooseBox.Text;

            CharakterChooseBox.Items.Add("weekdays");
            CharakterChooseBox.Items.Add("year");
            CharakterChooseBox.SelectedItem = var;
            
            CharakterList.Items.Add("Monday");
            CharakterList.Items.Add("Tuesday");
            CharakterList.Items.Add("Wednesday");
            CharakterList.Items.Add("Thursday");
            CharakterList.Items.Add("Friday");
            CharakterList.Items.Add("Saturday");
            CharakterList.Items.Add("Sunday");
            CharakterList.Items.Add("First Quarter");
            CharakterList.Items.Add("Second Quarter");
            string item = CharakterList.GetItemText(CharakterList.SelectedItem);
            
            fQ.Add("January");
            fQ.Add("February");
            fQ.Add("March");
            sQ.Add("April");
            sQ.Add("May");
            sQ.Add("June");
            List<string> nList = new List<string>();
            nList.Add("First Quarter");
            nList.Add("Second Quarter");
            CharakterList.DataSource = nList;
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

        private void CharakterChooseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionChooseBox.Items.Remove(ActionChooseBox.SelectedItem);
            ActionChooseBox.Items.Clear();
            if (CharakterChooseBox.SelectedItem == "weekdays")
            {
                ActionChooseBox.Items.Add("Sunday");
                ActionChooseBox.Items.Add("Monday");
                ActionChooseBox.Items.Add("Tuesday");
            }
            else if (CharakterChooseBox.SelectedItem == "year")
            {
                ActionChooseBox.Items.Add("2012");
                ActionChooseBox.Items.Add("2013");
                ActionChooseBox.Items.Add("2014");
            }
        }

        private void charakterListElement_Click(object sender, EventArgs e)
        {
            foreach (Object obj in CharakterList.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            }
        }

        private void CharakterListButton_Click_1(object sender, EventArgs e)
        {
            string items = "";
            foreach (var item in CharakterList.Items)
            {
                if (item == null)
                { }
                else items += item.ToString() + ", ";
            }
            MessageBox.Show(items);
        }

        private void CharakterListButton_Click_2(object sender, EventArgs e)
        {
            List<string> nList = new List<string>();
            nList.Add("January");
            nList.Add("February");
            nList.Add("March");
            nList.Add("April");
            CharakterList.DataSource = nList;
        }

        //private void CharakterList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (CharakterList.SelectedItem==null)
        //    { }
        //    else MessageBox.Show(CharakterList.SelectedItem.ToString());
        //}

        //private void CharakterList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (CharakterList.SelectedIndex == 0)
        //    {
        //        CharakterSheet.DataSource = null;
        //        CharakterSheet.DataSource = fQ;
        //    }
        //    else if (CharakterList.SelectedIndex == 1)
        //    {
        //        CharakterSheet.DataSource = null;
        //        CharakterSheet.DataSource = sQ;
        //    }
        //}

        private void CharakterListButton_Click_3(object sender, EventArgs e)
        {
            CharakterList.DataSource = null;
            CharakterList.HorizontalScrollbar = true;
            CharakterList.MultiColumn = true;
            CharakterList.ScrollAlwaysVisible = true;
            CharakterList.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
        }

        private void UncheckAllitems(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckedActionList.Items.Count; i++)
            {
                CheckedActionList.SetItemChecked(i, false);
            }
        }

        private void CheckAllitems(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckedActionList.Items.Count; i++)
            {
                CheckedActionList.SetItemChecked(i, true);
            }
        }
    }
}
