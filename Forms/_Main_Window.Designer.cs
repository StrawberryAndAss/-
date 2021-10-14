namespace 智能工时系统
{
    partial class _Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Main_Window));
            this.Depiction_2 = new MetroFramework.Controls.MetroLabel();
            this.Lab_01 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this._btn_send_task_time = new Sunny.UI.UIButton();
            this._date_picker_start = new Sunny.UI.UIDatePicker();
            this._date_picker_end = new Sunny.UI.UIDatePicker();
            this._result_message_data = new Sunny.UI.UIListBox();
            this._settings_ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._settings_)).BeginInit();
            this.SuspendLayout();
            // 
            // Depiction_2
            // 
            this.Depiction_2.AutoSize = true;
            this.Depiction_2.Location = new System.Drawing.Point(0, 326);
            this.Depiction_2.Name = "Depiction_2";
            this.Depiction_2.Size = new System.Drawing.Size(320, 19);
            this.Depiction_2.TabIndex = 10;
            this.Depiction_2.Text = "Copyright © 2021 Strawberry Ass All Rights Reserved";
            // 
            // Lab_01
            // 
            this.Lab_01.AutoSize = true;
            this.Lab_01.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Lab_01.Location = new System.Drawing.Point(36, 109);
            this.Lab_01.Name = "Lab_01";
            this.Lab_01.Size = new System.Drawing.Size(90, 21);
            this.Lab_01.TabIndex = 12;
            this.Lab_01.Text = "开始时间：";
            this.Lab_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(36, 162);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(90, 21);
            this.uiLabel1.TabIndex = 14;
            this.uiLabel1.Text = "结束时间：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(70, 22);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(361, 168);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(8, 8);
            this.htmlLabel1.TabIndex = 18;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // _btn_send_task_time
            // 
            this._btn_send_task_time.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_send_task_time.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._btn_send_task_time.Location = new System.Drawing.Point(43, 238);
            this._btn_send_task_time.Name = "_btn_send_task_time";
            this._btn_send_task_time.Radius = 15;
            this._btn_send_task_time.Size = new System.Drawing.Size(222, 37);
            this._btn_send_task_time.Style = Sunny.UI.UIStyle.Custom;
            this._btn_send_task_time.TabIndex = 19;
            this._btn_send_task_time.Text = "批 量 录 入 工 时";
            this._btn_send_task_time.Click += new System.EventHandler(this._btn_logon_Click);
            // 
            // _date_picker_start
            // 
            this._date_picker_start.DateFormat = "yyyy-MM-dd ";
            this._date_picker_start.FillColor = System.Drawing.Color.White;
            this._date_picker_start.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._date_picker_start.Location = new System.Drawing.Point(119, 105);
            this._date_picker_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._date_picker_start.MaxLength = 11;
            this._date_picker_start.MinimumSize = new System.Drawing.Size(63, 0);
            this._date_picker_start.Name = "_date_picker_start";
            this._date_picker_start.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this._date_picker_start.Radius = 15;
            this._date_picker_start.Size = new System.Drawing.Size(139, 29);
            this._date_picker_start.SymbolDropDown = 61555;
            this._date_picker_start.SymbolNormal = 61555;
            this._date_picker_start.TabIndex = 18;
            this._date_picker_start.Text = "2021-10-11 ";
            this._date_picker_start.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this._date_picker_start.Value = new System.DateTime(2021, 10, 11, 0, 0, 0, 0);
            // 
            // _date_picker_end
            // 
            this._date_picker_end.FillColor = System.Drawing.Color.White;
            this._date_picker_end.Font = new System.Drawing.Font("微软雅黑", 12F);
            this._date_picker_end.Location = new System.Drawing.Point(119, 158);
            this._date_picker_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._date_picker_end.MaxLength = 10;
            this._date_picker_end.MinimumSize = new System.Drawing.Size(63, 0);
            this._date_picker_end.Name = "_date_picker_end";
            this._date_picker_end.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this._date_picker_end.Radius = 15;
            this._date_picker_end.Size = new System.Drawing.Size(139, 29);
            this._date_picker_end.SymbolDropDown = 61555;
            this._date_picker_end.SymbolNormal = 61555;
            this._date_picker_end.TabIndex = 19;
            this._date_picker_end.Text = "2021-10-11";
            this._date_picker_end.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this._date_picker_end.Value = new System.DateTime(2021, 10, 11, 0, 0, 0, 0);
            // 
            // _result_message_data
            // 
            this._result_message_data.BackColor = System.Drawing.Color.Transparent;
            this._result_message_data.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._result_message_data.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this._result_message_data.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this._result_message_data.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._result_message_data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this._result_message_data.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this._result_message_data.HoverColor = System.Drawing.Color.Transparent;
            this._result_message_data.ItemHeight = 30;
            this._result_message_data.ItemSelectBackColor = System.Drawing.Color.Transparent;
            this._result_message_data.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this._result_message_data.Location = new System.Drawing.Point(318, 55);
            this._result_message_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._result_message_data.Name = "_result_message_data";
            this._result_message_data.Padding = new System.Windows.Forms.Padding(7);
            this._result_message_data.Radius = 15;
            this._result_message_data.RectColor = System.Drawing.Color.White;
            this._result_message_data.RectDisableColor = System.Drawing.Color.White;
            this._result_message_data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._result_message_data.Size = new System.Drawing.Size(265, 273);
            this._result_message_data.Style = Sunny.UI.UIStyle.Custom;
            this._result_message_data.TabIndex = 23;
            this._result_message_data.Text = null;
            this._result_message_data.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _settings_
            // 
            this._settings_.Cursor = System.Windows.Forms.Cursors.Hand;
            this._settings_.Image = ((System.Drawing.Image)(resources.GetObject("_settings_.Image")));
            this._settings_.Location = new System.Drawing.Point(6, 21);
            this._settings_.Name = "_settings_";
            this._settings_.Size = new System.Drawing.Size(32, 32);
            this._settings_.TabIndex = 24;
            this._settings_.TabStop = false;
            this._settings_.Click += new System.EventHandler(this._settings__Click);
            // 
            // _Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 346);
            this.Controls.Add(this._settings_);
            this.Controls.Add(this._result_message_data);
            this.Controls.Add(this._date_picker_end);
            this.Controls.Add(this._date_picker_start);
            this.Controls.Add(this._btn_send_task_time);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Depiction_2);
            this.Controls.Add(this.Lab_01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_Main_Window";
            this.Text = "Intelligent Task Time By Straberry Ass";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this._settings_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Depiction_2;
        private Sunny.UI.UILabel Lab_01;
        private Sunny.UI.UILabel uiLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private Sunny.UI.UIButton _btn_send_task_time;
        private Sunny.UI.UIDatePicker _date_picker_start;
        private Sunny.UI.UIDatePicker _date_picker_end;
        private Sunny.UI.UIListBox _result_message_data;
        private System.Windows.Forms.PictureBox _settings_;
    }
}