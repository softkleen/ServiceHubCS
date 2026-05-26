using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceHub
{
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }

        private void HabilitaControle()
        {
            btnAdd.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
        }
        private void DesabilitaControle()
        {
            btnAdd.Enabled = false;
            btnEditar.Enabled = false;
            //btnExcluir.Enabled = false;
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from servicos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvServicos.Rows.Add();
                int linha = dgvServicos.RowCount - 1;
                dgvServicos.Rows[linha].Cells[0].Value = dr.GetInt32(0);
                dgvServicos.Rows[linha].Cells[1].Value = dr.GetString(1);
                dgvServicos.Rows[linha].Cells[2].Value = dr.GetString(2);
                dgvServicos.Rows[linha].Cells[3].Value = dr.GetDouble(3);
                dgvServicos.Rows[linha].Cells[4].Value = dr.GetBoolean(4);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            double preco = double.Parse(txtPreco.Text);

            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert servicos (nome, descricao, preco)" +
                $"values('{nome}','{descricao}',{preco})";
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = "select last_insert_id()";
                txtId.Text = cmd.ExecuteScalar().ToString();
                btnAdd.Enabled = false;
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DesabilitaControle();
            if (btnPesquisar.Text == "&Pesquisar")
            {
                txtId.ReadOnly = false;
                txtNome.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                txtPreco.ReadOnly = true;
                checkBox1.Enabled = false;
                txtId.Focus();
                btnPesquisar.Text = "Buscar";
            }
            else if (btnPesquisar.Text == "Buscar")
            {
                // busca no banco
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from servicos where id = {txtId.Text}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr.GetString(1);
                    txtDescricao.Text = dr.GetString(2);
                    txtPreco.Text = dr.GetDecimal(3).ToString();
                    checkBox1.Checked = dr.GetBoolean(4);
                }
                btnPesquisar.Text = "&Pesquisar";
                txtId.ReadOnly = true;

                btnEditar.Enabled = true;
                btnPesquisar.Enabled = false;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "&Editar")
            {
                txtDescricao.ReadOnly = false;
                txtNome.ReadOnly = false;
                txtPreco.ReadOnly = false;
                checkBox1.Enabled = true;
                btnEditar.Text = "Salvar";
            }
            else
            {
                string descont = checkBox1.Checked ? "1" : "0";
                double pre = double.Parse(txtPreco.Text);
                string descricao = txtDescricao.Text;
                string nome = txtNome.Text;
                var cmd = Banco.Abrir();
                cmd.CommandText = $"update servicos set nome = '{nome}', " +
                    $"descricao = '{descricao}', preco = {pre}, " +
                    $"descontinuado = {descont} where id  = {txtId.Text}";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    btnEditar.Text = "&Editar";
                    txtNome.ReadOnly = true;
                    txtDescricao.ReadOnly = true;
                    txtPreco.ReadOnly = true;
                    checkBox1.Enabled = false;
                }
                HabilitaControle();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cmd = Banco.Abrir(@"server=10.91.47.48;database=comercialdb01;user=root;password=P@ssw0rd");
            cmd.CommandText = $"delete from servicos where id = {txtId.Text}";
            if (cmd.ExecuteNonQuery()>0)
            {
                btnExcluir.Enabled = false;
            }
        }
    }
}
