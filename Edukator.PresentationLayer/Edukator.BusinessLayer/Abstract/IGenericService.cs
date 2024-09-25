using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        //Methodların başına T koymamızın sebebi Data Access Layer katmanındaki IGenericDal içindeki methodlar ile karıştırmamak. (T opsiyonel)
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
