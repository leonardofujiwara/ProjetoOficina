using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Programa_Oficina.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programa_Oficina.Classes
{
    public class cls_Carro
    {
        public class Unit
        {
            public string CodigoCliente { get; set; }
            public string Codigo { get; set; }
            [Required(ErrorMessage = "Proprietário do veículo inválido.")]
            public string Proprietario { get; set; }
            public string Categoria { get; set; }
            [Required(ErrorMessage = "Marca do veículo inválida.")]
            public string Marca { get; set; }
            [Required(ErrorMessage = "Modelo do veículo inválido.")]
            public string Modelo { get; set; }
            [Required(ErrorMessage = "Placa do veículo inválido.")]
            public string Placa { get; set; }
            [Required(ErrorMessage = "Ano do veículo inválido.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Ano do veículo somente aceita valores numéricos.")]
            [StringLength(4,MinimumLength = 4, ErrorMessage = "Ano do veículo deve conter 4 dígitos.")]
            public string Ano { get; set; }
            [Required(ErrorMessage = "Cor do veículo inválido.")]
            public string Cor { get; set; }
            public string DataCadastro { get; set; }
            public string Chassi { get; set; }

            public bool ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public int GeraCodigo()
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "Select Max([Codigo Carro]) as codigo from Tabela_Carros";
                var dt = db.SqlQuery(sql);
                var dr = dt.Rows[0];

                if (dr.IsNull("codigo"))
                {
                    return 1;
                }
                else
                {
                    int resultado = dr.Field<int>("codigo");
                    resultado += 1;
                    return resultado;
                }
                

            }

            public void InsertCarro()
            {
                SQLServerClass db = new SQLServerClass();
                string SQL = "INSERT INTO[dbo].[Tabela_Carros]" +
                             "([Codigo Cliente]" +
                             ",[Proprietario]" +
                             ",[Categoria]" +
                             ",[Marca]" +
                             ",[Modelo]" +
                             ",[Placa]" +
                             ",[Ano]" +
                             ",[Cor]" +
                             ",[Chassi]" +
                             ",[Data de Cadastro]" +
                             ",[Codigo Carro])" +
                             "VALUES" +
                             "(" + this.CodigoCliente +
                             ",'" + this.Proprietario + "'" +
                             ",'" + this.Categoria + "'" +
                             ",'" + this.Marca + "'" +
                             ",'" + this.Modelo + "'" +
                             ",'" + this.Placa + "'" +
                             "," + this.Ano + "" +
                             ",'" + this.Cor + "'" +
                             ",'" + this.Chassi + "'" +
                             ",'" + this.DataCadastro + "'" +
                             ",'" + this.Codigo + "')";

                db.SQLCommand(SQL);
            }

            public void UpdateCarro(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "UPDATE [dbo].[Tabela_Carros]" +
                             " SET [Codigo Cliente] = '" + this.CodigoCliente + "'" +
                            ",[Proprietario] = '" + this.Proprietario + "'" +
                            ",[Categoria] = '" + this.Categoria + "'" +
                            ",[Marca] = '" + this.Marca + "'" +
                            ",[Modelo] = '" + this.Modelo + "'" +
                            ",[Placa] = '" + this.Placa + "'" +
                            ",[Ano] = " + this.Ano + "" +
                            ",[Cor] = '" + this.Cor + "'" +
                            ",[Chassi] = '" + this.Chassi + "'" +
                            ",[Data de Cadastro] = '" + this.DataCadastro + "'" +
                            ",[Codigo Carro] = '" + this.Codigo + "' " +
                            "WHERE  [codigo carro] = '" + codigo + "'";
                db.SQLCommand(sql);
            }

            public void DeleteCarro(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "delete from tabela_carros where [codigo carro] = " + codigo;
                db.SQLCommand(sql);
            }

            public string SelectCodigoCliente(string nome)
            {
                try
                {
                    SQLServerClass db = new SQLServerClass();

                    string sql = "select [codigo cliente] from tabela_clientes where nome = '" + nome + "'";
                    var dt = db.SqlQuery(sql);
                    if (dt.Rows.Count > 0)
                    {
                        string resultado = dt.Rows[0][0].ToString();
                        return resultado;
                    }
                    else
                    {
                        throw new Exception("Cliente não cadastrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Programa Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

            }

            public string SelectNomeCliente(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "Select Nome from Tabela_Clientes where [codigo cliente] = " + codigo;
                var dt = db.SqlQuery(sql);
                return dt.Rows[0][0].ToString();
            }

            public DataTable PesquisarCarrosSemTempo(string filtro, string valor)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select [codigo carro],marca,modelo,cor,placa,ano,proprietario,convert(nvarchar(10),[data de cadastro],103) " +
                    "from tabela_carros where [" + filtro + "] like '%" + valor + "%' ";
                var dt = db.SqlQuery(sql);
                return dt;
            }

            public DataTable PesquisarCarrosComTempo(string filtro, string valor, string inicio, string fim)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select [codigo carro],marca,modelo,cor,placa,ano,proprietario,convert(nvarchar(10),[data de cadastro],103) " +
                    "from tabela_carros where [" + filtro + "] like '%" + valor + "%' " +
                    "and [data de cadastro] between '" + inicio + "' and '" + fim + "'";
                var dt = db.SqlQuery(sql);
                return dt;
            }

            public DataTable SelectCarro(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select [codigo cliente],proprietario,categoria, marca, modelo," +
                    " placa, ano, cor, chassi, convert(nvarchar(10),[data de cadastro],103),[codigo carro] " +
                    "from tabela_carros where [codigo carro] like '%" + codigo + "%'";
                var dt = db.SqlQuery(sql);
                return dt;

            }
        }

        public class List
        {

        }
    }
}
