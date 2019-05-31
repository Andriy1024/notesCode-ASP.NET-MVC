using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace notesCode_ASP_NET_MVC.Models
{
    //public class myContext : DbContext
    //{
    //    public myContext() : base("name=myContext") { }
    //    public DbSet<Course> Courses { get; set; }
    //    public DbSet<Lesson> Lessons { get; set; }
    //}
    //public class notesCodeDbInitializer : DropCreateDatabaseIfModelChanges<myContext>
    //{
    //    protected override void Seed(myContext db)
    //    {
    //        db.Courses.Add(new Course { Id = 1, Name = "C++" });
    //        db.Courses.Add(new Course { Id = 2, Name = "Qt" });

    //        //C++ lessons
    //        db.Lessons.Add(new Lesson { Subject = "Типи даних", Description = "Типи даних", Filepath = "c/type.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Оператори й операції", Description = "Оператори й операції", Filepath = "c/operators.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Керуючі структури С++", Description = "Керуючі структури С++", Filepath = "c/managing_structures.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Цикли в С++", Description = "Цикли в С++", Filepath = "c/cycle.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Функції", Description = "Функції", Filepath = "c/standart_functions.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Масиви", Description = "Масиви", Filepath = "c/array.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Вказівники*, Силки&", Description = "Вказівники*, Силки&", Filepath = "c/ptr.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Робота зі стрічками", Description = "Робота зі стрічками", Filepath = "c/string.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Структури", Description = "Структури", Filepath = "c/struct.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Динамічні Структури даних", Description = "Динамічні Структури даних", Filepath = "c/dynamic_struct.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Робота з файлами", Description = "Робота з файлами", Filepath = "c/fstream.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Шаблони функцій", Description = "Шаблони функцій", Filepath = "c/template.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "ООП Класи", Description = "ООП Класи", Filepath = "c/clases.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Конструктор і Деструктор", Description = "Конструктор і Деструктор", Filepath = "c/constructors.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Перегрузка операцій", Description = "Перегрузка операцій", Filepath = "c/peregruzka.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Наслідування", Description = "Наслідування", Filepath = "c/nasliduvanya.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Virtual", Description = "Virtual", Filepath = "c/virtual.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "Exeption", Description = "Exeption", Filepath = "c/exception.html", CourseId = 1 });
    //        db.Lessons.Add(new Lesson { Subject = "STL", Description = "STL", Filepath = "c/stl.html", CourseId = 1 });

    //        //Qt lessons
    //        db.Lessons.Add(new Lesson { Subject = "Qt Creator", Description = "Qt Creator", Filepath = "qt/qt_creator.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Віджети та компанування", Description = "Віджети та компанування", Filepath = "qt/Widgets.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Класи компанування", Description = "Класи компанування", Filepath = "qt/comp.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Модулі Qt", Description = "Модулі Qt", Filepath = "qt/Modul.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Знайомство з Qt Designer", Description = "Знайомство з Qt Designer", Filepath = "qt/qt_designer.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Сигнали і слоти", Description = "Сигнали і слоти", Filepath = "qt/signals.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Класи головного вікна", Description = "Класи головного вікна", Filepath = "qt/mainwindow.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Діалогові вікна", Description = "Діалогові вікна", Filepath = "qt/dialog.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Модальні і немодальні вікна", Description = "Модальні і немодальні вікна", Filepath = "qt/Modal.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Створення меню", Description = "Створення меню", Filepath = "qt/Menu.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Робота з файлами", Description = "Робота з файлами", Filepath = "qt/qfile.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Клас QDate", Description = "Клас QDate", Filepath = "qt/qdata.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Клас QTime", Description = "Клас QTime", Filepath = "qt/qtime.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Контейнери", Description = "Контейнери", Filepath = "qt/conteiner.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Ітератори", Description = "Ітератори", Filepath = "qt/iterator.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "foreach", Description = "foreach", Filepath = "qt/foreach.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "QtWebKit Guide", Description = "QtWebKit Guide", Filepath = "qt/Webkit.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Модуль QtSql", Description = "Модуль QtSql", Filepath = "qt/sql.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Система малювання в Qt", Description = "Система малювання в Qt", Filepath = "qt/paint.html", CourseId = 2 });
    //        db.Lessons.Add(new Lesson { Subject = "Тестування в Qt", Description = "Тестування в Qt", Filepath = "qt/test.html", CourseId = 2 });


    //        base.Seed(db);
    //    }
    //}
}