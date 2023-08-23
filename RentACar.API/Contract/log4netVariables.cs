using System;
using Volo.Abp.Users;

namespace RentACar.API.Contract
{
	public class log4netVariables
	{
        private readonly ICurrentUser _current;

        public log4netVariables(ICurrentUser current)
        {
            _current = current;
        }

        

	}

}

