namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sum = tx1.Text.Split(' ')
                                        .Where(s => !string.IsNullOrWhiteSpace(s))
                                        .Select(s => int.Parse(s))
                                        .Sum();
            tx1.Text = sum.ToString();
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(tx2.Text);
            tx2.Text = (currentValue + 1).ToString();
            var numbers = tx3.Text.Split(' ')
                                          .Where(s => !string.IsNullOrWhiteSpace(s))
                                          .Select(s => int.Parse(s));
            double average = numbers.Average();
            tx3.Text = average.ToString();
        }

    }
}
/