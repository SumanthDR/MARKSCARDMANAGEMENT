namespace MARKSCARDMANAGEMENT
{
    partial class Frm_Course
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
            this.components = new System.ComponentModel.Container();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.txtbx_coursename = new System.Windows.Forms.TextBox();
            this.lbl_coursename = new System.Windows.Forms.Label();
            this.lbl_coursedescrp = new System.Windows.Forms.Label();
            this.txtbx_coursedescrp = new System.Windows.Forms.TextBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_coursecode = new System.Windows.Forms.TextBox();
            this.err_crs_code = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_crs_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_name)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(338, 265);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(198, 9);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(84, 20);
            this.lbl_heading.TabIndex = 1;
            this.lbl_heading.Text = "COURSE";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbx_coursename
            // 
            this.txtbx_coursename.Location = new System.Drawing.Point(133, 120);
            this.txtbx_coursename.Name = "txtbx_coursename";
            this.txtbx_coursename.Size = new System.Drawing.Size(280, 20);
            this.txtbx_coursename.TabIndex = 1;
            this.txtbx_coursename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_coursename_KeyPress);
            // 
            // lbl_coursename
            // 
            this.lbl_coursename.AutoSize = true;
            this.lbl_coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursename.Location = new System.Drawing.Point(38, 121);
            this.lbl_coursename.Name = "lbl_coursename";
            this.lbl_coursename.Size = new System.Drawing.Size(89, 15);
            this.lbl_coursename.TabIndex = 3;
            this.lbl_coursename.Text = "Course Name :";
            // 
            // lbl_coursedescrp
            // 
            this.lbl_coursedescrp.AutoSize = true;
            this.lbl_coursedescrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursedescrp.Location = new System.Drawing.Point(10, 157);
            this.lbl_coursedescrp.Name = "lbl_coursedescrp";
            this.lbl_coursedescrp.Size = new System.Drawing.Size(117, 15);
            this.lbl_coursedescrp.TabIndex = 4;
            this.lbl_coursedescrp.Text = "Course Description :";
            // 
            // txtbx_coursedescrp
            // 
            this.txtbx_coursedescrp.Location = new System.Drawing.Point(133, 156);
            this.txtbx_coursedescrp.Multiline = true;
            this.txtbx_coursedescrp.Name = "txtbx_coursedescrp";
            this.txtbx_coursedescrp.Size = new System.Drawing.Size(280, 103);
            this.txtbx_coursedescrp.TabIndex = 3;
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(236, 265);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 4;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course Code :";
            // 
            // txtbx_coursecode
            // 
            this.txtbx_coursecode.Location = new System.Drawing.Point(133, 85);
            this.txtbx_coursecode.Name = "txtbx_coursecode";
            this.txtbx_coursecode.Size = new System.Drawing.Size(178, 20);
            this.txtbx_coursecode.TabIndex = 0;
            this.txtbx_coursecode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_coursecode_KeyPress);
            // 
            // err_crs_code
            // 
            this.err_crs_code.ContainerControl = this;
            // 
            // err_crs_name
            // 
            this.err_crs_name.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Status :-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 24);
            this.panel1.TabIndex = 11;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(64, 4);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 13);
            this.label_status.TabIndex = 11;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(338, 266);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(202, 285);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Frm_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 339);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_coursecode);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.txtbx_coursedescrp);
            this.Controls.Add(this.lbl_coursedescrp);
            this.Controls.Add(this.lbl_coursename);
            this.Controls.Add(this.txtbx_coursename);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_name)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.TextBox txtbx_coursename;
        private System.Windows.Forms.Label lbl_coursename;
        private System.Windows.Forms.Label lbl_coursedescrp;
        private System.Windows.Forms.TextBox txtbx_coursedescrp;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_coursecode;
        private System.Windows.Forms.ErrorProvider err_crs_code;
        private System.Windows.Forms.ErrorProvider err_crs_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_edit;
    }
}

