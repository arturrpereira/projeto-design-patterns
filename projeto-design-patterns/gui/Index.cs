using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace projeto_design_patterns
{
    public partial class index : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public index()
        {
            InitializeComponent();
        }


        private void AbrirNOPrincipal(object form)
        {
            if (this.Principal.Controls.Count > 0)
                this.Principal.Controls.RemoveAt(0);
            Form principal = form as Form;
            principal.TopLevel = false;
            principal.FormBorderStyle = FormBorderStyle.None;
            principal.Dock = DockStyle.Fill;
            this.Principal.Controls.Add(principal);
            this.Principal.Tag = principal;
            principal.BringToFront();
            principal.Show();

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new inicio());

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Principal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BarraServico_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new viewCompracs());
            btnHome.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new inicio());
            btnCompra.Visible = true;
        }


        
        private void Btn_inserirVeic_Click(object sender, EventArgs e)
        {
            
        }
    }
}
