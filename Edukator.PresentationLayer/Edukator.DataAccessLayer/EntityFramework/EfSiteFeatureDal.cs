using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfSiteFeatureDal : GenericRepository<SiteFeature>, ISiteFeatureDal
    {
        public List<SiteFeature> GetLast4Record()
        {
            using var context = new Context();
            return context.SiteFeatures.OrderByDescending(x => x.SiteFeatureID).Take(4).ToList();
        }
    }
}
