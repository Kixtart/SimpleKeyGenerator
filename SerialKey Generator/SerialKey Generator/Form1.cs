using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SerialKey_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void OpenProgram_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
            if (folderBrowserDialog1.SelectedPath != "")
            ActionTime.Enabled = true;
        }
        private void GenSerialKey_Click(object sender, EventArgs e)
        {
            SKGL.Generate generate = new SKGL.Generate();
            generate.secretPhase = Password.Text;
            SerialKey.Text = generate.doKey(Convert.ToInt32(ActionTime.Text));
           
        }

        private void ValidateSerialKey_Click(object sender, EventArgs e)
        {
            SKGL.Validate validate = new SKGL.Validate();
            validate.secretPhase = Password.Text;
            validate.Key = SerialKey.Text;
            ValidateReport.Text = "Дата создания: " + validate.CreationDate +
              "\r\n" + "Дата истекания: " + validate.ExpireDate + " \r\n"
                + "Дней осталось: " + validate.DaysLeft;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActionTime.Enabled = false;
            Password.Enabled = false;
            SerialKey.Enabled = false;
            ValidateReport.Enabled = false;
            GenSerialKey.Enabled = false;
            ValidateSerialKey.Enabled = false;
        }
        private void ActionTime_TextChanged(object sender, EventArgs e)
        {
          string pattern = @"\d$";
          if (Regex.IsMatch(ActionTime.Text, pattern) == false)
          ActionTime.Text = "";
          else
          {
              Password.Enabled = true;
              SerialKey.Enabled = true;
              ValidateReport.Enabled = true;
              GenSerialKey.Enabled = true;
              ValidateSerialKey.Enabled = true;
          }
            
        }
        
        
        
    }
}
