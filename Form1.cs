namespace WordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WordCountLabel.Text = "Word Count: 0";
            CharacterCountNoWhite.Text = "Character Count (no whitespace): 0";
            CharacterCountLabel.Text = "Character Count: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            WordCountLabel.Text = "Word Count: 0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        CharacterCountLabel.Text = $"Character Count: {textBox1.Text.Length}";
            var characterCountNoWhite = textBox1.Text.Count(c => !char.IsWhiteSpace(c));
        CharacterCountNoWhite.Text = $"Character Count (No Whitespace): {characterCountNoWhite}";
            var words = textBox1.Text.Split(new[] { ' ', '\n', '\r', '\t'}, StringSplitOptions.RemoveEmptyEntries);

        WordCountLabel.Text = $"Word Count: {words.Length}";
        }
    }
}
