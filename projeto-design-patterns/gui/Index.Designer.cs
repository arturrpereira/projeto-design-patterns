namespace projeto_design_patterns
{
    partial class index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCompra = new System.Windows.Forms.Button();
            this.barraServico = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.Principal = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.Btn_inserirVeic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.barraServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(205)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.Btn_inserirVeic);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnCompra);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 688);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 85);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(13, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 84);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel4.Location = new System.Drawing.Point(0, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 55);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(125)))), ((int)(((byte)(168)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.Black;
            this.btnCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCompra.Image")));
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(5, 113);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(245, 55);
            this.btnCompra.TabIndex = 0;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.BtnCompra_Click);
            // 
            // barraServico
            // 
            this.barraServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.barraServico.Controls.Add(this.btnHome);
            this.barraServico.Controls.Add(this.btnSair);
            this.barraServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraServico.Location = new System.Drawing.Point(250, 0);
            this.barraServico.Name = "barraServico";
            this.barraServico.Size = new System.Drawing.Size(1132, 85);
            this.barraServico.TabIndex = 1;
            this.barraServico.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.barraServico.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraServico_MouseDown);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1068, 27);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(35, 35);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Principal
            // 
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.Location = new System.Drawing.Point(250, 85);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(1132, 603);
            this.Principal.TabIndex = 2;
            this.Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Principal_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(18, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 52);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Btn_inserirVeic
            // 
            this.Btn_inserirVeic.BackColor = System.Drawing.Color.Transparent;
            this.Btn_inserirVeic.FlatAppearance.BorderSize = 0;
            this.Btn_inserirVeic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(125)))), ((int)(((byte)(168)))));
            this.Btn_inserirVeic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_inserirVeic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inserirVeic.ForeColor = System.Drawing.Color.Black;
            this.Btn_inserirVeic.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inserirVeic.Image")));
            this.Btn_inserirVeic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_inserirVeic.Location = new System.Drawing.Point(5, 184);
            this.Btn_inserirVeic.Name = "Btn_inserirVeic";
            this.Btn_inserirVeic.Size = new System.Drawing.Size(245, 55);
            this.Btn_inserirVeic.TabIndex = 4;
            this.Btn_inserirVeic.Text = "Inserir";
            this.Btn_inserirVeic.UseVisualStyleBackColor = false;
            this.Btn_inserirVeic.Visible = false;
            this.Btn_inserirVeic.Click += new System.EventHandler(this.Btn_inserirVeic_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 55);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 688);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.barraServico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.barraServico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel barraServico;
        private System.Windows.Forms.Panel Principal;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Button Btn_inserirVeic;
        private System.Windows.Forms.Panel panel2;
    }
}

