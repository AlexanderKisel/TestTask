using System.Collections.Generic;

namespace Staff.Models
{
    //Модель статуса
    public partial class StatusModel
    {
        public StatusModel()
        {
            Persons = new HashSet<PersonModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PersonModel> Persons { get; set; }
    }
}
