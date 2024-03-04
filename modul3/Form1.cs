namespace modul3
{
    public partial class Form1 : Form
    {
        int jumlah;
        string bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, bt10, bt11, bt12;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bt6 = "6";
            label1.Text = label1.Text + bt6; ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bt2 = "2";
            label1.Text = label1.Text + bt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bt1 = "1";
            label1.Text = label1.Text + bt1;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bt3 = "3";
            label1.Text = label1.Text + bt3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bt4 = "4";
            label1.Text = label1.Text + bt4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bt5 = "5";
            label1.Text = label1.Text + bt5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bt7 = "7";
            label1.Text = label1.Text + bt7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bt8 = "8";
            label1.Text = label1.Text + bt8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bt9 = "9";
            label1.Text = label1.Text + bt9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bt11 = "0";
            label1.Text = label1.Text + bt11;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            jumlah = Convert.ToInt32(label1.Text);
            label1.Text = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int jumlah2, hasil;
            jumlah2 = Convert.ToInt32(label1.Text);
            hasil = jumlah + jumlah2;
            label1.Text = Convert.ToString(hasil);
        }
    }
}
