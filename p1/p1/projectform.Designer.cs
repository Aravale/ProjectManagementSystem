namespace p1
{
    partial class projectform
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
            this.cmb_clientname = new System.Windows.Forms.ComboBox();
            this.rtb_projectdescription = new System.Windows.Forms.RichTextBox();
            this.txt_projectname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LL_Back = new System.Windows.Forms.LinkLabel();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_estdtime
            // 
            this.dtp_estdtime.Location = new System.Drawing.Point(130, 85);
            this.dtp_estdtime.Name = "dtp_estdtime";
            this.dtp_estdtime.Size = new System.Drawing.Size(200, 20);
            this.dtp_estdtime.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Estimated Time";
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Location = new System.Drawing.Point(130, 59);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_startdate.TabIndex = 40;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(151, 222);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 39;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmb_clientname
            // 
            this.cmb_clientname.DisplayMember = "clientname";
            this.cmb_clientname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clientname.FormattingEnabled = true;
            this.cmb_clientname.Location = new System.Drawing.Point(130, 34);
            this.cmb_clientname.Name = "cmb_clientname";
            this.cmb_clientname.Size = new System.Drawing.Size(121, 21);
            this.cmb_clientname.TabIndex = 38;
            this.cmb_clientname.ValueMember = "clientname";
            // 
            // rtb_projectdescription
            // 
            this.rtb_projectdescription.Location = new System.Drawing.Point(130, 111);
            this.rtb_projectdescription.Name = "rtb_projectdescription";
            this.rtb_projectdescription.Size = new System.Drawing.Size(121, 96);
            this.rtb_projectdescription.TabIndex = 37;
            this.rtb_projectdescription.Text = "";
            // 
            // txt_projectname
            // 
            this.txt_projectname.Location = new System.Drawing.Point(130, 9);
            this.txt_projectname.Name = "txt_projectname";
            this.txt_projectname.Size = new System.Drawing.Size(121, 20);
            this.txt_projectname.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Project Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Title";
            // 
            // LL_Back
            // 
            this.LL_Back.AutoSize = true;
            this.LL_Back.Location = new System.Drawing.Point(12, 255);
            this.LL_Back.Name = "LL_Back";
            this.LL_Back.Size = new System.Drawing.Size(44, 13);
            this.LL_Back.TabIndex = 57;
            this.LL_Back.TabStop = true;
            this.LL_Back.Text = "<<Back";
            this.LL_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Back_LinkClicked);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // projectform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(346, 286);
            this.Controls.Add(this.LL_Back);
            this.Controls.Add(this.dtp_estdtime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_startdate);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_clientname);
            this.Controls.Add(this.rtb_projectdescription);
            this.Controls.Add(this.txt_projectname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "projectform";
            this.Text = "Project Form";
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_estdtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_clientname;
        private System.Windows.Forms.RichTextBox rtb_projectdescription;
        private System.Windows.Forms.TextBox txt_projectname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LL_Back;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}