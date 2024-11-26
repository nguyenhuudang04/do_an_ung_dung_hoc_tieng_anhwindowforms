using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace windowforms_sqlsever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void đâsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newWordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Danh sách các chủ đề mẫu
        List<string> topics = new List<string>
{
    "Family", "Friends", "Home", "Daily Activities", "Weather",
    "Food & Drinks", "Shopping", "Education", "School", "Jobs & Professions",
    "Technology", "Office", "Communication", "Animals", "Plants", "Nature",
    "Seasons", "Geography", "Environment", "Health", "Fitness", "Human Body",
    "Diseases", "Medicine", "Mental Health", "Sports", "Music", "Movies",
    "Travel", "Hobbies", "Games", "Relationships", "Festivals & Holidays",
    "Culture", "History", "Politics", "News & Media", "Science", "Space",
    "Inventions", "Technology", "Mathematics", "Transportation", "Vehicles",
    "Road Safety", "Directions", "Travel & Tourism", "Emotions", "Personality",
    "Problem Solving", "Leadership", "Teamwork", "Colors", "Shapes", "Numbers",
    "Time", "Clothing"
};

        // Xử lý sự kiện khi người dùng chọn một chủ đề trong ListBox
        private void listBoxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có mục được chọn
            if (listBoxTopics.SelectedItem != null)
            {
                // Hiển thị mục được chọn trong TextBox
                txtTopic.Text = listBoxTopics.SelectedItem.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = txtTopic.Text.ToLower();

            // Nếu không có ký tự nào trong ô tìm kiếm, hiển thị toàn bộ danh sách chủ đề
            if (string.IsNullOrEmpty(searchQuery))
            {
                listBoxTopics.Items.Clear();
                listBoxTopics.Items.AddRange(topics.ToArray());
            }
            else
            {
                // Lọc danh sách các chủ đề có chứa từ khóa tìm kiếm
                var filteredTopics = topics
                    .Where(t => t.ToLower().Contains(searchQuery)) // Lọc các chủ đề chứa từ khóa tìm kiếm
                    .OrderBy(t => t.StartsWith(searchQuery) ? 0 : 1) // Đưa các chủ đề bắt đầu với từ khóa lên đầu
                    .ToList();

                // Cập nhật kết quả tìm kiếm vào ListBox
                listBoxTopics.Items.Clear();
                listBoxTopics.Items.AddRange(filteredTopics.ToArray());
            }

        }
        // Hàm cập nhật ListBox
        private void UpdateListBox(IEnumerable<string> sortedList)
        {
            listBoxTopics.Items.Clear(); // Xóa các mục hiện có trong ListBox
            listBoxTopics.Items.AddRange(sortedList.ToArray()); // Thêm danh sách mới vào ListBox
        }

        private void rdiAZ_CheckedChanged(object sender, EventArgs e)
        {
            var sortedTopics = topics.OrderBy(t => t).ToList();
            UpdateListBox(sortedTopics);
        }

        

        private void listBoxTopics_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string searchQuery = textBox3.Text.ToLower(); // Lấy từ khóa tìm kiếm trong ô TextBox

        //    // Nếu ô tìm kiếm trống, hiển thị toàn bộ danh sách chủ đề
        //    if (string.IsNullOrEmpty(searchQuery))
        //    {
        //        listBox1.Items.Clear();
        //        listBox1.Items.AddRange(topics.ToArray());
        //    }
        //    else
        //    {
        //        // Tìm các chủ đề phù hợp với từ khóa
        //        var filteredTopics = topics
        //            .Where(topic => topic.ToLower().Contains(searchQuery)) // Lọc theo từ khóa
        //            .OrderBy(topic => topic.StartsWith(searchQuery) ? 0 : 1) // Sắp xếp ưu tiên từ khóa
        //            .ToList();

        //        // Cập nhật ListBox
        //        listBox1.Items.Clear();
        //        listBox1.Items.AddRange(filteredTopics.ToArray());
        //    }

        //    // Nếu không tìm thấy kết quả, thông báo người dùng
        //    if (listBoxTopics.Items.Count == 0)
        //    {
        //        MessageBox.Show("Không tìm thấy chủ đề phù hợp. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Danh sách từ vựng
        List<Vocabulary> vocabularies = new List<Vocabulary>();

        // Lớp Vocabulary
        public class Vocabulary
        {
            public string Word { get; set; }
            public string Meaning { get; set; }
            public string PartOfSpeech { get; set; }
            public string Topic { get; set; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtWord.Text) ||
                string.IsNullOrWhiteSpace(txtMeaning.Text) ||
                string.IsNullOrWhiteSpace(cmbPartOfSpeech.Text) ||
                string.IsNullOrWhiteSpace(txtTopic.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm từ mới vào danh sách
            Vocabulary newWord = new Vocabulary
            {
                Word = txtWord.Text,
                Meaning = txtMeaning.Text,
                PartOfSpeech = cmbPartOfSpeech.Text,
                Topic = txtTopic.Text
            };

            vocabularies.Add(newWord);

            //// Làm mới DataGridView
            //RefreshDataGridView();

            // Xóa các ô nhập liệu sau khi thêm
            txtWord.Clear();
            txtMeaning.Clear();
            cmbPartOfSpeech.SelectedIndex = -1;
            txtTopic.Clear();
        }

    }
}
