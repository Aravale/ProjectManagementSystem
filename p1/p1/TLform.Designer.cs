namespace p1
{
    partial class TLform
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pn2 = new System.Windows.Forms.Panel();
            this.dtp_estdtime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.rtd_desc = new System.Windows.Forms.RichTextBox();
            this.lb_teammembers = new System.Windows.Forms.ListBox();
            this.btn_removemember = new System.Windows.Forms.Button();
            this.cmb_teamadd = new System.Windows.Forms.ComboBox();
            this.btn_addmember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LL_logout = new System.Windows.Forms.LinkLabel();
            this.pn1.SuspendLayout();
            this.pn2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 24);
            this.lbl_title.TabIndex = 0;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.dtp_startdate);
            this.pn1.Controls.Add(this.label5);
            this.pn1.Location = new System.Drawing.Point(17, 94);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(221, 57);
            this.pn1.TabIndex = 15;
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Enabled = false;
            this.dtp_startdate.Location = new System.Drawing.Point(7, 23);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_startdate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date:";
            // 
            // pn2
            // 
            this.pn2.Controls.Add(this.dtp_estdtime);
            this.pn2.Controls.Add(this.label4);
            this.pn2.Location = new System.Drawing.Point(244, 94);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(221, 57);
            this.pn2.TabIndex = 14;
            // 
            // dtp_estdtime
            // 
            this.dtp_estdtime.Enabled = false;
            this.dtp_estdtime.Location = new System.Drawing.Point(3, 23);
            this.dtp_estdtime.Name = "dtp_estdtime";
            this.dtp_estdtime.Size = new System.Drawing.Size(200, 20);
            this.dtp_estdtime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "End Date:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(17, 355);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // rtd_desc
            // 
            this.rtd_desc.Location = new System.Drawing.Point(17, 197);
            this.rtd_desc.Name = "rtd_desc";
            this.rtd_desc.Size = new System.Drawing.Size(200, 143);
            this.rtd_desc.TabIndex = 12;
            this.rtd_desc.Text = "";
            // 
            // lb_teammembers
            // 
            this.lb_teammembers.FormattingEnabled = true;
            this.lb_teammembers.Location = new System.Drawing.Point(244, 197);
            this.lb_teammembers.Name = "lb_teammembers";
            this.lb_teammembers.Size = new System.Drawing.Size(120, 95);
            this.lb_teammembers.TabIndex = 16;
            // 
            // btn_removemember
            // 
            this.btn_removemember.Location = new System.Drawing.Point(371, 197);
            this.btn_removemember.Name = "btn_removemember";
            this.btn_removemember.Size = new System.Drawing.Size(75, 23);
            this.btn_removemember.TabIndex = 17;
            this.btn_removemember.Text = "Remove";
            this.btn_removemember.UseVisualStyleBackColor = true;
            this.btn_removemember.Click += new System.EventHandler(this.btn_removemember_Click);
            // 
            // cmb_teamadd
            // 
            this.cmb_teamadd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_teamadd.FormattingEnabled = true;
            this.cmb_teamadd.Location = new System.Drawing.Point(244, 299);
            this.cmb_teamadd.Name = "cmb_teamadd";
            this.cmb_teamadd.Size = new System.Drawing.Size(121, 21);
            this.cmb_teamadd.TabIndex = 18;
            // 
            // btn_addmember
            // 
            this.btn_addmember.Location = new System.Drawing.Point(371, 299);
            this.btn_addmember.Name = "btn_addmember";
            this.btn_addmember.Size = new System.Drawing.Size(75, 23);
            this.btn_addmember.TabIndex = 19;
            this.btn_addmember.Text = "Add";
            this.btn_addmember.UseVisualStyleBackColor = true;
            this.btn_addmember.Click += new System.EventHandler(this.btn_addmember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Team Members:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Task Description:";
            // 
            // LL_logout
            // 
            this.LL_logout.AutoSize = true;
            this.LL_logout.Location = new System.Drawing.Point(473, 9);
            this.LL_logout.Name = "LL_logout";
            this.LL_logout.Size = new System.Drawing.Size(40, 13);
            this.LL_logout.TabIndex = 22;
            this.LL_logout.TabStop = true;
            this.LL_logout.Text = "Logout";
            this.LL_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_logout_LinkClicked);
            // 
            // TLform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 427);
            this.Controls.Add(this.LL_logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addmember);
            this.Controls.Add(this.cmb_teamadd);
            this.Controls.Add(this.btn_removemember);
            this.Controls.Add(this.lb_teammembers);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.rtd_desc);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TLform";
            this.Text = "Team Lead Task Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TLform_FormClosed);
            this.Load += new System.EventHandler(this.TLform_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.DateTimePicker dtp_estdtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.RichTextBox rtd_desc;
        private System.Windows.Forms.ListBox lb_teammembers;
        private System.Windows.Forms.Button btn_removemember;
        private System.Windows.Forms.ComboBox cmb_teamadd;
        private System.Windows.Forms.Button btn_addmember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LL_logout;
    }
}