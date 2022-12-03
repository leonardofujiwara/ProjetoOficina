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
    internal class cls_Estoque
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código inválido.")]
            public string Codigo { get; set; }
            [Required(ErrorMessage = "Nome inválido.")]
            public string Nome { get; set; }
            public string Marca { get; set; }
            public string Referencia { get; set; }
            public string Compra { get; set; }
            public string Venda { get; set; }
            public string Validade { get; set; }
            [Required(ErrorMessage = "Quantidade inválida.")]
            public string Quantidade { get; set; }
            public string Unidade { get; set; }


            public void InsertEstoque()
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "INSERT INTO [dbo].[Tabela_Estoque]" +
                                "([Codigo Produto]" +
                                ",[Nome Produto]" +
                                ",[Marca]" +
                                ",[Quantidade]" +
                                ",[Referencia]" +
                                ",[Data Validade]" +
                                ",[Compra]" +
                                ",[Venda]" +
                                ",[Unidade])" +
                                "VALUES" +
                                "('" + this.Codigo + "'" +
                                ",'" + this.Nome + "'" + 
                                ",'" + this.Marca + "'" +
                                "," + this.Quantidade.Replace(",",".") +
                                ",'" + this.Referencia + "'" +
                                ",'" + this.Validade + "'" +
                                ",'" + this.Compra.Replace(",", ".") + "'" +
                                ",'" + this.Venda.Replace(",", ".") + "'" +
                                ",'" + this.Unidade + "')";
                db.SQLCommand(sql);
            }

            public void UpdateEstoque(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "UPDATE [dbo].[Tabela_Estoque]" +
                             "SET [Codigo Produto] = '" + this.Codigo + "'" +
                             ",[Nome Produto] = '" + this.Nome + "'" +
                             ",[Marca] = '" + this.Marca + "'" +
                             ",[Quantidade] = " + this.Quantidade +
                             ",[Referencia] = '" + this.Referencia + "'" +
                             ",[Data Validade] = '" + this.Validade + "'" +
                             ",[Compra] = '" + this.Compra + "'" +
                             ",[Venda] = '" + this.Venda + "'" +
                             ",[Unidade] = '" + this.Unidade + "'" +
                             " where " +
                             "[codigo produto] =  '" + this.Codigo + "'" +
                             "and [nome produto] =  '" + this.Nome + "'" +
                             "and [marca] =  '" + this.Marca + "'" +
                             "and [referencia] =  '" + this.Referencia + "'" +
                             "and [data validade] =  '" + this.Validade + "'" +
                             "and [compra] =  '" + this.Compra + "'" +
                             "and [venda] =  '" + this.Venda + "'" +
                             "and [unidade] =  '" + this.Unidade + "'";

                db.SQLCommand(sql);
            }

            public void DeleteEstoque()
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "Delete from tabela_estoque where " +
                             "[codigo produto] =  '" + this.Codigo + "'" +
                             "and [nome produto] =  '" + this.Nome + "'" +
                             "and [marca] =  '" + this.Marca + "'" +
                             "and [referencia] =  '" + this.Referencia + "'" +
                             "and [data validade] =  '" + this.Validade + "'" +
                             "and [compra] =  '" + this.Compra + "'" +
                             "and [venda] =  '" + this.Venda + "'" +
                             "and [unidade] =  '" + this.Unidade + "'";
                db.SQLCommand(sql);
            }

            public string GetQuantidadeEstoque(string codigo,string validade)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select [quantidade] from tabela_estoque where [codigo produto] = '" + codigo + 
                    "' and [data validade] = '" + validade + "'" ;
                var dt = db.SqlQuery(sql);
                float quantidade = float.Parse(dt.Rows[0][0].ToString());
                string Quantidade = quantidade.ToString("0.00");
                return Quantidade;
            }

            public DataTable SelectEstoqueSemTempo(string filtrobusca,string busca)
            {
                SQLServerClass db = new SQLServerClass();
                if (filtrobusca == "Nome")
                {
                    filtrobusca = "Nome Produto";
                }
                string sql = "select top(50) " +
                    "[Codigo Produto]" +
                    ",[Nome Produto]" +
                    ",[Marca]" +
                    ",[Quantidade]" +
                    ",[Referencia]" +
                    ",convert(nvarchar(10),[Data Validade],103)" +
                    ",[Compra]" +
                    ",[Venda]" +
                    ",[Unidade] from tabela_estoque where [" + filtrobusca + "] like '%" + busca + "%'";
                var dt = db.SqlQuery(sql);
                return dt;
            }

            public DataTable SelectEstoqueComTempo(string filtrobusca, string busca, string inicial,string final)
            {
                if (filtrobusca == "Nome")
                {
                    filtrobusca = "Nome Produto";
                }
                SQLServerClass db = new SQLServerClass();
                string sql = "select top(50) * from tabela_estoque where [" + filtrobusca + "] like '%" + busca + "%'" +
                    "and [data validade] between '" + inicial + "'and '" + final + "'";
                var dt = db.SqlQuery(sql);
                return dt;
            }

            public DataTable SelectEstoqueFormulario(string filtrobusca,string busca,string validade)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select * from tabela_estoque where [" + filtrobusca + "] = '" + busca
                    + "' and [Data Validade] = '" + validade + "'";
                var dt = db.SqlQuery(sql);
                return dt;
            }

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
        }


        
        public class List
        {

        }
    }
}
