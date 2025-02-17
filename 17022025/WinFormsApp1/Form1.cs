namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetFormData()
        {
            string fullName = textBox1.Text;
            string city = comboBox1.Text;
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            string birthDate = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            string checkedSections = "";
            foreach (var section in checkedListBox1.CheckedItems)
            {
                checkedSections += section.ToString() + ", ";

            }
            if (!string.IsNullOrEmpty(checkedSections))
            {
                checkedSections = checkedSections.TrimEnd(',', ' ');
            }
            return $"Фамилия, имя и отчество: {fullName}.\nГород: {city}.\nПол: {gender}.\nДата рождения: {birthDate}.\nВыбранные секции: {checkedSections}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(GetFormData());
            MessageBox.Show("Результаты сохранены!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}