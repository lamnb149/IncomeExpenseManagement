using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.Models
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }

        public Category(int categoryId, string name, string description, int type)
        {
            CategoryId = categoryId;
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
