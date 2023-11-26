




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
student1.Id = 1;
student1.StudentInfo();

Student student2 = new("Nergiz Quliyeva",92);
student2.Id = 2;
student2.StudentInfo();

Student student3 = new("Ferid Huseynov",53);
student3.Id = 3;
student3.StudentInfo();


