using projeto_design_patterns.design_patterns.strategy;
using projeto_design_patterns.model.entities;
using projeto_design_patterns.model.services;

namespace projeto_design_patterns
{
    public partial class viewCompracs : Form
    {
        private CarroService carService = new CarroService();
        private Compra entity = new Compra();
        private CompraService compraService = new CompraService();
        private List<Carro> listaDeCompras = new List<Carro>();
        private Desconto desconto = new Desconto();

        private float valor_bruto;
        public viewCompracs()
        {
            InitializeComponent();
            GerarGrade();
            PopularGrade();

            Nm_comprador.Text = Global.globalCliente.nome_cliente;
            Cpf_comprador.Text = Global.globalCliente.cpf_cliente;
            Tel_comprador.Text = Global.globalCliente.telefone_cliente;
        }

        private void viewCompracs_Load(object sender, EventArgs e)
        {

        }
        private void GerarGrade()
        {
            listView1.Columns.Add("Código", 50).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Marca", 100).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Modelo", 100).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Cor", 50).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Valor", 50).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Tipo", 50).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;

            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView3.Columns.Add("Código", 50).TextAlign = HorizontalAlignment.Center;
            listView3.Columns.Add("Marca", 100).TextAlign = HorizontalAlignment.Center;
            listView3.Columns.Add("Modelo", 100).TextAlign = HorizontalAlignment.Center;
            listView3.Columns.Add("Cor", 50).TextAlign = HorizontalAlignment.Center;
            listView3.Columns.Add("Valor", 50).TextAlign = HorizontalAlignment.Center;
            listView3.Columns.Add("Tipo", 50).TextAlign = HorizontalAlignment.Center;
            listView3.View = View.Details;

            listView3.GridLines = true;

        }
        private void PopularGrade()
        {
            string[] item = new string[6];



            foreach (Carro car in carService.buscarTodosOsCarros())
            {
                item[0] = Convert.ToString(car.id_carro);
                item[1] = car.marca;
                item[2] = car.modelo;
                item[3] = car.cor;
                item[4] = Convert.ToString(car.valor);
                item[5] = car.tipo;

                listView1.Items.Add(new ListViewItem(item));

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    Carro obj = carService.buscarPorId(Convert.ToInt32(item.Text));

                    entity.carros.Add(new Carro(obj.id_carro, obj.marca, obj.modelo, obj.cor, obj.valor, obj.tipo, obj.situacao_carro));

                    PopularListView2(obj);

                    listView1.Items.RemoveAt(item.Index);
                }
            }
        }

        private void PopularListView2(Carro obj)
        {
            string[] item = new string[6];

         
            item[0] = Convert.ToString(obj.id_carro);
            item[1] = obj.marca;
            item[2] = obj.modelo;
            item[3] = obj.cor;
            item[4] = Convert.ToString(obj.valor);
            item[5] = obj.tipo;

            listView3.Items.Add(new ListViewItem(item));

            valor_bruto += obj.valor;
            Valor_bruto.Text = Convert.ToString(valor_bruto);

            if (entity.carros.Count == 1)
            {
                desconto.setStrategy(new _10percent());
                Total_desconto.Text = "10%";
            }
            else if (entity.carros.Count == 2)
            {
                desconto.setStrategy(new _20percent());
                Total_desconto.Text = "20%";
            }
            else if (entity.carros.Count >= 3)
            {
                desconto.setStrategy(new _30percent());
                Total_desconto.Text = "30%";
            }

            entity.valor_compra = 0;

            entity.calcularTotal();

            entity.valor_compra = entity.valor_compra - (entity.valor_compra * desconto.descontar());

            Valor_total.Text = Convert.ToString(entity.valor_compra);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(entity.carros == null)
            {
                MessageBox.Show("A sua lista de compras está vazia");
            }
            else
            {
                try
                {
                    entity.cliente = Global.globalCliente;
                    entity.data_compra = "HOJE";
                    compraService.save(entity);

                    MessageBox.Show("Compra efetuada com sucesso!");

                    foreach (ListViewItem item in listView3.Items)
                    {
                        listView3.Items.RemoveAt(item.Index);                    
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            
        }
    }
}
