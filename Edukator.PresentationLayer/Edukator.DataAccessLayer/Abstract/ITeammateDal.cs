using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ITeammateDal:IGenericDal<Teammate>
    {
        List<Teammate> LoadLast4Records();
    }
}
