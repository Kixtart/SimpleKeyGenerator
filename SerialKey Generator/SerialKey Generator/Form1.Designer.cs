namespace SerialKey_Generator
{
    partial class Form1
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
            this.GenSerialKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SerialKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValidateReport = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.ValidateSerialKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenSerialKey
            // 
            this.GenSerialKey.Location = new System.Drawing.Point(324, 122);
            this.GenSerialKey.Name = "GenSerialKey";
            this.GenSerialKey.Size = new System.Drawing.Size(107, 40);
            this.GenSerialKey.TabIndex = 0;
            this.GenSerialKey.Text = "Сгенерировать";
            this.GenSerialKey.UseVisualStyleBackColor = true;
            this.GenSerialKey.Click += new System.EventHandler(this.GenSerialKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время действия серийного ключа (дни):";
            // 
            // ActionTime
            // 
            this.ActionTime.Location = new System.Drawing.Point(361, 27);
            this.ActionTime.Name = "ActionTime";
            this.ActionTime.Size = new System.Drawing.Size(70, 20);
            this.ActionTime.TabIndex = 2;
            this.ActionTime.TextChanged += new System.EventHandler(this.ActionTime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Серийный ключ:";
            // 
            // SerialKey
            // 
            this.SerialKey.Location = new System.Drawing.Point(104, 96);
            this.SerialKey.Name = "SerialKey";
            this.SerialKey.ReadOnly = true;
            this.SerialKey.Size = new System.Drawing.Size(327, 20);
            this.SerialKey.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчет:";
            // 
            // ValidateReport
            // 
            this.ValidateReport.Location = new System.Drawing.Point(65, 168);
            this.ValidateReport.Multiline = true;
            this.ValidateReport.Name = "ValidateReport";
            this.ValidateReport.Size = new System.Drawing.Size(366, 103);
            this.ValidateReport.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(104, 64);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(327, 20);
            this.Password.TabIndex = 9;
            this.Password.UseSystemPasswordChar = true;
            // 
            // ValidateSerialKey
            // 
            this.ValidateSerialKey.Location = new System.Drawing.Point(316, 277);
            this.ValidateSerialKey.Name = "ValidateSerialKey";
            this.ValidateSerialKey.Size = new System.Drawing.Size(115, 40);
            this.ValidateSerialKey.TabIndex = 10;
            this.ValidateSerialKey.Text = "Проверка действительности";
            this.ValidateSerialKey.UseVisualStyleBackColor = true;
            this.ValidateSerialKey.Click += new System.EventHandler(this.ValidateSerialKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 321);
            this.Controls.Add(this.ValidateSerialKey);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ValidateReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SerialKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActionTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenSerialKey);
            this.Name = "Form1";
            this.Text = "SerialKey Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenSerialKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ActionTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SerialKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValidateReport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ValidateSerialKey;
    }
}

