using System.Windows.Forms;

namespace WorkClock
{

    partial class Displej
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
            this.txtTaskName = new System.Windows.Forms.RichTextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.taskListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskName.Location = new System.Drawing.Point(74, 16);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.txtTaskName.Multiline = false;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtTaskName.Size = new System.Drawing.Size(400, 16);
            this.txtTaskName.TabIndex = 1;
            this.txtTaskName.Text = "";
            this.txtTaskName.WordWrap = false;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.Location = new System.Drawing.Point(9, 14);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(51, 15);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "My task:";
            this.labelTask.Click += new System.EventHandler(this.labelTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(494, 12);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(97, 23);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "START NOW";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.Location = new System.Drawing.Point(11, 74);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(92, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkRed;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(494, 74);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(64, 12);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(421, 22);
            this.richTextBox1.TabIndex = 77;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Location = new System.Drawing.Point(11, 103);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(580, 207);
            this.richTextBox2.TabIndex = 78;
            this.richTextBox2.Text = "";
            // 
            // listView1
            // 
            this.taskListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.taskListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskListView.CheckBoxes = true;
            this.taskListView.FullRowSelect = true;
            this.taskListView.GridLines = true;
            this.taskListView.HideSelection = false;
            this.taskListView.LabelWrap = false;
            this.taskListView.Location = new System.Drawing.Point(22, 114);
            this.taskListView.MultiSelect = false;
            this.taskListView.Name = "listView1";
            this.taskListView.Size = new System.Drawing.Size(557, 187);
            this.taskListView.TabIndex = 79;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.List;
            // 
            // Displej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 322);
            this.Controls.Add(this.taskListView);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Name = "Displej";
            this.Text = "WorkClock";
            this.Load += new System.EventHandler(this.Displej_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtTaskName;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private ListView taskListView;
    }
}

