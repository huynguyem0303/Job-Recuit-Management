namespace Trial
{
    partial class Management
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
            this.lbCandidateID = new System.Windows.Forms.Label();
            this.lbPostingID = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbProfileUrl = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtProfileUrl = new System.Windows.Forms.TextBox();
            this.txtPSD = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtCandidateID = new System.Windows.Forms.TextBox();
            this.cbPostingID = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCandidateID
            // 
            this.lbCandidateID.AutoSize = true;
            this.lbCandidateID.Location = new System.Drawing.Point(48, 16);
            this.lbCandidateID.Name = "lbCandidateID";
            this.lbCandidateID.Size = new System.Drawing.Size(92, 20);
            this.lbCandidateID.TabIndex = 0;
            this.lbCandidateID.Text = "CandidateID";
            // 
            // lbPostingID
            // 
            this.lbPostingID.AutoSize = true;
            this.lbPostingID.Location = new System.Drawing.Point(48, 232);
            this.lbPostingID.Name = "lbPostingID";
            this.lbPostingID.Size = new System.Drawing.Size(72, 20);
            this.lbPostingID.TabIndex = 1;
            this.lbPostingID.Text = "PostingID";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(473, 16);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(117, 20);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Search Fullname";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(48, 104);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(64, 20);
            this.lbBirthday.TabIndex = 3;
            this.lbBirthday.Text = "Birthday";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(48, 64);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(72, 20);
            this.lbFullName.TabIndex = 4;
            this.lbFullName.Text = "FullName";
            // 
            // lbProfileUrl
            // 
            this.lbProfileUrl.AutoSize = true;
            this.lbProfileUrl.Location = new System.Drawing.Point(48, 192);
            this.lbProfileUrl.Name = "lbProfileUrl";
            this.lbProfileUrl.Size = new System.Drawing.Size(71, 20);
            this.lbProfileUrl.TabIndex = 5;
            this.lbProfileUrl.Text = "ProfileUrl";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(-4, 152);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(171, 20);
            this.lbDescription.TabIndex = 6;
            this.lbDescription.Text = "Profile Short Description";
            this.lbDescription.Click += new System.EventHandler(this.lbDescription_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(473, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 27);
            this.txtSearch.TabIndex = 7;
            // 
            // txtProfileUrl
            // 
            this.txtProfileUrl.Location = new System.Drawing.Point(173, 185);
            this.txtProfileUrl.Name = "txtProfileUrl";
            this.txtProfileUrl.Size = new System.Drawing.Size(250, 27);
            this.txtProfileUrl.TabIndex = 8;
            // 
            // txtPSD
            // 
            this.txtPSD.Location = new System.Drawing.Point(173, 145);
            this.txtPSD.Name = "txtPSD";
            this.txtPSD.Size = new System.Drawing.Size(250, 27);
            this.txtPSD.TabIndex = 9;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(173, 64);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(250, 27);
            this.txtFullname.TabIndex = 10;
            // 
            // txtCandidateID
            // 
            this.txtCandidateID.Location = new System.Drawing.Point(173, 12);
            this.txtCandidateID.Name = "txtCandidateID";
            this.txtCandidateID.Size = new System.Drawing.Size(250, 27);
            this.txtCandidateID.TabIndex = 11;
            // 
            // cbPostingID
            // 
            this.cbPostingID.Location = new System.Drawing.Point(173, 232);
            this.cbPostingID.Name = "cbPostingID";
            this.cbPostingID.Size = new System.Drawing.Size(250, 28);
            this.cbPostingID.TabIndex = 12;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(173, 104);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(250, 27);
            this.dtpBirthday.TabIndex = 13;
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(673, 228);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(573, 228);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(94, 29);
            this.btUpdate.TabIndex = 15;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(473, 228);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(94, 29);
            this.btCreate.TabIndex = 16;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(667, 47);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 29);
            this.btSearch.TabIndex = 17;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 278);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(776, 242);
            this.dgv.TabIndex = 18;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cbPostingID);
            this.Controls.Add(this.txtCandidateID);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtPSD);
            this.Controls.Add(this.txtProfileUrl);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbProfileUrl);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbPostingID);
            this.Controls.Add(this.lbCandidateID);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCandidateID;
        private System.Windows.Forms.Label lbPostingID;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbProfileUrl;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtProfileUrl;
        private System.Windows.Forms.TextBox txtPSD;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtCandidateID;
        private System.Windows.Forms.ComboBox cbPostingID;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dgv;
    }
}