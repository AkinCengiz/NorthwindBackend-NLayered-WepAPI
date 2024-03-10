using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBackend.Core.DataAccess;
using NorthwindBackend.Entities.Concrete;

namespace NorthwindBackend.DataAccess.Abstract;
public interface IOperationClaimDal : IEntityRepository<OperationClaim>
{
}
