using projeto_design_patterns.design_patterns;
using projeto_design_patterns.model.entities;
using projeto_design_patterns.model.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_design_patterns.gui
{
    public partial class viewInserir : Form
    {
        CarroFactory cf = null;
        PopularService popularService = new PopularService();
        LuxoService luxoService = new LuxoService();
        EsportivoService esportivoService = new EsportivoService();

        public viewInserir()
        {
            InitializeComponent();
        }

        private void viewInserir_Load(object sender, EventArgs e)
        {

        }

        private void BtnCarro_popular_Click(object sender, EventArgs e)
        {
            //Abstract factory definindo o tipo de carro que sera montado
            cf = new CarroPopularFactory();
            Carro carro = cf.montarCarro();

            try
            {
                popularService.save((Popular)carro);
                MessageBox.Show("Carro popular construído com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BtnCarro_luxo_Click(object sender, EventArgs e)
        {
            //Abstract factory definindo o tipo de carro que sera montado
            cf = new CarroLuxoFactory();
            Carro carro = cf.montarCarro();

            try
            {
                luxoService.save((Luxo)carro);
                MessageBox.Show("Carro de luxo construído com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BtnCarro_esportivo_Click(object sender, EventArgs e)
        {
            //Abstract factory definindo o tipo de carro que sera montado
            cf = new CarroEsportivoFactory();
            Carro carro = cf.montarCarro();

            try
            {
                esportivoService.save((Esportivo)carro);
                MessageBox.Show("Carro esportivo construído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
