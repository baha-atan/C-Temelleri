using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_0._9
{
	class DatabaseLoggerService : ILoggerService
	{
		public void log()
		{
			Console.WriteLine("Veritabanına loglandı");
		}
	}
}
