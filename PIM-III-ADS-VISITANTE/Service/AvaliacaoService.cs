using System;
using Dapper;
using Npgsql;
using PIM_III_ADS_2P17.Servico;



namespace PIM_III_ADS_2P17_AVALIACAO.Servico
{
    internal class AvaliacaoService
    {
        private Dbconexao dbconexao = new Dbconexao();
        private NpgsqlConnection conexao;

        internal AvaliacaoService()
        {
            conexao = dbconexao.GetConnection() as NpgsqlConnection;
        }

        internal void RegistrarVoto(string pergunta, string avaliacao, string codigoUsuario)
        {
            
            using (NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO public.votos (codigo, pergunta, voto, data)
                                                       VALUES (@CodigoPessoa, @Pergunta, @Voto, @Data)", conexao))
            {
                command.Parameters.AddWithValue("@CodigoPessoa", codigoUsuario);
                command.Parameters.AddWithValue("@Pergunta", pergunta);
                command.Parameters.AddWithValue("@Voto", avaliacao);
                command.Parameters.AddWithValue("@Data", DateTime.Now);

                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas < 0)
                {
                    MessageBox.Show("Falha ao registrar o voto.");
                }
            }
        }
    }

}

