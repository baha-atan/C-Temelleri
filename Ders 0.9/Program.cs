using System;
using System.Collections.Generic;

namespace Ders_0._9
{
	//OPP3
	class Program
	{
		static void Main(string[] args)
		{
			IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
			IKrediManager tasitKrediManager = new TasitKrediManager();
			//TasitKrediManager tasitKrediManager = new TasitKrediManager();
			IKrediManager konutKrediManager = new KonutKrediManager();

			ILoggerService databaseLoggerService = new DatabaseLoggerService();
			ILoggerService fileLogerService = new FileLoggerService();

			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(new EsnafKredisiManager(),new SmsLoggerService());


			List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

			//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
		}
	}
}
