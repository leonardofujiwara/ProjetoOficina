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

namespace Programa_Oficina.Classes
{
    public class cls_Cliente
    {
        public class Unit
        {
            public string Codigo { get; set; }
            [Required(ErrorMessage = "Nome do cliente inválido.")]
            public string Nome { get; set; }
            public string Nascimento { get; set; }
            public string Pessoa { get; set; }
            public string Cpf { get; set; }
            public string Cnpj { get; set; }
            [Required(ErrorMessage = "Cep do cliente inválido.")]
            public string  Cep { get; set; }
            [Required(ErrorMessage = "Logradouro inválido.")]
            public string Logradouro { get; set; }
            [Required(ErrorMessage = "Bairro inválido.")]
            public string Bairro {get; set; }
            [Required(ErrorMessage = "Cidade inválida.")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "Estado inválido.")]
            public string Estado { get; set; }
            public string Complemento { get; set; }
            [Required(ErrorMessage = "Número inválido.")]
            public string Numero { get; set; }
            public string Celular { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }




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
                string sql = "Select Max([Codigo Cliente]) as codigo from Tabela_Clientes";
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

            public void InsertCliente()
            {
                SQLServerClass sqlcon = new SQLServerClass();
                string SQL;
                string nascimento = this.Nascimento.Replace(" ", "").Replace("/", "");
                if (nascimento.Length == 0)
                {
                    this.Nascimento = nascimento;
                }
                string cpf = this.Cpf.Replace(".", "").Replace("-", "").Replace("_", "");
                if (cpf == "         ")
                {
                    this.Cpf = "";
                }
                string cnpj = this.Cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (cnpj == "            ")
                {
                    this.Cnpj = "";
                }
                        SQL = "INSERT INTO[dbo].[Tabela_Clientes]";
                SQL += "([Codigo Cliente]";
                SQL += ",[Nome]";
                SQL += ",[Tipo]";
                SQL += ",[Nascimento]";
                SQL += ",[CPF]";
                SQL += ",[CNPJ]";
                SQL += ",[CEP]";
                SQL += ",[Logradouro]";
                SQL += ",[Bairro]";
                SQL += ",[Cidade]";
                SQL += ",[Estado]";
                SQL += ",[Numero]";
                SQL += ",[Complemento]";
                SQL += ",[Celular]";
                SQL += ",[Telefone]";
                SQL += ",[Email]";
                SQL += ",[Data de Cadastro])";
                SQL += " VALUES (";
                SQL += this.Codigo;
                SQL += ",'" + this.Nome + "'";
                SQL += ",'" + this.Pessoa + "'";
                SQL += ",'"+ this.Nascimento + "'";
                SQL += ",'" + this.Cpf + "'";
                SQL += ",'" + this.Cnpj + "'";
                SQL += ",'" + this.Cep + "'";
                SQL += ",'" + this.Logradouro + "'";
                SQL += ",'" + this.Bairro + "'";
                SQL += ",'" + this.Cidade + "'";
                SQL += ",'" + this.Estado + "'";
                SQL += ",'" + this.Numero + "'";
                SQL += ",'" + this.Complemento + "'";
                SQL += ",'" + this.Celular + "'";
                SQL += ",'" + this.Telefone + "'";
                SQL += ",'" + this.Email + "'";
                SQL += ",GETDATE())";
                sqlcon.SQLCommand(SQL);
            }

            public DataTable SelectCliente(string nome)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select [codigo cliente], nome from tabela_clientes where nome like '%" + nome + "%'";
                var dt = db.SqlQuery(sql);
                return dt;
                
            }
           

            public void UpdateCliente(string ID)
            {
                SQLServerClass db = new SQLServerClass();
                string nascimento = this.Nascimento.Replace(" ", "").Replace("/", "");
                if (nascimento.Length == 0)
                {
                    this.Nascimento = nascimento;
                }
                string cpf = this.Cpf.Replace(".", "").Replace("-", "").Replace("_", "");
                if (cpf == "         ")
                {
                    this.Cpf = "";
                }
                string cnpj = this.Cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (cnpj == "            ")
                {
                    this.Cnpj = "";
                }
                string SQL = "UPDATE [Tabela_Clientes] " +
                             "SET " +
                             "[Nome] = '" + this.Nome + "'" +
                             ",[Tipo] = '" + this.Pessoa + "'" +
                             ",[Nascimento] = '" + this.Nascimento + "'" +
                             ",[CPF] = '" + this.Cpf + "'" +
                             ",[CNPJ] = '" + this.Cnpj + "'" +
                             ",[CEP] = '" + this.Cep + "'" +
                             ",[Logradouro] = '" + this.Logradouro + "'" +
                             ",[Bairro] = '" + this.Bairro + "'" +
                             ",[Cidade] = '" + this.Cidade + "'" +
                             ",[Estado] = '" + this.Estado + "'" +
                             ",[Numero] = '" + this.Numero + "'" +
                             ",[Complemento] = '" + this.Complemento + "'" +
                             ",[Celular] = '" + this.Celular + "'" +
                             ",[Telefone] = '" + this.Telefone + "'" +
                             ",[Email] = '" + this.Email + "'" +
                             " WHERE [codigo cliente]  = " + ID;
                db.SQLCommand(SQL);
            }

            public void DeleteCliente(string ID)
            {
                SQLServerClass db = new SQLServerClass();
                string SQL = "Delete from tabela_clientes where [Codigo Cliente] = " + ID;
                var dt = db.SQLCommand(SQL);
            }

            public DataTable PesquisarClienteSemTempo(string filtro,string valor)
            {
                string SQL = "select " +
                             "[Codigo Cliente]," +
                             "[Nome]," +
                             "[Tipo]," +
                             "[Cidade]," +
                             "[Estado]," +
                             "[Celular]," +
                             "[Telefone]," +
                             "[Email]," +
                             "CONVERT(VARCHAR(10), [Data de cadastro], 103)" +
                             " from tabela_clientes where [" + filtro + "] like '%" + valor + "%'";
                SQLServerClass db = new SQLServerClass();
                var dt = db.SqlQuery(SQL);
                return dt;
            }

            public DataTable PesquisarClienteComTempo(string filtro, string valor,string Inicio,string Fim)
            {
                string SQL = "select " +
                             "[Codigo Cliente]," +
                             "[Nome]," +
                             "[Tipo]," +
                             "[Cidade]," +
                             "[Estado]," +
                             "[Celular]," +
                             "[Telefone]," +
                             "[Email]," +
                             "CONVERT(VARCHAR(10), [Data de cadastro], 103)" +
                             " from tabela_clientes where [" + filtro + "] like '%" + valor + "%'"+
                             " and [data de cadastro] between '" + Inicio + "' and '" + Fim + "'";
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
