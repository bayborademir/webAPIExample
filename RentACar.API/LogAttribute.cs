using System;
using System.Net;

namespace RentACar.API
{
	public class LogAttribute
	{
		[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
		public sealed class MyAttribute : Attribute
		{
			private readonly ILogger _logger;

            public MyAttribute(ILogger logger)
            {
                _logger = logger;
            }

			public void CreateInfoLog()
			{

            }
        
        }
	}
}

