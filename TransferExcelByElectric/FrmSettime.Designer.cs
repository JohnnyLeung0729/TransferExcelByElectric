namespace TransferExcelByElectric
{
    partial class FrmSettime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_timeset = new System.Windows.Forms.DateTimePicker();
            this.btn_settime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_timeset
            // 
            this.dtp_timeset.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_timeset.Location = new System.Drawing.Point(46, 52);
            this.dtp_timeset.Name = "dtp_timeset";
            this.dtp_timeset.ShowUpDown = true;
            this.dtp_timeset.Size = new System.Drawing.Size(200, 26);
            this.dtp_timeset.TabIndex = 0;
            // 
            // btn_settime
            // 
            this.btn_settime.Location = new System.Drawing.Point(336, 45);
            this.btn_settime.Name = "btn_settime";
            this.btn_settime.Size = new System.Drawing.Size(115, 44);
            this.btn_settime.TabIndex = 1;
            this.btn_settime.Text = "设  置";
            this.btn_settime.UseVisualStyleBackColor = true;
            this.btn_settime.Click += new System.EventHandler(this.btn_settime_Click);
            // 
            // FrmSettime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 128);
            this.Controls.Add(this.btn_settime);
            this.Controls.Add(this.dtp_timeset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSettime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置执行时间";
            this.Load += new System.EventHandler(this.FrmSettime_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_timeset;
        private System.Windows.Forms.Button btn_settime;
    }
}