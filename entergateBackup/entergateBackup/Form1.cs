using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
namespace entergateBackup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void startbutton_Click(object sender, EventArgs e)
        //{
            //    string targetpath = ConfigurationManager.AppSettings["targetpath"];
            //    string cwd = Directory.GetCurrentDirectory();
            //    Console.WriteLine(cwd);
            //    string backupspath = Directory.GetParent(cwd).Parent.FullName;
            //    Console.WriteLine(backupspath);
            //    string backuptargets = File.ReadAllText(backupspath + "/backups.txt");
            //    Console.WriteLine(backuptargets);
       private void startbutton_Click(object sender, EventArgs e) {
            string source = pathtextbox.Text; 
            string dest = pathtextbox2.Text;
            string import = "backupfolder";
            string sourceimportdirectory = Path.Combine(source, import);
            string destimportdirectory = Path.Combine(dest, import);
            DirectoryInfo di = new DirectoryInfo(sourceimportdirectory);
            DirectoryInfo dis = new DirectoryInfo(destimportdirectory);

            if(di.Exists == true)
            {
                if(dis.Exists == false)
                {
                    Directory.CreateDirectory(destimportdirectory);

                }
            }
       }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathtextbox.Text = ofd.SelectedPath;
            }
        }

        private void backupbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathtextbox2.Text = ofd.SelectedPath;
            }
        }
    }
}
