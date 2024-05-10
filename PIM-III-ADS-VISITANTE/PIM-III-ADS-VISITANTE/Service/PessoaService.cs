using Dapper;
using PIM_III_ADS_VISITANTE.Controller;


namespace PIM_III_ADS_VISITANTE.Service
{
    public class PessoaServico
    {
        private readonly Dbconexao dbconexao;

        public PessoaServico(Dbconexao conexao)
        {
            this.dbconexao = conexao;
        }

        public PessoaController BuscarPorCodigo(PessoaController pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                   "SELECT * FROM tbl_visitante WHERE Codigo = @codigo ",
                    new { Codigo = pessoa.Codigo });

                if (resultado == null)
                {
                    return null;
                }
                pessoa.Codigo = resultado.codigo;
                pessoa.Nome = resultado.nome;
                return pessoa;
            }
        }
    }
}
