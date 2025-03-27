using System.Collections.ObjectModel;
using FinanceBlazor.Model;

namespace FinanceBlazor.Service;

public class TransactionService
{
    public ObservableCollection<ModelTransaction> Transactions { get; } = new();
    private int _nextId = 0;

    public ModelTransaction CreateTransaction(ModelTransaction transaction)
    {
        transaction.Id = _nextId++; // Define um ID único
        transaction.CreatedAt = DateTime.Now;
        transaction.UpdatedAt = DateTime.Now;
        Transactions.Add(transaction);
        return transaction;
    }

    public ModelTransaction? GetTransactionById(int id)
    {
        return Transactions.FirstOrDefault(t => t.Id == id);
    }

    public bool UpdateTransaction(int id, ModelTransaction updatedTransaction)
    {
        var transaction = Transactions.FirstOrDefault(t => t.Id == id);
        if (transaction == null) return false;

        transaction.Name = updatedTransaction.Name;
        transaction.Category = updatedTransaction.Category;
        transaction.Type = updatedTransaction.Type;
        transaction.Price = updatedTransaction.Price;
        transaction.UpdatedAt = DateTime.Now;
        
        return true;
    }

    public bool DeleteTransaction(int id)
    {
        var transaction = Transactions.FirstOrDefault(t => t.Id == id);
        if (transaction == null) return false;

        Transactions.Remove(transaction);
        return true;
    }
    
    public List<ModelTransaction> GetIncomeTransactions()
    {
        return Transactions.Where(t => t.Type == Enum.TypeTransaction.Income).ToList();
    }
    
    public List<ModelTransaction> GetExpenseTransactions()
    {
        return Transactions.Where(t => t.Type == Enum.TypeTransaction.Expense).ToList();
    }

    public double SumIncomeTransactions()
    {
        return (double)GetIncomeTransactions().Sum(t => t.Price);
    }
    
    public double SumExpenseTransactions()
    {
        return (double)GetExpenseTransactions().Sum(t => t.Price);
    }
    
    public double SumTotalTransactions()
    {
        return SumIncomeTransactions() - SumExpenseTransactions();
    }
}