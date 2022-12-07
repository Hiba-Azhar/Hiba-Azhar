namespace Tictactoe
{
    public partial class Form1 : Form
    {
        String player = "O";
        short movement = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button bt = (Button)sender;
            bt.BackColor = Color.LightPink;
            bt.Enabled = false;
            if (player == "O")
            {
                bt.Text = "O";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))

                {
                    MessageBox.Show(($"The winner is {player.ToUpper()}"));
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw");
                }
                player = "X";

            }
            else if (player == "X")
            {

                bt.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                  (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b5.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"The winner is {player.ToUpper()}"));
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw");
                }
                player = "O";
            }
            movement++;

        }
    }
}