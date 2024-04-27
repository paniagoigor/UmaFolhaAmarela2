namespace UmaFolhaAmarela2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAleatorio_MouseEnter(object sender, EventArgs e)
        {
            Random NumAleatorio = new Random();
            int PrimeiraOpcao = NumAleatorio.Next(1, 700);
            int SegundaOpcao = NumAleatorio.Next(1, 200);
            btnAleatorio.Location = new Point(PrimeiraOpcao, SegundaOpcao);
        }

        private void btnFinalizador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otimo. FIM :)");
            Environment.Exit(0);

        }
    }
}