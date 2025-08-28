using System.Collections.Generic;

namespace TestTask.Models
{
    //Модель отделов
    public partial class DepModel
    {
        public DepModel()
        {
            Persons = new HashSet<PersonModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PersonModel> Persons { get; set; }
    }
}
