namespace projeto_design_patterns.gui
{
    partial class viewInserir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCarro_popular = new System.Windows.Forms.Button();
            this.BtnCarro_luxo = new System.Windows.Forms.Button();
            this.BtnCarro_esportivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserir:";
            // 
            // BtnCarro_popular
            // 
            this.BtnCarro_popular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BtnCarro_popular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCarro_popular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCarro_popular.FlatAppearance.BorderSize = 0;
            this.BtnCarro_popular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarro_popular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCarro_popular.ForeColor = System.Drawing.Color.White;
            this.BtnCarro_popular.Location = new System.Drawing.Point(168, 238);
            this.BtnCarro_popular.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCarro_popular.Name = "BtnCarro_popular";
            this.BtnCarro_popular.Size = new System.Drawing.Size(162, 45);
            this.BtnCarro_popular.TabIndex = 7;
            this.BtnCarro_popular.Text = "Carro popular";
            this.BtnCarro_popular.UseVisualStyleBackColor = false;
            this.BtnCarro_popular.Click += new System.EventHandler(this.BtnCarro_popular_Click);
            // 
            // BtnCarro_luxo
            // 
            this.BtnCarro_luxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BtnCarro_luxo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCarro_luxo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCarro_luxo.FlatAppearance.BorderSize = 0;
            this.BtnCarro_luxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarro_luxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCarro_luxo.ForeColor = System.Drawing.Color.White;
            this.BtnCarro_luxo.Location = new System.Drawing.Point(407, 238);
            this.BtnCarro_luxo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCarro_luxo.Name = "BtnCarro_luxo";
            this.BtnCarro_luxo.Size = new System.Drawing.Size(162, 45);
            this.BtnCarro_luxo.TabIndex = 8;
            this.BtnCarro_luxo.Text = "Carro luxo";
            this.BtnCarro_luxo.UseVisualStyleBackColor = false;
            this.BtnCarro_luxo.Click += new System.EventHandler(this.BtnCarro_luxo_Click);
            // 
            // BtnCarro_esportivo
            // 
            this.BtnCarro_esportivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BtnCarro_esportivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCarro_esportivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCarro_esportivo.FlatAppearance.BorderSize = 0;
            this.BtnCarro_esportivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarro_esportivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCarro_esportivo.ForeColor = System.Drawing.Color.White;
            this.BtnCarro_esportivo.Location = new System.Drawing.Point(642, 238);
            this.BtnCarro_esportivo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCarro_esportivo.Name = "BtnCarro_esportivo";
            this.BtnCarro_esportivo.Size = new System.Drawing.Size(162, 45);
            this.BtnCarro_esportivo.TabIndex = 9;
            this.BtnCarro_esportivo.Text = "Carro esportivo";
            this.BtnCarro_esportivo.UseVisualStyleBackColor = false;
            this.BtnCarro_esportivo.Click += new System.EventHandler(this.BtnCarro_esportivo_Click);
            // 
            // viewInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 565);
            this.Controls.Add(this.BtnCarro_esportivo);
            this.Controls.Add(this.BtnCarro_luxo);
            this.Controls.Add(this.BtnCarro_popular);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewInserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewInserir";
            this.Load += new System.EventHandler(this.viewInserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCarro_popular;
        private System.Windows.Forms.Button BtnCarro_luxo;
        private System.Windows.Forms.Button BtnCarro_esportivo;
    }
}