namespace MARKSCARDMANAGEMENT
{
    partial class Frm_Subject
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
            this.txtbx_SubName = new System.Windows.Forms.TextBox();
            this.btn_ok1 = new System.Windows.Forms.Button();
            this.lbl_sname = new System.Windows.Forms.Label();
            this.lbl_subjectdec = new System.Windows.Forms.Label();
            this.txtbx_SubDesc = new System.Windows.Forms.TextBox();
            this.btn_cancle1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_sub_thMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_sub_thMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_sub_IAMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_sub_IAMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_coursename = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_SubCode = new System.Windows.Forms.TextBox();
            this.err_SubCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_SubName = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_SubDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_SubCrs = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_SubCat = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_SubThMax = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_SubThMin = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_IAMax = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_IAMin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_crsEdit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubCrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubThMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubThMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_IAMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_IAMin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_SubName
            // 
            this.txtbx_SubName.Location = new System.Drawing.Point(45, 132);
            this.txtbx_SubName.Name = "txtbx_SubName";
            this.txtbx_SubName.Size = new System.Drawing.Size(333, 20);
            this.txtbx_SubName.TabIndex = 1;
            this.txtbx_SubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_SubName_KeyPress);
            // 
            // btn_ok1
            // 
            this.btn_ok1.Location = new System.Drawing.Point(303, 477);
            this.btn_ok1.Name = "btn_ok1";
            this.btn_ok1.Size = new System.Drawing.Size(75, 23);
            this.btn_ok1.TabIndex = 11;
            this.btn_ok1.Text = "OK";
            this.btn_ok1.UseVisualStyleBackColor = true;
            this.btn_ok1.Click += new System.EventHandler(this.btn_ok1_Click);
            // 
            // lbl_sname
            // 
            this.lbl_sname.AutoSize = true;
            this.lbl_sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sname.Location = new System.Drawing.Point(42, 114);
            this.lbl_sname.Name = "lbl_sname";
            this.lbl_sname.Size = new System.Drawing.Size(47, 15);
            this.lbl_sname.TabIndex = 4;
            this.lbl_sname.Text = "Name :";
            // 
            // lbl_subjectdec
            // 
            this.lbl_subjectdec.AutoSize = true;
            this.lbl_subjectdec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subjectdec.Location = new System.Drawing.Point(42, 165);
            this.lbl_subjectdec.Name = "lbl_subjectdec";
            this.lbl_subjectdec.Size = new System.Drawing.Size(75, 15);
            this.lbl_subjectdec.TabIndex = 5;
            this.lbl_subjectdec.Text = "Description :";
            // 
            // txtbx_SubDesc
            // 
            this.txtbx_SubDesc.Location = new System.Drawing.Point(45, 183);
            this.txtbx_SubDesc.Multiline = true;
            this.txtbx_SubDesc.Name = "txtbx_SubDesc";
            this.txtbx_SubDesc.Size = new System.Drawing.Size(333, 68);
            this.txtbx_SubDesc.TabIndex = 3;
            // 
            // btn_cancle1
            // 
            this.btn_cancle1.Location = new System.Drawing.Point(205, 477);
            this.btn_cancle1.Name = "btn_cancle1";
            this.btn_cancle1.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle1.TabIndex = 10;
            this.btn_cancle1.Text = "Cancle";
            this.btn_cancle1.UseVisualStyleBackColor = true;
            this.btn_cancle1.Click += new System.EventHandler(this.btn_cancle1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "SUBJECT";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Theory/Practical :";
            // 
            // txtbx_sub_thMax
            // 
            this.txtbx_sub_thMax.Location = new System.Drawing.Point(136, 358);
            this.txtbx_sub_thMax.Name = "txtbx_sub_thMax";
            this.txtbx_sub_thMax.Size = new System.Drawing.Size(61, 20);
            this.txtbx_sub_thMax.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max. Marks :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Min. Marks :";
            // 
            // txtbx_sub_thMin
            // 
            this.txtbx_sub_thMin.Location = new System.Drawing.Point(317, 358);
            this.txtbx_sub_thMin.Name = "txtbx_sub_thMin";
            this.txtbx_sub_thMin.Size = new System.Drawing.Size(61, 20);
            this.txtbx_sub_thMin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Internal Assessment :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Min. Marks :";
            // 
            // txtbx_sub_IAMin
            // 
            this.txtbx_sub_IAMin.Location = new System.Drawing.Point(317, 417);
            this.txtbx_sub_IAMin.Name = "txtbx_sub_IAMin";
            this.txtbx_sub_IAMin.Size = new System.Drawing.Size(61, 20);
            this.txtbx_sub_IAMin.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max. Marks :";
            // 
            // txtbx_sub_IAMax
            // 
            this.txtbx_sub_IAMax.Location = new System.Drawing.Point(136, 417);
            this.txtbx_sub_IAMax.Name = "txtbx_sub_IAMax";
            this.txtbx_sub_IAMax.Size = new System.Drawing.Size(61, 20);
            this.txtbx_sub_IAMax.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Category :";
            // 
            // cmb_Category
            // 
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.ItemHeight = 13;
            this.cmb_Category.Items.AddRange(new object[] {
            "Core Subject",
            "LAB",
            "I Language",
            "Susidiary (Not Added To Total Marks)"});
            this.cmb_Category.Location = new System.Drawing.Point(228, 290);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(150, 21);
            this.cmb_Category.TabIndex = 5;
            this.cmb_Category.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Category_KeyPress);
            // 
            // cmb_coursename
            // 
            this.cmb_coursename.FormattingEnabled = true;
            this.cmb_coursename.ItemHeight = 13;
            this.cmb_coursename.Location = new System.Drawing.Point(47, 290);
            this.cmb_coursename.Name = "cmb_coursename";
            this.cmb_coursename.Size = new System.Drawing.Size(150, 21);
            this.cmb_coursename.TabIndex = 4;
            this.cmb_coursename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_coursename_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Course:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Subject Code :";
            // 
            // txtbx_SubCode
            // 
            this.txtbx_SubCode.Location = new System.Drawing.Point(45, 81);
            this.txtbx_SubCode.Name = "txtbx_SubCode";
            this.txtbx_SubCode.Size = new System.Drawing.Size(333, 20);
            this.txtbx_SubCode.TabIndex = 0;
            this.txtbx_SubCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_SubCode_KeyPress);
            // 
            // err_SubCode
            // 
            this.err_SubCode.ContainerControl = this;
            // 
            // err_SubName
            // 
            this.err_SubName.ContainerControl = this;
            // 
            // err_SubDesc
            // 
            this.err_SubDesc.ContainerControl = this;
            // 
            // err_SubCrs
            // 
            this.err_SubCrs.ContainerControl = this;
            // 
            // err_SubCat
            // 
            this.err_SubCat.ContainerControl = this;
            // 
            // err_SubThMax
            // 
            this.err_SubThMax.ContainerControl = this;
            // 
            // err_SubThMin
            // 
            this.err_SubThMin.ContainerControl = this;
            // 
            // err_IAMax
            // 
            this.err_IAMax.ContainerControl = this;
            // 
            // err_IAMin
            // 
            this.err_IAMin.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 24);
            this.panel1.TabIndex = 26;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(64, 4);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 13);
            this.label_status.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Status :-";
            // 
            // btn_crsEdit
            // 
            this.btn_crsEdit.Location = new System.Drawing.Point(157, 317);
            this.btn_crsEdit.Name = "btn_crsEdit";
            this.btn_crsEdit.Size = new System.Drawing.Size(40, 23);
            this.btn_crsEdit.TabIndex = 27;
            this.btn_crsEdit.Text = "Edit";
            this.btn_crsEdit.UseVisualStyleBackColor = true;
            this.btn_crsEdit.Visible = false;
            this.btn_crsEdit.Click += new System.EventHandler(this.btn_crsEdit_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(303, 477);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(157, 460);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // Frm_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 538);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_crsEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbx_SubCode);
            this.Controls.Add(this.cmb_coursename);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_sub_IAMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_sub_IAMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_sub_thMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_sub_thMax);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancle1);
            this.Controls.Add(this.txtbx_SubDesc);
            this.Controls.Add(this.lbl_subjectdec);
            this.Controls.Add(this.lbl_sname);
            this.Controls.Add(this.btn_ok1);
            this.Controls.Add(this.txtbx_SubName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_SubCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubCrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubThMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_SubThMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_IAMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_IAMin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_SubName;
        private System.Windows.Forms.Button btn_ok1;
        private System.Windows.Forms.Label lbl_sname;
        private System.Windows.Forms.Label lbl_subjectdec;
        private System.Windows.Forms.TextBox txtbx_SubDesc;
        private System.Windows.Forms.Button btn_cancle1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_sub_thMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_sub_thMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_sub_IAMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_sub_IAMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_coursename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbx_SubCode;
        private System.Windows.Forms.ErrorProvider err_SubCode;
        private System.Windows.Forms.ErrorProvider err_SubName;
        private System.Windows.Forms.ErrorProvider err_SubDesc;
        private System.Windows.Forms.ErrorProvider err_SubCrs;
        private System.Windows.Forms.ErrorProvider err_SubCat;
        private System.Windows.Forms.ErrorProvider err_SubThMax;
        private System.Windows.Forms.ErrorProvider err_SubThMin;
        private System.Windows.Forms.ErrorProvider err_IAMax;
        private System.Windows.Forms.ErrorProvider err_IAMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_crsEdit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_edit;
    }
}