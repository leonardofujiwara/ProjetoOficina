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
    public class cls_Servico
    {
        public class Unit
        {
            [Required(ErrorMessage ="Código inválido.")]
            public string Codigo { get; set; }
            public string Referencia { get; set; }
            [Required(ErrorMessage = "Nome inválido.")]
            public string Nome { get; set; }
            public string Produtos { get; set; }
            [Required(ErrorMessage = "Preço inválido.")]
            public string Venda { get; set; }
            public string Codigo_Produto { get; set; }
            public string Nome_Produto { get; set; }
            public string Referencia_Produto { get; set; }
            public string Quantidade_Produto { get; set; }
            public string Unidade_Produto { get; set; }
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
                string sql = "Select Max([Codigo Servico]) as codigo from Tabela_Servicos";
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

            public void InsertServico()
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "INSERT INTO [dbo].[Tabela_Servicos]" +
                             "([Codigo Servico]" +
                             ",[Nome Servico]" +
                             ",[Valor Venda]" +
                             ",[Descricao]" +
                             ",[Codigo Produto]" +
                             ",[Nome Produto]" +
                             ",[Referencia]" +
                             ",[Referencia Produto]" +
                             ",[Quantidade Produto]" +
                             ",[Unidade Produto]) " +
                             "VALUES " +
                             "(" + this.Codigo +
                             ",'" + this.Nome + "'" +
                             "," + this.Venda +
                             ",'" + this.Descricao + "'" +
                             ",'" + this.Codigo_Produto + "'" +
                             ",'" + this.Nome_Produto + "'" +
                             ",'" + this.Referencia + "'" +
                             ",'" + this.Referencia_Produto + "'" +
                             "," + this.Quantidade_Produto + 
                             ",'" + this.Unidade_Produto + "')";
                db.SQLCommand(sql);
            }

            public void DeleteServico(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "delete from tabela_servicos where [codigo servico] = '" + codigo + "'";
                db.SQLCommand(sql);
            }

            public DataTable SelectServicos()
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "SELECT [codigo servico],[referencia],[nome servico]," +
                             "STRING_AGG(ISNULL([Referencia Produto], '  '), ', ') As 'Ref. Produtos'," +
                             "Descricao,[Valor Venda]" +
                             "From Tabela_Servicos group by[codigo servico],[referencia],[nome servico], Descricao,[Valor Venda]";

                var dt = db.SqlQuery(sql);
                return dt;
            }

            public DataTable SelectPesquisaServico(string filtro,string busca)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select * From " +
                    "(SELECT[codigo servico],[referencia],[nome servico], " +
                    "STRING_AGG(ISNULL([Referencia Produto], '  '), ', ') As 'Referencia Produto'" +
                    ",Descricao,[Valor Venda] From Tabela_Servicos group by[codigo servico]" +
                    ",[referencia],[nome servico], Descricao,[Valor Venda]) db where db.[" + filtro + "] " + "like '%" + busca + "%'";
                             
                var dt = db.SqlQuery(sql);
                return dt;
            }

            public DataTable SelectServicoFormulario(string codigo)
            {
                SQLServerClass db = new SQLServerClass();
                string sql = "select * from tabela_servicos where [codigo servico] = '" + codigo + "'";
                var dt = db.SqlQuery(sql);
                return dt;
            }
        }
        
        
        public class List
        {

        }
    }
}
