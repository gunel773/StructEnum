//- StudentLimit - qrupda ola biləcək tələbə sayını göstərir minumum 5 maximum 18 ola bilər.
//- Students - Student tipindən bir array-dir özündə student obyektləri saxlayacaq və private olacaq.
//- AddStudent() -parametr olaraq Student obyekti qəbul edir və gələn student obyektini
//Group class-ında olan Students arrayinə əlavə edir əgər arrayin uzuluğu StudentLimit-i
//keçirsə əlavə etməməlidi.
//- GetStudent() -parametr olaraq nullable int tipindən bir id dəyəri alacaq və
//həmin id-li Student obyektini tapıb geriyə qaytaracaq.
//- GetAllStudents() -geriyə Student arrayi qaytaracaq.


//ps: GroupNo və StudentLimit dəyərləri olmadan Group Obyekti yaratmaq olmaz.

using StructEnum.Domain.Models;

Student student1 = new ("Teymur Abbasli",75);
student1.StudentInfo();

Student student2 = new("Nergiz Quliyeva",92);
student2.StudentInfo();

Student student3 = new("Ferid Huseynov",53);
student3.StudentInfo();
Console.WriteLine("-------------------------------------------------");

Group group1 = new(11,"PB530");
group1.AddStudent(student1);
group1.AddStudent(student2);
group1.AddStudent(student3);
Console.WriteLine("Searched student:");
group1.GetStudent(2);
Console.WriteLine("Students of group:");
group1.GetAllStudent();
Console.WriteLine("___________________________________________________");

Group group2 = new(4, "PCB530");
group2.AddStudent(student1);
group2.AddStudent(student2);
group2.AddStudent(student3);
Console.WriteLine("Searched student:");
group2.GetStudent(3);
Console.WriteLine("...............................");
Console.WriteLine("Students of group:");
group2.GetAllStudent();
Console.WriteLine("___________________________________________________");


Group group3 = new(7, "PB50");
group3.AddStudent(student1);
group3.AddStudent(student2);
group3.AddStudent(student3);
Console.WriteLine("Searched student:");
group3.GetStudent(4);
Console.WriteLine("...............................");
Console.WriteLine("Students of group:");
group3.GetAllStudent();
Console.WriteLine("___________________________________________________");







