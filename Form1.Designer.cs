namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.selectPort = new System.Windows.Forms.Button();
            this.led_btn_on_1 = new System.Windows.Forms.Button();
            this.led_btn_off_1 = new System.Windows.Forms.Button();
            this.led_btn_on_2 = new System.Windows.Forms.Button();
            this.led_btn_off_2 = new System.Windows.Forms.Button();
            this.textout = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comPorts
            // 
            this.comPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.comPorts.Location = new System.Drawing.Point(12, 32);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(121, 26);
            this.comPorts.TabIndex = 0;
            // 
            // selectPort
            // 
            this.selectPort.Location = new System.Drawing.Point(139, 32);
            this.selectPort.Name = "selectPort";
            this.selectPort.Size = new System.Drawing.Size(121, 26);
            this.selectPort.TabIndex = 1;
            this.selectPort.Text = "연결";
            this.selectPort.UseVisualStyleBackColor = true;
            this.selectPort.Click += new System.EventHandler(this.selectPort_Click);
            // 
            // led_btn_on_1
            // 
            this.led_btn_on_1.Location = new System.Drawing.Point(12, 88);
            this.led_btn_on_1.Name = "led_btn_on_1";
            this.led_btn_on_1.Size = new System.Drawing.Size(121, 72);
            this.led_btn_on_1.TabIndex = 2;
            this.led_btn_on_1.Text = "LED_01 ON";
            this.led_btn_on_1.UseVisualStyleBackColor = true;
            this.led_btn_on_1.Click += new System.EventHandler(this.led_btn_on_1_Click);
            // 
            // led_btn_off_1
            // 
            this.led_btn_off_1.Location = new System.Drawing.Point(139, 88);
            this.led_btn_off_1.Name = "led_btn_off_1";
            this.led_btn_off_1.Size = new System.Drawing.Size(121, 72);
            this.led_btn_off_1.TabIndex = 3;
            this.led_btn_off_1.Text = "LED_01 OFF";
            this.led_btn_off_1.UseVisualStyleBackColor = true;
            this.led_btn_off_1.Click += new System.EventHandler(this.led_btn_off_1_Click);
            // 
            // led_btn_on_2
            // 
            this.led_btn_on_2.Location = new System.Drawing.Point(12, 166);
            this.led_btn_on_2.Name = "led_btn_on_2";
            this.led_btn_on_2.Size = new System.Drawing.Size(121, 72);
            this.led_btn_on_2.TabIndex = 4;
            this.led_btn_on_2.Text = "LED_02 ON";
            this.led_btn_on_2.UseVisualStyleBackColor = true;
            this.led_btn_on_2.Click += new System.EventHandler(this.led_btn_on_2_Click);
            // 
            // led_btn_off_2
            // 
            this.led_btn_off_2.Location = new System.Drawing.Point(139, 166);
            this.led_btn_off_2.Name = "led_btn_off_2";
            this.led_btn_off_2.Size = new System.Drawing.Size(121, 72);
            this.led_btn_off_2.TabIndex = 5;
            this.led_btn_off_2.Text = "LED_02 OFF";
            this.led_btn_off_2.UseVisualStyleBackColor = true;
            this.led_btn_off_2.Click += new System.EventHandler(this.led_btn_off_2_Click);
            // 
            // textout
            // 
            this.textout.Enabled = false;
            this.textout.Location = new System.Drawing.Point(118, 286);
            this.textout.Name = "textout";
            this.textout.Size = new System.Drawing.Size(202, 28);
            this.textout.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Massage : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 372);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textout);
            this.Controls.Add(this.led_btn_off_2);
            this.Controls.Add(this.led_btn_on_2);
            this.Controls.Add(this.led_btn_off_1);
            this.Controls.Add(this.led_btn_on_1);
            this.Controls.Add(this.selectPort);
            this.Controls.Add(this.comPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Button selectPort;
        private System.Windows.Forms.Button led_btn_on_1;
        private System.Windows.Forms.Button led_btn_off_1;
        private System.Windows.Forms.Button led_btn_on_2;
        private System.Windows.Forms.Button led_btn_off_2;
        private System.Windows.Forms.TextBox textout;
        private System.Windows.Forms.TextBox textBox2;
    }
}

