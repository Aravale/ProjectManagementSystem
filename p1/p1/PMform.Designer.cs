namespace p1
{
    partial class PMform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LL_logout = new System.Windows.Forms.LinkLabel();
            this.btn_task = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_deleteproject = new System.Windows.Forms.Button();
            this.btn_editproject = new System.Windows.Forms.Button();
            this.btn_addproject = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_searchby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_projects = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.LL_logout);
            this.panel1.Controls.Add(this.btn_task);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_deleteproject);
            this.panel1.Controls.Add(this.btn_editproject);
            this.panel1.Controls.Add(this.btn_addproject);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.cmb_searchby);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_projects);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 349);
            this.panel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // LL_logout
            // 
            this.LL_logout.AutoSize = true;
            this.LL_logout.Location = new System.Drawing.Point(873, 10);
            this.LL_logout.Name = "LL_logout";
            this.LL_logout.Size = new System.Drawing.Size(40, 13);
            this.LL_logout.TabIndex = 9;
            this.LL_logout.TabStop = true;
            this.LL_logout.Text = "Logout";
            this.LL_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_logout_LinkClicked);
            // 
            // btn_task
            // 
            this.btn_task.Location = new System.Drawing.Point(826, 47);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(75, 23);
            this.btn_task.TabIndex = 8;
            this.btn_task.Text = "View Tasks";
            this.btn_task.UseVisualStyleBackColor = true;
            this.btn_task.Click += new System.EventHandler(this.btn_task_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(327, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_deleteproject
            // 
            this.btn_deleteproject.Location = new System.Drawing.Point(825, 235);
            this.btn_deleteproject.Name = "btn_deleteproject";
            this.btn_deleteproject.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteproject.TabIndex = 6;
            this.btn_deleteproject.Text = "Delete";
            this.btn_deleteproject.UseVisualStyleBackColor = true;
            this.btn_deleteproject.Click += new System.EventHandler(this.btn_deleteproject_Click);
            // 
            // btn_editproject
            // 
            this.btn_editproject.Location = new System.Drawing.Point(825, 206);
            this.btn_editproject.Name = "btn_editproject";
            this.btn_editproject.Size = new System.Drawing.Size(75, 23);
            this.btn_editproject.TabIndex = 5;
            this.btn_editproject.Text = "Edit";
            this.btn_editproject.UseVisualStyleBackColor = true;
            this.btn_editproject.Click += new System.EventHandler(this.btn_editproject_Click);
            // 
            // btn_addproject
            // 
            this.btn_addproject.Location = new System.Drawing.Point(12, 263);
            this.btn_addproject.Name = "btn_addproject";
            this.btn_addproject.Size = new System.Drawing.Size(75, 23);
            this.btn_addproject.TabIndex = 4;
            this.btn_addproject.Text = "Add Project";
            this.btn_addproject.UseVisualStyleBackColor = true;
            this.btn_addproject.Click += new System.EventHandler(this.btn_addproject_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(198, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(122, 20);
            this.txt_search.TabIndex = 3;
            // 
            // cmb_searchby
            // 
            this.cmb_searchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_searchby.FormattingEnabled = true;
            this.cmb_searchby.Items.AddRange(new object[] {
            "Project Title",
            "Client"});
            this.cmb_searchby.Location = new System.Drawing.Point(71, 13);
            this.cmb_searchby.Name = "cmb_searchby";
            this.cmb_searchby.Size = new System.Drawing.Size(121, 21);
            this.cmb_searchby.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By";
            // 
            // dgv_projects
            // 
            this.dgv_projects.AllowUserToAddRows = false;
            this.dgv_projects.AllowUserToDeleteRows = false;
            this.dgv_projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_projects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projects.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_projects.Location = new System.Drawing.Point(13, 47);
            this.dgv_projects.Name = "dgv_projects";
            this.dgv_projects.ReadOnly = true;
            this.dgv_projects.Size = new System.Drawing.Size(806, 210);
            this.dgv_projects.TabIndex = 0;
            // 
            // PMform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 349);
            this.Controls.Add(this.panel1);
            this.Name = "PMform";
            this.Text = "Project Manager Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PMform_FormClosed);
            this.Load += new System.EventHandler(this.PMform_Load);
            this.Click += new System.EventHandler(this.PMform_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deleteproject;
        private System.Windows.Forms.Button btn_editproject;
        private System.Windows.Forms.Button btn_addproject;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_searchby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_projects;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_task;
        private System.Windows.Forms.LinkLabel LL_logout;
    }
}