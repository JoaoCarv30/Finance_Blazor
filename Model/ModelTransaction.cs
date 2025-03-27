using FinanceBlazor.Enum;

namespace FinanceBlazor.Model;

public class ModelTransaction
{
    
    
    public int Id { get; set; }
    public TypeTransaction Type { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Value { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
}

