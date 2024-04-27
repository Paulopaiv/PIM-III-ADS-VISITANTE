using System;
using Dapper;
using Npgsql;
using PIM_III_ADS_2P17.Servico;



namespace PIM_III_ADS_2P17_AVALIACAO.Servico
{
    internal class AvaliacaoService
    {
        private Dbconexao dbconexao = new Dbconexao();

        internal void RegistrarVoto(string pergunta, string avaliacao, string codigoUsuario)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                // Crie o comando SQL
                using (NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO public.votos (codigo, pergunta, voto, data)
                                                               VALUES (@CodigoPessoa, @Pergunta, @Voto, @Data)", conexao))
                {
                    command.Parameters.AddWithValue("@CodigoPessoa", codigoUsuario);
                    command.Parameters.AddWithValue("@Pergunta", pergunta);
                    command.Parameters.AddWithValue("@Voto", avaliacao);
                    command.Parameters.AddWithValue("@Data", DateTime.Now);

                    int linhasAfetadas = command.ExecuteNonQuery();
                    conexao.Close(); 

                    if (linhasAfetadas > 0)
                    {
                        Console.WriteLine("Voto registrado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Falha ao registrar o voto.");
                    }
                }
            }
        }
    }
}

