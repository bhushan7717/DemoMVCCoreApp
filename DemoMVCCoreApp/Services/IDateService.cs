using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVCCoreApp.Services
{
	public interface IDateService
	{
		DateTime Today { get; }
	}

	public class DateService : IDateService
	{
		public DateTime Today
		{
			get
			{
				return DateTime.Today;
			}
		}
	}

	public class TestService : IDateService
	{
		public DateTime Today
		{
			get
			{
				return new DateTime(2017, 3, 21);
			}
		}
	}

}
