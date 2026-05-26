namespace ServiceHub
{
    partial class FrmServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServico));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            btnAdd = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtPreco = new TextBox();
            dgvServicos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            cnlNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnPreco = new DataGridViewTextBoxColumn();
            clnDescontinuado = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(97, 68);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(75, 117);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 10;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(78, 215);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 12;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(57, 166);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 11;
            label4.Text = "Descrição";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F);
            checkBox1.Location = new Point(386, 214);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 23);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(130, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(49, 25);
            txtId.TabIndex = 13;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 10F);
            txtDescricao.Location = new Point(130, 163);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(362, 25);
            txtDescricao.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(130, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(226, 25);
            txtNome.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Beige;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnAdd.Image = Properties.Resources.Add;
            btnAdd.Location = new Point(58, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 61);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "&Adicionar";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnEditar.Image = Properties.Resources.Edit;
            btnEditar.Location = new Point(278, 254);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 61);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnPesquisar.Image = Properties.Resources.Search;
            btnPesquisar.Location = new Point(168, 254);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(99, 61);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(388, 254);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(99, 61);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(502, 254);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 61);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(130, 215);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 14;
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.AllowUserToDeleteRows = false;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { clnId, cnlNome, clnDescricao, clnPreco, clnDescontinuado });
            dgvServicos.Location = new Point(32, 342);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.ReadOnly = true;
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.Size = new Size(658, 269);
            dgvServicos.TabIndex = 15;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // cnlNome
            // 
            cnlNome.Frozen = true;
            cnlNome.HeaderText = "Nome";
            cnlNome.Name = "cnlNome";
            cnlNome.ReadOnly = true;
            cnlNome.Width = 200;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 206;
            // 
            // clnPreco
            // 
            clnPreco.HeaderText = "Preço";
            clnPreco.Name = "clnPreco";
            clnPreco.ReadOnly = true;
            // 
            // clnDescontinuado
            // 
            clnDescontinuado.HeaderText = "Descontinuado";
            clnDescontinuado.Name = "clnDescontinuado";
            clnDescontinuado.ReadOnly = true;
            // 
            // FrmServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 642);
            Controls.Add(dgvServicos);
            Controls.Add(txtPreco);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdd);
            Controls.Add(txtNome);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServico";
            Text = "ServiceHub - Serviços";
            Load += FrmServico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox txtId;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private Button btnAdd;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtPreco;
        private DataGridView dgvServicos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn cnlNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnPreco;
        private DataGridViewCheckBoxColumn clnDescontinuado;
    }
}