using System;
using Dapper;
using Npgsql;
using PIM_III_ADS_2P17.Service;

namespace PIM_III_ADS_2P17_AVALIACAO.Service
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

        internal List<string> QuantidadeVotos()
        {
            List<string> resultados = new List<string>();

            using (NpgsqlCommand command = new NpgsqlCommand
                (@"SELECT
            voto,
            COUNT(voto) AS quantidade
        FROM
           votos
        GROUP BY
            voto", conexao))
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string voto = reader.GetString(0);
                    int quantidade = reader.GetInt32(1);
                    resultados.Add($"{voto}\t{quantidade}");
                }
            }

            return resultados;
        }



    }
}
