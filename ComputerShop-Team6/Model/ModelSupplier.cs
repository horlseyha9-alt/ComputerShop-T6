using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop_Team6.Model
{
    internal class ModelSupplier : DbConnection
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string SupplierName { get; set; }
        public DateTime DOB { get; set; }          // Date of Birth
        public string POB { get; set; }             // Place of Birth
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    
        public byte[] Photo { get; set; }           // បើរក្សាទុកជា Image ក្នុង Database

        
    }
}
