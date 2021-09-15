
namespace Rateio
{
    partial class FormRateio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRateio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRatear = new System.Windows.Forms.Button();
            this.buttonZerar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.listViewAtivos = new System.Windows.Forms.ListView();
            this.columnHeaderTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRateio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.textBoxCompras = new System.Windows.Forms.TextBox();
            this.textBoxVendas = new System.Windows.Forms.TextBox();
            this.textBoxCorretagem = new System.Windows.Forms.TextBox();
            this.textBoxValorLiquido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCustos = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total das compras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total das vendas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Corretagem por ativo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor líquido da operação:";
            // 
            // buttonRatear
            // 
            this.buttonRatear.Location = new System.Drawing.Point(365, 84);
            this.buttonRatear.Name = "buttonRatear";
            this.buttonRatear.Size = new System.Drawing.Size(75, 23);
            this.buttonRatear.TabIndex = 15;
            this.buttonRatear.Text = "Ratear";
            this.buttonRatear.UseVisualStyleBackColor = true;
            this.buttonRatear.Click += new System.EventHandler(this.buttonRatear_Click);
            // 
            // buttonZerar
            // 
            this.buttonZerar.Location = new System.Drawing.Point(365, 133);
            this.buttonZerar.Name = "buttonZerar";
            this.buttonZerar.Size = new System.Drawing.Size(75, 23);
            this.buttonZerar.TabIndex = 16;
            this.buttonZerar.Text = "Zerar";
            this.buttonZerar.UseVisualStyleBackColor = true;
            this.buttonZerar.Click += new System.EventHandler(this.buttonZerar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(13, 82);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 12;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxValor);
            this.groupBox2.Controls.Add(this.listViewAtivos);
            this.groupBox2.Controls.Add(this.buttonLimpar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxTicket);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonRemover);
            this.groupBox2.Controls.Add(this.buttonAdicionar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ativos";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(146, 46);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 11;
            this.textBoxValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxValor_KeyDown);
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            this.textBoxValor.Leave += new System.EventHandler(this.textBoxValor_Leave);
            // 
            // listViewAtivos
            // 
            this.listViewAtivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTicket,
            this.columnHeaderValor,
            this.columnHeaderRateio});
            this.listViewAtivos.FullRowSelect = true;
            this.listViewAtivos.HideSelection = false;
            this.listViewAtivos.Location = new System.Drawing.Point(13, 111);
            this.listViewAtivos.MultiSelect = false;
            this.listViewAtivos.Name = "listViewAtivos";
            this.listViewAtivos.Size = new System.Drawing.Size(431, 131);
            this.listViewAtivos.TabIndex = 19;
            this.listViewAtivos.UseCompatibleStateImageBehavior = false;
            this.listViewAtivos.View = System.Windows.Forms.View.Details;
            this.listViewAtivos.SelectedIndexChanged += new System.EventHandler(this.listViewAtivos_SelectedIndexChanged);
            // 
            // columnHeaderTicket
            // 
            this.columnHeaderTicket.Text = "Ticket";
            this.columnHeaderTicket.Width = 70;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.Width = 120;
            // 
            // columnHeaderRateio
            // 
            this.columnHeaderRateio.Text = "Taxas";
            this.columnHeaderRateio.Width = 120;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(176, 82);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor da operação";
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTicket.Location = new System.Drawing.Point(13, 47);
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.Size = new System.Drawing.Size(100, 20);
            this.textBoxTicket.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ticket";
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(94, 82);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 13;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // textBoxCompras
            // 
            this.textBoxCompras.Location = new System.Drawing.Point(158, 56);
            this.textBoxCompras.Name = "textBoxCompras";
            this.textBoxCompras.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompras.TabIndex = 3;
            this.textBoxCompras.Leave += new System.EventHandler(this.textBoxCompras_Leave);
            // 
            // textBoxVendas
            // 
            this.textBoxVendas.Location = new System.Drawing.Point(158, 15);
            this.textBoxVendas.Name = "textBoxVendas";
            this.textBoxVendas.Size = new System.Drawing.Size(100, 20);
            this.textBoxVendas.TabIndex = 1;
            this.textBoxVendas.Leave += new System.EventHandler(this.textBoxVendas_Leave);
            // 
            // textBoxCorretagem
            // 
            this.textBoxCorretagem.Location = new System.Drawing.Point(158, 94);
            this.textBoxCorretagem.Name = "textBoxCorretagem";
            this.textBoxCorretagem.Size = new System.Drawing.Size(100, 20);
            this.textBoxCorretagem.TabIndex = 5;
            this.textBoxCorretagem.Leave += new System.EventHandler(this.textBoxCorretagem_Leave);
            // 
            // textBoxValorLiquido
            // 
            this.textBoxValorLiquido.Location = new System.Drawing.Point(158, 130);
            this.textBoxValorLiquido.Name = "textBoxValorLiquido";
            this.textBoxValorLiquido.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorLiquido.TabIndex = 7;
            this.textBoxValorLiquido.Leave += new System.EventHandler(this.textBoxValorLiquido_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total dos custos:";
            // 
            // textBoxCustos
            // 
            this.textBoxCustos.Enabled = false;
            this.textBoxCustos.Location = new System.Drawing.Point(158, 167);
            this.textBoxCustos.Name = "textBoxCustos";
            this.textBoxCustos.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustos.TabIndex = 18;
            // 
            // FormRateio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 441);
            this.Controls.Add(this.textBoxCustos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxValorLiquido);
            this.Controls.Add(this.textBoxCorretagem);
            this.Controls.Add(this.textBoxVendas);
            this.Controls.Add(this.textBoxCompras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonZerar);
            this.Controls.Add(this.buttonRatear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRateio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rateio de Despesas com Ações";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRatear;
        private System.Windows.Forms.Button buttonZerar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.ListView listViewAtivos;
        private System.Windows.Forms.ColumnHeader columnHeaderTicket;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderRateio;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxCompras;
        private System.Windows.Forms.TextBox textBoxVendas;
        private System.Windows.Forms.TextBox textBoxCorretagem;
        private System.Windows.Forms.TextBox textBoxValorLiquido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCustos;
    }
}

