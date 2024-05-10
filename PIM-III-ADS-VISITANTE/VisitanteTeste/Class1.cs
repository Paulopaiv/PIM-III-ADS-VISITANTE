using NUnit.Framework;
using PIM_III_ADS_VISITANTE.Controller;

namespace VisitanteTeste
{
    [TestFixture]
    public class AvaliacaoControllerTests
    {
        [Test]
        public void AvaliacaoSelecionada_DeveRetornarNenhumaAvaliacaoQuandoNenhumaAvaliacaoSelecionada()
        {
            // Arrange
            var avaliacaoController = new AvaliacaoController();

            // Act
            var resultado = avaliacaoController.AvaliacaoSelecionada();

            // Assert
            Assert.AreEqual("Nenhuma avaliação selecionada", resultado);
        }

        // Adicione mais testes aqui para outros métodos e propriedades
    }
}
