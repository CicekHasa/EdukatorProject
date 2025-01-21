using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class SiteFeatureManager : ISiteFeatureService
    {

        private readonly ISiteFeatureDal _siteFeatureDal;

        public SiteFeatureManager(ISiteFeatureDal siteFeatureDal)
        {
            _siteFeatureDal = siteFeatureDal;
        }

        public void TDelete(SiteFeature t)
        {
           _siteFeatureDal.Delete(t);
        }

        public SiteFeature TGetByID(int id)
        {
            return _siteFeatureDal.GetByID(id);
        }

        public List<SiteFeature> TGetLast4Record()
        {
            return _siteFeatureDal.GetLast4Record();
        }

        public List<SiteFeature> TGetList()
        {
            return _siteFeatureDal.GetList();
        }

        public void TInsert(SiteFeature t)
        {
           _siteFeatureDal.Insert(t);
        }

        public void TUpdate(SiteFeature t)
        {
            _siteFeatureDal.Update(t);
        }
    }
}
