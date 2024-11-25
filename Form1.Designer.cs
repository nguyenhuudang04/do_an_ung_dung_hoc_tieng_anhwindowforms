namespace windowforms_sqlsever
{
    partial class Form1
    {
        
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdoZA = new System.Windows.Forms.RadioButton();
            this.rdiAZ = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefreshlist = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartofSpeech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.txtenter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 566);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtenter);
            this.tabPage1.Controls.Add(this.rdoZA);
            this.tabPage1.Controls.Add(this.rdiAZ);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listBoxTopics);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(865, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Topic";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // rdoZA
            // 
            this.rdoZA.AutoSize = true;
            this.rdoZA.Location = new System.Drawing.Point(60, 325);
            this.rdoZA.Name = "rdoZA";
            this.rdoZA.Size = new System.Drawing.Size(60, 24);
            this.rdoZA.TabIndex = 14;
            this.rdoZA.TabStop = true;
            this.rdoZA.Text = "Z-A";
            this.rdoZA.UseVisualStyleBackColor = true;
            this.rdoZA.CheckedChanged += new System.EventHandler(this.rdoZA_CheckedChanged);
            // 
            // rdiAZ
            // 
            this.rdiAZ.AutoSize = true;
            this.rdiAZ.Location = new System.Drawing.Point(60, 286);
            this.rdiAZ.Name = "rdiAZ";
            this.rdiAZ.Size = new System.Drawing.Size(60, 24);
            this.rdiAZ.TabIndex = 13;
            this.rdiAZ.TabStop = true;
            this.rdiAZ.Text = "A-Z";
            this.rdiAZ.UseVisualStyleBackColor = true;
            this.rdiAZ.CheckedChanged += new System.EventHandler(this.rdiAZ_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(166, 239);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 30);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.ItemHeight = 20;
            this.listBoxTopics.Items.AddRange(new object[] {
            "Family",
            "",
            "Friends",
            "",
            "Home",
            "",
            "Daily ",
            "Activities",
            "",
            "Weather",
            "Food & Drinks",
            "",
            "Shopping",
            "Education",
            "",
            "School",
            "",
            "Jobs & Professions",
            "",
            "Technology",
            "Office",
            "",
            "Communication",
            "Animals",
            "",
            "Plants",
            "",
            "Nature",
            "",
            "Seasons",
            "",
            "Geography",
            "",
            "Environment",
            "Health",
            "",
            "Fitness",
            "",
            "Human Body",
            "",
            "Diseases",
            "",
            "Medicine",
            "",
            "Mental Health",
            "Sports",
            "",
            "Music",
            "",
            "Movies",
            "",
            "Travel",
            "",
            "Hobbies",
            "",
            "Games",
            "Relationships",
            "",
            "Festivals & Holidays",
            "",
            "Culture",
            "History",
            "",
            "Politics",
            "News & Media",
            "Science",
            "",
            "Space",
            "Inventions",
            "T",
            "echnology",
            "",
            "Mathematics",
            "Transportation",
            "",
            "Vehicles",
            "Road Safety",
            "",
            "Directions",
            "",
            "Travel & Tourism",
            "Emotions",
            "",
            "Personality",
            "",
            "Problem Solving",
            "",
            "Leadership",
            "",
            "Teamwork",
            "Colors",
            "",
            "Shapes",
            "",
            "Numbers",
            "",
            "Time",
            "",
            "Clothing"});
            this.listBoxTopics.Location = new System.Drawing.Point(155, 286);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.Size = new System.Drawing.Size(281, 184);
            this.listBoxTopics.TabIndex = 9;
            this.listBoxTopics.SelectedIndexChanged += new System.EventHandler(this.listBoxTopics_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Topic";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Noun (n.)",
            "Verb (v.)",
            "Adjective (adj.)",
            "Adverb (adv.)",
            "Preposition (prep.)"});
            this.comboBox1.Location = new System.Drawing.Point(166, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Part of Speech";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the meaning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the word";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchtxt);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.btnRefreshlist);
            this.tabPage2.Controls.Add(this.btnFilter);
            this.tabPage2.Controls.Add(this.bntDelete);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(865, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vocabulary List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(697, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 39);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefreshlist
            // 
            this.btnRefreshlist.Location = new System.Drawing.Point(697, 153);
            this.btnRefreshlist.Name = "btnRefreshlist";
            this.btnRefreshlist.Size = new System.Drawing.Size(110, 36);
            this.btnRefreshlist.TabIndex = 4;
            this.btnRefreshlist.Text = "Refresh List";
            this.btnRefreshlist.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(697, 385);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 36);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(697, 234);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(110, 36);
            this.bntDelete.TabIndex = 2;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(697, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Column1,
            this.Topic,
            this.PartofSpeech});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(651, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.MinimumWidth = 8;
            this.Word.Name = "Word";
            this.Word.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Meaning";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.MinimumWidth = 8;
            this.Topic.Name = "Topic";
            this.Topic.Width = 150;
            // 
            // PartofSpeech
            // 
            this.PartofSpeech.HeaderText = "Part of Speech";
            this.PartofSpeech.MinimumWidth = 8;
            this.PartofSpeech.Name = "PartofSpeech";
            this.PartofSpeech.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(865, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quiz";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(865, 533);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quiz History";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(670, 36);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(174, 37);
            this.searchtxt.TabIndex = 6;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // txtenter
            // 
            this.txtenter.Location = new System.Drawing.Point(623, 437);
            this.txtenter.Name = "txtenter";
            this.txtenter.Size = new System.Drawing.Size(134, 55);
            this.txtenter.TabIndex = 15;
            this.txtenter.Text = "Enter";
            this.txtenter.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(862, 131);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Family",
            "",
            "Friends",
            "",
            "Home",
            "",
            "Daily ",
            "Activities",
            "",
            "Weather",
            "Food & Drinks",
            "",
            "Shopping",
            "Education",
            "",
            "School",
            "",
            "Jobs & Professions",
            "",
            "Technology",
            "Office",
            "",
            "Communication",
            "Animals",
            "",
            "Plants",
            "",
            "Nature",
            "",
            "Seasons",
            "",
            "Geography",
            "",
            "Environment",
            "Health",
            "",
            "Fitness",
            "",
            "Human Body",
            "",
            "Diseases",
            "",
            "Medicine",
            "",
            "Mental Health",
            "Sports",
            "",
            "Music",
            "",
            "Movies",
            "",
            "Travel",
            "",
            "Hobbies",
            "",
            "Games",
            "Relationships",
            "",
            "Festivals & Holidays",
            "",
            "Culture",
            "History",
            "",
            "Politics",
            "News & Media",
            "Science",
            "",
            "Space",
            "Inventions",
            "T",
            "echnology",
            "",
            "Mathematics",
            "Transportation",
            "",
            "Vehicles",
            "Road Safety",
            "",
            "Directions",
            "",
            "Travel & Tourism",
            "Emotions",
            "",
            "Personality",
            "",
            "Problem Solving",
            "",
            "Leadership",
            "",
            "Teamwork",
            "Colors",
            "",
            "Shapes",
            "",
            "Numbers",
            "",
            "Time",
            "",
            "Clothing"});
            this.listBox1.Location = new System.Drawing.Point(42, 261);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 184);
            this.listBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select Topics:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 223);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 30);
            this.textBox3.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(874, 569);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxTopics;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdiAZ;
        private System.Windows.Forms.RadioButton rdoZA;
        private System.Windows.Forms.Button btnRefreshlist;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartofSpeech;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button txtenter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}
