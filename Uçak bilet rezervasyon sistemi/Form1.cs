namespace Uçak_bilet_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LİSTE.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + "Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + "Yolcu Bilgileri ~ Ad: " + textBox1.Text + "T.C.: " + maskedTextBox2.Text + "Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
