using StructEnum.Domain.Models;


namespace StructEnum.Domain.Interface
{
    public interface IGroup
    {
        public string CheckGroupNo(string groupNo);
        public Student AddStudent( Student student);
        public string GetStudent(Nullable <int> id);
    }
}
