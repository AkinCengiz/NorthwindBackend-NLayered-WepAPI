using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBackend.Business.Abstract;
using NorthwindBackend.DataAccess.Abstract;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.Business.Concrete;
public class UserManager : IUserService
{
	private IUserDal _userDal;

	public UserManager(IUserDal userDal)
	{
		_userDal = userDal;
	}

	public List<OperationClaim> GetClaims(User user)
	{
		return _userDal.GetClaims(user);
	}

	public void Add(User user)
	{
		_userDal.Add(user);
	}

	public User GetByMail(string mail)
	{
		return _userDal.Get(u => u.Email == mail);
	}
}
