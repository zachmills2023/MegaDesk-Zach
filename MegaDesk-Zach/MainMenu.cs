namespace MegaDesk_Zach
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        // NAVIGATION CONTROLS BELOW:
        private void button1_Click(object sender, EventArgs e) // AddQuote Button
        {
            AddQuote aq = new AddQuote();
            aq.Show();
        }

        private void button1_Click_1(object sender, EventArgs e) // ViewAllQuotes Button
        {
            ViewAllQuotes vaq = new ViewAllQuotes();
            vaq.Show();
        }

        private void button2_Click(object sender, EventArgs e) // SearchQuote Button
        {
            SearchQuotes sq = new SearchQuotes();
            sq.Show();
        }
        private void button3_Click(object sender, EventArgs e) // Exit Button
        {
            Application.Exit();
        }
    }
}
