

using System;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DNDSimulatorInterface
{
    public partial class MainMenu : Form
    {
        private Button Start;

        private Button fight;
        private Button loadChar;
        private Button viewChar;
        private Button newChar;
        private Button back;
        private Button exit;

        private PictureBox scroll;

        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainMenu));

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            InitStart();

            SizeChanged += new EventHandler(MainMenu_SizeChanged);
        }        

        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(Start);
        }

        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 3;
        }

        private void CenterStartLeuchtet_1(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2 - 13;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 3 - 13;
        }

        private void CenterStartLeuchtet_2(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2 - 18;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 3 - 11;
        }

        private void CenterStartLeuchtet_3(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2 - 30;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 3 - 20;
        }

        private void Start_MouseEnters(object sender, EventArgs e)
        {
            InvokeStart_LightUp_1();
            CenterStartLeuchtet_1(Start);
        }

        private void InvokeStart_LightUp_1()
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Start\Start_Leuchten_1.jpg");
            Start.BackgroundImage = Image.FromFile(file);
        }

        private void InvokeStart_LightUp_2()
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Start\Start_Leuchten_2.jpg");
            Start.BackgroundImage = Image.FromFile(file);
            CenterStartLeuchtet_2(Start);
        }

        private void InvokeStart_LightUp_3()
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Start\Start_Leuchten_3.jpg");
            Start.BackgroundImage = Image.FromFile(file);
            CenterStartLeuchtet_3(Start);
        }

        private void Start_MouseKlick(object sender, EventArgs e)
        {
            InvokeStart_LightUp_2();
            Task.Delay(500).Wait();
            RemoveStart();
        }

        #region Test for time based event

        //private void Start_MouseKlick(object sender, MouseEventArgs e)
        //{
        //    InvokeStart_LightUp_2__3();
        //}

        //private void InvokeStart_LightUp_2__3()
        //{

        //    var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //    var file1 = Path.Combine(projectFolder, @"Images\Buttons\Start\Start_Leuchten_1.jpg");
        //    var file2 = Path.Combine(projectFolder, @"Images\Buttons\Start\Start_Leuchten_2.jpg");
        //    var file3 = Path.Combine(projectFolder, @"Images\Buttons\Start\Start_Leuchten_3.jpg");

        //    var PathList = new List<string>(0);
        //    PathList.Add(file2);
        //    PathList.Add(file3);
        //    PathList.Add(file2);
        //    PathList.Add(file1);

        //    //var startTimeSpan = TimeSpan.Zero;
        //    //var periodTimeSpan = TimeSpan.FromSeconds(0.5);
        //    int index = 0;
        //    System.Threading.Timer t = new System.Threading.Timer(o =>
        //                                    {
        //                                        if (index < PathList.Count)
        //                                        {
        //                                            Start.BackgroundImage = Image.FromFile(PathList[index]);
        //                                            if (index == 0 || index == 2)
        //                                            {
        //                                                CenterStartLeuchtet_2(Start);
        //                                                index = index + 1;
        //                                            }
        //                                            else
        //                                                if (index == 1)
        //                                                {
        //                                                    CenterStartLeuchtet_3(Start);
        //                                                    index = index + 1;
        //                                                }
        //                                                else
        //                                                    if (index == 3)
        //                                                    {
        //                                                        CenterStartLeuchtet_1(Start);
        //                                                        index = index + 1;
        //                                                    }
        //                                        }
        //                                        else index = 0;
        //                                    }, null, 100, 500);
        //    t.InitializeLifetimeService();
        //}

        #endregion

        private void Start_ChangeBackgroundIamge(List<string> pathList, ref int index)
        {            
            {
                
            }
        }

        private void Start_MouseLeaves(object sender, EventArgs e)
        {
            InvokeStart();
            CenterControlInParent(Start);
        }

        private void InvokeStart()
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Start\Start.jpg");
            Start.BackgroundImage = Image.FromFile(file);
        }

        private void InitStart()
        {
            Start = new Button();

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Start\Start.jpg");

            Start.BackColor = Color.Transparent;
            Start.BackgroundImage = Image.FromFile(file);
            Start.BackgroundImageLayout = ImageLayout.Center;
            Start.FlatAppearance.BorderSize = 0;
            Start.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Start.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Start.FlatStyle = FlatStyle.Flat;
            Start.ForeColor = Color.Transparent;
            Start.Location = new Point(255, 45);
            Start.Name = "Start";
            Start.Size = new Size(349, 200);
            Start.TabIndex = 0;
            Start.TabStop = false;
            Start.UseVisualStyleBackColor = false;

            Controls.Add(Start);

            CenterControlInParent(Start);

            Start.MouseEnter += new EventHandler(Start_MouseEnters);
            Start.MouseLeave += new EventHandler(Start_MouseLeaves);
            Start.MouseClick += new MouseEventHandler(Start_MouseKlick);            
        }

        private void RemoveStart()
        {
            Controls.Remove(Start);
            Start.Dispose();

            Task.Delay(500).Wait();
            Scroll_Init();
            InitCharakterMenu();            
        }

        private void InitCharakterMenu()
        {
            fight    = new Button();
            loadChar = new Button();
            viewChar = new Button();
            newChar  = new Button();
            back = new Button();
            exit = new Button();

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Menu\Papyrus.jpg");

            // 
            // fight
            // 
            fight.Location = new Point(357, 103);
            fight.Name = "fight";
            fight.Size = new Size(150, 30);
            fight.TabIndex = 0;
            fight.Text = "Fight";
            fight.UseVisualStyleBackColor = false;
            fight.BackColor = Color.Transparent;
            //fight.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            fight.BackgroundImageLayout = ImageLayout.Center;
            fight.FlatAppearance.MouseDownBackColor = Color.Transparent;
            fight.FlatAppearance.MouseOverBackColor = Color.Transparent;
            fight.ForeColor = Color.Transparent;
            fight.FlatStyle = FlatStyle.Flat;
            fight.FlatAppearance.BorderSize = 0;
            fight.Font = new Font("Calibri", 12);
            //fight.Parent = scroll;
            fight.SendToBack();
            // 
            // loadChar
            // 
            loadChar.Location = new Point(357, 160);
            loadChar.Name = "loadChar";
            loadChar.Size = new Size(150, 30);
            loadChar.TabIndex = 1;
            loadChar.Text = "Load Charakter";
            loadChar.UseVisualStyleBackColor = false;
            loadChar.BackColor = Color.Transparent;
            //loadChar.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            loadChar.BackgroundImageLayout = ImageLayout.Center;
            loadChar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loadChar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loadChar.ForeColor = Color.Transparent;
            loadChar.FlatStyle = FlatStyle.Flat;
            loadChar.FlatAppearance.BorderSize = 0;
            loadChar.Font = new Font("Calibri", 12);
            fight.Parent = scroll;
            // 
            // viewChar
            // 
            viewChar.Location = new Point(357, 216);
            viewChar.Name = "viewChar";
            viewChar.Size = new Size(150, 30);
            viewChar.TabIndex = 2;
            viewChar.Text = "View Charakter";
            viewChar.UseVisualStyleBackColor = false;
            viewChar.BackColor = Color.Transparent;
            //viewChar.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            viewChar.BackgroundImageLayout = ImageLayout.Center;
            viewChar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            viewChar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            viewChar.ForeColor = Color.Transparent;
            viewChar.FlatStyle = FlatStyle.Flat;
            viewChar.FlatAppearance.BorderSize = 0;
            viewChar.Font = new Font("Calibri", 12);
            fight.Parent = scroll;
            // 
            // newChar
            // 
            newChar.Location = new Point(357, 280);
            newChar.Name = "newChar";
            newChar.Size = new Size(150, 30);
            newChar.TabIndex = 3;
            newChar.Text = "Create New Charakter";
            newChar.UseVisualStyleBackColor = true;
            newChar.BackColor = Color.Transparent;
            //newChar.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            newChar.BackgroundImageLayout = ImageLayout.Center;
            newChar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            newChar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            newChar.ForeColor = Color.Transparent;
            newChar.FlatStyle = FlatStyle.Flat;
            newChar.FlatAppearance.BorderSize = 0;
            newChar.Font = new Font("Calibri", 12);
            fight.Parent = scroll;
            // 
            // back
            // 
            back.Location = new Point(357, 342);
            back.Name = "back";
            back.Size = new Size(150, 30);
            back.TabIndex = 4;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.BackColor = Color.Transparent;
            //back.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            back.BackgroundImageLayout = ImageLayout.Center;
            back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            back.ForeColor = Color.Transparent;
            back.FlatStyle = FlatStyle.Flat;
            back.FlatAppearance.BorderSize = 0;
            back.Font = new Font("Calibri", 12);
            fight.Parent = scroll;
            // 
            // exit
            // 
            exit.Location = new Point(357, 342);
            exit.Name = "exit";
            exit.Size = new Size(150, 30);
            exit.TabIndex = 5;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.BackColor = Color.Transparent;
            //exit.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            exit.BackgroundImageLayout = ImageLayout.Center;
            exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exit.ForeColor = Color.Transparent;
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;
            exit.Font = new Font("Calibri", 12);
            fight.Parent = scroll;

            Controls.Add(back);
            Controls.Add(newChar);
            Controls.Add(viewChar);
            Controls.Add(loadChar);
            Controls.Add(fight);
            Controls.Add(exit);

            CenterCharakterMenuButtons(fight, 375);
            CenterCharakterMenuButtons(loadChar, 325);
            CenterCharakterMenuButtons(viewChar, 275);
            CenterCharakterMenuButtons(newChar, 225);
            CenterCharakterMenuButtons(back, 175);
            CenterCharakterMenuButtons(exit, 125);

            #region Events of charakter menu buttons

            fight.MouseEnter += new EventHandler(fight_MouseEnters);
            fight.MouseLeave += new EventHandler(fight_MouseLeaves);
            loadChar.MouseEnter += new EventHandler(loadChar_MouseEnters);
            loadChar.MouseLeave += new EventHandler(loadChar_MouseLeaves);
            viewChar.MouseEnter += new EventHandler(viewChar_MouseEnters);
            viewChar.MouseLeave += new EventHandler(viewChar_MouseLeaves);
            newChar.MouseEnter += new EventHandler(newChar_MouseEnters);
            newChar.MouseLeave += new EventHandler(newChar_MouseLeaves);
            back.MouseEnter += new EventHandler(back_MouseEnters);
            back.MouseLeave += new EventHandler(back_MouseLeaves);
            exit.MouseEnter += new EventHandler(exit_MouseEnters);
            exit.MouseLeave += new EventHandler(exit_MouseLeaves);

            fight.Click += new EventHandler(ShowMessage);
            loadChar.Click += new EventHandler(ShowMessage);
            viewChar.Click += new EventHandler(ShowMessage);
            newChar.Click += new EventHandler(ShowMessage);
            back.Click += new EventHandler(back_Click);
            exit.Click += new EventHandler(exit_Click);

            #endregion
        }

        private void Scroll_Init()
        {
            // 
            // scroll
            // 
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Menu\Papyrus.jpg");

            scroll = new PictureBox();
            ((ISupportInitialize)(scroll)).BeginInit();

            scroll.Location = new Point(303, 41);
            scroll.Name = "scroll";
            scroll.Size = new Size(200, 350);
            scroll.SizeMode = PictureBoxSizeMode.StretchImage;
            scroll.TabIndex = 0;
            scroll.TabStop = false;
            scroll.Image = Image.FromFile(file);
            scroll.BackgroundImageLayout = ImageLayout.Center;

            Controls.Add(scroll);

            CenterCharakterMenuButtons(scroll, 70);

            ((ISupportInitialize)(scroll)).EndInit();
        }

        #region Border colour change for buttons of main menu

        private void fight_BorderChange(Color color, int size)
        {
            fight.FlatAppearance.BorderColor = color;
            fight.FlatAppearance.BorderSize = size;
        }

        private void fight_MouseEnters(object sender, EventArgs e)
        {
            fight_BorderChange(Color.DarkRed, 1);
        }

        private void fight_MouseLeaves(object sender, EventArgs e)
        {
            fight_BorderChange(Color.DarkRed, 0);
        }

        private void loadChar_BorderChange(Color color, int size)
        {
            loadChar.FlatAppearance.BorderColor = color;
            loadChar.FlatAppearance.BorderSize = size;
        }

        private void loadChar_MouseEnters(object sender, EventArgs e)
        {
            loadChar_BorderChange(Color.DarkRed, 1);
        }

        private void loadChar_MouseLeaves(object sender, EventArgs e)
        {
            loadChar_BorderChange(Color.DarkRed, 0);
        }

        private void viewChar_BorderChange(Color color, int size)
        {
            viewChar.FlatAppearance.BorderColor = color;
            viewChar.FlatAppearance.BorderSize = size;
        }

        private void viewChar_MouseEnters(object sender, EventArgs e)
        {
            viewChar_BorderChange(Color.DarkRed, 1);
        }

        private void viewChar_MouseLeaves(object sender, EventArgs e)
        {
            viewChar_BorderChange(Color.DarkRed, 0);
        }

        private void newChar_BorderChange(Color color, int size)
        {
            newChar.FlatAppearance.BorderColor = color;
            newChar.FlatAppearance.BorderSize = size;
        }

        private void newChar_MouseEnters(object sender, EventArgs e)
        {
            newChar_BorderChange(Color.DarkRed, 1);
        }

        private void newChar_MouseLeaves(object sender, EventArgs e)
        {
            newChar_BorderChange(Color.DarkRed, 0);
        }

        private void back_BorderChange(Color color, int size)
        {
            back.FlatAppearance.BorderColor = color;
            back.FlatAppearance.BorderSize = size;
        }

        private void back_MouseEnters(object sender, EventArgs e)
        {
            back_BorderChange(Color.DarkRed, 1);
        }

        private void back_MouseLeaves(object sender, EventArgs e)
        {
            back_BorderChange(Color.DarkRed, 0);
        }

        private void exit_BorderChange(Color color, int size)
        {
            exit.FlatAppearance.BorderColor = color;
            exit.FlatAppearance.BorderSize = size;
        }

        private void exit_MouseEnters(object sender, EventArgs e)
        {
            exit_BorderChange(Color.DarkRed, 1);
        }

        private void exit_MouseLeaves(object sender, EventArgs e)
        {
            exit_BorderChange(Color.DarkRed, 0);
        }

        #endregion

        #region Charakter menu click methods

        private void back_Click(object sender, EventArgs e)
        {
            RemoveCharakterMenu();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void RemoveCharakterMenu()
        {
            Controls.Remove(fight);
            Controls.Remove(loadChar);
            Controls.Remove(viewChar);
            Controls.Remove(newChar);
            Controls.Remove(back);
            Controls.Remove(exit);

            fight.Dispose();
            loadChar.Dispose();
            viewChar.Dispose();
            newChar.Dispose();
            back.Dispose();
            exit.Dispose();

            Task.Delay(500).Wait();

            InitStart();

            Controls.Add(Start);

            CenterControlInParent(Start);
        }

        private void CenterCharakterMenuButtons(Control ctrlToCenter, int height)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) - height;
        }

        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Failure! Feature not implemented yet");
        }
    }
}
