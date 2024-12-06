namespace CreditSuiss; 
public interface ICategoryRule
{
    string Categorize(ITrade trade, DateTime referenceDate);
}