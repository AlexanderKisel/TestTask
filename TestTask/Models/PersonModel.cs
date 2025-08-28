using System;

namespace TestTask.Models
{
    //Модель работников
    public partial class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateEmploy { get; set; }
        public DateTime? DateUnemploy { get; set; }
        public int StatusId { get; set; }
        public int DepId { get; set; }
        public int PostId { get; set; }

        public virtual DepModel Dep { get; set; }
        public virtual PostModel Post { get; set; }
        public virtual StatusModel Status { get; set; }
    }
}
