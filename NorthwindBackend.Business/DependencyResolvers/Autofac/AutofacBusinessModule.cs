using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NorthwindBackend.Business.Abstract;
using NorthwindBackend.Business.Concrete;
using NorthwindBackend.DataAccess.Abstract;
using NorthwindBackend.DataAccess.Concrete.EntityFramework;

namespace NorthwindBackend.Business.DependencyResolvers.Autofac;
public class AutofacBusinessModule : Module
{
	protected override void Load(ContainerBuilder builder)
	{
		builder.RegisterType<ProductManager>().As<IProductService>();
		builder.RegisterType<EfProductDal>().As<IProductDal>();
		builder.RegisterType<CategoryManager>().As<ICategoryService>();
		builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
		builder.RegisterType<UserManager>().As<IUserService>();
		builder.RegisterType<EfUserDal>().As<IUserDal>();
	}
}
