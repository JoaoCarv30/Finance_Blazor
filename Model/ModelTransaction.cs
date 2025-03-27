using System.ComponentModel.DataAnnotations;
using FinanceBlazor.Enum;

namespace FinanceBlazor.Model;

public class ModelTransaction
{
    
    
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo Descrição é obrigatório")]
    public string Category { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo Tipo é obrigatório")]
    public TypeTransaction Type { get; set; }
    [Required(ErrorMessage = "O campo Preço é obrigatório")]
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
}

