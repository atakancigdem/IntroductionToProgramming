using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager // Başvuru 
    {
        //Method injection
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices) // Başvuru Yap
        {
            // Başvuru bilgileri değerlendirme.

            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            } 
        }

        public void GiveCreditInformation(List<ICreditManager> credits) //Kredi Ön Bilgilendirmesi Yap
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
