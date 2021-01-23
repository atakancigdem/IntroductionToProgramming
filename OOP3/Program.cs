using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();          
            ICreditManager vehicleCreditManager = new VehicleCreditManager();            
            ICreditManager housingCreditManager = new HousingCreditManager();
            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> logger = new List<ILoggerService>() { databaseLoggerService, smsLoggerService};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(vehicleCreditManager, logger);

            List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager, vehicleCreditManager};            
            //applicationManager.GiveCreditInformation(credits);
            
        }
    }
}
