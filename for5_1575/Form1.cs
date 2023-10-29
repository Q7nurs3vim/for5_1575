namespace for5_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbSayi.Items.Clear();

            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);
            int degisim = Convert.ToInt32(txtDegisim.Text);

            for (int i = baslangic; i <= bitis; i = i + degisim)
            {
                lbSayi.Items.Add(i);
            }
        }
    }
}