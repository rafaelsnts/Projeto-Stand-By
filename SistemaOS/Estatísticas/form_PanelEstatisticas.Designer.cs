namespace SistemaOS.Financeiro
{
    partial class form_PanelEstatisticas
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
            this.btn_Lucros = new System.Windows.Forms.Button();
            this.btn_LucrosGastos = new System.Windows.Forms.Button();
            this.btn_TopClientes = new System.Windows.Forms.Button();
            this.btn_Prejuizos = new System.Windows.Forms.Button();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.pnl_Financeiro = new System.Windows.Forms.Panel();
            this.bunifuShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Lucros
            // 
            this.btn_Lucros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btn_Lucros.FlatAppearance.BorderSize = 0;
            this.btn_Lucros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lucros.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lucros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Lucros.Location = new System.Drawing.Point(3, 40);
            this.btn_Lucros.Name = "btn_Lucros";
            this.btn_Lucros.Size = new System.Drawing.Size(396, 88);
            this.btn_Lucros.TabIndex = 6;
            this.btn_Lucros.Text = "LUCROS";
            this.btn_Lucros.UseVisualStyleBackColor = false;
            this.btn_Lucros.Click += new System.EventHandler(this.btn_Lucros_Click);
            // 
            // btn_LucrosGastos
            // 
            this.btn_LucrosGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btn_LucrosGastos.FlatAppearance.BorderSize = 0;
            this.btn_LucrosGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LucrosGastos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LucrosGastos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_LucrosGastos.Location = new System.Drawing.Point(795, 40);
            this.btn_LucrosGastos.Name = "btn_LucrosGastos";
            this.btn_LucrosGastos.Size = new System.Drawing.Size(396, 88);
            this.btn_LucrosGastos.TabIndex = 8;
            this.btn_LucrosGastos.Text = "LUCROS / GASTOS";
            this.btn_LucrosGastos.UseVisualStyleBackColor = false;
            this.btn_LucrosGastos.Click += new System.EventHandler(this.btn_LucrosGastos_Click);
            // 
            // btn_TopClientes
            // 
            this.btn_TopClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btn_TopClientes.FlatAppearance.BorderSize = 0;
            this.btn_TopClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TopClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TopClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_TopClientes.Location = new System.Drawing.Point(1191, 40);
            this.btn_TopClientes.Name = "btn_TopClientes";
            this.btn_TopClientes.Size = new System.Drawing.Size(396, 88);
            this.btn_TopClientes.TabIndex = 9;
            this.btn_TopClientes.Text = "TOP CLIENTES";
            this.btn_TopClientes.UseVisualStyleBackColor = false;
            this.btn_TopClientes.Click += new System.EventHandler(this.btn_TopClientes_Click);
            // 
            // btn_Prejuizos
            // 
            this.btn_Prejuizos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btn_Prejuizos.FlatAppearance.BorderSize = 0;
            this.btn_Prejuizos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prejuizos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prejuizos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Prejuizos.Location = new System.Drawing.Point(399, 40);
            this.btn_Prejuizos.Name = "btn_Prejuizos";
            this.btn_Prejuizos.Size = new System.Drawing.Size(396, 88);
            this.btn_Prejuizos.TabIndex = 10;
            this.btn_Prejuizos.Text = "PREJUÍZOS";
            this.btn_Prejuizos.UseVisualStyleBackColor = false;
            this.btn_Prejuizos.Click += new System.EventHandler(this.btn_Prejuizos_Click);
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel2.BorderRadius = 1;
            this.bunifuShadowPanel2.BorderThickness = 1;
            this.bunifuShadowPanel2.Controls.Add(this.btn_Minimizar);
            this.bunifuShadowPanel2.Controls.Add(this.btn_Fechar);
            this.bunifuShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.bunifuShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowDepth = 5;
            this.bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(1591, 48);
            this.bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel2.TabIndex = 11;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Image = global::SistemaOS.Properties.Resources.minimize_window_20px;
            this.btn_Minimizar.Location = new System.Drawing.Point(1523, 12);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Image = global::SistemaOS.Properties.Resources.close_20px;
            this.btn_Fechar.Location = new System.Drawing.Point(1550, 12);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(30, 30);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // pnl_Financeiro
            // 
            this.pnl_Financeiro.Location = new System.Drawing.Point(3, 134);
            this.pnl_Financeiro.Name = "pnl_Financeiro";
            this.pnl_Financeiro.Size = new System.Drawing.Size(1591, 478);
            this.pnl_Financeiro.TabIndex = 12;
            // 
            // form_PanelFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1591, 615);
            this.Controls.Add(this.pnl_Financeiro);
            this.Controls.Add(this.bunifuShadowPanel2);
            this.Controls.Add(this.btn_Prejuizos);
            this.Controls.Add(this.btn_TopClientes);
            this.Controls.Add(this.btn_LucrosGastos);
            this.Controls.Add(this.btn_Lucros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_PanelFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Financeiro";
            this.bunifuShadowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Lucros;
        private System.Windows.Forms.Button btn_LucrosGastos;
        private System.Windows.Forms.Button btn_TopClientes;
        private System.Windows.Forms.Button btn_Prejuizos;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Panel pnl_Financeiro;
    }
}