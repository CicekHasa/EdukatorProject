using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfTeammateDal : GenericRepository<Teammate>, ITeammateDal
    {
        public List<Teammate> LoadLast4Records()
        {
            //using keyword'ü ile nesne oluşturunca nesne ile işi bittiğinde otomatik olarak Dispose methodunu çağırarak nesneyi öldürür, belleği temizler.
            //using kullanılmadan oluşturulan nesneleri senin dispose methodunu çağırarak öldürmen gerek!
            using var context = new Context();
            var values=context.Teammates.OrderByDescending(x=>x.TeammateID).Take(4).ToList();
            return values;
        }
    }
}
