﻿namespace TransferExcelByElectric
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Prob_scanspan = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_excelfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslbl_errrows = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prob_send = new System.Windows.Forms.ProgressBar();
            this.btn_startend = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_scanspan = new System.Windows.Forms.TextBox();
            this.txt_postadd = new System.Windows.Forms.TextBox();
            this.txt_readrows = new System.Windows.Forms.TextBox();
            this.txt_sendrows = new System.Windows.Forms.TextBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_msend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nono = new System.Windows.Forms.TextBox();
            this.txt_hassend = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer_send = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.Tsmi_exit});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.系统SToolStripMenuItem.Text = "系统(S)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 26);
            this.toolStripMenuItem2.Text = "设置系统(&S)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // Tsmi_exit
            // 
            this.Tsmi_exit.Name = "Tsmi_exit";
            this.Tsmi_exit.Size = new System.Drawing.Size(167, 26);
            this.Tsmi_exit.Text = "退出系统(&X)";
            this.Tsmi_exit.Click += new System.EventHandler(this.Tsmi_exit_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我们AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于我们AToolStripMenuItem
            // 
            this.关于我们AToolStripMenuItem.Name = "关于我们AToolStripMenuItem";
            this.关于我们AToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.关于我们AToolStripMenuItem.Text = "关于我们(&A)";
            // 
            // Prob_scanspan
            // 
            this.Prob_scanspan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Prob_scanspan.Location = new System.Drawing.Point(0, 28);
            this.Prob_scanspan.Name = "Prob_scanspan";
            this.Prob_scanspan.Size = new System.Drawing.Size(810, 23);
            this.Prob_scanspan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件路径：";
            // 
            // txt_excelfile
            // 
            this.txt_excelfile.Enabled = false;
            this.txt_excelfile.Location = new System.Drawing.Point(96, 75);
            this.txt_excelfile.Name = "txt_excelfile";
            this.txt_excelfile.Size = new System.Drawing.Size(702, 22);
            this.txt_excelfile.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "扫描周期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "调用地址：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbl_errrows});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslbl_errrows
            // 
            this.tsslbl_errrows.Name = "tsslbl_errrows";
            this.tsslbl_errrows.Size = new System.Drawing.Size(41, 20);
            this.tsslbl_errrows.Text = "状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "发送条数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "读取条数：";
            // 
            // prob_send
            // 
            this.prob_send.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prob_send.Location = new System.Drawing.Point(0, 357);
            this.prob_send.Name = "prob_send";
            this.prob_send.Size = new System.Drawing.Size(810, 23);
            this.prob_send.TabIndex = 9;
            // 
            // btn_startend
            // 
            this.btn_startend.Location = new System.Drawing.Point(131, 293);
            this.btn_startend.Name = "btn_startend";
            this.btn_startend.Size = new System.Drawing.Size(92, 43);
            this.btn_startend.TabIndex = 10;
            this.btn_startend.Text = "无    效";
            this.btn_startend.UseVisualStyleBackColor = true;
            this.btn_startend.Click += new System.EventHandler(this.btn_startend_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "重    置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_scanspan
            // 
            this.txt_scanspan.Enabled = false;
            this.txt_scanspan.Location = new System.Drawing.Point(96, 132);
            this.txt_scanspan.Name = "txt_scanspan";
            this.txt_scanspan.Size = new System.Drawing.Size(231, 22);
            this.txt_scanspan.TabIndex = 12;
            // 
            // txt_postadd
            // 
            this.txt_postadd.Enabled = false;
            this.txt_postadd.Location = new System.Drawing.Point(96, 185);
            this.txt_postadd.Name = "txt_postadd";
            this.txt_postadd.Size = new System.Drawing.Size(702, 22);
            this.txt_postadd.TabIndex = 13;
            // 
            // txt_readrows
            // 
            this.txt_readrows.Enabled = false;
            this.txt_readrows.Location = new System.Drawing.Point(96, 242);
            this.txt_readrows.Name = "txt_readrows";
            this.txt_readrows.Size = new System.Drawing.Size(91, 22);
            this.txt_readrows.TabIndex = 14;
            // 
            // txt_sendrows
            // 
            this.txt_sendrows.Enabled = false;
            this.txt_sendrows.Location = new System.Drawing.Point(292, 242);
            this.txt_sendrows.Name = "txt_sendrows";
            this.txt_sendrows.Size = new System.Drawing.Size(91, 22);
            this.txt_sendrows.TabIndex = 15;
            // 
            // btn_test
            // 
            this.btn_test.Enabled = false;
            this.btn_test.Location = new System.Drawing.Point(676, 293);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(92, 43);
            this.btn_test.TabIndex = 16;
            this.btn_test.Text = "测试系统";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_msend
            // 
            this.btn_msend.Location = new System.Drawing.Point(328, 293);
            this.btn_msend.Name = "btn_msend";
            this.btn_msend.Size = new System.Drawing.Size(92, 43);
            this.btn_msend.TabIndex = 17;
            this.btn_msend.Text = "手动发送";
            this.btn_msend.UseVisualStyleBackColor = true;
            this.btn_msend.Click += new System.EventHandler(this.btn_msend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "无手机号：";
            // 
            // txt_nono
            // 
            this.txt_nono.Enabled = false;
            this.txt_nono.Location = new System.Drawing.Point(489, 242);
            this.txt_nono.Name = "txt_nono";
            this.txt_nono.Size = new System.Drawing.Size(91, 22);
            this.txt_nono.TabIndex = 19;
            // 
            // txt_hassend
            // 
            this.txt_hassend.Enabled = false;
            this.txt_hassend.Location = new System.Drawing.Point(685, 242);
            this.txt_hassend.Name = "txt_hassend";
            this.txt_hassend.Size = new System.Drawing.Size(91, 22);
            this.txt_hassend.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "历史发送：";
            // 
            // timer_send
            // 
            this.timer_send.Tick += new System.EventHandler(this.timer_send_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 405);
            this.Controls.Add(this.txt_hassend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_msend);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.txt_sendrows);
            this.Controls.Add(this.txt_readrows);
            this.Controls.Add(this.txt_postadd);
            this.Controls.Add(this.txt_scanspan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_startend);
            this.Controls.Add(this.prob_send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_excelfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prob_scanspan);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电力公司催缴短信内外对接模块";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_exit;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ProgressBar Prob_scanspan;
        private System.Windows.Forms.ToolStripMenuItem 关于我们AToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_excelfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prob_send;
        private System.Windows.Forms.Button btn_startend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_scanspan;
        private System.Windows.Forms.TextBox txt_postadd;
        private System.Windows.Forms.TextBox txt_sendrows;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.TextBox txt_readrows;
        private System.Windows.Forms.Button btn_msend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nono;
        private System.Windows.Forms.TextBox txt_hassend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl_errrows;
        private System.Windows.Forms.Timer timer_send;
    }
}
