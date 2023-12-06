using StructEnum.Domain.Interface;
using StructEnum.Helper.Messages;
using System.Text.RegularExpressions;


namespace StructEnum.Domain.Models
{
    public class Group:IGroup
    {
        public int Id { get; set; }
        private string _groupNo;
        public string GroupNo 
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if(CheckGroupNo(value))
                {
                    _groupNo = value;
                    Console.WriteLine(InfoMessage.SuccessMessage);
                    return;
                }
                Console.WriteLine(InfoMessage.FailMessage);
                return;
            }

        }
        private int _studentslimit;
        public int StudentLimit
        {
            get { return _studentslimit; }
            set
            {
                if (value>=5 && value<=18)
                {
                    _studentslimit = value;
                    return;
                }
                Console.WriteLine(InfoMessage.LimitMessage);
            }
        }
        private Student[] Students =new Student[0];

       
        public Group(int studentLimit, string groupNo)
        {
            StudentLimit = studentLimit;
            GroupNo = groupNo;
           
        }





        public bool CheckGroupNo(string groupNo)
        {

            return new Regex(@"^[A-Z]{2}[0-9]{3}$").IsMatch(groupNo);

        }

        public void GetStudent(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id==id)
                {
                    Console.WriteLine(student);
                    return;
                }
            }
            Console.WriteLine($" Student Not Found, which id={id}");
        }

        public void AddStudent(Student student)
        {
            if (Students.Length >= StudentLimit) return;

            Array.Resize ( ref Students, Students.Length+1);
            Students[Students.Length-1]= student;
            Console.WriteLine($"{student} added is group");


        }

        public void GetAllStudent()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
            
        }
    }
}
