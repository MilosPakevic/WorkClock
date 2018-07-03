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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.taskListView = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.selectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(76, 16);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.txtTaskName.Multiline = false;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtTaskName.Size = new System.Drawing.Size(419, 17);
            this.txtTaskName.TabIndex = 0;
            this.txtTaskName.Text = "";
            this.txtTaskName.WordWrap = false;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.Location = new System.Drawing.Point(9, 14);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(51, 15);
            this.labelTask.TabIndex = 99;
            this.labelTask.Text = "My task:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(12, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 26);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START NOW";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDelete
            // 
            this.btnDismiss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDismiss.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDismiss.Location = new System.Drawing.Point(516, 41);
            this.btnDismiss.Name = "btnDelete";
            this.btnDismiss.Size = new System.Drawing.Size(75, 26);
            this.btnDismiss.TabIndex = 4;
            this.btnDismiss.Text = "Dismiss";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.DarkRed;
            this.btnStop.Location = new System.Drawing.Point(121, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 26);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(64, 12);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(443, 25);
            this.richTextBox1.TabIndex = 77;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(11, 103);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(580, 207);
            this.richTextBox2.TabIndex = 78;
            this.richTextBox2.Text = "";
            // 
            // taskListView
            // 
            this.taskListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.taskListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskListView.CheckBoxes = true;
            this.taskListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListView.FullRowSelect = true;
            this.taskListView.GridLines = true;
            this.taskListView.HideSelection = false;
            this.taskListView.LabelWrap = false;
            this.taskListView.Location = new System.Drawing.Point(22, 114);
            this.taskListView.MultiSelect = false;
            this.taskListView.Name = "taskListView";
            this.taskListView.Size = new System.Drawing.Size(557, 187);
            this.taskListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.taskListView.TabIndex = 79;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.Details;
            this.taskListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.taskListView_ItemChecked);
            this.taskListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.taskListView_ItemSelectionChanged);
            this.taskListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskListView_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(516, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // selectAll
            // 
            this.selectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAll.Location = new System.Drawing.Point(516, 71);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(75, 26);
            this.selectAll.TabIndex = 100;
            this.selectAll.Text = "Select all";
            this.selectAll.UseVisualStyleBackColor = true;
            // 
            // Displej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 322);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.taskListView);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnStart);
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private ListView taskListView;
        private Button btnAdd;
        private Button selectAll;
    }
}

