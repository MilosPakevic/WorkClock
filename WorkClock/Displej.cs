using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace WorkClock
{
    public partial class Displej : Form
    {
        public Displej()
        {
            InitializeComponent();

            // 
            // taskListView
            // 
            this.taskListView.Columns.Add("Task name", 240);
            this.taskListView.Columns.Add("Started", 100);
            this.taskListView.Columns.Add("Ended", 100);
            this.taskListView.Columns.Add("Time spent", 100);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }

        private void Displej_Load(object sender, EventArgs e)
        {

        }

        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in taskListView.Items)
            {
                if (item.Checked) DoAction(Akcija.dismiss,item);
            }
        }

        private void taskListView_DoubleClick(object sender, EventArgs e) {
            DoAction(Akcija.selectOne, taskListView.FocusedItem);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DoAction(Akcija.selectNone, taskListView.FocusedItem);
        }

        private void taskListView_ItemSelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string txt = txtTaskName.Text;
            if (!String.IsNullOrEmpty(txt))
            {
                bool existingEntry = false;
                foreach (ListViewItem item in taskListView.Items)
                {
                    if (item.Text != null && item.Text.Trim().ToLower() == txt.Trim().ToLower())
                    {
                        existingEntry = true;
                        if (!item.Checked)
                        {
                            item.Checked = true;
                            item.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            //ovde ponovni start
                        }
                        break;
                    }
                }
                if (existingEntry)
                {
                    //already exists
                }
                else
                {
                    foreach (ListViewItem item in taskListView.Items)
                    {
                        item.Checked = false;
                        item.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                    ListViewItem newItem = new ListViewItem
                    {
                        Text = txt,
                        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        Checked = true
                    };
                    txtTaskName.Text = "";
                    this.taskListView.Items.Add(newItem);
                }
            }
            else
            {
                //Ovde moze validacija
            }
        }
        public void taskListView_ItemChecked(object sender, EventArgs e)
        {
            
        }
    }
}
