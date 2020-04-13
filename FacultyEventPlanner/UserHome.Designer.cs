namespace FacultyEventPlanner
{
    partial class UserHome
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
            this.createEventBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myViolationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsDGV = new System.Windows.Forms.DataGridView();
            this.depComboBox = new System.Windows.Forms.ComboBox();
            this.depLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // createEventBtn
            // 
            this.createEventBtn.Location = new System.Drawing.Point(842, 60);
            this.createEventBtn.Name = "createEventBtn";
            this.createEventBtn.Size = new System.Drawing.Size(125, 48);
            this.createEventBtn.TabIndex = 0;
            this.createEventBtn.Text = "create event";
            this.createEventBtn.UseVisualStyleBackColor = true;
            this.createEventBtn.Click += new System.EventHandler(this.createEventBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.myEventsToolStripMenuItem,
            this.myRequestsToolStripMenuItem,
            this.myViolationsToolStripMenuItem});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.myAccountToolStripMenuItem.Text = "My account";
            // 
            // myEventsToolStripMenuItem
            // 
            this.myEventsToolStripMenuItem.Name = "myEventsToolStripMenuItem";
            this.myEventsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.myEventsToolStripMenuItem.Text = "My events";
            this.myEventsToolStripMenuItem.Click += new System.EventHandler(this.myEventsToolStripMenuItem_Click);
            // 
            // myRequestsToolStripMenuItem
            // 
            this.myRequestsToolStripMenuItem.Name = "myRequestsToolStripMenuItem";
            this.myRequestsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.myRequestsToolStripMenuItem.Text = "My requests";
            // 
            // myViolationsToolStripMenuItem
            // 
            this.myViolationsToolStripMenuItem.Name = "myViolationsToolStripMenuItem";
            this.myViolationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.myViolationsToolStripMenuItem.Text = "My violations";
            // 
            // eventsDGV
            // 
            this.eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDGV.Location = new System.Drawing.Point(12, 272);
            this.eventsDGV.Name = "eventsDGV";
            this.eventsDGV.RowHeadersWidth = 51;
            this.eventsDGV.RowTemplate.Height = 24;
            this.eventsDGV.Size = new System.Drawing.Size(1023, 432);
            this.eventsDGV.TabIndex = 2;
            // 
            // depComboBox
            // 
            this.depComboBox.FormattingEnabled = true;
            this.depComboBox.Location = new System.Drawing.Point(713, 226);
            this.depComboBox.Name = "depComboBox";
            this.depComboBox.Size = new System.Drawing.Size(322, 24);
            this.depComboBox.TabIndex = 3;
            this.depComboBox.SelectedIndexChanged += new System.EventHandler(this.depComboBox_SelectedIndexChanged);
            // 
            // depLbl
            // 
            this.depLbl.AutoSize = true;
            this.depLbl.Location = new System.Drawing.Point(554, 226);
            this.depLbl.Name = "depLbl";
            this.depLbl.Size = new System.Drawing.Size(89, 17);
            this.depLbl.TabIndex = 4;
            this.depLbl.Text = "Departments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Events";
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depLbl);
            this.Controls.Add(this.depComboBox);
            this.Controls.Add(this.eventsDGV);
            this.Controls.Add(this.createEventBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserHome_FormClosed);
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createEventBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myViolationsToolStripMenuItem;
        private System.Windows.Forms.DataGridView eventsDGV;
        private System.Windows.Forms.ComboBox depComboBox;
        private System.Windows.Forms.Label depLbl;
        private System.Windows.Forms.Label label1;
    }
}