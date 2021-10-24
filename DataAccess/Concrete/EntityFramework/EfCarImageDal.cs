using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarImageDal : EfEntityRepositoryBase<CarImage, ReCapProjectContext>, ICarImageDal
	{
		public bool IsExist(int id)
		{
			using (ReCapProjectContext context = new ReCapProjectContext())
			{
				return context.CarImages.Any(p => p.Id == id);
			}
		}
	}
}
