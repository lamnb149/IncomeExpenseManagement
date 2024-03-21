using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string Username { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }

        public Transaction(int transactionId, string username, int categoryId, decimal amount, DateTime createdDate, DateTime? updatedDate, DateTime? deletedDate, string description, int type)
        {
            TransactionId = transactionId;
            Username = username;
            CategoryId = categoryId;
            Amount = amount;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            DeletedDate = deletedDate;
            Description = description;
            Type = type;
        }
    }
}
