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

        //public PessoaControle BuscarPessoaNomeECodigo(PessoaControle pessoa)
        //{
        //    using (var conexao = new Dbconexao())
        //    {
        //        var connection = conexao.GetConnection();

        //        var resultado = connection.QueryFirstOrDefault(
        //            "SELECT nome, idade, email, cep, codigo FROM public.visitante WHERE nome = @nome AND codigo = @codigo",
        //            new { pessoa.Nome, pessoa.Codigo });

        //        if (resultado != null)
        //        {
                   
        //            pessoa.Nome = resultado.nome;
        //            pessoa.IdadeDb = resultado.idade;
        //            pessoa.Email = resultado.email;
        //            pessoa.Cep = resultado.cep;
        //            pessoa.Codigo = resultado.codigo;

        //            // Retornando a própria instância de pessoa, que agora está atualizada com os dados encontrados
        //            return pessoa;
        //        }
        //        return null;
        //    }
        //}
    }
}
