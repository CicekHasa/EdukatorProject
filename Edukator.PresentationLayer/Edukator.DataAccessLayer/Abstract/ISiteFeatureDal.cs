using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ISiteFeatureDal:IGenericDal<SiteFeature>
    {
        List<SiteFeature> GetLast4Record();
    }
}
