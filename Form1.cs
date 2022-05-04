using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CPAU
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            StreamReader fileReader = new StreamReader(@"account.txt");
            string Text = fileReader.ReadToEnd();
            accountText.Text = Text;
        }

        private void ExportB_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            string account;
            string pass;
            string path;
            string keyN;
            account = accountText.Text;
            pass = PasswdText.Text;
            path = PathText.Text;
            keyN = KeyText.Text;

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;// 接受來自呼叫程式的輸入資訊
            p.StartInfo.RedirectStandardOutput = true;// 由呼叫程式獲取輸出資訊
            p.StartInfo.RedirectStandardError = true;//重定向標準錯誤輸出
            p.StartInfo.CreateNoWindow = true; //不跳出cmd視窗
            p.Start();// 啟動程式
            p.StandardInput.WriteLine($"CPAU.exe -u {account} -p {pass} -ex \"{path}\" -enc -file {keyN}.key");//向cmd視窗傳送輸入資訊
            p.Close();//關閉程式


            string bat = $"CPAU.exe -dec -file {keyN}.key -lwp";
            File.WriteAllText($"{keyN}.bat", bat, Encoding.GetEncoding(936));

            EndLab.Text = $"已生成{keyN}.key";
        }
    }
}
