using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.Models
{
    public class Budget
    {
        public string Username { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Budget(string username, int categoryId, decimal amount, DateTime startDate, DateTime endDate)
        {
            Username = username;
            CategoryId = categoryId;
            Amount = amount;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
