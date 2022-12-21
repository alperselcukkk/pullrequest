namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ucret = Convert.ToInt32(textBox1.Text)*4 + Convert.ToInt32(textBox2.Text)*2
                + Convert.ToInt32(textBox3.Text) * 3 + Convert.ToInt32(textBox4.Text) * 15;

            label12.Text = "Toplam : "+ucret.ToString()+" Lira";
        }
    }
}