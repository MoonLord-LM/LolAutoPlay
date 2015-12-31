using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MyCSharp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }
        //——————编译选项——————
        int 游戏模式 = 2;//1统治战场优先2召唤师峡谷优先
        bool 优化模式 = true;//优化模式下使用BES进行CPU优化，使用SendMessage阻止窗体重绘进行显卡优化//false//true
        bool 调试模式 = true;//调试模式下会保存异常的截图
        //——————编译选项——————
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.Visible = false;
            this.ShowInTaskbar = false;
            if (My.Computer.FindWindow("League of Legends (TM) Client").Width == 0 && My.Computer.FindWindow("PVP.net 客户端").Width == 0)
            {
                MessageBox.Show("请先运行英雄联盟游戏（League of Legends）！", "程序即将退出");
                toolStripMenuItem退出_Click(sender, e);
            }
            else
            {
                string 提示 = "";
                提示 = 提示 + "程序将在后台运行。\r\n";
                提示 = 提示 + "按住ESC键、Delete键、BackSpace键任意一个不松（约1秒），即可结束程序。\r\n";
                提示 = 提示 + "————————————————————\r\n";
                提示 = 提示 + "请保证游戏内的分辨率为【1280*720】。\r\n";
                提示 = 提示 + "请保证游戏内的窗口模式为【无边框】。\r\n";
                提示 = 提示 + "————————————————————\r\n";
                提示 = 提示 + "请尽量关闭可能会弹出窗口的程序（例如TGP助手等）。\r\n";
                提示 = 提示 + "请尽量不要在挂机过程中做其它操作。\r\n";
                MessageBox.Show(提示, "使用前必看！");
            }
            if (优化模式)
            {
                My.Computer.Shell("\"BES\\BES.exe\" --exitnow");
                My.Computer.Shell("\"BES\\BES.exe\" --disallow-multi --watch-multi --minimize");
            }
            My.Computer.SetWindowCanNotRedraw("PVP.net 客户端");
            My.Computer.SetWindowCanNotRedraw("League of Legends (TM) Client");
            My.Computer.SetWindowCanRedraw("League of Legends (TM) Client");
            My.Computer.SetWindowCanRedraw("PVP.net 客户端");
            PVP监控Timer.Interval = 20000;
            LOL监控Timer.Interval = 5000;
            退出监控Timer.Interval = 200;
            PVP监控Timer.Enabled = true;
            LOL监控Timer.Enabled = true;
            退出监控Timer.Enabled = true;
            My.Computer.ShowDesktop();
            Thread.Sleep(1000);
            PVP监控(sender, e);
            Thread.Sleep(1000);
            LOL监控(sender, e);
        }
        private void 退出监控(object sender, EventArgs e)
        {
            if (My.Computer.KeyBeingPressed(Keys.Escape) || My.Computer.KeyBeingPressed(Keys.Delete) || My.Computer.KeyBeingPressed(Keys.Back))
            {
                toolStripMenuItem退出_Click(sender, e);
            }
        }
        public void PVP统治战场玩家对战匹配()
        {
            //7级才可以打统治战场（匹配）
            //5级才可以打统治战场（人机）
            //开始匹配
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 985, PVP窗口位置.Top + 50);//关闭浏览英雄的界面（正常界面下点击此处无效果）
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 70, PVP窗口位置.Top + 35);//英雄联盟
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 510, PVP窗口位置.Top + 30);//开始游戏
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 260, PVP窗口位置.Top + 100);//玩家对战
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 375, PVP窗口位置.Top + 145);//统治战场
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 540, PVP窗口位置.Top + 120);//水晶之痕
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 710, PVP窗口位置.Top + 130);//匹配模式
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 600, PVP窗口位置.Top + 570);//单人
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 860, PVP窗口位置.Top + 40);//个人资料
            My.Computer.MouseLeftClick();
            游戏模式 = 1;
        }
        public void PVP召唤师峡谷人机入门匹配()
        {
            //1级就可以打入门人机
            //25级以下才能获得奖励
            //开始匹配
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 985, PVP窗口位置.Top + 50);//关闭浏览英雄的界面（正常界面下点击此处无效果）
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 70, PVP窗口位置.Top + 35);//英雄联盟
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 510, PVP窗口位置.Top + 30);//开始游戏
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 260, PVP窗口位置.Top + 145);//人机对战
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 390, PVP窗口位置.Top + 120);//经典对战
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 545, PVP窗口位置.Top + 120);//召唤师峡谷
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 690, PVP窗口位置.Top + 120);//入门
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 600, PVP窗口位置.Top + 570);//单人
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 860, PVP窗口位置.Top + 40);//个人资料
            My.Computer.MouseLeftClick();
            游戏模式 = 2;
        }
        public void PVP召唤师峡谷人机简单匹配()
        {
            //1级就可以打简单人机
            //开始匹配
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 985, PVP窗口位置.Top + 50);//关闭浏览英雄的界面（正常界面下点击此处无效果）
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 70, PVP窗口位置.Top + 35);//英雄联盟
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 510, PVP窗口位置.Top + 30);//开始游戏
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 260, PVP窗口位置.Top + 145);//人机对战
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 390, PVP窗口位置.Top + 120);//经典对战
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 545, PVP窗口位置.Top + 120);//召唤师峡谷
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 690, PVP窗口位置.Top + 145);//简单
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 600, PVP窗口位置.Top + 570);//单人
            My.Computer.MouseLeftClick();
            My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 860, PVP窗口位置.Top + 40);//个人资料
            My.Computer.MouseLeftClick();
            游戏模式 = 2;
        }
        Rectangle PVP窗口位置 = new Rectangle((Screen.PrimaryScreen.Bounds.Width - 1024) / 2, (Screen.PrimaryScreen.Bounds.Height - 640) / 2, 1024, 640);//最小分辨率1024*640
        Bitmap 英雄联盟_PVP截图;
        bool 优化PVP = false;
        private void PVP监控(object sender, EventArgs e)
        {
            if (My.Computer.FindWindow("PVP.net 客户端").Width != 0)
            {
                if (优化PVP == false && 优化模式)
                {
                    优化PVP = true;
                    My.Computer.Shell("\"BES\\BES.exe\" \"" + My.Computer.GetProcessFilePath("LolClient") + "\" 60 --add --minimize");//实测，优化90%还是OK的，优化80%开始游戏可能出错
                    Thread.Sleep(1000);
                }
                notifyIcon1.ShowBalloonTip(3000, "LOL自动挂机-提示", "PVP界面监控中", ToolTipIcon.Info);
                //移动窗口
                My.Computer.ShowWindowNormal("PVP.net 客户端");
                My.Computer.SetForegroundWindow("PVP.net 客户端");
                My.Computer.MoveWindow("PVP.net 客户端", PVP窗口位置);
                My.Computer.ShowWindowNormal("PVP.net 客户端");
                My.Computer.SetForegroundWindow("PVP.net 客户端");
                My.Computer.MoveWindow("PVP.net 客户端", PVP窗口位置);
                //截图
                英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                Color 商店按钮 = 英雄联盟_PVP截图.GetPixel(723, 34);
                Color 开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);//开始游戏按钮，位置555, 30，未点击的颜色172,34,21，点击后没开游戏的颜色15,44,48
                Color 重新连接按钮 = 英雄联盟_PVP截图.GetPixel(512, 360);//重新连接按钮，位置512,360，出现按钮时的颜色208,121,52
                Color 游戏加载上边框 = 英雄联盟_PVP截图.GetPixel(512, 300);
                Color 游戏加载下边框 = 英雄联盟_PVP截图.GetPixel(512, 347);
                Color 游戏内人物区域 = 英雄联盟_PVP截图.GetPixel(340, 630);
                //操作
                if (商店按钮.R == 22 && 商店按钮.G == 10 && 商店按钮.B == 26)//位置723, 34客户端启动中22,10,26
                {
                    return;
                }
                if (商店按钮.R == 193 && 商店按钮.G == 104 && 商店按钮.B == 0)//位置723, 34默认颜色193,104,0
                {
                    if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                    {
                        PVP监控Timer.Interval = 5000;
                        LoadingTime = 60000;
                        if (游戏模式 == 1)
                        {
                            PVP统治战场玩家对战匹配();
                            Thread.Sleep(1000);
                            英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                            开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);
                            if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                            {
                                PVP召唤师峡谷人机入门匹配();
                            }
                        }
                        else
                        {
                            PVP召唤师峡谷人机简单匹配();
                            Thread.Sleep(1000);
                            英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                            开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);
                            if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                            {
                                PVP统治战场玩家对战匹配();
                                Thread.Sleep(1000);
                                英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                                开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);
                                if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                                {
                                    PVP召唤师峡谷人机入门匹配();
                                }
                            }
                        }
                    }
                    return;
                }
                if (商店按钮.R == 224 && 商店按钮.G == 143 && 商店按钮.B == 22)//位置723, 34鼠标悬停224,143,22
                {
                    if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                    {
                        PVP监控Timer.Interval = 5000;
                        LoadingTime = 60000;
                        if (游戏模式 == 1)
                        {
                            PVP统治战场玩家对战匹配();
                            Thread.Sleep(1000);
                            英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                            开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);
                            if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                            {
                                PVP召唤师峡谷人机入门匹配();
                            }
                        }
                        else
                        {
                            PVP召唤师峡谷人机简单匹配();
                            Thread.Sleep(1000);
                            英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                            开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);
                            if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                            {
                                PVP统治战场玩家对战匹配();
                                Thread.Sleep(1000);
                                英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                                开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);
                                if ((开始游戏按钮.R == 172 && 开始游戏按钮.G == 34 && 开始游戏按钮.B == 21) || (开始游戏按钮.R == 15 && 开始游戏按钮.G == 44 && 开始游戏按钮.B == 48))
                                {
                                    PVP召唤师峡谷人机入门匹配();
                                }
                            }
                        }
                    }
                    return;
                }
                if (商店按钮.R == 95 && 商店按钮.G == 50 && 商店按钮.B == 0)//位置723, 34已找到对手95,50,0
                {
                    PVP监控Timer.Interval = 5000;
                    LoadingTime = 60000;
                    My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 620, PVP窗口位置.Top + 400);//现在开始
                    My.Computer.MouseLeftClick();
                    return;
                }
                if (商店按钮.R == 6 && 商店按钮.G == 3 && 商店按钮.B == 1)//位置723, 34选择英雄6,3,1
                {
                    PVP监控Timer.Interval = 20000;
                    LoadingTime = 60000;
                    My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 260, PVP窗口位置.Top + 170);//随机英雄
                    My.Computer.MouseLeftClick();
                    Thread.Sleep(1000);
                    My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 735, PVP窗口位置.Top + 415);//确定
                    My.Computer.MouseLeftClick();
                    return;
                }
                if (商店按钮.R == 5 && 商店按钮.G == 4 && 商店按钮.B == 10)//位置723, 34游戏进行中&中途退出游戏5,4,10
                {
                    if (重新连接按钮.R == 208 && 重新连接按钮.G == 121 && 重新连接按钮.B == 52)
                    {
                        PVP监控Timer.Interval = 20000;
                        LoadingTime = 60000;
                        My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 512, PVP窗口位置.Top + 365);//重新连接
                        My.Computer.MouseLeftClick();
                    }
                    else
                    {
                        PVP监控Timer.Interval = 40000;
                    }
                    return;
                }
                if (商店按钮.R == 47 && 商店按钮.G == 71 && 商店按钮.B == 99)//位置723, 34游戏结束47,71,99
                {
                    PVP监控Timer.Interval = 5000;
                    LoadingTime = 60000;
                    My.Computer.ShellKill("League of Legends");
                    /*
                    string SaveFileName1 = "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
                    英雄联盟_PVP截图.Save("英雄联盟PVP" + SaveFileName1 + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    My.IO.WriteString(
                        "商店按钮" + 商店按钮.ToString() + "\r\n" +
                        "开始游戏按钮" + 开始游戏按钮.ToString() + "\r\n" +
                        "重新连接按钮" + 重新连接按钮.ToString() + "\r\n" +
                        "游戏加载上边框" + 游戏加载上边框.ToString() + "\r\n" +
                        "游戏加载下边框" + 游戏加载下边框.ToString() + "\r\n" +
                        "游戏内人物区域" + 游戏内人物区域.ToString() + "\r\n"
                        , "英雄联盟PVP" + SaveFileName1 + ".txt");
                     * */
                    My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 890, PVP窗口位置.Top + 590);//再来一局
                    My.Computer.MouseLeftClick();
                    Thread.Sleep(1000);
                    英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
                    商店按钮 = 英雄联盟_PVP截图.GetPixel(723, 34);
                    if (商店按钮.R == 47 && 商店按钮.G == 71 && 商店按钮.B == 99)
                    {
                        My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 730, PVP窗口位置.Top + 590);//回到大厅
                        My.Computer.MouseLeftClick();
                    }
                    return;
                }
                if (商店按钮.R == 77 && 商店按钮.G == 41 && 商店按钮.B == 0)//位置723, 34客户端关闭中&新赛季全新天赋77,41,0
                {
                    PVP监控Timer.Interval = 5000;
                    LoadingTime = 60000;
                    My.Computer.MouseMoveToPixel(PVP窗口位置.Left + 465, PVP窗口位置.Top + 365);//是
                    My.Computer.MouseLeftClick();
                    return;
                }
                if (商店按钮.R == 95 && 商店按钮.G == 50 && 商店按钮.B == 0)//位置723, 34进入队列失败（选择英雄早退）95,50,0
                {
                    PVP监控Timer.Interval = 5000;
                    LoadingTime = 60000;
                    return;
                }
                if ((商店按钮.R == 0 && 商店按钮.G == 0 && 商店按钮.B == 0) || (商店按钮.R == 255 && 商店按钮.G == 255 && 商店按钮.B == 255))//位置723, 34卡顿中
                {
                    return;
                }
                //处理截图冲突：
                if ((游戏加载上边框.R == 16 && 游戏加载上边框.G == 36 && 游戏加载上边框.B == 66) && (游戏加载下边框.R == 74 && 游戏加载下边框.G == 24 && 游戏加载下边框.B == 24))//游戏加载中（蓝色、红色）
                {
                    return;
                }
                if ((游戏加载上边框.R == 82 && 游戏加载上边框.G == 81 && 游戏加载上边框.B == 66) && (游戏加载下边框.R == 74 && 游戏加载下边框.G == 24 && 游戏加载下边框.B == 24))//游戏加载中（银色，红色）
                {
                    return;
                }
                if ((游戏加载上边框.R == 74 && 游戏加载上边框.G == 24 && 游戏加载上边框.B == 24) && (游戏加载下边框.R == 16 && 游戏加载下边框.G == 36 && 游戏加载下边框.B == 66))//游戏加载中（红色、蓝色）
                {
                    return;
                }
                if ((游戏加载上边框.R == 74 && 游戏加载上边框.G == 24 && 游戏加载上边框.B == 24) && (游戏加载下边框.R == 82 && 游戏加载下边框.G == 81 && 游戏加载下边框.B == 66))//游戏加载中（红色、银色）
                {
                    return;
                }
                if (游戏内人物区域.R == 16 && 游戏内人物区域.G == 29 && 游戏内人物区域.B == 30)//游戏进行中
                {
                    return;
                }
                if (游戏加载上边框.R == 255 && 游戏加载上边框.G == 255 && 游戏加载上边框.B == 242)//游戏结束（等待点击胜利）
                {
                    return;
                }
                if (游戏加载上边框.R == 250 && 游戏加载上边框.G == 214 && 游戏加载上边框.B == 162)//游戏结束（等待点击失败）
                {
                    return;
                }
                if ((游戏加载上边框.R == 255 && 游戏加载上边框.G == 255 && 游戏加载上边框.B == 255) && (游戏加载下边框.R == 240 && 游戏加载下边框.G == 240 && 游戏加载下边框.B == 240) && (游戏内人物区域.R == 0 && 游戏内人物区域.G == 0 && 游戏内人物区域.B == 0))//已断开连接
                {
                    PVP监控Timer.Interval = 5000;
                    LoadingTime = 60000;
                    My.Computer.ShellKill("League of Legends");
                    return;
                }
                //保存其它情况：
                if (调试模式)
                {
                    string SaveFileName = "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
                    英雄联盟_PVP截图.Save("英雄联盟PVP" + SaveFileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    My.IO.WriteString(
                            "商店按钮" + 商店按钮.ToString() + "\r\n" +
                            "开始游戏按钮" + 开始游戏按钮.ToString() + "\r\n" +
                            "重新连接按钮" + 重新连接按钮.ToString() + "\r\n" +
                            "游戏加载上边框" + 游戏加载上边框.ToString() + "\r\n" +
                            "游戏加载下边框" + 游戏加载下边框.ToString() + "\r\n" +
                            "游戏内人物区域" + 游戏内人物区域.ToString() + "\r\n"
                            , "英雄联盟PVP" + SaveFileName + ".txt");
                }
                return;
            }
        }
        Rectangle LOL窗口位置 = new Rectangle((Screen.PrimaryScreen.Bounds.Width - 1280) / 2, (Screen.PrimaryScreen.Bounds.Height - 720) / 2, 1280, 720);//分辨率1280*720
        Bitmap 英雄联盟_LOL截图;
        int LoadingTime = 0;
        bool 优化LOL = false;
        private void LOL监控(object sender, EventArgs e)
        {
            LOL监控Timer.Enabled = false;
            if (LoadingTime > 0)
            {
                LoadingTime = LoadingTime - LOL监控Timer.Interval;//游戏加载期间的等待时间（单位毫秒）
                LOL监控Timer.Enabled = true;
                return;
            }
            if (My.Computer.FindWindow("League of Legends (TM) Client").Width != 0)
            {
                if (优化LOL == false && 优化模式)
                {
                    优化LOL = true;
                    My.Computer.Shell("\"BES\\BES.exe\" \"" + My.Computer.GetProcessFilePath("League of Legends") + "\" 60 --add --minimize");//实测，优化90%进不去游戏，优化60%一定概率进不去游戏
                    My.Computer.SetWindowCanRedraw("League of Legends (TM) Client");
                }
                else if (优化模式)
                {
                    My.Computer.SetWindowCanRedraw("League of Legends (TM) Client");
                }
                notifyIcon1.ShowBalloonTip(3000, "LOL自动挂机-提示", "LOL界面监控中", ToolTipIcon.Info);
                My.Computer.ShowWindowNormal("League of Legends (TM) Client");
                My.Computer.SetForegroundWindow("League of Legends (TM) Client");
                My.Computer.MoveWindow("League of Legends (TM) Client", LOL窗口位置);
                //Thread.Sleep(20);
                //原地随机移动
                Random R = new Random();
                My.Computer.MouseMoveToPixel(LOL窗口位置.Left + LOL窗口位置.Width / 2 - 50 + R.Next(-50, 50), LOL窗口位置.Top + LOL窗口位置.Height / 2 + 50 + R.Next(-50, 50));
                My.Computer.MouseRightDown();
                My.Computer.MouseRightUp();
                My.Computer.MouseRightUp();
                Thread.Sleep(2);
                My.Computer.MouseLeftDown();
                My.Computer.MouseLeftUp();
                My.Computer.MouseLeftUp();
                Thread.Sleep(2);
                /*
                int TEMP = R.Next(1, 9);
                notifyIcon1.ShowBalloonTip(3000, "LOL自动挂机-提示", "LOL界面监控中，获取到随机数"+TEMP, ToolTipIcon.Info);
                switch (TEMP)
                 * */
                switch (R.Next(1, 9))//随机数1-8
                {
                    case 1:
                        if (游戏模式 == 1)
                        {
                            My.Computer.PressKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.W);
                            My.Computer.ReleaseKey(Keys.W);
                            My.Computer.ReleaseKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.E);
                            My.Computer.ReleaseKey(Keys.E);
                            My.Computer.ReleaseKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.R);
                            My.Computer.ReleaseKey(Keys.R);
                            My.Computer.ReleaseKey(Keys.LControlKey);
                        }
                        else if (游戏模式 == 2)
                        {
                            My.Computer.PressKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.LControlKey);
                        }
                        else
                        {
                            My.Computer.PressKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.D5);
                            My.Computer.ReleaseKey(Keys.D5);
                            My.Computer.ReleaseKey(Keys.LControlKey);
                        }
                        break;
                    case 2:
                        if (游戏模式 == 1)
                        {
                            My.Computer.PressKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.W);
                            My.Computer.ReleaseKey(Keys.W);
                            My.Computer.ReleaseKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.E);
                            My.Computer.ReleaseKey(Keys.E);
                            My.Computer.ReleaseKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.R);
                            My.Computer.ReleaseKey(Keys.R);
                            My.Computer.ReleaseKey(Keys.LShiftKey);
                        }
                        else if (游戏模式 == 2)
                        {
                            My.Computer.PressKey(Keys.LShiftKey);
                            My.Computer.PressKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.Q);
                            My.Computer.ReleaseKey(Keys.LShiftKey);
                        }
                        else
                        {
                            My.Computer.PressKey(Keys.LControlKey);
                            My.Computer.PressKey(Keys.D6);
                            My.Computer.ReleaseKey(Keys.D6);
                            My.Computer.ReleaseKey(Keys.LControlKey);
                        }
                        break;
                    case 3:
                        My.Computer.PressKey(Keys.LControlKey);
                        My.Computer.PressKey(Keys.D1);
                        My.Computer.ReleaseKey(Keys.D1);
                        My.Computer.ReleaseKey(Keys.LControlKey);
                        break;
                    case 4:
                        My.Computer.PressKey(Keys.LControlKey);
                        My.Computer.PressKey(Keys.D2);
                        My.Computer.ReleaseKey(Keys.D2);
                        My.Computer.ReleaseKey(Keys.LControlKey);
                        break;
                    case 5:
                        My.Computer.PressKey(Keys.LControlKey);
                        My.Computer.PressKey(Keys.D3);
                        My.Computer.ReleaseKey(Keys.D3);
                        My.Computer.ReleaseKey(Keys.LControlKey);
                        break;
                    case 6:
                        My.Computer.PressKey(Keys.LControlKey);
                        My.Computer.PressKey(Keys.D4);
                        My.Computer.ReleaseKey(Keys.D4);
                        My.Computer.ReleaseKey(Keys.LControlKey);
                        break;
                    case 7:
                        My.Computer.PressKey(Keys.B);
                        My.Computer.ReleaseKey(Keys.B);
                        break;
                    case 8:
                        My.Computer.PressKey(Keys.D);
                        My.Computer.ReleaseKey(Keys.D);
                        My.Computer.PressKey(Keys.F);
                        My.Computer.ReleaseKey(Keys.F);
                        break;
                }
                if (优化模式)
                {
                    //Thread.Sleep(20);
                    My.Computer.SetWindowCanNotRedraw("League of Legends (TM) Client");
                    //My.Computer.SetForegroundWindow("PVP.net 客户端");
                }
            }
            LOL监控Timer.Enabled = true;
            return;
        }
        private void toolStripMenuItemPVP截图_Click(object sender, EventArgs e)
        {
            My.Computer.SetWindowCanRedraw("PVP.net 客户端");
            My.Computer.ShowWindowNormal("PVP.net 客户端");
            My.Computer.SetForegroundWindow("PVP.net 客户端");
            My.Computer.MoveWindow("PVP.net 客户端", PVP窗口位置);
            My.Computer.ShowWindowNormal("PVP.net 客户端");
            My.Computer.SetForegroundWindow("PVP.net 客户端");
            My.Computer.MoveWindow("PVP.net 客户端", PVP窗口位置);
            英雄联盟_PVP截图 = My.Computer.SaveScreen(PVP窗口位置);
            Color 商店按钮 = 英雄联盟_PVP截图.GetPixel(723, 34);
            Color 开始游戏按钮 = 英雄联盟_PVP截图.GetPixel(555, 30);
            Color 重新连接按钮 = 英雄联盟_PVP截图.GetPixel(512, 360);
            Color 游戏加载上边框 = 英雄联盟_PVP截图.GetPixel(512, 300);
            Color 游戏加载下边框 = 英雄联盟_PVP截图.GetPixel(512, 347);
            Color 游戏内人物区域 = 英雄联盟_PVP截图.GetPixel(340, 630);
            string SaveFileName1 = "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
            英雄联盟_PVP截图.Save("英雄联盟PVP" + SaveFileName1 + ".png", System.Drawing.Imaging.ImageFormat.Png); My.IO.WriteString(
                         "商店按钮" + 商店按钮.ToString() + "\r\n" +
                         "开始游戏按钮" + 开始游戏按钮.ToString() + "\r\n" +
                         "重新连接按钮" + 重新连接按钮.ToString() + "\r\n" +
                         "游戏加载上边框" + 游戏加载上边框.ToString() + "\r\n" +
                         "游戏加载下边框" + 游戏加载下边框.ToString() + "\r\n" +
                         "游戏内人物区域" + 游戏内人物区域.ToString() + "\r\n"
                         , "英雄联盟PVP" + SaveFileName1 + ".txt");
        }
        private void toolStripMenuItemLOL截图_Click(object sender, EventArgs e)
        {
            My.Computer.SetWindowCanRedraw("League of Legends (TM) Client");
            My.Computer.ShowWindowNormal("League of Legends (TM) Client");
            My.Computer.SetForegroundWindow("League of Legends (TM) Client");
            My.Computer.MoveWindow("League of Legends (TM) Client", LOL窗口位置);
            英雄联盟_LOL截图 = My.Computer.SaveScreen(LOL窗口位置);
            Color 商店按钮 = 英雄联盟_LOL截图.GetPixel(723, 34);
            Color 开始游戏按钮 = 英雄联盟_LOL截图.GetPixel(555, 30);
            Color 重新连接按钮 = 英雄联盟_LOL截图.GetPixel(512, 360);
            Color 游戏加载上边框 = 英雄联盟_PVP截图.GetPixel(512, 300);
            Color 游戏加载下边框 = 英雄联盟_PVP截图.GetPixel(512, 347);
            Color 游戏内人物区域 = 英雄联盟_PVP截图.GetPixel(340, 630);
            string SaveFileName1 = "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
            英雄联盟_LOL截图.Save("英雄联盟LOL" + SaveFileName1 + ".png", System.Drawing.Imaging.ImageFormat.Png); My.IO.WriteString(
                         "商店按钮" + 商店按钮.ToString() + "\r\n" +
                         "开始游戏按钮" + 开始游戏按钮.ToString() + "\r\n" +
                         "重新连接按钮" + 重新连接按钮.ToString() + "\r\n" +
                         "游戏加载上边框" + 游戏加载上边框.ToString() + "\r\n" +
                         "游戏加载下边框" + 游戏加载下边框.ToString() + "\r\n" +
                         "游戏内人物区域" + 游戏内人物区域.ToString() + "\r\n"
                         , "英雄联盟LOL" + SaveFileName1 + ".txt");
        }
        private void toolStripMenuItem退出_Click(object sender, EventArgs e)
        {
            if (优化模式)
            {
                My.Computer.Shell("\"BES\\BES.exe\" --exitnow");
            }
            My.Computer.SetWindowCanRedraw("League of Legends (TM) Client");
            My.Computer.SetWindowCanRedraw("PVP.net 客户端");
            notifyIcon1.Visible = false;
            Application.Exit();
            Process.GetCurrentProcess().Kill();
        }
        private void toolStripMenuItem帮助_Click(object sender, EventArgs e)
        {
            My.Computer.Shell("explorer.exe " + "\"" + "http://www.moonlord.cn/blog/blog.php?id=1451477428" + "\"");
        }
    }
}
