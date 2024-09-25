using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        //**Ef içinde her entity'e ait DAL katmanındaki Entity klasörü altında sınıf oluşturma sebebi generic olarak oluşturulan repository'i hangi entity'e karşılık geldiğini dolduruyoruz.
        //ICategoryDal 'ı da ekleme sebebim entity'e özel bir method da olabilir. GenericRepo içindekinin dışında!

    }
}
