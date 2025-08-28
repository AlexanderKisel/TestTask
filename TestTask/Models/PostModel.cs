using System.Collections.Generic;

namespace TestTask.Models
{
    //Модель должности
    public partial class PostModel
    {
        public PostModel()
        {
            Persons = new HashSet<PersonModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PersonModel> Persons { get; set; }
    }
}
