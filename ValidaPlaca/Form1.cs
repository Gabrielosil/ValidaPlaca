namespace ValidaPlaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (ValidaPlaca(txtPlaca.Text))
            {
                if (Database.ExistePlaca(txtPlaca.Text))
                {
                    MessageBox.Show("Placa já existente!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Database.SalvarPlacaDeCarro(txtPlaca.Text);
                MessageBox.Show("Placa Válida");
                AtualizarListView();
            }
            else
                MessageBox.Show("Placa Inválida");

        }

        private bool ValidaPlaca(string placa)
        {
            if (string.IsNullOrEmpty(placa) || placa.Length != 8)
                return false;
            else
            {
                string inicioDaPlaca = placa.Substring(0, 3);
                string finalDaPlaca = placa.Substring(4);
                if (placa[3] != '-' || !inicioDaPlaca.All(char.IsLetter) || !finalDaPlaca.All(char.IsDigit))
                    return false;
                else
                    return true;
            }
        }

        private void AtualizarListView()
        {
            lvPlacas.Items.Clear();

            List<string> placas = Database.ListaPlacas();

            foreach (string placa in placas)
            {
                lvPlacas.Items.Add(new ListViewItem(placa));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarListView();
        }
    }
}