namespace Dijital_Saat
{
    public partial class Form1 : Form
    {
        int saat = 21; int dk = 56; int sn = 00;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sn++;
            label1.Text = saat + " : " + dk + " : " + sn;
            if (sn == 60)
            {

                dk++;
                label1.Text = saat+" : "+dk + " : " + sn;
                sn = 0;
            }
            if(dk == 60)
            {
                saat++;
                dk = 0;
                label1.Text = saat + " : " + dk + " : " + sn;
                sn = 0;
            }
        }
    }
}