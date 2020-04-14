namespace FacultyEventPlanner
{
    partial class MyEvents
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
            this.label1 = new System.Windows.Forms.Label();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.saveEditBtn = new System.Windows.Forms.Button();
            this.timeCB = new System.Windows.Forms.ComboBox();
            this.locCB = new System.Windows.Forms.ComboBox();
            this.depCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.capTxt = new System.Windows.Forms.TextBox();
            this.Capacity = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.eventsCLB = new System.Windows.Forms.CheckedListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.eventsPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Events";
            // 
            // eventsPanel
            // 
            this.eventsPanel.Controls.Add(this.delBtn);
            this.eventsPanel.Controls.Add(this.editBtn);
            this.eventsPanel.Controls.Add(this.eventsCLB);
            this.eventsPanel.Location = new System.Drawing.Point(45, 72);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(959, 598);
            this.eventsPanel.TabIndex = 1;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.cancelBtn);
            this.editPanel.Controls.Add(this.saveEditBtn);
            this.editPanel.Controls.Add(this.timeCB);
            this.editPanel.Controls.Add(this.locCB);
            this.editPanel.Controls.Add(this.depCB);
            this.editPanel.Controls.Add(this.label7);
            this.editPanel.Controls.Add(this.Time);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.capTxt);
            this.editPanel.Controls.Add(this.Capacity);
            this.editPanel.Controls.Add(this.descriptionTxt);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.titleTxt);
            this.editPanel.Location = new System.Drawing.Point(45, 72);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(956, 598);
            this.editPanel.TabIndex = 2;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.Location = new System.Drawing.Point(472, 427);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(213, 58);
            this.saveEditBtn.TabIndex = 40;
            this.saveEditBtn.Text = "save edit and send request";
            this.saveEditBtn.UseVisualStyleBackColor = true;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // timeCB
            // 
            this.timeCB.FormattingEnabled = true;
            this.timeCB.Location = new System.Drawing.Point(219, 223);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(466, 24);
            this.timeCB.TabIndex = 39;
            this.timeCB.SelectedIndexChanged += new System.EventHandler(this.timeCB_SelectedIndexChanged);
            // 
            // locCB
            // 
            this.locCB.FormattingEnabled = true;
            this.locCB.Location = new System.Drawing.Point(219, 179);
            this.locCB.Name = "locCB";
            this.locCB.Size = new System.Drawing.Size(466, 24);
            this.locCB.TabIndex = 38;
            this.locCB.SelectedIndexChanged += new System.EventHandler(this.locCB_SelectedIndexChanged);
            // 
            // depCB
            // 
            this.depCB.FormattingEnabled = true;
            this.depCB.Location = new System.Drawing.Point(219, 279);
            this.depCB.Name = "depCB";
            this.depCB.Size = new System.Drawing.Size(466, 24);
            this.depCB.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Department";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(69, 223);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 17);
            this.Time.TabIndex = 33;
            this.Time.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Location";
            // 
            // capTxt
            // 
            this.capTxt.Location = new System.Drawing.Point(219, 130);
            this.capTxt.Name = "capTxt";
            this.capTxt.Size = new System.Drawing.Size(466, 22);
            this.capTxt.TabIndex = 31;
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(69, 130);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(62, 17);
            this.Capacity.TabIndex = 30;
            this.Capacity.Text = "Capacity";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(219, 85);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(466, 22);
            this.descriptionTxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Event Title";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(219, 38);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(466, 22);
            this.titleTxt.TabIndex = 26;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(236, 279);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(188, 56);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(18, 279);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(188, 56);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // eventsCLB
            // 
            this.eventsCLB.FormattingEnabled = true;
            this.eventsCLB.Location = new System.Drawing.Point(18, 4);
            this.eventsCLB.Name = "eventsCLB";
            this.eventsCLB.Size = new System.Drawing.Size(679, 242);
            this.eventsCLB.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(219, 427);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 58);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // MyEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 703);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.label1);
            this.Name = "MyEvents";
            this.Text = "MyEvents";
            this.Load += new System.EventHandler(this.MyEvents_Load);
            this.eventsPanel.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel eventsPanel;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.CheckedListBox eventsCLB;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.ComboBox timeCB;
        private System.Windows.Forms.ComboBox locCB;
        private System.Windows.Forms.ComboBox depCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capTxt;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Button saveEditBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}