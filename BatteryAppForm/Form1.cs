using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BatteryAppForm
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(HandleRef hWnd,
        uint Msg, uint wParam, IntPtr lParam);

        private const uint WM_USER = 0x400;
        private const uint PBM_SETSTATE = WM_USER + 16;
        private const uint PBST_NORMAL = 0x0001;
        private const uint PBST_ERROR = 0x0002;
        private const uint PBST_PAUSED = 0x0003;
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void ReLoad_Button_Click(object sender, EventArgs e)
        {
            for (;;)
            {
                await Task.Run(() =>
                {
                    System.Threading.Thread.Sleep(800);
                    //800ミリ秒待つだけ
                });
                BatteryChargeStatus bcs = SystemInformation.PowerStatus.BatteryChargeStatus;
                if ((bcs & BatteryChargeStatus.NoSystemBattery) == BatteryChargeStatus.NoSystemBattery)
                {
                    persent_label.Text = ("???");
                    zyoukyou.Text = ("なし");
                }
                else
                {
                    float blp = SystemInformation.PowerStatus.BatteryLifePercent;
                    float blp2 = blp * 100;
                    int blr = SystemInformation.PowerStatus.BatteryLifeRemaining;
                    int blrs = blr % 60;
                    int blrm = (blr - blrs) / 60 % 60;
                    int blrh = (blr - blrs - blrm * 60) / 3600;
                    if (-1 < blr)
                    {
                        hourlabel.Text = blrh.ToString();
                        minites.Text = blrm.ToString();
                        second.Text = blrs.ToString();
                    }
                    else
                    {
                        hourlabel.Text = ("??");
                        minites.Text = ("??");
                        second.Text = ("??");
                    }
                        persent_label.Text = blp2.ToString();
                    battery_progress.Value = (int)blp2;
                    if (blp2 <= 10)
                    {
                        zyoukyou.Text = ("危険");
                        if (battery_progress.IsHandleCreated)
                        {
                            SendMessage(new HandleRef(battery_progress, battery_progress.Handle), PBM_SETSTATE, PBST_ERROR, IntPtr.Zero);
                        }
                        if ((bcs & BatteryChargeStatus.Charging) == BatteryChargeStatus.Charging)
                        {
                            zyuden.Text = ("充電中");
                        }
                        else
                        {
                            zyuden.Text = ("充電してください");
                        }
                    }
                    else if (blp2 > 10 && blp2 <= 25)
                    {
                        zyoukyou.Text = ("注意");
                        if (battery_progress.IsHandleCreated)
                        {
                            SendMessage(new HandleRef(battery_progress, battery_progress.Handle), PBM_SETSTATE, PBST_PAUSED, IntPtr.Zero);
                        }
                        if ((bcs & BatteryChargeStatus.Charging) == BatteryChargeStatus.Charging)
                        {
                            zyuden.Text = ("充電中");
                        }
                        else
                        {
                            zyuden.Text = ("充電してください");
                        }
                    }
                    else if (blp2 > 25 && blp2 <= 100)
                    {
                        zyoukyou.Text = ("普通");
                        if (battery_progress.IsHandleCreated)
                        {
                            SendMessage(new HandleRef(battery_progress, battery_progress.Handle), PBM_SETSTATE, PBST_NORMAL, IntPtr.Zero);
                        }
                        if ((bcs & BatteryChargeStatus.Charging) == BatteryChargeStatus.Charging)
                        {
                            if (blp2 == 100)
                            {
                                zyuden.Text = ("充電完了");
                            }
                            else
                            {
                                zyuden.Text = ("充電中");
                            }
                        }
                        else
                        {
                            zyuden.Text = ("");
                        }
                    }
                }
            }
        }
    }
}
