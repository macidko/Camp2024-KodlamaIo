using Intro_2024.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_2024.Business;

public class CourseManager
{
    //ctor içerisinde değer atayıp diğer metotlarda kullanabilmek için global scope'da array tanımlanır 
    Course[] _courses = new Course[3];
    public CourseManager()
    {
        //referans oluşturma - instance
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C# Course";
        course1.Description = ".NET 8 vs...";
        course1.Price = 20;
        //referans oluşturma - instance
        Course course2 = new Course();
        course1.Id = 2;
        course1.Name = "Java Course";
        course1.Description = "Java 17...";
        course1.Price = 10;
        //referans oluşturma - instance
        Course course3 = new Course();
        course1.Id = 3;
        course1.Name = "Python Course";
        course1.Description = "Python 3.12...";
        course1.Price = 100;

        //_courses arrayine değer atama
        _courses[0] = course1;
        _courses[1] = course2;
        _courses[2] = course3;

    }
    public Course[] GetAll()
    {
        //Veri kaynağından çekilir...
        //Console.WriteLine("Kurslar Listelendi.");

        //courses array'in döndürülmesi
        return _courses;
    }
}
