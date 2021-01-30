using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        public bool Validate(Gamer gamer);
    }
}
