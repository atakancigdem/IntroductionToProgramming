using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Miras - inheritance
    class CorporateCustomer:Customer //Tüzel Müşteri
    {
        public string CompanyName { get; set; } //Şirket Adı       
        public string TaxNumber { get; set; } // Vergi Numarası
    }
}
