namespace Unesi_listu_i_animiraj__brisanje
{
    public partial class Form1 : Form
    {
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(r.Next(10, 100));
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int broj = int.Parse(textBox1.Text);
            listBox1.Items.Add(broj);
            textBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                timer1.Enabled = false;
            }
            else
            {
                listBox1.Items.RemoveAt(0);
            }
        }

        private void btnAnimirajIObrisi_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}