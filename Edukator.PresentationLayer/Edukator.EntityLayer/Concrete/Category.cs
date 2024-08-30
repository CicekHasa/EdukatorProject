using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Category
    {
        //değişken
        //int x;

        //Property
        //class ile aynı isimde id oluşturulursa o değişkeni tablonun birincil anahtarı olarak ve identity'si de 1 er kez artacak şekilde algılar.
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }    
    }
}
