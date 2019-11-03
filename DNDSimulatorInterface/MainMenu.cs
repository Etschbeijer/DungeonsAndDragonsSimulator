

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
        //private System.Timers.Timer timer = new System.Timers.Timer();

        ComponentResourceManager resources = new ComponentResourceManager(typeof(MainMenu));

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SizeChanged += new EventHandler(MainMenu_SizeChanged);
            Start.MouseEnter += new EventHandler(Start_MouseEnters);
            Start.MouseLeave += new EventHandler(Start_MouseLeaves);
            Start.MouseClick += new MouseEventHandler(Start_MouseKlick);

            Controls.Add(Start);

            CenterControlInParent(Start);
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
        }

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
            Start.BackgroundImage = ((Image)(resources.GetObject("Start.BackgroundImage")));
        }
    }
}
