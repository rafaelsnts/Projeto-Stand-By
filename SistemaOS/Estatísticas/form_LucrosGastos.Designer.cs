namespace SistemaOS.Financeiro
{
    partial class form_LucrosGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LucrosGastos));
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.date_Final = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.date_Inicial = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lbl_TotalLucro = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_TotalGastos = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_TextoLucro = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_TextoGastos = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btn_Buscar.Image = global::SistemaOS.Properties.Resources.search_50px;
            this.btn_Buscar.Location = new System.Drawing.Point(762, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(66, 65);
            this.btn_Buscar.TabIndex = 18;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // date_Final
            // 
            this.date_Final.BackColor = System.Drawing.Color.Transparent;
            this.date_Final.BorderRadius = 1;
            this.date_Final.Color = System.Drawing.Color.Silver;
            this.date_Final.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.date_Final.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.date_Final.DisabledColor = System.Drawing.Color.Gray;
            this.date_Final.DisplayWeekNumbers = false;
            this.date_Final.DPHeight = 0;
            this.date_Final.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_Final.FillDatePicker = false;
            this.date_Final.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_Final.ForeColor = System.Drawing.Color.White;
            this.date_Final.Icon = ((System.Drawing.Image)(resources.GetObject("date_Final.Icon")));
            this.date_Final.IconColor = System.Drawing.Color.White;
            this.date_Final.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.date_Final.LeftTextMargin = 5;
            this.date_Final.Location = new System.Drawing.Point(834, 21);
            this.date_Final.MinimumSize = new System.Drawing.Size(4, 32);
            this.date_Final.Name = "date_Final";
            this.date_Final.Size = new System.Drawing.Size(220, 32);
            this.date_Final.TabIndex = 22;
            // 
            // date_Inicial
            // 
            this.date_Inicial.BackColor = System.Drawing.Color.Transparent;
            this.date_Inicial.BorderRadius = 1;
            this.date_Inicial.Color = System.Drawing.Color.Silver;
            this.date_Inicial.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.date_Inicial.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.date_Inicial.DisabledColor = System.Drawing.Color.Gray;
            this.date_Inicial.DisplayWeekNumbers = false;
            this.date_Inicial.DPHeight = 0;
            this.date_Inicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_Inicial.FillDatePicker = false;
            this.date_Inicial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_Inicial.ForeColor = System.Drawing.Color.White;
            this.date_Inicial.Icon = ((System.Drawing.Image)(resources.GetObject("date_Inicial.Icon")));
            this.date_Inicial.IconColor = System.Drawing.Color.White;
            this.date_Inicial.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.date_Inicial.LeftTextMargin = 5;
            this.date_Inicial.Location = new System.Drawing.Point(536, 21);
            this.date_Inicial.MinimumSize = new System.Drawing.Size(4, 32);
            this.date_Inicial.Name = "date_Inicial";
            this.date_Inicial.Size = new System.Drawing.Size(220, 32);
            this.date_Inicial.TabIndex = 21;
            // 
            // lbl_TotalLucro
            // 
            this.lbl_TotalLucro.AllowParentOverrides = false;
            this.lbl_TotalLucro.AutoEllipsis = false;
            this.lbl_TotalLucro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_TotalLucro.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_TotalLucro.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalLucro.ForeColor = System.Drawing.Color.Green;
            this.lbl_TotalLucro.Location = new System.Drawing.Point(226, 164);
            this.lbl_TotalLucro.Name = "lbl_TotalLucro";
            this.lbl_TotalLucro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TotalLucro.Size = new System.Drawing.Size(299, 128);
            this.lbl_TotalLucro.TabIndex = 23;
            this.lbl_TotalLucro.Text = "LUCRO";
            this.lbl_TotalLucro.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TotalLucro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_TotalLucro.Visible = false;
            // 
            // lbl_TotalGastos
            // 
            this.lbl_TotalGastos.AllowParentOverrides = false;
            this.lbl_TotalGastos.AutoEllipsis = false;
            this.lbl_TotalGastos.CursorType = null;
            this.lbl_TotalGastos.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalGastos.ForeColor = System.Drawing.Color.Red;
            this.lbl_TotalGastos.Location = new System.Drawing.Point(1061, 164);
            this.lbl_TotalGastos.Name = "lbl_TotalGastos";
            this.lbl_TotalGastos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TotalGastos.Size = new System.Drawing.Size(352, 128);
            this.lbl_TotalGastos.TabIndex = 24;
            this.lbl_TotalGastos.Text = "GASTOS";
            this.lbl_TotalGastos.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TotalGastos.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_TotalGastos.Visible = false;
            // 
            // lbl_TextoLucro
            // 
            this.lbl_TextoLucro.AllowParentOverrides = false;
            this.lbl_TextoLucro.AutoEllipsis = false;
            this.lbl_TextoLucro.CursorType = null;
            this.lbl_TextoLucro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextoLucro.ForeColor = System.Drawing.Color.White;
            this.lbl_TextoLucro.Location = new System.Drawing.Point(226, 104);
            this.lbl_TextoLucro.Name = "lbl_TextoLucro";
            this.lbl_TextoLucro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TextoLucro.Size = new System.Drawing.Size(258, 45);
            this.lbl_TextoLucro.TabIndex = 25;
            this.lbl_TextoLucro.Text = "TOTAL DE LUCRO";
            this.lbl_TextoLucro.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TextoLucro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_TextoLucro.Visible = false;
            // 
            // lbl_TextoGastos
            // 
            this.lbl_TextoGastos.AllowParentOverrides = false;
            this.lbl_TextoGastos.AutoEllipsis = false;
            this.lbl_TextoGastos.CursorType = null;
            this.lbl_TextoGastos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextoGastos.ForeColor = System.Drawing.Color.White;
            this.lbl_TextoGastos.Location = new System.Drawing.Point(1061, 104);
            this.lbl_TextoGastos.Name = "lbl_TextoGastos";
            this.lbl_TextoGastos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TextoGastos.Size = new System.Drawing.Size(276, 45);
            this.lbl_TextoGastos.TabIndex = 26;
            this.lbl_TextoGastos.Text = "TOTAL DE GASTOS";
            this.lbl_TextoGastos.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_TextoGastos.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_TextoGastos.Visible = false;
            // 
            // form_LucrosGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1591, 478);
            this.Controls.Add(this.lbl_TextoGastos);
            this.Controls.Add(this.lbl_TextoLucro);
            this.Controls.Add(this.lbl_TotalGastos);
            this.Controls.Add(this.lbl_TotalLucro);
            this.Controls.Add(this.date_Final);
            this.Controls.Add(this.date_Inicial);
            this.Controls.Add(this.btn_Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_LucrosGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_LucrosGastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Buscar;
        private Bunifu.UI.WinForms.BunifuDatePicker date_Final;
        private Bunifu.UI.WinForms.BunifuDatePicker date_Inicial;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TotalLucro;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TotalGastos;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TextoLucro;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TextoGastos;
    }
}