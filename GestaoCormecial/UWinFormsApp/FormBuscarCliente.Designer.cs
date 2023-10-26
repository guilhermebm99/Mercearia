namespace UWinFormsApp
{
    partial class FormBuscarCliente
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCliente = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelarCliente = new System.Windows.Forms.Button();
            this.buttonSalvarCliente = new System.Windows.Forms.Button();
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.buttonInserirCliente = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "Fone",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(64, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.AllowUserToOrderColumns = true;
            this.dataGridViewCliente.AutoGenerateColumns = false;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.foneDataGridViewTextBoxColumn});
            this.dataGridViewCliente.DataSource = this.bindingSourceCliente;
            this.dataGridViewCliente.Location = new System.Drawing.Point(64, 113);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.RowHeadersWidth = 51;
            this.dataGridViewCliente.RowTemplate.Height = 29;
            this.dataGridViewCliente.Size = new System.Drawing.Size(918, 286);
            this.dataGridViewCliente.TabIndex = 20;
            this.dataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellContentClick);
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
            // foneDataGridViewTextBoxColumn
            // 
            this.foneDataGridViewTextBoxColumn.DataPropertyName = "Fone";
            this.foneDataGridViewTextBoxColumn.HeaderText = "Fone";
            this.foneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foneDataGridViewTextBoxColumn.Name = "foneDataGridViewTextBoxColumn";
            this.foneDataGridViewTextBoxColumn.ReadOnly = true;
            this.foneDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceCliente
            // 
            this.bindingSourceCliente.DataSource = typeof(Models.Cliente);
            // 
            // buttonCancelarCliente
            // 
            this.buttonCancelarCliente.Location = new System.Drawing.Point(884, 405);
            this.buttonCancelarCliente.Name = "buttonCancelarCliente";
            this.buttonCancelarCliente.Size = new System.Drawing.Size(94, 31);
            this.buttonCancelarCliente.TabIndex = 19;
            this.buttonCancelarCliente.Text = "&Cancelar";
            this.buttonCancelarCliente.UseVisualStyleBackColor = true;
            this.buttonCancelarCliente.Click += new System.EventHandler(this.buttonCancelarCliente_Click);
            // 
            // buttonSalvarCliente
            // 
            this.buttonSalvarCliente.Location = new System.Drawing.Point(784, 405);
            this.buttonSalvarCliente.Name = "buttonSalvarCliente";
            this.buttonSalvarCliente.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvarCliente.TabIndex = 18;
            this.buttonSalvarCliente.Text = "&Salvar";
            this.buttonSalvarCliente.UseVisualStyleBackColor = true;
            this.buttonSalvarCliente.Click += new System.EventHandler(this.buttonSalvarCliente_Click);
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.Location = new System.Drawing.Point(888, 80);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluirCliente.TabIndex = 17;
            this.buttonExcluirCliente.Text = "&Excluir";
            this.buttonExcluirCliente.UseVisualStyleBackColor = true;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.buttonExcluirCliente_Click);
            // 
            // buttonInserirCliente
            // 
            this.buttonInserirCliente.Location = new System.Drawing.Point(788, 78);
            this.buttonInserirCliente.Name = "buttonInserirCliente";
            this.buttonInserirCliente.Size = new System.Drawing.Size(94, 29);
            this.buttonInserirCliente.TabIndex = 16;
            this.buttonInserirCliente.Text = "&Inserir";
            this.buttonInserirCliente.UseVisualStyleBackColor = true;
            this.buttonInserirCliente.Click += new System.EventHandler(this.buttonInserirCliente_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.Location = new System.Drawing.Point(688, 80);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterarCliente.TabIndex = 15;
            this.buttonAlterarCliente.Text = "&Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = true;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.buttonAlterarCliente_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1068, 47);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(588, 80);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarCliente.TabIndex = 12;
            this.buttonBuscarCliente.Text = "&Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Location = new System.Drawing.Point(229, 82);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(344, 27);
            this.textBoxBuscarPor.TabIndex = 11;
            this.textBoxBuscarPor.TextChanged += new System.EventHandler(this.textBoxBuscarPor_TextChanged);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.buttonCancelarCliente);
            this.Controls.Add(this.buttonSalvarCliente);
            this.Controls.Add(this.buttonExcluirCliente);
            this.Controls.Add(this.buttonInserirCliente);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Name = "FormBuscarCliente";
            this.Text = "FormBuscarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridViewCliente;
        private Button buttonCancelarCliente;
        private Button buttonSalvarCliente;
        private Button buttonExcluirCliente;
        private Button buttonInserirCliente;
        private Button buttonAlterarCliente;
        private Label label2;
        private Label label1;
        private Button buttonBuscarCliente;
        private TextBox textBoxBuscarPor;
        private BindingSource bindingSourceCliente;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
    }
}