using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programa_Oficina.Classes;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Programa_Oficina.Formulários;

namespace Programa_Oficina.Classes
{
    public class cls_Funcionario
    {
        public class Unit
        {
            public string Codigo { get; set; }
            [Required(ErrorMessage = "Nome inválido.")]
            public string Nome { get; set; }
            public string Nascimento { get; set; }
            public string Rg { get; set; }
            public string Cpf { get; set; }
            public string ComissaoProduto { get; set; }
            public string ComissaoServico { get; set; }
            public string TipoPagamento { get; set; }
            public string Pagamento { get; set; }
            public string Salario { get; set; }
            [Required(ErrorMessage = "Cep inválido.")]
            public string Cep { get; set; }
            [Required(ErrorMessage = "Logradouro inválido.")]
            public string Logradouro { get; set; }
            [Required(ErrorMessage = "Bairro inválido.")]
            public string Bairro { get; set; }
            [Required(ErrorMessage = "Cidade inválida.")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "Estado inválido.")]
            public string Estado { get; set; }
            public string Complemento { get; set; }
            [Required(ErrorMessage = "Número inválido.")]
            public string Numero { get; set; }
            public string Admissao { get; set; }
            public string Demissao { get; set; }
            public string Celular { get; set; }
            public string Telefone { get; set; }

            public string Status { get; set; }

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
                string sql = "Select Max([Codigo Funcionario]) as codigo from Tabela_Funcionarios";
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

            public void InsertFuncionario()
            {
                SQLServerClass db = new SQLServerClass();
                string nascimento = this.Nascimento.Replace(" ", "").Replace("/", "");
                if (nascimento.Length == 0)
                {
                    this.Nascimento = nascimento;
                }
                string salario = this.Salario.Replace(" ", "").Replace(".","");
                if (salario.Length == 0)
                {
                    this.Salario = "000.00";
                }

                string sql = "INSERT INTO [dbo].[Tabela_Funcionarios] " +
                              "([Codigo Funcionario]" +
                              ",[Nome]" +
                              ",[Cpf]" +
                              ",[Cep]" +
                              ",[Logradouro]" +
                              ",[Bairro]" +
                              ",[Cidade]" +
                              ",[Estado]" +
                              ",[Data de Admissão]" +
                              ",[Data de Demissão]" +
                              ",[Porcentagem MO]" +
                              ",[Porcentagem Produto]" +
                              ",[Pagamento]" +
                              ",[Salario]" +
                              ",[Tipo de Pagamento]" +
                              ",[Rg]" +
                              ",[Numero]" +
                              ",[Celular]" +
                              ",[Telefone]" +
                              ",[Status]" +
                              ",[Nascimento])" +
                              " VALUES " +
                              "(" + this.Codigo +
                              ",'" + this.Nome + "'" +
                              ",'" + this.Cpf + "'" +
                              ",'" + this.Cep + "'" +
                              ",'" + this.Logradouro + "'" +
                              ",'" + this.Bairro + "'" +
                              ",'" + this.Cidade + "'" +
                              ",'" + this.Estado + "'" +
                              ",'" + this.Admissao + "'" +
                              ",'" + this.Demissao + "'" +
                              ",'" + this.ComissaoServico + "'" +
                              ",'" + this.ComissaoProduto + "'" +
                              ",'" + this.Pagamento + "'" +
                              "," + this.Salario +
                              ",'" + this.TipoPagamento + "'" +
                              ",'" + this.Rg + "'" +
                              ",'" + this.Numero + "'" +
                              ",'" + this.Celular + "'" +
                              ",'" + this.Telefone + "'" +
                              ",'" + this.Status + "'" +
                               ",'" + this.Nascimento + "')";

                db.SQLCommand(sql);
            }

