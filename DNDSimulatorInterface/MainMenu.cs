

using System;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DnDSimulatorInterface
{
    public partial class MainMenu : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int height;

        private Button Start;

        private Button fight;
        private Button loadChar;
        private Button viewChar;
        private Button newChar;
        private Button back;
        private Button exit;

        private PictureBox hide_PictureBox;
        private PictureBox scroll;
        private PictureBox scrollEnding_Top;
        private PictureBox scroll_Enscrolling;

        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainMenu));

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            InitStart();

            SizeChanged += new EventHandler(MainMenu_SizeChanged);
            timer.Disposed += new EventHandler(exchangeHideBoxWithCharaktermenu);
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
            Start_Remove();
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
            Start_Init();
            CenterControlInParent(Start);
        }

        private void Start_Init()
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

        private void Start_Remove()
        {
            Controls.Remove(Start);
            Start.Dispose();

            timer.Tick += new EventHandler(Scroll_Elongate_DuringTime);
            height = 325;

            //Task.Delay(200).Wait();
            ScrollEnding_Top_Init();
            hide_PictureBox_init();
            Scroll_Enscrolling_Init();
            Controls.Add(scrollEnding_Top);


            //Task.Delay(325).Wait();
            //{
            //    LoadingScreen_Remove();
            //    Scroll_Init();
            //    CharakterMenu_Init();
            //}            
        }

        private void exchangeHideBoxWithCharaktermenu(object sender, EventArgs e)
        {            
            Scroll_Init();
            CharakterMenu_Init();
            LoadingScreen_Remove();
        }

        private void CharakterMenu_Init()
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
            fight.ForeColor = Color.DarkRed;
            fight.FlatStyle = FlatStyle.Flat;
            fight.FlatAppearance.BorderSize = 0;
            fight.Font = new Font("Calibri", 12);
            fight.Parent = scroll;
            //fight.SendToBack();
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
            loadChar.ForeColor = Color.DarkRed;
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
            viewChar.ForeColor = Color.DarkRed;
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
            newChar.ForeColor = Color.DarkRed;
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
            back.ForeColor = Color.DarkRed;
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
            exit.ForeColor = Color.DarkRed;
            exit.FlatStyle = FlatStyle.Flat;
            exit.FlatAppearance.BorderSize = 0;
            exit.Font = new Font("Calibri", 12);
            fight.Parent = scroll;

            scroll.Controls.Add(back);
            scroll.Controls.Add(newChar);
            scroll.Controls.Add(viewChar);
            scroll.Controls.Add(loadChar);
            scroll.Controls.Add(fight);
            scroll.Controls.Add(exit);

            CenterCharakterMenuButtons(fight, 300);
            CenterCharakterMenuButtons(loadChar, 250);
            CenterCharakterMenuButtons(viewChar, 200);
            CenterCharakterMenuButtons(newChar, 150);
            CenterCharakterMenuButtons(back, 100);
            CenterCharakterMenuButtons(exit, 50);

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
            scroll.BackColor = Color.Transparent;
            scroll.Parent = this;
            scroll.BringToFront();

            Controls.Add(scroll);
            Controls.Add(scrollEnding_Top);

            CenterCharakterMenuButtons(scroll, 75);

            ((ISupportInitialize)(scroll)).EndInit();
        }

        private void ScrollEnding_Top_Init()
        {
            // 
            // ScrollEnding_Top
            // 
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Menu\ScrollEnding_Top.png");

            scrollEnding_Top = new PictureBox();
            ((ISupportInitialize)(scrollEnding_Top)).BeginInit();

            scrollEnding_Top.Location = new Point(303, 41);
            scrollEnding_Top.Name = "scrollEnding_Top";
            scrollEnding_Top.Size = new Size(260, 50);
            scrollEnding_Top.SizeMode = PictureBoxSizeMode.StretchImage;
            scrollEnding_Top.TabIndex = 1;
            scrollEnding_Top.TabStop = false;
            scrollEnding_Top.Image = Image.FromFile(file);
            scrollEnding_Top.BackgroundImageLayout = ImageLayout.Center;
            scrollEnding_Top.BackColor = Color.Transparent;
            scrollEnding_Top.Parent = this;
            scrollEnding_Top.SendToBack();

            Controls.Add(scrollEnding_Top);

            CenterCharakterMenuButtons(scrollEnding_Top, 412);

            Timer_Interval(1);
            Timer_Start();

            ((ISupportInitialize)(scrollEnding_Top)).EndInit();
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
            CharakterMenu_Remove();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void CharakterMenu_Remove()
        {
            scroll.Controls.Remove(fight);
            scroll.Controls.Remove(loadChar);
            scroll.Controls.Remove(viewChar);
            scroll.Controls.Remove(newChar);
            scroll.Controls.Remove(back);
            scroll.Controls.Remove(exit);

            Controls.Remove(scroll);
            Controls.Remove(scrollEnding_Top);

            fight.Dispose();
            loadChar.Dispose();
            viewChar.Dispose();
            newChar.Dispose();
            back.Dispose();
            exit.Dispose();

            scroll.Dispose();
            scrollEnding_Top.Dispose();

            Task.Delay(500).Wait();

            InitStart();

            Controls.Add(Start);

            CenterControlInParent(Start);
        }

        #region Loadingscreen members

        private void hide_PictureBox_init()
        {
            // 
            // hide_PictureBox
            // 
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Menu\Papyrus.jpg");

            hide_PictureBox = new PictureBox();
            ((ISupportInitialize)(hide_PictureBox)).BeginInit();

            hide_PictureBox.Location = new Point(303, 41);
            hide_PictureBox.Name = "hide";
            hide_PictureBox.Size = new Size(200, 350);
            hide_PictureBox.TabIndex = 0;
            hide_PictureBox.TabStop = false;
            hide_PictureBox.BackColor = Color.Transparent;
            hide_PictureBox.Parent = this;

            Controls.Add(hide_PictureBox);

            CenterCharakterMenuButtons(hide_PictureBox, 75);

            ((ISupportInitialize)(hide_PictureBox)).EndInit();
        }

        private void Scroll_Enscrolling_Init()
        {
            // 
            // scroll_Enscrolling
            // 
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, @"Images\Buttons\Menu\Papyrus.jpg");

            scroll_Enscrolling = new PictureBox();
            ((ISupportInitialize)(scroll_Enscrolling)).BeginInit();

            scroll_Enscrolling.Location = new Point(303, 41);
            scroll_Enscrolling.Name = "scroll_Enscrolling";
            scroll_Enscrolling.Size = new Size(200, 350);
            scroll_Enscrolling.SizeMode = PictureBoxSizeMode.StretchImage;
            scroll_Enscrolling.TabIndex = 0;
            scroll_Enscrolling.TabStop = false;
            scroll_Enscrolling.Image = Image.FromFile(file);
            scroll_Enscrolling.BackgroundImageLayout = ImageLayout.Center;
            scroll_Enscrolling.Parent = hide_PictureBox;
            scroll_Enscrolling.BringToFront();

            hide_PictureBox.Controls.Add(scroll_Enscrolling);

            CenterEnscrolling(scroll_Enscrolling, 0, 325);

            ((ISupportInitialize)(scroll_Enscrolling)).EndInit();
        }

        private void Scroll_Enscrolling_Elongate(int height)
        {
            CenterEnscrolling(scroll_Enscrolling, 0, height);
        }

        private void LoadingScreen_Remove()
        {    
            hide_PictureBox.Controls.Remove(scroll_Enscrolling);
            scroll_Enscrolling.Dispose();

            Controls.Remove(hide_PictureBox);
            hide_PictureBox.Dispose();
        }

        #endregion

        private void CenterCharakterMenuButtons(Control ctrlToCenter, int height)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) - height;
        }

        private void CenterEnscrolling(Control ctrlToCenter, int width, int height)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2 + width;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) - height;
        }

        private void Scroll_Elongate_DuringTime(object sender, EventArgs e)
        {
            if (height >= 0)
            {
                Scroll_Enscrolling_Elongate(height);
                height = height - 3;
            }
            else
            {
                timer.Tick -= new EventHandler(Scroll_Elongate_DuringTime);
                Timer_Stop();
                Timer_Reset();
            }
        }

        #region Time coordianting

        private void Timer_Start()
        {
            timer.Start();
        }

        private void Timer_Stop()
        {
            timer.Stop();
        }

        private void Timer_Reset()
        {
            timer.Dispose();
        }

        private void Timer_Interval(int interval)
        {
            timer.Interval = interval;
        }

        #endregion

        private void startTimer(Control ctrlToCenter, int width, int height)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2 + width;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) - height;
        }

        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Failure! Feature not implemented yet");
        }
    }
}
