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
    public class EfContactInfoDal : GenericRepository<ContactInfo>, IContactInfoDal
    {
        public ContactInfo GetLast2Record()
        {
            using var context = new Context();
            var values = context.ContactInfos.OrderByDescending(x => x.ContactInfoID).Take(1).FirstOrDefault();
            return values;
        }
    }
}
