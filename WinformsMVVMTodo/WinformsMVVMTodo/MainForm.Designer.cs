namespace WinformsMVVMTodo
{
    partial class MainForm
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
            this.button_Add = new System.Windows.Forms.Button();
            this.listBox_Tasks = new System.Windows.Forms.ListBox();
            this.textBox_Task = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox_Tasks = new System.Windows.Forms.GroupBox();
            this.label_ToDoList = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_Tasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Add.Location = new System.Drawing.Point(282, 724);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(144, 29);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // listBox_Tasks
            // 
            this.listBox_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Tasks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox_Tasks.FormattingEnabled = true;
            this.listBox_Tasks.ItemHeight = 21;
            this.listBox_Tasks.Location = new System.Drawing.Point(3, 29);
            this.listBox_Tasks.Margin = new System.Windows.Forms.Padding(10);
            this.listBox_Tasks.Name = "listBox_Tasks";
            this.listBox_Tasks.Size = new System.Drawing.Size(562, 633);
            this.listBox_Tasks.TabIndex = 2;
            // 
            // textBox_Task
            // 
            this.textBox_Task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Task.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Task.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Task.Location = new System.Drawing.Point(8, 724);
            this.textBox_Task.Name = "textBox_Task";
            this.textBox_Task.PlaceholderText = "Task";
            this.textBox_Task.Size = new System.Drawing.Size(268, 29);
            this.textBox_Task.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.button_Delete, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_Add, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Task, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_Tasks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_ToDoList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 761);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // button_Delete
            // 
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Delete.Location = new System.Drawing.Point(432, 724);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(144, 29);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // groupBox_Tasks
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox_Tasks, 3);
            this.groupBox_Tasks.Controls.Add(this.listBox_Tasks);
            this.groupBox_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Tasks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Tasks.Location = new System.Drawing.Point(8, 53);
            this.groupBox_Tasks.Name = "groupBox_Tasks";
            this.groupBox_Tasks.Size = new System.Drawing.Size(568, 665);
            this.groupBox_Tasks.TabIndex = 4;
            this.groupBox_Tasks.TabStop = false;
            this.groupBox_Tasks.Text = "Tasks";
            // 
            // label_ToDoList
            // 
            this.label_ToDoList.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label_ToDoList, 3);
            this.label_ToDoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ToDoList.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ToDoList.Location = new System.Drawing.Point(8, 5);
            this.label_ToDoList.Name = "label_ToDoList";
            this.label_ToDoList.Size = new System.Drawing.Size(568, 45);
            this.label_ToDoList.TabIndex = 5;
            this.label_ToDoList.Text = "Todo List";
            this.label_ToDoList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms MVVM Todo";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox_Tasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button_Add;
        private ListBox listBox_Tasks;
        private TextBox textBox_Task;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_Delete;
        private GroupBox groupBox_Tasks;
        private Label label_ToDoList;
    }
}