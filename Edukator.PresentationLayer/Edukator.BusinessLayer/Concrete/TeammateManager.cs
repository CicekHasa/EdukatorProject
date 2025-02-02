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
    public class TeammateManager : ITeammateService
    {

        private readonly ITeammateDal _teammateDal;

        public TeammateManager(ITeammateDal teammateDal)
        {
            _teammateDal = teammateDal;
        }

        public void TDelete(Teammate t)
        {
            _teammateDal.Delete(t);
        }

        public Teammate TGetByID(int id)
        {
            return _teammateDal.GetByID(id);
        }

        public List<Teammate> TGetList()
        {
            return _teammateDal.GetList();
        }

        public void TInsert(Teammate t)
        {
            _teammateDal.Insert(t);
        }

        public List<Teammate> TLoadLast4Records()
        {
            return _teammateDal.LoadLast4Records();
        }

        public void TUpdate(Teammate t)
        {
            _teammateDal.Update(t);
        }
    }
}
