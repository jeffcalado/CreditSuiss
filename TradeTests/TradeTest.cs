
using Xunit;

namespace CreditSuiss.Tests;

public class TradeTests
{
    [Fact]
    public void Trade_ShouldInitializeCorrectly()
    {
        // Arrange
        var trade = new Trade(1000000, "Private", new DateTime(2025, 12, 29));

        // Act & Assert
        Assert.Equal(1000000, trade.Value);
        Assert.Equal("Private", trade.ClientSector);
        Assert.Equal(new DateTime(2025, 12, 29), trade.NextPaymentDate);

    }

    [Theory]
    [InlineData(500000, "Private", "2024-12-12", "UNCATEGORIZED")]
    [InlineData(2000000, "Public", "2024-11-10", "MEDIUMRISK")]
    public void Categorizer_ShouldCategorizeCorrectly(double value, string clientSector, string nextPaymentDate, string expectedCategory)
    {
        // Arrange
        var trade = new Trade(value, clientSector, DateTime.Parse(nextPaymentDate));

        // Act
        var category = Categorizer.Categorize(trade, DateTime.Now);

        // Assert
        Assert.Equal(expectedCategory, category);
    }
}