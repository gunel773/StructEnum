using StructEnum.Domain.Interface;

using System.Text.RegularExpressions;


namespace StructEnum.Domain.Models
{
    public class Group:Student ,IGroup
    {
        public string GroupNo { get; set; }
        private int _studentslimit;
        private Student[] Students { get; set; }




        public Group(string fullname, int point) : base(fullname, point)
        {
        }

        public int StudentsLimit 
        {
            get
            {
                return _studentslimit;
            }

            set
            {
                if(Students.Length>5& Students.Length < 18)
                {
                    Console.WriteLine("Limit kecilmeyib. Telebe qebul edile biler");
                }
                else
                {
                    Console.WriteLine("Qrup dolub...");
                }
                
            }
        }

        public string CheckGroupNo(string groupNo)
        {
            GroupNo = groupNo;
            if (string.IsNullOrEmpty(GroupNo))
            {
                Console.WriteLine("Siz hec bir nomre daxil etmemisiniz");
            }

            bool pattern = Regex.IsMatch(GroupNo, @"^[A-Z]{2}[0-9]{3}$");
            if (pattern)
            {
                return $"giriş edildi";
            }
            return "Daxil etdiyiniz nomre tapilmadi";
        }

        Student[] students=new Student[StudentsLimit];

        public string GetStudent(int? id)
        {
            if (!id.HasValue)
            {
                return null;
            }

            
            Student student = students.Find(a => a.Id == id.Value);
            return student.Fullname;
        }

        public Student AddStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
