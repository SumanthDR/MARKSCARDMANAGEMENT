namespace MARKSCARDMANAGEMENT
{
    partial class Frm_Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.studentToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.courseToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.subjectMappingToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Create";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courseToolStripMenuItem.Text = "New Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subjectToolStripMenuItem.Text = "New Subject";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // subjectMappingToolStripMenuItem
            // 
            this.subjectMappingToolStripMenuItem.Name = "subjectMappingToolStripMenuItem";
            this.subjectMappingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subjectMappingToolStripMenuItem.Text = "Subject Mapping";
            this.subjectMappingToolStripMenuItem.Click += new System.EventHandler(this.subjectMappingToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerToolStripMenuItem.Text = "New  Student";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click_1);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertMarksToolStripMenuItem,
            this.viewMarksToolStripMenuItem,
            this.completeResultToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // insertMarksToolStripMenuItem
            // 
            this.insertMarksToolStripMenuItem.Name = "insertMarksToolStripMenuItem";
            this.insertMarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertMarksToolStripMenuItem.Text = "Insert Marks";
            this.insertMarksToolStripMenuItem.Click += new System.EventHandler(this.insertMarksToolStripMenuItem_Click);
            // 
            // viewMarksToolStripMenuItem
            // 
            this.viewMarksToolStripMenuItem.Name = "viewMarksToolStripMenuItem";
            this.viewMarksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewMarksToolStripMenuItem.Text = "View Marks";
            // 
            // completeResultToolStripMenuItem
            // 
            this.completeResultToolStripMenuItem.Name = "completeResultToolStripMenuItem";
            this.completeResultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.completeResultToolStripMenuItem.Text = "Complete Result";
            this.completeResultToolStripMenuItem.Click += new System.EventHandler(this.completeResultToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSubjectToolStripMenuItem,
            this.viewSubjectToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.viewStudentToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewSubjectToolStripMenuItem
            // 
            this.viewSubjectToolStripMenuItem.Name = "viewSubjectToolStripMenuItem";
            this.viewSubjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewSubjectToolStripMenuItem.Text = "View Course";
            this.viewSubjectToolStripMenuItem.Click += new System.EventHandler(this.viewSubjectToolStripMenuItem_Click_1);
            // 
            // viewSubjectToolStripMenuItem1
            // 
            this.viewSubjectToolStripMenuItem1.Name = "viewSubjectToolStripMenuItem1";
            this.viewSubjectToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewSubjectToolStripMenuItem1.Text = "View Subject";
            this.viewSubjectToolStripMenuItem1.Click += new System.EventHandler(this.viewSubjectToolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "View Mapping";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewStudentToolStripMenuItem.Text = "View Student";
            this.viewStudentToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
    }
}