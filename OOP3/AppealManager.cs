using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{         //BaşvuruManager
    class AppealManager
    {
        public void Appeal(ICreditManager creditManager, ILoggerService loggerService) //Başvuru yapma operaasyonu
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void Information(List<ICreditManager> credits) //ön bilgilendirme operasyonu
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
