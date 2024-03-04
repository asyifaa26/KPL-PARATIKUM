namespace modul3
{
    public partial class Form1 : Form
    {

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
            label1.Text = "6" + bt6;
            bt6 += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "2" + bt2;
            bt2 += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bt1 += "1"; 
            label1.Text = "1" + bt1;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3" + bt3;
            bt3 += "3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "4" + bt4;
            bt4 += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "5" + bt5;
            bt5 += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "7" + bt7;
            bt7 += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "8" + bt8;
            bt8 += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "9" + bt9;
            bt9 += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "10" + bt11;
            bt10 += "10";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "+" + bt11;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "=" + bt12;
        }
    }
}
