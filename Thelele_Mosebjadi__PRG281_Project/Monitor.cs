using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;

using Thelele_Mosebjadi__PRG281_Project.Properties;

namespace Thelele_Mosebjadi__PRG281_Project
{
    public partial class Monitor : Form
    {
        //private static System.IO.FileSystemWatcher watcher;

        static StringBuilder output = new StringBuilder();
         

        public Monitor()
        {
            
            InitializeComponent();
        }

        //access to those files that have administrative access rights

      //  [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        //private static void RunWatcher()
        //{
        //    try
        //    {
                //output = new StringBuilder();

                //FileSystemWatcher watcher = new FileSystemWatcher();
                //watcher.Path = frmDirectMonitor.folderToMonitor;

                //watcher.NotifyFilter = System.IO.NotifyFilters.DirectoryName;

                //watcher.NotifyFilter = NotifyFilters.LastAccess
                //    | NotifyFilters.LastWrite
                //    | NotifyFilters.FileName
                //    | NotifyFilters.DirectoryName;


                ////events handlers
                //watcher.Created += watcher_Created;
                //watcher.Deleted += watcher_Deleted;
                //watcher.Changed += watcher_Changed;
                //watcher.Renamed += watcher_Renamed;
                //watcher.Error += watcher_Error;






                ////begin watching
                //bool subDir = false;

                //subDir = frmDirectMonitor.isChecked;

                //if (subDir == true)
                //{
                //    watcher.IncludeSubdirectories = true;
                //}

                //else if (subDir == false)
                //{
                //    watcher.IncludeSubdirectories = false;
                //}
                //try
                //{
                //    watcher.EnableRaisingEvents = true;

                //}
                //catch (Exception err)
                //{
                //    MessageBox.Show(err.Message);
                //    watcher.EnableRaisingEvents = false;
                //}
            //}

            //catch (Exception errx)
            //{
            //    MessageBox.Show(errx.Message);
            //}
            
        //}

        //defining event handlers
        static void watcher_Error(object sender, System.IO.ErrorEventArgs e)
        {

            try
            {
                //string error = null;
                Exception exc = e.GetException();
                MessageBox.Show(exc.Message);
                  
                if (exc.InnerException != null)
                {
                    MessageBox.Show(exc.Message);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        static void watcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {

            try
            {
                string rename = null;
                rename = string.Format("File renamed. Old name: {0} \t New name: {1} ", e.OldName, e.Name);
                //input into stringbuilder

               output.Remove(0,output.Length);
               output.Append(e.FullPath);
               output.Append(" ");
               output.Append(rename);
               output.Append("    ");
               output.Append(DateTime.Now.ToString());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        static void watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

            try
            {
                string change = null;

                change = string.Format("A change occurred in the monitored directory. Change type: {0} \t File name: {1}", e.ChangeType, e.Name);

                output.Remove(0, output.Length);
                output.Append(e.FullPath);
                output.Append(" ");
                output.Append(change);
                output.Append("    ");
                output.Append(DateTime.Now.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            

        }

        static void watcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                string delete = null;

                delete = string.Format("File deleted. Name: {0}", e.Name);

                output.Remove(0, output.Length);
                output.Append(e.FullPath);
                output.Append(" ");
                output.Append(delete);
                output.Append("    ");
                output.Append(DateTime.Now.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //throw new NotImplementedException();
        }

        static void watcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                string create = null;

                create = string.Format("File created. Name: {0}", e.Name);

                output.Remove(0, output.Length);
                output.Append(e.FullPath);
                output.Append(" ");
                output.Append(create);
                output.Append("    ");
                output.Append(DateTime.Now.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            //throw new NotImplementedException();
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            try
            {

               

                FileSystemWatcher watcher = new FileSystemWatcher();

                string getVal = string.Empty;
                getVal = frmDirectMonitor.folderToMonitor;

                watcher.Path = getVal;

              

                lblActivity.Text = "Activity of " + getVal;

                lblSub.Text = "Monitor subdirectories: " + frmDirectMonitor.isChecked.ToString();
                lblDate.Text = DateTime.Today.ToShortDateString();

                bool subDir = false;

                subDir = frmDirectMonitor.isChecked;

                if (subDir == true)
                {
                    watcher.IncludeSubdirectories = true;
                }

                else
                {
                    watcher.IncludeSubdirectories = false;
                }

                //declare file watcher
                //watcher.Filter = "*.*";
                watcher.NotifyFilter = System.IO.NotifyFilters.DirectoryName;

                watcher.NotifyFilter = NotifyFilters.LastAccess
                    | NotifyFilters.LastWrite
                    | NotifyFilters.FileName
                    | NotifyFilters.DirectoryName;


                //events handlers
                watcher.Created += watcher_Created;
                watcher.Deleted += watcher_Deleted;
                watcher.Changed += watcher_Changed;
                watcher.Renamed += watcher_Renamed;
                watcher.Error += watcher_Error;
                try
                {
                    watcher.EnableRaisingEvents = true;
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                    watcher.EnableRaisingEvents = false;
                }
                
                
                //begin watching

                //lstOutput.BeginUpdate();
                //lstOutput.Items.Add(output.ToString());
                //lstOutput.EndUpdate();

              

                
            }

            catch(Exception er)
            {
                MessageBox.Show(er.Message);

            }



            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmDirectMonitor main = new frmDirectMonitor();
            
            this.Close();
            main.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lstOutput.BeginUpdate();
            lstOutput.Items.Add(output.ToString());
            lstOutput.EndUpdate();
        }
    }
}
