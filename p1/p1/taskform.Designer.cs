﻿namespace p1
{
    partial class taskform
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
            this.dtp_estdtime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.rtb_taskdescription = new System.Windows.Forms.RichTextBox();
            this.txt_taskname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_teamlead = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LL_Back = new System.Windows.Forms.LinkLabel();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_estdtime
            // 
            this.dtp_estdtime.Location = new System.Drawing.Point(138, 64);
            this.dtp_estdtime.Name = "dtp_estdtime";
            this.dtp_estdtime.Size = new System.Drawing.Size(200, 20);
            this.dtp_estdtime.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Estimated Time";
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Location = new System.Drawing.Point(138, 38);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_startdate.TabIndex = 51;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(138, 219);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 50;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // rtb_taskdescription
            // 
            this.rtb_taskdescription.Location = new System.Drawing.Point(138, 117);
            this.rtb_taskdescription.Name = "rtb_taskdescription";
            this.rtb_taskdescription.Size = new System.Drawing.Size(121, 96);
            this.rtb_taskdescription.TabIndex = 48;
            this.rtb_taskdescription.Text = "";
            // 
            // txt_taskname
            // 
            this.txt_taskname.Location = new System.Drawing.Point(138, 12);
            this.txt_taskname.Name = "txt_taskname";
            this.txt_taskname.Size = new System.Drawing.Size(121, 20);
            this.txt_taskname.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Task Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Task Name";
            // 
            // cmb_teamlead
            // 
            this.cmb_teamlead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_teamlead.FormattingEnabled = true;
            this.cmb_teamlead.Location = new System.Drawing.Point(138, 90);
            this.cmb_teamlead.Name = "cmb_teamlead";
            this.cmb_teamlead.Size = new System.Drawing.Size(121, 21);
            this.cmb_teamlead.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Assign Team Lead";
            // 
            // LL_Back
            // 
            this.LL_Back.AutoSize = true;
            this.LL_Back.Location = new System.Drawing.Point(18, 229);
            this.LL_Back.Name = "LL_Back";
            this.LL_Back.Size = new System.Drawing.Size(44, 13);
            this.LL_Back.TabIndex = 56;
            this.LL_Back.TabStop = true;
            this.LL_Back.Text = "<<Back";
            this.LL_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Back_LinkClicked);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // taskform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(356, 269);
            this.Controls.Add(this.LL_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_teamlead);
            this.Controls.Add(this.dtp_estdtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_startdate);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rtb_taskdescription);
            this.Controls.Add(this.txt_taskname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "taskform";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.taskform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_estdtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox rtb_taskdescription;
        private System.Windows.Forms.TextBox txt_taskname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_teamlead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LL_Back;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}