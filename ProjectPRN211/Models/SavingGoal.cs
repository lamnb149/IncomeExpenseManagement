using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.Models
{
    public class SavingGoal
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SavingGoal(string username, string name, decimal targetAmount, decimal currentAmount, DateTime startDate, DateTime endDate)
        {
            Username = username;
            Name = name;
            TargetAmount = targetAmount;
            CurrentAmount = currentAmount;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
