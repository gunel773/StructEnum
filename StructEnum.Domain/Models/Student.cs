using StructEnum.Domain.Interface;

namespace StructEnum.Domain.Models
{
    public class Student:IStudent
    {
        private static int _id;
        public int Id { get; set; }
        public int Point { get; set; }
        public string Fullname { get; set; }


        public Student(string fullname, int point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;

        }

        public void StudentInfo()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{Id}){Fullname}- {Point}";
        }
    }
}