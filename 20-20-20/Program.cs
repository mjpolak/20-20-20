using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_20_20
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new AP();
            Application.Run();

        }
        class AP
        {

            enum State
            {
                Work,
                Counting
            }

            private State state = State.Work;
            NotifyIcon icon;
            private bool work = true;
            private Form global = new Form();

            private System.Timers.Timer timer;
            public AP()
            {

                global.Show();
                global.Visible = false;
                frm = new Break();
                icon = new NotifyIcon();
                icon.Text = "20-20-20";
                icon.Icon = new Icon(SystemIcons.Shield, 40, 40);
                icon.Visible = true;


                ContextMenu cm = new ContextMenu();
                MenuItem mi = new MenuItem() { Text = "Wyjście" };
                mi.Click += mi_Click;
                cm.MenuItems.Add(mi);

                mi = new MenuItem() { Text = "Test" };
                mi.Click += (object sender, EventArgs e) =>
                {
                    Window();
                    Task.Run(new Action(async () =>
                    {
                        UpdateCounter();
                        await Task.Delay(2000);
                        CloseWindow();
                    }));
                };



                cm.MenuItems.Add(mi);
                mi = new MenuItem() { Text = "Ustawienia" };
                mi.Click += mi_Settings;
                cm.MenuItems.Add(mi);

                icon.ContextMenu = cm;
                //bw.RunWorkerAsync();

                frm.OnPauseEnd += frm_OnPauseEnd;

                timer = new System.Timers.Timer(1000 * 60 * 20);
                timer.AutoReset = false;
                timer.Elapsed += timer_Elapsed;
                
                timer.Start();
            }

            void frm_OnPauseEnd()
            {
                if (value <= 0)
                {
                    CloseWindow();
                    state = State.Work;
                    timer.Interval = 1000*60*20;
                    timer.AutoReset = false;
                    timer.Start();
                }
            }
            int value;

            void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                switch(state)
                {
                    case State.Work:
                        state = State.Counting;
                        timer.Interval = 1000;
                        timer.AutoReset = false;
                        value = 20;
                        UpdateCounter();
                        Window();
                        break;
                    case State.Counting:
                        timer.Interval = 1000;
                        timer.AutoReset = false;
                        if( value > 0 )
                            timer.Start();
                        value--;
                        UpdateCounter();
                        break;
                }
                
                
            }


            Break frm;

            void UpdateCounter()
            {
                global.Invoke((MethodInvoker)delegate()
                {
                    frm.UpdateCounter(value);
                });
            }

            void Window()
            {
                global.Invoke((MethodInvoker)delegate()
                {
                    frm.AllowClose = false;
                    frm.Show();
                });
            }
            void CloseWindow()
            {
                global.Invoke((MethodInvoker)delegate()
                {
                    frm.AllowClose = true;
                    frm.Hide();
                });
            }
            void mi_Settings(object sender, EventArgs e)
            {
                frmSettings fSettings = new frmSettings();
                fSettings.ShowDialog();
            }
            void mi_Click(object sender, EventArgs e)
            {
                timer.Stop();
                CloseWindow();
                icon.Visible = false;
                Application.Exit();
            }

        }

    }
}
