
namespace Trabalho
{
    partial class Cadastrar
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
            this.components = new System.ComponentModel.Container();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.LabelRSocial = new System.Windows.Forms.Label();
            this.LabelCNPJ = new System.Windows.Forms.Label();
            this.LabelIE = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.LabelTEL = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.BoxRSocial = new System.Windows.Forms.TextBox();
            this.BoxCnpj = new System.Windows.Forms.TextBox();
            this.BoxIE = new System.Windows.Forms.TextBox();
            this.BoxTelefone = new System.Windows.Forms.TextBox();
            this.BoxEndereco = new System.Windows.Forms.TextBox();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Trabalho.DataSet1();
            this.customersTableAdapter = new Trabalho.DataSet1TableAdapters.CustomersTableAdapter();
            this.customersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDs = new Trabalho.IDs();
            this.dataSet11 = new Trabalho.DataSet1();
            this.dataSet12 = new Trabalho.DataSet1();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new Trabalho.IDsTableAdapters.CustomersTableAdapter();
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.BoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(12, 12);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(107, 50);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_click);
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(12, 180);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(107, 50);
            this.btn_exibir.TabIndex = 1;
            this.btn_exibir.Text = "Exibir ";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_click);
            // 
            // dataCustomers
            // 
            this.dataCustomers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Location = new System.Drawing.Point(165, 381);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.RowHeadersWidth = 51;
            this.dataCustomers.RowTemplate.Height = 24;
            this.dataCustomers.Size = new System.Drawing.Size(605, 206);
            this.dataCustomers.TabIndex = 2;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(12, 68);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(107, 50);
            this.btn_alterar.TabIndex = 3;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(134, 599);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(12, 124);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(107, 50);
            this.btn_deletar.TabIndex = 5;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_click);
            // 
            // LabelRSocial
            // 
            this.LabelRSocial.AutoSize = true;
            this.LabelRSocial.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRSocial.Location = new System.Drawing.Point(161, 58);
            this.LabelRSocial.Name = "LabelRSocial";
            this.LabelRSocial.Size = new System.Drawing.Size(96, 21);
            this.LabelRSocial.TabIndex = 6;
            this.LabelRSocial.Text = "Razão Social";
            // 
            // LabelCNPJ
            // 
            this.LabelCNPJ.AutoSize = true;
            this.LabelCNPJ.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCNPJ.Location = new System.Drawing.Point(180, 97);
            this.LabelCNPJ.Name = "LabelCNPJ";
            this.LabelCNPJ.Size = new System.Drawing.Size(44, 21);
            this.LabelCNPJ.TabIndex = 7;
            this.LabelCNPJ.Text = "CNPJ";
            // 
            // LabelIE
            // 
            this.LabelIE.AutoSize = true;
            this.LabelIE.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIE.Location = new System.Drawing.Point(138, 138);
            this.LabelIE.Name = "LabelIE";
            this.LabelIE.Size = new System.Drawing.Size(135, 21);
            this.LabelIE.TabIndex = 8;
            this.LabelIE.Text = "Inscrição Estadual";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(161, 224);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(76, 21);
            this.E.TabIndex = 9;
            this.E.Text = "Endereço";
            // 
            // LabelTEL
            // 
            this.LabelTEL.AutoSize = true;
            this.LabelTEL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTEL.Location = new System.Drawing.Point(166, 180);
            this.LabelTEL.Name = "LabelTEL";
            this.LabelTEL.Size = new System.Drawing.Size(71, 21);
            this.LabelTEL.TabIndex = 10;
            this.LabelTEL.Text = "Telefone";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(172, 265);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(53, 21);
            this.LabelEmail.TabIndex = 11;
            this.LabelEmail.Text = "E-mail";
            // 
            // BoxRSocial
            // 
            this.BoxRSocial.Location = new System.Drawing.Point(296, 58);
            this.BoxRSocial.Name = "BoxRSocial";
            this.BoxRSocial.Size = new System.Drawing.Size(343, 22);
            this.BoxRSocial.TabIndex = 12;
            // 
            // BoxCnpj
            // 
            this.BoxCnpj.Location = new System.Drawing.Point(296, 96);
            this.BoxCnpj.Name = "BoxCnpj";
            this.BoxCnpj.Size = new System.Drawing.Size(228, 22);
            this.BoxCnpj.TabIndex = 13;
            // 
            // BoxIE
            // 
            this.BoxIE.Location = new System.Drawing.Point(296, 137);
            this.BoxIE.Name = "BoxIE";
            this.BoxIE.Size = new System.Drawing.Size(157, 22);
            this.BoxIE.TabIndex = 14;
            // 
            // BoxTelefone
            // 
            this.BoxTelefone.Location = new System.Drawing.Point(296, 179);
            this.BoxTelefone.Name = "BoxTelefone";
            this.BoxTelefone.Size = new System.Drawing.Size(157, 22);
            this.BoxTelefone.TabIndex = 15;
            // 
            // BoxEndereco
            // 
            this.BoxEndereco.Location = new System.Drawing.Point(296, 223);
            this.BoxEndereco.Name = "BoxEndereco";
            this.BoxEndereco.Size = new System.Drawing.Size(343, 22);
            this.BoxEndereco.TabIndex = 16;
            // 
            // BoxEmail
            // 
            this.BoxEmail.Location = new System.Drawing.Point(296, 264);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(157, 22);
            this.BoxEmail.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(516, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(253, 20);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Todas as informações estão corretas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource3
            // 
            this.customersBindingSource3.DataMember = "Customers";
            this.customersBindingSource3.DataSource = this.iDsBindingSource;
            // 
            // iDsBindingSource
            // 
            this.iDsBindingSource.DataSource = this.iDs;
            this.iDsBindingSource.Position = 0;
            // 
            // iDs
            // 
            this.iDs.DataSetName = "IDs";
            this.iDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.iDsBindingSource;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.iDsBindingSource;
            // 
            // customersBindingSource4
            // 
            this.customersBindingSource4.DataMember = "Customers";
            this.customersBindingSource4.DataSource = this.iDsBindingSource;
            // 
            // BoxID
            // 
            this.BoxID.Location = new System.Drawing.Point(606, 349);
            this.BoxID.Multiline = true;
            this.BoxID.Name = "BoxID";
            this.BoxID.Size = new System.Drawing.Size(41, 26);
            this.BoxID.TabIndex = 19;
            this.BoxID.TextChanged += new System.EventHandler(this.BoxID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Para vizualizar um ID específico, Alterar ou Deletar digite aqui o ID";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 537);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 50);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(793, 599);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxID);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BoxEmail);
            this.Controls.Add(this.BoxEndereco);
            this.Controls.Add(this.BoxTelefone);
            this.Controls.Add(this.BoxIE);
            this.Controls.Add(this.BoxCnpj);
            this.Controls.Add(this.BoxRSocial);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelTEL);
            this.Controls.Add(this.E);
            this.Controls.Add(this.LabelIE);
            this.Controls.Add(this.LabelCNPJ);
            this.Controls.Add(this.LabelRSocial);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dataCustomers);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.splitter1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Cadastrar";
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Label LabelRSocial;
        private System.Windows.Forms.Label LabelCNPJ;
        private System.Windows.Forms.Label LabelIE;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label LabelTEL;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox BoxRSocial;
        private System.Windows.Forms.TextBox BoxCnpj;
        private System.Windows.Forms.TextBox BoxIE;
        private System.Windows.Forms.TextBox BoxTelefone;
        private System.Windows.Forms.TextBox BoxEndereco;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.CheckBox checkBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource iDsBindingSource;
        private IDs iDs;
        private DataSet1 dataSet11;
        private DataSet1 dataSet12;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private IDsTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.BindingSource customersBindingSource3;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private System.Windows.Forms.BindingSource customersBindingSource4;
        private System.Windows.Forms.TextBox BoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
    }
}

