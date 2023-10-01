namespace ADS_ED1I4_20230918
{
    public partial class Form1 : Form
    {
        readonly Guiches guiches = new();
        readonly Senhas senhas = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void listarAtendimentoBtn_Click(object sender, EventArgs e)
        {
            atendimentosListBox.Items.Clear();

            List<Senha> atendimentos = new();

            foreach (Guiche guiche in guiches.ListaGuiches)
            {
                atendimentos.AddRange(guiche.Atendimentos);
            }

            atendimentos.Sort((a, b) => a.Id.CompareTo(b.Id));

            foreach (Senha senha in atendimentos) 
            {
                atendimentosListBox.Items.Add(senha.DadosCompletos());
            }
        }

        private void gerarBtn_Click(object sender, EventArgs e)
        {
            senhas.Gerar();
        }

        private void listarSenhasBtn_Click(object sender, EventArgs e)
        {
            senhasListBox.Items.Clear();

            foreach (Senha senha in senhas.FilaSenhas)
            {
                senhasListBox.Items.Add(senha.DadosParciais());
            }
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            Guiche newGuiche = new(guiches.ListaGuiches.Count + 1);

            guiches.AdicionarGuiche(newGuiche);

            guicheCounterLabel.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void chamarBtn_Click(object sender, EventArgs e)
        {
            String id = guicheNumberTxtBox.Text;

            if (id.Length == 0) return;

            Guiche? foundGuiche = guiches.ListaGuiches.FirstOrDefault(
                    (element) => element.Id.Equals(int.Parse(id))
                );

            if (foundGuiche == null) return;

            foundGuiche.Chamar(senhas.FilaSenhas);
        }
    }
}