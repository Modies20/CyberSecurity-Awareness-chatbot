using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSecurity_Awareness_chatbot
{
    public partial class AssistantForm : Form
    {
        public AssistantForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.lblTask = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblReminder = new System.Windows.Forms.Label();
            this.dtReminder = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(194, 42);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(70, 16);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Task Title:";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(270, 42);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(267, 22);
            this.txtTask.TabIndex = 1;
            this.txtTask.TextChanged += new System.EventHandler(this.txtTask_TextChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(194, 86);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(78, 16);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(270, 86);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(267, 56);
            this.txtDesc.TabIndex = 3;
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Location = new System.Drawing.Point(163, 171);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(101, 16);
            this.lblReminder.TabIndex = 4;
            this.lblReminder.Text = "Reminder Date:";
            // 
            // dtReminder
            // 
            this.dtReminder.Location = new System.Drawing.Point(270, 171);
            this.dtReminder.Name = "dtReminder";
            this.dtReminder.Size = new System.Drawing.Size(267, 22);
            this.dtReminder.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // taskList
            // 
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 16;
            this.taskList.Location = new System.Drawing.Point(166, 280);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(371, 84);
            this.taskList.TabIndex = 7;
            // 
            // AssistantForm
            // 
            this.ClientSize = new System.Drawing.Size(744, 393);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtReminder);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTask);
            this.Name = "AssistantForm";
            this.Load += new System.EventHandler(this.AssistantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssistantForm_Load(object sender, EventArgs e)
        {

        }
        private List<string> taskLog = new List<string>();
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string taskTitle = txtTask.Text.Trim();
            string description = txtDesc.Text.Trim();
            DateTime reminderDate = dtReminder.Value;

            if (string.IsNullOrEmpty(taskTitle))
            {
                MessageBox.Show("Please enter a task title.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string taskSummary = $"{taskTitle} - {description} (Due: {reminderDate.ToShortDateString()})";
            taskLog.Add(taskSummary);
            taskList.Items.Add(taskSummary);

            // Optional: Clear input fields after adding
            txtTask.Clear();
            txtDesc.Clear();
            dtReminder.Value = DateTime.Now;
        }
    }
}