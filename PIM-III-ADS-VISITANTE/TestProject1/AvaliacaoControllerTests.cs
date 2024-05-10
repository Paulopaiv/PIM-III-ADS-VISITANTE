using Xunit;
using PIM_III_ADS_VISITANTE.Controller;

namespace TestProject
{
    public class AvaliacaoControllerTests
    {
        [Fact]
        public void AvaliacaoSelecionada_Ruim_ReturnsRuim()
        {
            // Arrange
            var avaliacaoController = new AvaliacaoController(ruim: true, regular: false, bom: false, otimo: false, excelente: false);

            // Act
            var resultado = avaliacaoController.AvaliacaoSelecionada();

            // Assert
            Assert.Equal("Ruim", resultado);
        }

        [Fact]
        public void AvaliacaoSelecionada_Regular_ReturnsRegular()
        {
            // Arrange
            var avaliacaoController = new AvaliacaoController(ruim: false, regular: true, bom: false, otimo: false, excelente: false);

            // Act
            var resultado = avaliacaoController.AvaliacaoSelecionada();

            // Assert
            Assert.Equal("Regular", resultado);
        }

        [Fact]
        public void AvaliacaoSelecionada_Bom_ReturnsBom()
        {
            // Arrange
            var avaliacaoController = new AvaliacaoController(ruim: false, regular: false, bom: true, otimo: false, excelente: false);

            // Act
            var resultado = avaliacaoController.AvaliacaoSelecionada();

            // Assert
            Assert.Equal("Bom", resultado);
        }

        [Fact]
        public void AvaliacaoSelecionada_Otimo_ReturnsOtimo()
        {
            // Arrange
            var avaliacaoController = new AvaliacaoController(ruim: false, regular: false, bom: false, otimo: true, excelente: false);

            // Act
            var resultado = avaliacaoController.AvaliacaoSelecionada();

            // Assert
            Assert.Equal("Otimo", resultado);
        }

        [Fact]
        public void AvaliacaoSelecionada_Excelente_ReturnsExcelente()
        {
            // Arrange
            var avaliacaoController = new AvaliacaoController(ruim: false, regular: false, bom: false, otimo: false, excelente: true);

            // Act
            var resultado = avaliacaoController.AvaliacaoSelecionada();

            // Assert
            Assert.Equal("Excelente", resultado);
        }
    }
}
