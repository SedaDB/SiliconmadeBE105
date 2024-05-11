namespace SDBOBSWebAPI.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
        public string ClassName { get; set; }

        public StudentEntity(int id, string name, string surname, int number, string className)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            this.ClassName = className;
        }

        public StudentEntity()
        {

        }
    }
}
