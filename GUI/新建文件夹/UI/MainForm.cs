﻿using BenNHControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class MainForm : FormEX
    {

        private static MainForm formInstance;
        public static MainForm GetIntance
        {
            get
            {
                if (formInstance != null)
                {
                    return formInstance;
                }
                else
                {
                    formInstance = new MainForm();
                    return formInstance;
                }
            }
        }


        public object lockObj = new object();
        public bool formSwitchFlag = false;

        /// <summary>
        /// 子窗体界面单例元素
        /// </summary>
        public static 开始体检 form1 = null;
        public static 木马查杀 form2 = null;
        public static 检查更新 form3 = null;
        public static 垃圾清理 form4 = null;
        public static 优化加速 form5 = null;
        public static 工具箱 form6 = null;
        public static 软件管家 form7 = null;



        /// <summary>
        /// 当前显示窗体
        /// </summary>
        private System.Windows.Forms.Form currentForm;


        /// <summary>
        /// 构造方法
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //主窗体容器打开
            this.IsMdiContainer = true;

            //实例化子窗体界面
            form1 = 开始体检.GetIntance;
            form2 = 木马查杀.GetIntance;
            form3 = 检查更新.GetIntance;
            form4 = 垃圾清理.GetIntance;
            form5 = 优化加速.GetIntance;
            form6 = 工具箱.GetIntance;
            form7 = 软件管家.GetIntance;
            //初始化按钮
            this.initButton();

        }


        /// <summary>
        /// 解决闪烁问题
        /// </summary>
        protected override CreateParams CreateParams//双字节解决图片闪烁
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private bool initButton()
        {
            try
            {
                this.button1.BackColor = Color.FromArgb(53, 66, 83);
                this.button2.BackColor = Color.FromArgb(53, 66, 83);
                this.button3.BackColor = Color.FromArgb(53, 66, 83);
                this.button4.BackColor = Color.FromArgb(53, 66, 83);
                this.button5.BackColor = Color.FromArgb(53, 66, 83);
                this.button6.BackColor = Color.FromArgb(53, 66, 83);
                this.button7.BackColor = Color.FromArgb(53, 66, 83);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="frm"></param>
        public void ShowForm(System.Windows.Forms.Panel panel, System.Windows.Forms.Form frm)
        {
            lock (this)
            {
                try
                {
                    if (this.currentForm != null && this.currentForm == frm)
                    {
                        return;
                    }
                    else if (this.currentForm != null)
                    {
                        if (this.ActiveMdiChild != null)
                        {
                            this.ActiveMdiChild.Hide();
                        }
                    }
                    this.currentForm = frm;
                    frm.TopLevel = false;
                    frm.MdiParent = this;
                    panel.Controls.Clear();
                    panel.Controls.Add(frm);
                    frm.Show();
                    frm.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.Refresh();
                    foreach (Control item in frm.Controls)
                    {
                        item.Focus();
                        break;
                    }
                }
                catch (System.Exception ex)
                {
                    //
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.initButton();
                this.button1.BackColor = Color.FromArgb(95, 129, 174);
                Monitor.Enter(this.lockObj);
                if (!formSwitchFlag)
                {
                    formSwitchFlag = true;
                    this.ShowForm(pnlCenter,form1);
                    formSwitchFlag = false;
                }
                else
                {
                    return;
                }
            }
            catch (System.Exception ex)
            {
                //
            }
            finally
            {
                Monitor.Exit(this.lockObj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.initButton();
                this.button2.BackColor = Color.FromArgb(95, 129, 174);
                Monitor.Enter(this.lockObj);
                if (!formSwitchFlag)
                {
                    formSwitchFlag = true;
                    this.ShowForm(pnlCenter, form2);
                    formSwitchFlag = false;
                }
                else
                {
                    return;
                }
            }
            catch (System.Exception ex)
            {
                //
            }
            finally
            {
                Monitor.Exit(this.lockObj);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.initButton();
                this.button3.BackColor = Color.FromArgb(95, 129, 174);
                Monitor.Enter(this.lockObj);
                if (!formSwitchFlag)
                {
                    formSwitchFlag = true;
                    this.ShowForm(pnlCenter, form3);
                    formSwitchFlag = false;
                }
                else
                {
                    return;
                }
            }
            catch (System.Exception ex)
            {
                //
            }
            finally
            {
                Monitor.Exit(this.lockObj);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.initButton();
                this.button4.BackColor = Color.FromArgb(95, 129, 174);
                Monitor.Enter(this.lockObj);
                if (!formSwitchFlag)
                {
                    formSwitchFlag = true;
                    this.ShowForm(pnlCenter, form4);
                    formSwitchFlag = false;
                }
                else
                {
                    return;
                }
            }
            catch (System.Exception ex)
            {
                //
            }
            finally
            {
                Monitor.Exit(this.lockObj);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.initButton();
                this.button5.BackColor = Color.FromArgb(95, 129, 174);
                Monitor.Enter(this.lockObj);
                if (!formSwitchFlag)
                {
                    formSwitchFlag = true;
                    this.ShowForm(pnlCenter, form5);
                    formSwitchFlag = false;
                }
                else
                {
                    return;
                }
            }
            catch (System.Exception ex)
            {
                //
            }
            finally
            {
                Monitor.Exit(this.lockObj);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.initButton();
                this.button6.BackColor = Color.FromArgb(95, 129, 174);
                Monitor.Enter(this.lockObj);
                if (!formSwitchFlag)
                {
                    formSwitchFlag = true;
                    this.ShowForm(pnlCenter, form6);
                    formSwitchFlag = false;
                }
                else
                {
                    return;
                }
            }
            catch (System.Exception ex)
            {
                //
            }
            finally
            {
                Monitor.Exit(this.lockObj);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.initButton();
                this.button7.BackColor = Color.FromArgb(95, 129, 174);
                Monitor.Enter(this.lockObj);
                if (!formSwitchFlag)
                {
                    formSwitchFlag = true;
                    this.ShowForm(pnlCenter, form7);
                    formSwitchFlag = false;
                }
                else
                {
                    return;
                }
            }
            catch (System.Exception ex)
            {
                //
            }
            finally
            {
                Monitor.Exit(this.lockObj);
            }
        }

       

        private void pnlCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)//退出界面
        {
            this.notifyIcon1.Visible = false;
            p.Kill();
            this.Close();
        }

        private void 打开性能监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            p.StartInfo.FileName = "TrafficMonitor.exe";
            p.Start();
        }

        private void 打开主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)//双击图标打开界面
        {
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }
        public void SetBackgroudImage(string imageFileName)
        {
            this.pnlCenter.BackgroundImage  = System.Drawing.Image.FromFile(imageFileName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
