namespace Blackjack_program
{
    public partial class Form1 : Form
    {
        int Maxk = 11;
        int Mink = 1;
        int Max = 21;
        int spelaren = 0;
        int handlaren = 0;
        Random kl = new Random();


        public Form1()
        {
            InitializeComponent();
            
        }
        private void visable()
        {
            label3.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible= false;
            this.BackColor = Color.Green;
            spelaren = 0;
            handlaren= 0;
            spelaren += kl.Next(Mink,Maxk);
            spelaren += kl.Next(Mink, Maxk);
            handlaren += kl.Next(Mink, Maxk);
            handlaren += kl.Next(Mink, Maxk);
            string test1 = spelaren.ToString();

            string test2 = handlaren.ToString();
            textBox1.Text = test1;
            textBox2.Text = test2;
            button1.Visible= false;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string S = textBox1.Text;
            int Sp = int.Parse(S);
            Sp += kl.Next(Mink, Maxk);
            string s = Sp.ToString();
            textBox1.Text= s;
            if (Sp > Max)
            {
                visable();
                label3.Text = "Du har förlorart";
                this.BackColor = Color.Red;
                button1.Text = "Spela igen";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string S = textBox1.Text;
            string h = textBox2.Text;
            int Sp = int.Parse(S);
            int Ha = int.Parse(h);
            while (Ha < Sp && Ha < Max)
            {
                Ha += kl.Next(Mink, Maxk);
            }
            if (Ha > Max)
            {

                label3.Text = "DU HAR VUNNIT";
                this.BackColor = Color.Green;
                visable();
                button1.Text = "Spela igen";
            }
            if (Ha == Sp)
            {
                visable();
                label3.Text = "Ingen Vann";
                this.BackColor = Color.Yellow;
                button1.Text = "Spela igen";
            }
            if (Ha > Max)
            {
                visable();
                label3.Text = "DU HAR VUNNIT";
                this.BackColor = Color.Green;
                button1.Text = "Spela igen";
            }
            else
            {
                visable();
                label3.Text = "Dator har vunnit";
                this.BackColor = Color.Red;
                button1.Text = "Spela igen";
            }
            textBox2.Text = Ha.ToString();
        }
    }
}