            public void UpdateFuncionario(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string nascimento = this.Nascimento.Replace(" ", "").Replace("/", "");
                if (nascimento.Length == 0)
                {
                    this.Nascimento = nascimento;
                }
                string salario = this.Salario.Replace(" ", "");
                if (salario.Length == 0)
                {
                    this.Salario = "000.00";
                }
                string sql = "UPDATE [dbo].[Tabela_Funcionarios]" +
                             "SET [Codigo Funcionario] = '" + this.Codigo + "'" +
                             ",[Nome] = '" + this.Nome + "'" +
                             ",[Cpf] ='" + this.Cpf + "'" +
                             ",[Cep] = '" + this.Cep + "'" +
                             ",[Logradouro] = '" + this.Logradouro + "'" +
                             ",[Bairro] = '" + this.Bairro + "'" +
                             ",[Cidade] = '" + this.Cidade + "'" +
                             ",[Estado] = '" + this.Estado + "'" +
                             ",[Data de Admissão] = '" + this.Admissao + "'" +
                             ",[Data de Demissão] = '" + this.Demissao + "'" +
                             ",[Porcentagem MO] = '" + this.ComissaoServico + "'" +
                             ",[Porcentagem Produto] = '" + this.ComissaoProduto + "'" +
                             ",[Pagamento] = '" + this.Pagamento + "'" +
                             ",[Salario] = '" + this.Salario + "'" +
                             ",[Tipo de Pagamento] = '" + this.TipoPagamento + "'" +
                             ",[Rg] = '" + this.Rg + "'" +
                             ",[Numero] = '" + this.Numero + "'" +
                             ",[Celular] = '" + this.Celular + "'" +
                             ",[Telefone] = '" + this.Telefone + "'" +
                             ",[Status] = '" + this.Status + "'" +
                             ",[Nascimento] = '" + this.Nascimento + "'" +
                             " WHERE [Codigo Funcionario] = " + this.Codigo ;

                db.SQLCommand(sql);
            }

            public void DeleteFuncionario(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "delete from tabela_funcionarios where [codigo funcionario] = " + codigo;
                db.SQLCommand(sql);
            }

            public void DesativarFuncionario(string codigo, string data)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "update Tabela_Funcionarios Set [Status] = 'Desligado' , [Data de Demissão] =  '" + data + "'" +
                    " where [codigo funcionario] = " + codigo;
                db.SQLCommand(sql);
            }

            public void ReligarFuncionario(string codigo, string data)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "update Tabela_Funcionarios Set [Status] = 'Ativo' , [Data de Demissão] = null , [Data de Admissão] = '" + data + "'" +
                    " where [codigo funcionario] = " + codigo;
                db.SQLCommand(sql);
            }

            public bool CodigoIgualNome(string codigo, string nome)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select [nome] from tabela_funcionarios where [codigo funcionario] = " + codigo;
                var dt = db.SqlQuery(sql);
                if (dt.Rows[0][0].ToString() == nome)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public DataTable PesquisarFuncComTempo(string filtro, string valor, string Inicio, string Fim)
            {
                string SQL = "select " +
                             "[Codigo Funcionario]," +
                             "[Nome]," +
                             "[Cidade]," +
                             "[Estado]," +
                             "[Porcentagem MO]," +
                             "[Porcentagem Produto]," +
                             "[Tipo de Pagamento]," +
                             "[Pagamento]," +
                             "CONVERT(VARCHAR(10), [Data de Admissão], 103)," +
                             "[Status]" +                             
                             " from tabela_Funcionarios where [" + filtro + "] like '%" + valor + "%'" +
                             " and [data de Admissão] between '" + Inicio + "' and '" + Fim + "'";
                SQLServerClass db = new SQLServerClass();
                var dt = db.SqlQuery(SQL);
                return dt;
            }

            public DataTable PesquisarFuncSemTempo(string filtro, string valor)
            {
                string SQL = "select " +
                             "[Codigo Funcionario]," +
                             "[Nome]," +
                             "[Cidade]," +
                             "[Estado]," +
                             "[Porcentagem MO]," +
                             "[Porcentagem Produto]," +
                             "[Tipo de Pagamento]," +
                             "[Pagamento]," +
                             "CONVERT(VARCHAR(10), [Data de Admissão], 103)," +
                             "[Status]" +
                             " from tabela_Funcionarios where [" + filtro + "] like '%" + valor + "%'";

                SQLServerClass db = new SQLServerClass();
                var dt = db.SqlQuery(SQL);
                return dt;
            }
        }
        public class List
        {

        }
    }
}
