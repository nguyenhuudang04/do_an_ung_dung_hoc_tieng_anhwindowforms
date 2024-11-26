namespace windowforms_sqlsever
{
    partial class Form1
    {
        
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtenter = new System.Windows.Forms.Button();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.lblPartOfSpeech = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.cmbPartOfSpeech = new System.Windows.Forms.ComboBox();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchList = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartofSpeech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefreshlist = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(-4, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Topic";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWord);
            this.groupBox1.Controls.Add(this.txtenter);
            this.groupBox1.Controls.Add(this.lblMeaning);
            this.groupBox1.Controls.Add(this.listBoxTopics);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTopic);
            this.groupBox1.Controls.Add(this.lblPartOfSpeech);
            this.groupBox1.Controls.Add(this.lblTopic);
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Controls.Add(this.cmbPartOfSpeech);
            this.groupBox1.Controls.Add(this.txtMeaning);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 486);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(23, 44);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(137, 25);
            this.lblWord.TabIndex = 3;
            this.lblWord.Text = "Enter the word";
            // 
            // txtenter
            // 
            this.txtenter.Location = new System.Drawing.Point(599, 392);
            this.txtenter.Name = "txtenter";
            this.txtenter.Size = new System.Drawing.Size(88, 42);
            this.txtenter.TabIndex = 15;
            this.txtenter.Text = "Add";
            this.txtenter.UseVisualStyleBackColor = true;
            //this.txtenter.Click += new System.EventHandler(this.txtenter_Click);
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaning.Location = new System.Drawing.Point(23, 100);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(170, 25);
            this.lblMeaning.TabIndex = 4;
            this.lblMeaning.Text = "Enter the meaning";
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.ItemHeight = 16;
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
            this.listBoxTopics.Location = new System.Drawing.Point(208, 254);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.Size = new System.Drawing.Size(346, 180);
            this.listBoxTopics.TabIndex = 9;
            this.listBoxTopics.SelectedIndexChanged += new System.EventHandler(this.listBoxTopics_SelectedIndexChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(588, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(208, 198);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(346, 30);
            this.txtTopic.TabIndex = 12;
            this.txtTopic.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblPartOfSpeech
            // 
            this.lblPartOfSpeech.AutoSize = true;
            this.lblPartOfSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartOfSpeech.Location = new System.Drawing.Point(23, 152);
            this.lblPartOfSpeech.Name = "lblPartOfSpeech";
            this.lblPartOfSpeech.Size = new System.Drawing.Size(141, 25);
            this.lblPartOfSpeech.TabIndex = 5;
            this.lblPartOfSpeech.Text = "Part of Speech";
            this.lblPartOfSpeech.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(23, 203);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(61, 25);
            this.lblTopic.TabIndex = 7;
            this.lblTopic.Text = "Topic";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(208, 44);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(346, 34);
            this.txtWord.TabIndex = 0;
            this.txtWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbPartOfSpeech
            // 
            this.cmbPartOfSpeech.FormattingEnabled = true;
            this.cmbPartOfSpeech.Items.AddRange(new object[] {
            "Noun (n.)",
            "Verb (v.)",
            "Adjective (adj.)",
            "Adverb (adv.)",
            "Preposition (prep.)"});
            this.cmbPartOfSpeech.Location = new System.Drawing.Point(208, 152);
            this.cmbPartOfSpeech.Name = "cmbPartOfSpeech";
            this.cmbPartOfSpeech.Size = new System.Drawing.Size(346, 24);
            this.cmbPartOfSpeech.TabIndex = 6;
            this.cmbPartOfSpeech.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(208, 100);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(346, 34);
            this.txtMeaning.TabIndex = 1;
            this.txtMeaning.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vocabulary List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchList);
            this.groupBox2.Controls.Add(this.searchtxt);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnRefreshlist);
            this.groupBox2.Controls.Add(this.bntDelete);
            this.groupBox2.Location = new System.Drawing.Point(0, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 508);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSearchList
            // 
            this.btnSearchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchList.Location = new System.Drawing.Point(706, 114);
            this.btnSearchList.Name = "btnSearchList";
            this.btnSearchList.Size = new System.Drawing.Size(110, 39);
            this.btnSearchList.TabIndex = 1;
            this.btnSearchList.Text = "Search";
            this.btnSearchList.UseVisualStyleBackColor = true;
            this.btnSearchList.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(679, 67);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(174, 37);
            this.searchtxt.TabIndex = 6;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Column1,
            this.Topic,
            this.PartofSpeech});
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 418);
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
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(706, 372);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 39);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(706, 245);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 39);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefreshlist
            // 
            this.btnRefreshlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshlist.Location = new System.Drawing.Point(706, 178);
            this.btnRefreshlist.Name = "btnRefreshlist";
            this.btnRefreshlist.Size = new System.Drawing.Size(110, 39);
            this.btnRefreshlist.TabIndex = 4;
            this.btnRefreshlist.Text = "Refresh";
            this.btnRefreshlist.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDelete.Location = new System.Drawing.Point(706, 312);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(110, 39);
            this.bntDelete.TabIndex = 2;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(881, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quiz";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(744, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 30);
            this.button4.TabIndex = 21;
            this.button4.Text = "Skip";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(613, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(240, 274);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 38);
            this.textBox3.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(240, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 38);
            this.progressBar1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter the answer";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Time";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(389, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 48);
            this.button3.TabIndex = 14;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(862, 131);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(865, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quiz History";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView2.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(803, 507);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quiz";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Result";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "List Question";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Answer";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button9);
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(865, 537);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(754, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 42);
            this.button9.TabIndex = 2;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(297, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 231);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Level";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(58, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 42);
            this.button8.TabIndex = 2;
            this.button8.Text = "Dificult";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(58, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 42);
            this.button7.TabIndex = 1;
            this.button7.Text = "Normal";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(58, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 42);
            this.button6.TabIndex = 0;
            this.button6.Text = "Easy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(355, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 42);
            this.button5.TabIndex = 0;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(910, 643);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblPartOfSpeech;
        private System.Windows.Forms.ComboBox cmbPartOfSpeech;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBoxTopics;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Button btnRefreshlist;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnSearchList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartofSpeech;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button txtenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
    }
}
