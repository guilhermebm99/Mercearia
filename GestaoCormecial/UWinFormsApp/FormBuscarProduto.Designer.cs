namespace UWinFormsApp
{
    partial class FormBuscarProduto
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceProduto = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelarProduto = new System.Windows.Forms.Button();
            this.buttonSalvarProduto = new System.Windows.Forms.Button();
            this.buttonExcluirProduto = new System.Windows.Forms.Button();
            this.buttonInserirProduto = new System.Windows.Forms.Button();
            this.buttonAlterarProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarProduto = new System.Windows.Forms.Button();
            this.textBoxBuscarPorProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Items.AddRange(new object[] {
            "Nome",
            "Nome Produto",
            "Todos"});
            this.comboBoxProduto.Location = new System.Drawing.Point(47, 88);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProduto.TabIndex = 32;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.AllowUserToOrderColumns = true;
            this.dataGridViewProduto.AutoGenerateColumns = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.Barras,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dataGridViewProduto.DataSource = this.bindingSourceProduto;
            this.dataGridViewProduto.Location = new System.Drawing.Point(43, 133);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(918, 286);
            this.dataGridViewProduto.TabIndex = 31;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Barras
            // 
            this.Barras.DataPropertyName = "Barras";
            this.Barras.HeaderText = "Barras";
            this.Barras.MinimumWidth = 6;
            this.Barras.Name = "Barras";
            this.Barras.ReadOnly = true;
            this.Barras.Width = 125;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceProduto
            // 
            this.bindingSourceProduto.DataSource = typeof(Models.Produto);
            // 
            // buttonCancelarProduto
            // 
            this.buttonCancelarProduto.Location = new System.Drawing.Point(867, 411);
            this.buttonCancelarProduto.Name = "buttonCancelarProduto";
            this.buttonCancelarProduto.Size = new System.Drawing.Size(94, 31);
            this.buttonCancelarProduto.TabIndex = 30;
            this.buttonCancelarProduto.Text = "&Cancelar";
            this.buttonCancelarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarProduto
            // 
            this.buttonSalvarProduto.Location = new System.Drawing.Point(767, 411);
            this.buttonSalvarProduto.Name = "buttonSalvarProduto";
            this.buttonSalvarProduto.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvarProduto.TabIndex = 29;
            this.buttonSalvarProduto.Text = "&Salvar";
            this.buttonSalvarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirProduto
            // 
            this.buttonExcluirProduto.Location = new System.Drawing.Point(871, 86);
            this.buttonExcluirProduto.Name = "buttonExcluirProduto";
            this.buttonExcluirProduto.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluirProduto.TabIndex = 28;
            this.buttonExcluirProduto.Text = "&Excluir";
            this.buttonExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // buttonInserirProduto
            // 
            this.buttonInserirProduto.Location = new System.Drawing.Point(771, 84);
            this.buttonInserirProduto.Name = "buttonInserirProduto";
            this.buttonInserirProduto.Size = new System.Drawing.Size(94, 29);
            this.buttonInserirProduto.TabIndex = 27;
            this.buttonInserirProduto.Text = "&Inserir";
            this.buttonInserirProduto.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarProduto
            // 
            this.buttonAlterarProduto.Location = new System.Drawing.Point(671, 86);
            this.buttonAlterarProduto.Name = "buttonAlterarProduto";
            this.buttonAlterarProduto.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterarProduto.TabIndex = 26;
            this.buttonAlterarProduto.Text = "&Alterar";
            this.buttonAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1020, 47);
            this.label2.TabIndex = 25;
            this.label2.Text = "Buscar Produto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Buscar por:";
            // 
            // buttonBuscarProduto
            // 
            this.buttonBuscarProduto.Location = new System.Drawing.Point(571, 86);
            this.buttonBuscarProduto.Name = "buttonBuscarProduto";
            this.buttonBuscarProduto.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarProduto.TabIndex = 23;
            this.buttonBuscarProduto.Text = "&Buscar";
            this.buttonBuscarProduto.UseVisualStyleBackColor = true;
            this.buttonBuscarProduto.Click += new System.EventHandler(this.buttonBuscarProduto_Click);
            // 
            // textBoxBuscarPorProduto
            // 
            this.textBoxBuscarPorProduto.Location = new System.Drawing.Point(212, 88);
            this.textBoxBuscarPorProduto.Name = "textBoxBuscarPorProduto";
            this.textBoxBuscarPorProduto.Size = new System.Drawing.Size(344, 27);
            this.textBoxBuscarPorProduto.TabIndex = 22;
            // 
            // FormBuscarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelarProduto;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.buttonCancelarProduto);
            this.Controls.Add(this.buttonSalvarProduto);
            this.Controls.Add(this.buttonExcluirProduto);
            this.Controls.Add(this.buttonInserirProduto);
            this.Controls.Add(this.buttonAlterarProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarProduto);
            this.Controls.Add(this.textBoxBuscarPorProduto);
            this.Name = "FormBuscarProduto";
            this.Text = "FormBuscarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxProduto;
        private DataGridView dataGridViewProduto;
        private Button buttonCancelarProduto;
        private Button buttonSalvarProduto;
        private Button buttonExcluirProduto;
        private Button buttonInserirProduto;
        private Button buttonAlterarProduto;
        private Label label2;
        private Label label1;
        private Button buttonBuscarProduto;
        private TextBox textBoxBuscarPorProduto;
        private BindingSource bindingSourceProduto;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Barras;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
    }
}