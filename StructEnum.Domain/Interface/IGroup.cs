using StructEnum.Domain.Models;


namespace StructEnum.Domain.Interface
{
    public interface IGroup
    {
        public bool CheckGroupNo(string groupNo);
        public void AddStudent( Student student);
        public void GetStudent(int id);
        public void GetAllStudent();
    }
}
