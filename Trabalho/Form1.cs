using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trabalho
{
    public partial class Cadastrar : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter data_adapter;
        string strSql;
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_adicionar_click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-7GQQIO3\SQLEXPRESS;Database=CLIENTESDB;User Id=teste001;Password=teste001;");
                strSql = "INSERT INTO Customers(rsocial, cnpj, ie, telefone, endereco, email ) VALUES(@rsocial, @cnpj, @ie, @telefone, @endereco, @email)";
                comando = new SqlCommand(strSql, conexao);
                if (BoxRSocial.Text == "" || BoxCnpj.Text == "" || BoxIE.Text == "" || BoxTelefone.Text == "" || BoxEndereco.Text == "" || BoxEmail.Text == "")
                {
                    MessageBox.Show("ATENÇÃO!! Todos os campos devem ser preenchidos");
                }
                else
                {

                    comando.Parameters.AddWithValue("@rsocial", BoxRSocial.Text);
                    comando.Parameters.AddWithValue("@cnpj", BoxCnpj.Text);
                    comando.Parameters.AddWithValue("@ie", BoxIE.Text);
                    comando.Parameters.AddWithValue("@telefone", BoxTelefone.Text);
                    comando.Parameters.AddWithValue("@endereco", BoxEndereco.Text);
                    comando.Parameters.AddWithValue("@email", BoxEmail.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("DADOS SALVOS COM SUCESSO!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_exibir_click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-7GQQIO3\SQLEXPRESS;Database=CLIENTESDB;User Id=teste001;Password=teste001;");
                if (BoxID.Text == "")
                {
                    strSql = "SELECT * FROM Customers";
                    data_adapter = new SqlDataAdapter(strSql, conexao);
                    MessageBox.Show("TODOS OS DADOS FORAM EXIBIDOS");
                }
                else
                {
                    strSql = "SELECT * FROM Customers WHERE ID = @id";
                    data_adapter = new SqlDataAdapter();
                    data_adapter.SelectCommand = new SqlCommand(strSql, conexao);
                    data_adapter.SelectCommand.Parameters.AddWithValue("@id", BoxID.Text);
                    MessageBox.Show("TODOS OS DADOS FORAM EXIBIDOS");
                }
                DataSet data_set = new DataSet();
                conexao.Open();
                data_adapter.Fill(data_set);
                dataCustomers.DataSource = data_set.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //SPLIT SEPARADOR 
        }

        private void btn_alterar_click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-7GQQIO3\SQLEXPRESS;Database=CLIENTESDB;User Id=teste001;Password=teste001;");
                conexao.Open();
                if (BoxRSocial.Text =="")
                {
                    { }
                }
                else
                {
                    strSql = "UPDATE Customers SET rsocial = @rsocial WHERE ID = @id ";
                    comando = new SqlCommand(strSql, conexao);
                    comando.Parameters.AddWithValue("@rsocial", BoxRSocial.Text);
                    comando.Parameters.AddWithValue("@id", BoxID.Text);
                    comando.ExecuteNonQuery();
                }
                if (BoxCnpj.Text == "")
                {
                    { }
                }
                else
                {
                    strSql = "UPDATE Customers SET cnpj = @cnpj WHERE ID = @id";
                    comando = new SqlCommand(strSql, conexao);
                    comando.Parameters.AddWithValue("@cnpj", BoxCnpj.Text);
                    comando.Parameters.AddWithValue("@id", BoxID.Text);
                    comando.ExecuteNonQuery();

                }
                if (BoxIE.Text == "")
                {
                    { }
                }
                else
                {
                    strSql = "UPDATE Customers SET ie = @ie WHERE ID = @id";
                    comando = new SqlCommand(strSql, conexao);
                    comando.Parameters.AddWithValue("@ie", BoxIE.Text);
                    comando.Parameters.AddWithValue("@id", BoxID.Text);
                    comando.ExecuteNonQuery();

                }
                if (BoxTelefone.Text == "")
                {
                    { }
                }
                else
                {
                    strSql = "UPDATE Customers SET telefone = @telefone WHERE ID = @id";
                    comando = new SqlCommand(strSql, conexao);
                    comando.Parameters.AddWithValue("@telefone", BoxTelefone.Text);
                    comando.Parameters.AddWithValue("@id", BoxID.Text);
                    comando.ExecuteNonQuery();

                }
                if (BoxEndereco.Text == "")
                {
                    { }
                }
                else
                {
                    strSql = "UPDATE Customers SET endereco = @endereco WHERE ID = @id";
                    comando = new SqlCommand(strSql, conexao);
                    comando.Parameters.AddWithValue("@endereco", BoxEndereco.Text);
                    comando.Parameters.AddWithValue("@id", BoxID.Text);
                    comando.ExecuteNonQuery();

                }
                if (BoxEmail.Text == "")
                {
                    { }
                }
                else
                {
                    strSql = "UPDATE Customers SET email = @email WHERE ID = @id";
                    comando = new SqlCommand(strSql, conexao);
                    comando.Parameters.AddWithValue("@email", BoxEmail.Text);
                    comando.Parameters.AddWithValue("@id", BoxID.Text);
                    comando.ExecuteNonQuery();
;
                }
                MessageBox.Show("DADOS SALVOS COM SUCESSO!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void btn_deletar_click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-7GQQIO3\SQLEXPRESS;Database=CLIENTESDB;User Id=teste001;Password=teste001;");
                strSql = "DELETE Customers WHERE ID = @id";
                comando = new SqlCommand(strSql, conexao);

                comando.Parameters.AddWithValue("@id", BoxID.Text);
                


                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("DADOS DELETADOS COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void BoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
