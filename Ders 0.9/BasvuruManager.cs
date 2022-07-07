using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_0._9
{
	class BasvuruManager
	{
		public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
		{
			krediManager.Hesapla();
			loggerService.log();
		}

		public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
		{
			foreach (var kredi in krediler)
			{
				kredi.Hesapla();
			}
		}

	}

}
