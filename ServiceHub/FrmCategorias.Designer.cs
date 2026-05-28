namespace ServiceHub
{
    partial class FrmCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdd = new Button();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtBuscar = new TextBox();
            dgvCategorias = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(402, 123);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 61);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(304, 123);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(92, 61);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnPesquisar.Image = Properties.Resources.Search;
            btnPesquisar.Location = new Point(108, 123);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(92, 61);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(206, 123);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(92, 61);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Beige;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.Location = new Point(10, 123);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 61);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "&Adicionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(65, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 25);
            txtNome.TabIndex = 15;
            // 
            // txtSigla
            // 
            txtSigla.Font = new Font("Segoe UI", 10F);
            txtSigla.Location = new Point(402, 71);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(80, 25);
            txtSigla.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(10, 71);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(49, 25);
            txtId.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(402, 49);
            label4.Name = "label4";
            label4.Size = new Size(37, 19);
            label4.TabIndex = 25;
            label4.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(65, 49);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 24;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(10, 49);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 9);
            label3.Name = "label3";
            label3.Size = new Size(260, 32);
            label3.TabIndex = 28;
            label3.Text = "Cadastro de Categorias";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(10, 204);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Categoria";
            txtBuscar.Size = new Size(472, 25);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCategorias.Location = new Point(12, 231);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.Size = new Size(470, 207);
            dgvCategorias.TabIndex = 29;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 330;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Sigla";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 67;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(txtBuscar);
            Controls.Add(txtNome);
            Controls.Add(txtSigla);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdd;
        private TextBox txtNome;
        private TextBox txtSigla;
        private TextBox txtId;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtBuscar;
        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}