using Moq;
using PIM_III_ADS_VISITANTE.Controller;
using PIM_III_ADS_VISITANTE.Model;
using PIM_III_ADS_VISITANTE.Service;
using Xunit;

namespace TestProject1
{
    public class AvaliacaoModelTests
    {
        [Fact]
        public void SalvarVoto_ShouldNotRegisterVote_WhenPerguntaAtualIsLast()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoControllerMock = new Mock<AvaliacaoController>();
            var perguntasControllerMock = new Mock<PerguntasController>();
            var avaliacaoServiceMock = new Mock<AvaliacaoService>();

            var avaliacaoModel = new AvaliacaoModel(pessoaControllerMock.Object, avaliacaoControllerMock.Object, perguntasControllerMock.Object);
            perguntasControllerMock.Setup(x => x.PerguntaAtual()).Returns("Obrigado por participar! Volte sempre.");

            // Act
            avaliacaoModel.SalvarVoto();

            // Assert
            avaliacaoServiceMock.Verify(x => x.RegistrarVoto(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never);
            perguntasControllerMock.VerifySet(x => x.IndicePergunta++, Times.Never);
        }

        [Fact]
        public void SalvarVoto_ShouldNotRegisterVote_WhenPerguntaAtualIsObrigadoMessage()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoControllerMock = new Mock<AvaliacaoController>();
            var perguntasControllerMock = new Mock<PerguntasController>();
            var avaliacaoServiceMock = new Mock<AvaliacaoService>();

            var avaliacaoModel = new AvaliacaoModel(pessoaControllerMock.Object, avaliacaoControllerMock.Object, perguntasControllerMock.Object);
            perguntasControllerMock.Setup(x => x.PerguntaAtual()).Returns("Pergunta 1");
            avaliacaoControllerMock.Setup(x => x.AvaliacaoSelecionada()).Returns("Excelente");
            pessoaControllerMock.Setup(x => x.Codigo).Returns("123");

            // Act
            avaliacaoModel.SalvarVoto();

            // Assert
            avaliacaoServiceMock.Verify(x => x.RegistrarVoto("Pergunta 1", "Excelente", "123"), Times.Once);
            perguntasControllerMock.VerifySet(x => x.IndicePergunta++, Times.Once);
        }

        [Fact]
        public void SalvarVoto_ShouldAdvancePerguntaIndex_WhenVotoRegistrado()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoControllerMock = new Mock<AvaliacaoController>();
            var perguntasControllerMock = new Mock<PerguntasController>();
            var avaliacaoServiceMock = new Mock<AvaliacaoService>();

            var avaliacaoModel = new AvaliacaoModel(pessoaControllerMock.Object, avaliacaoControllerMock.Object, perguntasControllerMock.Object);
            perguntasControllerMock.Setup(x => x.PerguntaAtual()).Returns("Pergunta 1");
            avaliacaoControllerMock.Setup(x => x.AvaliacaoSelecionada()).Returns("Bom");
            pessoaControllerMock.Setup(x => x.Codigo).Returns("123");

            // Act
            avaliacaoModel.SalvarVoto();

            // Assert
            avaliacaoServiceMock.Verify(x => x.RegistrarVoto("Pergunta 1", "Bom", "123"), Times.Once);
            perguntasControllerMock.VerifySet(x => x.IndicePergunta++, Times.Once);
        }
    }
}
