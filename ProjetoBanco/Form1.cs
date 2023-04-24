namespace ProjetoBanco
{
    public partial class Form1 : Form
    {
        public List<Conta> listContas { get; set; }
        public int IndexCBbox { get; set; }
        public Conta? ContaAtual1 { get; set; }
        public Conta? ContaAtual2 { get; set; }
        public Conta? ContaAtual3 { get; set; }

        public Form1()
        {
            InitializeComponent();
            listContas = new List<Conta>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarLabel(5);
            AtualizarComboBox();
        }

        private void AtualizarComboBox()
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listContas;

            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            //comboBox1.DataSource = listContas;
            comboBox1.DisplayMember = "Numero";
            comboBox1.ValueMember = "Numero";
            comboBox1.DataSource = bindingSource1.DataSource;

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = listContas;

            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            //comboBox2.DataSource = listContas;
            comboBox2.DisplayMember = "Numero";
            comboBox2.ValueMember = "Numero";
            comboBox2.DataSource = bindingSource2.DataSource;

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = listContas;

            comboBox3.DataSource = null;
            comboBox3.Items.Clear();
            //comboBox3.DataSource = listContas;
            comboBox3.DisplayMember = "Numero";
            comboBox3.ValueMember = "Numero";
            comboBox3.DataSource = bindingSource3.DataSource;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta? selectedConta = comboBox1.SelectedItem as Conta;
            if (selectedConta != null)
            {
                IndexCBbox = listContas.FindIndex(x => x.Numero == selectedConta.Numero);
                ContaAtual1 = listContas[IndexCBbox];
                AtualizarLabel(1);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta? selectedConta = comboBox2.SelectedItem as Conta;
            IndexCBbox = listContas.FindIndex(x => x.Numero == selectedConta.Numero);
            ContaAtual2 = listContas[IndexCBbox];
            AtualizarLabel(3);
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta? selectedConta = comboBox3.SelectedItem as Conta;
            IndexCBbox = listContas.FindIndex(x => x.Numero == selectedConta.Numero);
            ContaAtual3 = listContas[IndexCBbox];
            AtualizarLabel(4);
        }
        private void Limpar(int opcao)   //Limpar campos preenchidos
        {
            if (opcao == 1)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox5.Text = string.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else if (opcao == 2)
            {
                comboBox1.ResetText();
                textBox3.Text = string.Empty;
            }
            else if (opcao == 3)
            {
                comboBox2.ResetText();
                comboBox3.ResetText();
                textBox4.Text = string.Empty;
            }
        }
        private void AtualizarLabel(int opcao)  //Atualizar Label
        {
            if (opcao == 1)
            {
                label1.Text = listContas[IndexCBbox].GetSaldo().ToString();
                label8.Text = listContas[IndexCBbox].GetSaldo().ToString();
                label2.Text = listContas[IndexCBbox].Numero.ToString();
                label3.Text = listContas[IndexCBbox].Cliente.Nome.ToString();
            }
            else if (opcao == 2)
            {
                label8.Text = listContas[IndexCBbox].GetSaldo().ToString();
                label1.Text = string.Empty;
            }
            else if (opcao == 3)
            {
                label1.Text = listContas[IndexCBbox].GetSaldo().ToString();
                label14.Text = listContas[IndexCBbox].GetSaldo().ToString();
                label13.Text = listContas[IndexCBbox].Numero.ToString();
                label12.Text = listContas[IndexCBbox].Cliente.Nome.ToString();
            }
            else if (opcao == 4)
            {
                label1.Text = listContas[IndexCBbox].GetSaldo().ToString();
                label20.Text = listContas[IndexCBbox].GetSaldo().ToString();
                label19.Text = listContas[IndexCBbox].Numero.ToString();
                label18.Text = listContas[IndexCBbox].Cliente.Nome.ToString();
            }
            else if (opcao == 5)
            {
                label1.Text = string.Empty;
                label3.Text = string.Empty;
                label2.Text = string.Empty;
                label8.Text = string.Empty;
                label12.Text = string.Empty;
                label13.Text = string.Empty;
                label14.Text = string.Empty;
                label18.Text = string.Empty;
                label19.Text = string.Empty;
                label20.Text = string.Empty;
            }

        }
        private void button1_Click(object sender, EventArgs e)  //Criar Conta
        {
            comboBox1.SelectedIndex = -1; // Limpar o ComboBox
            if (radioButton1.Checked)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = textBox1.Text;
                Conta conta = conta = new ContaCorrente(cliente, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox5.Text));
                listContas.Add(conta);
                AtualizarComboBox();
            }
            else if (radioButton2.Checked)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = textBox1.Text;
                Conta conta = conta = new ContaPoupanca(cliente, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox5.Text));
                listContas.Add(conta);
                AtualizarComboBox();
            }
            Limpar(1); // Limpar os campos de entrada de dados
        }

        private void button2_Click(object sender, EventArgs e)  //Depositar
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                ContaAtual1.Depositar(Convert.ToDouble(textBox3.Text));
            }
            else
            {
                MessageBox.Show("valor n�o Informado");
            }
            Limpar(2);
            AtualizarLabel(2);
        }

        private void button3_Click(object sender, EventArgs e)  //Sacar
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                if (ContaAtual1 is ContaCorrente)
                {
                    ContaAtual1.Sacar(Convert.ToDouble(textBox3.Text));
                }
                else if (ContaAtual1 is ContaPoupanca)
                {
                    ContaAtual1.Sacar(Convert.ToDouble(textBox3.Text));
                }
            }
            else
            {
                MessageBox.Show("valor n�o informado");
            }
            Limpar(2);
            AtualizarLabel(2);
        }

        private void button4_Click(object sender, EventArgs e)  //Transferir
        {
            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                if (comboBox2.SelectedItem is Conta)
                {
                    ContaAtual2.Transferir(ContaAtual2, ContaAtual3, Convert.ToDouble(textBox4.Text));
                }
                else
                {
                    MessageBox.Show("Item selecionado n�o � uma Conta");
                }
            }
            else
            {
                MessageBox.Show("valor n�o informado");
            }
            Limpar(3);
            AtualizarLabel(5);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label8.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label8.Text = "";
        }
    }
}