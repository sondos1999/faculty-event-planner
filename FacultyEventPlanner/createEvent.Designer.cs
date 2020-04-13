namespace FacultyEventPlanner
{
    partial class createEvent
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.Capacity = new System.Windows.Forms.Label();
            this.capTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.depCB = new System.Windows.Forms.ComboBox();
            this.hostCLB = new System.Windows.Forms.CheckedListBox();
            this.locCB = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.timeCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(189, 54);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(466, 22);
            this.titleTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(189, 101);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(466, 22);
            this.descriptionTxt.TabIndex = 3;
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(39, 146);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(62, 17);
            this.Capacity.TabIndex = 4;
            this.Capacity.Text = "Capacity";
            // 
            // capTxt
            // 
            this.capTxt.Location = new System.Drawing.Point(189, 146);
            this.capTxt.Name = "capTxt";
            this.capTxt.Size = new System.Drawing.Size(466, 22);
            this.capTxt.TabIndex = 5;
            this.capTxt.TextChanged += new System.EventHandler(this.capTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(39, 239);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 17);
            this.Time.TabIndex = 8;
            this.Time.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Co-host";
            // 
            // depCB
            // 
            this.depCB.FormattingEnabled = true;
            this.depCB.Location = new System.Drawing.Point(189, 362);
            this.depCB.Name = "depCB";
            this.depCB.Size = new System.Drawing.Size(466, 24);
            this.depCB.TabIndex = 18;
            // 
            // hostCLB
            // 
            this.hostCLB.FormattingEnabled = true;
            this.hostCLB.Location = new System.Drawing.Point(189, 400);
            this.hostCLB.Name = "hostCLB";
            this.hostCLB.Size = new System.Drawing.Size(466, 72);
            this.hostCLB.TabIndex = 19;
            // 
            // locCB
            // 
            this.locCB.FormattingEnabled = true;
            this.locCB.Location = new System.Drawing.Point(189, 195);
            this.locCB.Name = "locCB";
            this.locCB.Size = new System.Drawing.Size(466, 24);
            this.locCB.TabIndex = 21;
            this.locCB.SelectedIndexChanged += new System.EventHandler(this.locCB_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(657, 497);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(144, 41);
            this.btn.TabIndex = 24;
            this.btn.Text = "Request Event";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // timeCB
            // 
            this.timeCB.FormattingEnabled = true;
            this.timeCB.Location = new System.Drawing.Point(189, 239);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(466, 24);
            this.timeCB.TabIndex = 25;
            // 
            // createEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 550);
            this.Controls.Add(this.timeCB);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.locCB);
            this.Controls.Add(this.hostCLB);
            this.Controls.Add(this.depCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capTxt);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTxt);
            this.Name = "createEvent";
            this.Text = "createEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.createEvent_FormClosed);
            this.Load += new System.EventHandler(this.createEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.TextBox capTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox depCB;
        private System.Windows.Forms.CheckedListBox hostCLB;
        private System.Windows.Forms.ComboBox locCB;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox timeCB;
    }
}