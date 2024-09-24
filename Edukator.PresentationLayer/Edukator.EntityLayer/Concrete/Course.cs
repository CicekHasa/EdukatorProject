using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Review { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        //Code first de ilişkili alan eklediğimizde CategoryID gibi, onun bir altına property olarak o alan hangi class'dan geliyorsa(Category) o class türünde bir prop belirtilmeli. Bunun yapılma sebebi ise CategoryID alanının ilişkili olduğunu göstermek için.

        //Db ye Sadece CategoryID alanı yansır. Category türünde oluşturulan alan db ye yansımaz!

    }
}
