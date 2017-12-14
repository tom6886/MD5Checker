using System;
using System.IO;
using System.Windows.Forms;

namespace MD5Reader
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private double progress;

        private DateTime beginTime;

        public Form1()
        {
            InitializeComponent();

            memoEdit1.ReadOnly = true;
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            //ofd.Filter = "Image Files(*.JPG;*.PNG;*.jpeg;*.GIF;*.BMP)|*.JPG;*.PNG;*.GIF;*.BMP;*.jpeg|All files(*.*)|*.*";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(ofd.FileName)) { memoEdit1.Text = "未找到指定文件！"; return; }

                FileInfo file = new FileInfo(ofd.FileName);

                double length = Math.Ceiling(file.Length / 1024.0);

                if (length < 102400 * 10)
                {
                    beginTime = DateTime.Now;
                    string md5Str = MD5Checker.Check(ofd.FileName);
                    memoEdit1.Text = "验算完成，MD5值：" + md5Str + "\r\n";
                    memoEdit1.MaskBox.AppendText("验算耗费时间：" + (DateTime.Now - beginTime).TotalSeconds + "s");
                }
                else
                {
                    memoEdit1.Text = "文件大小超过1G，开启异步计算\r\n";
                    progress = 0;
                    beginTime = DateTime.Now;
                    MD5Checker checker = new MD5Checker();
                    checker.AsyncCheckProgress += Checker_AsyncCheckProgress;
                    checker.AsyncCheck(ofd.FileName);
                }
            }
        }

        private void Checker_AsyncCheckProgress(AsyncCheckEventArgs e)
        {
            if (e.State == AsyncCheckState.Checking)
            {
                double pro = Convert.ToDouble(e.Value);
                if (pro - progress < 1) { return; }
                progress = pro;
                SetEdit("验算进度：" + pro + "%\r\n");
            }
            else
            {
                SetEdit("验算完成，MD5值：" + e.Value + "\r\n");
                SetEdit("验算耗费时间：" + (DateTime.Now - beginTime).TotalSeconds + "s");
            }
        }

        private delegate void setEdit(string text);

        private void SetEdit(string text)
        {
            if (memoEdit1.InvokeRequired)
            {
                BeginInvoke(new setEdit(SetEdit), text);
            }
            else
            {
                memoEdit1.MaskBox.AppendText(text);
            }
        }
    }
}
