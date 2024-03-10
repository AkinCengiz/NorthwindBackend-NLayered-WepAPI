using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using NorthwindBackend.Core.Entities.Concrete;

namespace NorthwindBackend.Core.Utilities.Security.JWT;
public interface ITokenHelper
{
	AccessToken CreateToken(User user);
}
