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
    internal class cls_Produto
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do produto inválido.")]
            public string Codigo { get; set; }
            [Required(ErrorMessage = "Nome do produto inválido.")]
            public string Nome { get; set; }
            public string Fornecedor { get; set; }
            public string Marca { get; set; }
            public string Referencia { get; set; }
            public string Unidade { get; set; }
            public string Quantidade { get; set; }
            public string Compra { get; set; }
            public string Venda { get; set; }
            public string Descricao { get; set; }


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
                string sql = "Select Max([Codigo Produto]) as codigo from Tabela_Produtos";
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

            public void InsertProduto()
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "INSERT INTO [dbo].[Tabela_Produtos]" +
                             "([Codigo Produto]" +
                             ",[Nome]" +
                             ",[Fornecedor]" +
                             ",[Valor Compra]" +
                             ",[Valor Venda]" +
                             ",[Descricao]" +
                             ",[Referencia]" +
                             ",[Quantidade]" +
                             ",[Unidade]" +
                             ",[Marca])" +
                             "VALUES" +
                             "(" + this.Codigo +
                             ",'" + this.Nome + "'" +
                             ",'" + this.Fornecedor + "'" +
                             "," + this.Compra +
                             "," + this.Venda +
                             ",'" + this.Descricao + "'" +
                             ",'" + this.Referencia + "'" +
                             "," + this.Quantidade +
                             ",'" + this.Unidade + "'" +
                             ",'" + this.Marca +"')";
                db.SQLCommand(sql);
            }

            public void UpdateProduto(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "UPDATE [dbo].[Tabela_Produtos] " +
                             "SET [Codigo Produto] = " + this.Codigo +
                             ",[Nome] = '" + this.Nome + "'" +
                             ",[Fornecedor] = '" + this.Fornecedor + "'" +
                             ",[Valor Compra] = " + this.Compra +
                             ",[Valor Venda] = " + this.Venda +
                             ",[Descricao] = '" + this.Descricao + "'" +
                             ",[Referencia] = '" + this.Referencia + "'" +
                             ",[Quantidade] = " + this.Quantidade +
                             ",[Unidade] = '" + this.Unidade + "'" +
                             ",[Marca] = '" + this.Marca + "'" +
                             "WHERE [codigo produto] = '" + this.Codigo + "'";

                db.SQLCommand(sql);
            }

            public void DeleteProduto(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "delete from tabela_produtos where [codigo produto] = " + codigo;
                db.SQLCommand(sql);
            }

            public DataTable SelectProdutos(string filtrobusca, string busca)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "Select top (30) * from tabela_produtos where [" + filtrobusca + "] like '%" + busca + "%'";
                var dt = db.SqlQuery(sql);
                return dt;
            }

            public DataTable SelectProdutoUnico(string filtrobusca, string busca)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "Select top (30) * from tabela_produtos where [" + filtrobusca + "] = '" + busca + "'";
                var dt = db.SqlQuery(sql);
                return dt;
            }
        }
        public class List
        {

        }
    }
}
