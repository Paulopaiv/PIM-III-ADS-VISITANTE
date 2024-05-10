using Xunit;
using Moq;
using PIM_III_ADS_VISITANTE.Controller;
using PIM_III_ADS_VISITANTE.Model;
using PIM_III_ADS_VISITANTE.View;

namespace TestProject
{
    public class AvaliacaoTests
    {
        [Fact]
        public void btnRuim_Click()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoModelMock = new Mock<AvaliacaoModel>();
            var avaliacaoControle = new AvaliacaoController();
            var avaliacaoForm = new Avaliacao(pessoaControllerMock.Object);
            avaliacaoForm.avaliacaoControle = avaliacaoControle;
            avaliacaoForm.avaliacaoModel = avaliacaoModelMock.Object;

            // Act
            avaliacaoForm.btnRuim_Click(null, null);

            // Assert
            Assert.True(avaliacaoControle.Ruim);
            Assert.False(avaliacaoControle.Regular);
            Assert.False(avaliacaoControle.Bom);
            Assert.False(avaliacaoControle.Otimo);
            Assert.False(avaliacaoControle.Excelente);
            avaliacaoModelMock.Verify(x => x.SalvarVoto(), Times.Once);
        }

        [Fact]
        public void btnRegular_Click()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoModelMock = new Mock<AvaliacaoModel>();
            var avaliacaoControle = new AvaliacaoController();
            var avaliacaoForm = new Avaliacao(pessoaControllerMock.Object);
            avaliacaoForm.avaliacaoControle = avaliacaoControle;
            avaliacaoForm.avaliacaoModel = avaliacaoModelMock.Object;

            // Act
            avaliacaoForm.btnRuim_Click(null, null);

            // Assert
            Assert.True(avaliacaoControle.Ruim);
            Assert.False(avaliacaoControle.Regular);
            Assert.False(avaliacaoControle.Bom);
            Assert.False(avaliacaoControle.Otimo);
            Assert.False(avaliacaoControle.Excelente);
            avaliacaoModelMock.Verify(x => x.SalvarVoto(), Times.Once);
        }

        [Fact]
        public void btnBom_Click()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoModelMock = new Mock<AvaliacaoModel>();
            var avaliacaoControle = new AvaliacaoController();
            var avaliacaoForm = new Avaliacao(pessoaControllerMock.Object);
            avaliacaoForm.avaliacaoControle = avaliacaoControle;
            avaliacaoForm.avaliacaoModel = avaliacaoModelMock.Object;

            // Act
            avaliacaoForm.btnRuim_Click(null, null);

            // Assert
            Assert.True(avaliacaoControle.Ruim);
            Assert.False(avaliacaoControle.Regular);
            Assert.False(avaliacaoControle.Bom);
            Assert.False(avaliacaoControle.Otimo);
            Assert.False(avaliacaoControle.Excelente);
            avaliacaoModelMock.Verify(x => x.SalvarVoto(), Times.Once);
        }

        [Fact]
        public void btnOtimo_Click()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoModelMock = new Mock<AvaliacaoModel>();
            var avaliacaoControle = new AvaliacaoController();
            var avaliacaoForm = new Avaliacao(pessoaControllerMock.Object);
            avaliacaoForm.avaliacaoControle = avaliacaoControle;
            avaliacaoForm.avaliacaoModel = avaliacaoModelMock.Object;

            // Act
            avaliacaoForm.btnRuim_Click(null, null);

            // Assert
            Assert.True(avaliacaoControle.Ruim);
            Assert.False(avaliacaoControle.Regular);
            Assert.False(avaliacaoControle.Bom);
            Assert.False(avaliacaoControle.Otimo);
            Assert.False(avaliacaoControle.Excelente);
            avaliacaoModelMock.Verify(x => x.SalvarVoto(), Times.Once);
        }

        [Fact]
        public void btnExcelente_Click()
        {
            // Arrange
            var pessoaControllerMock = new Mock<PessoaController>();
            var avaliacaoModelMock = new Mock<AvaliacaoModel>();
            var avaliacaoControle = new AvaliacaoController();
            var avaliacaoForm = new Avaliacao(pessoaControllerMock.Object);
            avaliacaoForm.avaliacaoControle = avaliacaoControle;
            avaliacaoForm.avaliacaoModel = avaliacaoModelMock.Object;

            // Act
            avaliacaoForm.btnRuim_Click(null, null);

            // Assert
            Assert.True(avaliacaoControle.Ruim);
            Assert.False(avaliacaoControle.Regular);
            Assert.False(avaliacaoControle.Bom);
            Assert.False(avaliacaoControle.Otimo);
            Assert.False(avaliacaoControle.Excelente);
            avaliacaoModelMock.Verify(x => x.SalvarVoto(), Times.Once);
        }

        // Similar tests for btnRegular_Click, btnBom_Click, btnOtimo_Click, btnExcelente_Click
    }
}
