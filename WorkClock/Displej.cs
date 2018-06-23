using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkClock
{
    public partial class Displej : Form
    {
        public Displej()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttTaskName_Popup(object sender, PopupEventArgs e)
        {

        }

        private void labelTask_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string txt = txtTaskName.Text;
            if (String.IsNullOrEmpty(txt))
            {
                //Ovde moze required validacija
            }
            else
            {
                this.taskListView.SelectedItems.Clear();
                this.taskListView.Items.Add(new ListViewItem(txt)).Checked=true;
            }
        }

        private void Displej_Load(object sender, EventArgs e)
        {

        }

        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
