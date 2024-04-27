using Npgsql;
using System;
using Dapper;

using PIM_III_ADS_2P17_AVALIACAO.Controle;

namespace PIM_III_ADS_2P17.Servico
{
    public class PessoaServico
    {
        private readonly Dbconexao dbconexao;

        public PessoaServico(Dbconexao conexao)
        {
            this.dbconexao = conexao;
        }

        public PessoaControle BuscarPorCodigo(PessoaControle pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                   "SELECT * FROM visitante WHERE Codigo = @codigo ",
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
