
namespace DomainLayer.Entities
{
    public  class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public CourseGroup Group { get; set; }
    }
}
