namespace ödev_alan_çevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            double UzunKenar = double.Parse(UzunKtxt.Text);  // stringi doubla çevirme kodu |text box kullanıcıdan veri alır 


            //double UzunKenar = Convert.ToDouble(UzunKtxt); // bu hata veriyor yanlış çeviriyor
            double KısaKenar = double.Parse(KısaKtxt.Text);

            double Alan = KısaKenar*UzunKenar;
            double Cevre = 2*(KısaKenar+UzunKenar);

            alanlbl.Text= Alan.ToString();    // alanlbl'a alan işelmini yazdır
            cevrelbl.Text= Cevre.ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KısaKtxt.Text = "0";    // kullanıcı sayı girmezse 0 yazılsın
            UzunKtxt.Text = "0";

            alanlbl.Text = "";
            cevrelbl.Text = "";

        }

    }
}