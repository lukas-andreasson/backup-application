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
using System.IO.Compression;

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

            string date = DateTime.Now.ToString();

            if (source == "" || dest == "")
            {
                throw new Exception("you need to input paths");
            }


            date = date.Replace(":", ".");

            //string name = "backup - " + date + ".zip";
            string name = $"backup-{date}.zip";
            string destimportdirectory = Path.Combine(dest, name);

            

            if(Directory.Exists(source))
            {
                if(!Directory.Exists(destimportdirectory))
                {
                    ZipFile.CreateFromDirectory(source, destimportdirectory);
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

        private void pathtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
