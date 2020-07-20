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
using System.Threading;

namespace Thelele_Mosebjadi__PRG281_Project
{
    public partial class frmDirectMonitor : Form
    {
        public static string folderToMonitor = string.Empty;
        public static bool isChecked = false;

        public frmDirectMonitor()
        {
            InitializeComponent();
        }

        private void frmDirectMonitor_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                lstDrive.Items.Add(drive);
            }

            pBar.Visible = false;
        }

        //select folder to monitor
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (lstFolder.SelectedItem == null)
            {
                MessageBox.Show("Choose folder to monitor from the list", "Empty Field", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (lstFolder.SelectedItem != null)
            {
                txtFolder.Text = lstDrive.SelectedItem.ToString() + lstFolder.SelectedItem.ToString();
                folderToMonitor = txtFolder.Text;
            }
           
         
            
        }

        private void lstDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFolder.Items.Clear();
            //catch exception if drive is bot ready for use or unavailable
            try
            {
                DriveInfo dr = (DriveInfo)lstDrive.SelectedItem;
                foreach (DirectoryInfo dirInfo in dr.RootDirectory.GetDirectories())
                {
                    lstFolder.Items.Add(dirInfo);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void lstFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();

            DirectoryInfo dir = (DirectoryInfo)lstFolder.SelectedItem;

            //catch any unauthorised access exceptions
            try
            {
                foreach (FileInfo fi in dir.GetFiles())
                {
                    lstFiles.Items.Add(fi);
                }


                


            }
            catch(Exception ex)
            {
             
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            //this.Update();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            if (txtFolder.Text != string.Empty)
            {

                Monitor mon = new Monitor();

                if (chkSub.Checked)
                {
                    isChecked = true;
                }

                else if (!chkSub.Checked)
                {
                    isChecked = false;
                }

                Thread.Sleep(1000);
                mon.Show();
                this.Hide();
                btnMonitor.Enabled = false;

                
            }
            else if (txtFolder.Text == string.Empty)
            {
                txtFolder.BackColor = Color.Red;
                MessageBox.Show("Choose folder to monitor", "Empty Field", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }
            txtFolder.BackColor = DefaultBackColor;

               
                

            // pBar.Visible = true;
            // pBar.Maximum = 2;
            //pBar.Step = 1;
            // pBar.PerformStep();
            // pBar.Value+= 1;

            //if (pBar.Value == 2)
            //{
            //}
              
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }
    }
}
