using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    class RealCustomer:Customer //Gerçek Müşteri
    {
        public string TcNumber { get; set; } // Tc numarası
        public string Name { get; set; } //Adı
        public string Surname { get; set; } // Soyadı
    }
}
