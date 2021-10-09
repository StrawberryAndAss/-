namespace 智能工时系统
{
    partial class Logon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logon));
            this._txt_username = new Sunny.UI.UITextBox();
            this.Depiction_3 = new MetroFramework.Controls.MetroLabel();
            this.Depiction_2 = new MetroFramework.Controls.MetroLabel();
            this.Depiction_1 = new MetroFramework.Controls.MetroLabel();
            this.Line = new Sunny.UI.UILine();
            this.Pic_TaskTime_Log = new System.Windows.Forms.PictureBox();
            this._txt_password = new Sunny.UI.UITextBox();
            this._btn_logon = new Sunny.UI.UIButton();
            this._Checkbox_RememberPassword = new Sunny.UI.UICheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_TaskTime_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // _txt_username
            // 
            this._txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txt_username.FillColor = System.Drawing.Color.White;
            this._txt_username.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._txt_username.Location = new System.Drawing.Point(349, 129);
            this._txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txt_username.Maximum = 2147483647D;
            this._txt_username.Minimum = -2147483648D;
            this._txt_username.Name = "_txt_username";
            this._txt_username.Padding = new System.Windows.Forms.Padding(5);
            this._txt_username.Radius = 15;
            this._txt_username.Size = new System.Drawing.Size(198, 29);
            this._txt_username.Style = Sunny.UI.UIStyle.Custom;
            this._txt_username.TabIndex = 0;
            this._txt_username.Watermark = "请您输入账号";
            // 
            // Depiction_3
            // 
            this.Depiction_3.AutoSize = true;
            this.Depiction_3.Location = new System.Drawing.Point(80, 304);
            this.Depiction_3.Name = "Depiction_3";
            this.Depiction_3.Size = new System.Drawing.Size(121, 19);
            this.Depiction_3.TabIndex = 10;
            this.Depiction_3.Text = "All Rights Reserved";
            // 
            // Depiction_2
            // 
            this.Depiction_2.AutoSize = true;
            this.Depiction_2.Location = new System.Drawing.Point(48, 285);
            this.Depiction_2.Name = "Depiction_2";
            this.Depiction_2.Size = new System.Drawing.Size(204, 19);
            this.Depiction_2.TabIndex = 9;
            this.Depiction_2.Text = "Copyright © 2021 Strawberry Ass";
            // 
            // Depiction_1
            // 
            this.Depiction_1.AutoSize = true;
            this.Depiction_1.Location = new System.Drawing.Point(25, 266);
            this.Depiction_1.Name = "Depiction_1";
            this.Depiction_1.Size = new System.Drawing.Size(252, 19);
            this.Depiction_1.TabIndex = 8;
            this.Depiction_1.Text = "Intelligent Task Time System for Windows ";
            // 
            // Line
            // 
            this.Line.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.Line.FillColor = System.Drawing.Color.White;
            this.Line.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Line.Location = new System.Drawing.Point(295, 51);
            this.Line.MinimumSize = new System.Drawing.Size(2, 2);
            this.Line.Name = "Line";
            this.Line.Radius = 20;
            this.Line.Size = new System.Drawing.Size(10, 290);
            this.Line.Style = Sunny.UI.UIStyle.Custom;
            this.Line.TabIndex = 11;
            // 
            // Pic_TaskTime_Log
            // 
            this.Pic_TaskTime_Log.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Pic_TaskTime_Log.ErrorImage")));
            this.Pic_TaskTime_Log.Image = ((System.Drawing.Image)(resources.GetObject("Pic_TaskTime_Log.Image")));
            this.Pic_TaskTime_Log.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pic_TaskTime_Log.InitialImage")));
            this.Pic_TaskTime_Log.Location = new System.Drawing.Point(84, 98);
            this.Pic_TaskTime_Log.Name = "Pic_TaskTime_Log";
            this.Pic_TaskTime_Log.Size = new System.Drawing.Size(128, 128);
            this.Pic_TaskTime_Log.TabIndex = 12;
            this.Pic_TaskTime_Log.TabStop = false;
            // 
            // _txt_password
            // 
            this._txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txt_password.FillColor = System.Drawing.Color.White;
            this._txt_password.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._txt_password.Location = new System.Drawing.Point(349, 185);
            this._txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txt_password.Maximum = 2147483647D;
            this._txt_password.Minimum = -2147483648D;
            this._txt_password.Name = "_txt_password";
            this._txt_password.Padding = new System.Windows.Forms.Padding(5);
            this._txt_password.PasswordChar = '*';
            this._txt_password.Radius = 15;
            this._txt_password.Size = new System.Drawing.Size(198, 29);
            this._txt_password.Style = Sunny.UI.UIStyle.Custom;
            this._txt_password.TabIndex = 1;
            this._txt_password.Watermark = "请您输入密码";
            // 
            // _btn_logon
            // 
            this._btn_logon.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_logon.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._btn_logon.Location = new System.Drawing.Point(349, 266);
            this._btn_logon.Name = "_btn_logon";
            this._btn_logon.Radius = 15;
            this._btn_logon.Size = new System.Drawing.Size(198, 37);
            this._btn_logon.Style = Sunny.UI.UIStyle.Custom;
            this._btn_logon.TabIndex = 3;
            this._btn_logon.Text = "登               录";
            this._btn_logon.Click += new System.EventHandler(this._btn_logon_Click);
            // 
            // _Checkbox_RememberPassword
            // 
            this._Checkbox_RememberPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this._Checkbox_RememberPassword.Font = new System.Drawing.Font("微软雅黑", 10F);
            this._Checkbox_RememberPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this._Checkbox_RememberPassword.Location = new System.Drawing.Point(443, 227);
            this._Checkbox_RememberPassword.Name = "_Checkbox_RememberPassword";
            this._Checkbox_RememberPassword.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this._Checkbox_RememberPassword.Size = new System.Drawing.Size(104, 29);
            this._Checkbox_RememberPassword.Style = Sunny.UI.UIStyle.Custom;
            this._Checkbox_RememberPassword.TabIndex = 13;
            this._Checkbox_RememberPassword.Text = "是否记住密码";
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 346);
            this.Controls.Add(this._Checkbox_RememberPassword);
            this.Controls.Add(this._btn_logon);
            this.Controls.Add(this._txt_password);
            this.Controls.Add(this.Pic_TaskTime_Log);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Depiction_3);
            this.Controls.Add(this.Depiction_2);
            this.Controls.Add(this.Depiction_1);
            this.Controls.Add(this._txt_username);
            this.MaximizeBox = false;
            this.Name = "Logon";
            this.Text = "Intelligent Task Time By Straberry Ass";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.Pic_TaskTime_Log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox _txt_username;
        private MetroFramework.Controls.MetroLabel Depiction_3;
        private MetroFramework.Controls.MetroLabel Depiction_2;
        private MetroFramework.Controls.MetroLabel Depiction_1;
        private Sunny.UI.UILine Line;
        private System.Windows.Forms.PictureBox Pic_TaskTime_Log;
        private Sunny.UI.UITextBox _txt_password;
        private Sunny.UI.UIButton _btn_logon;
        private Sunny.UI.UICheckBox _Checkbox_RememberPassword;
    }
}

