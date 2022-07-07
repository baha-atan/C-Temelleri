using System;

namespace Ders_0._9
{
	class FileLoggerService : ILoggerService
	{
		public void log()
		{
			Console.WriteLine("Dosyaya loglandı");
		}
	}
}
