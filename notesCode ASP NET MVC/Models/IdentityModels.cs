using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace notesCode_ASP_NET_MVC.Models
{
    public class ApplicationUser : IdentityUser //модель юзера
    {
        public string Name { get; set; }
        public string Secondname { get; set; }
        public int Age { get; set; } // добавляем свойство Age
        public int RightAnswers_of_CpluplusTest { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
                : base(store)
        {
        }
        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options,
                                                IOwinContext context)
        {
            ApplicationContext db = context.Get<ApplicationContext>();
            ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            return manager;
        }
    }
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        // при добалвені нових сущостей або полів треба виконувати міграцію бази даних
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Article> Articles { get; set; }

        public ApplicationContext()
            : base("myContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            // создаем две роли
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };

            // добавляем роли в бд
            roleManager.Create(role1);
            roleManager.Create(role2);

            // создаем пользователей
            var admin = new ApplicationUser { Email = "somemail@mail.ru", UserName = "andriy1024",Age = 20, Name = "Andriy", Secondname = "Zubyk" };
            string password = "123456";
            var result = userManager.Create(admin, password);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }
            else
            {
                string err = "";
                foreach (string error in result.Errors)
                {
                    err += error + " ";
                }
                throw new Exception(err);
            }

            db.Courses.Add(new Course { Id = 1, Name = "C++" });
            db.Courses.Add(new Course { Id = 2, Name = "Qt" });

            //C++ lessons
            db.Lessons.Add(new Lesson { Subject = "Типи даних", Description = "Типи даних", Filepath = "c/type.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Оператори й операції", Description = "Оператори й операції", Filepath = "c/operators.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Керуючі структури С++", Description = "Керуючі структури С++", Filepath = "c/managing_structures.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Цикли в С++", Description = "Цикли в С++", Filepath = "c/cycle.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Функції", Description = "Функції", Filepath = "c/standart_functions.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Масиви", Description = "Масиви", Filepath = "c/array.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Вказівники*, Силки&", Description = "Вказівники*, Силки&", Filepath = "c/ptr.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Робота зі стрічками", Description = "Робота зі стрічками", Filepath = "c/string.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Структури", Description = "Структури", Filepath = "c/struct.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Динамічні Структури даних", Description = "Динамічні Структури даних", Filepath = "c/dynamic_struct.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Робота з файлами", Description = "Робота з файлами", Filepath = "c/fstream.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Шаблони функцій", Description = "Шаблони функцій", Filepath = "c/template.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "ООП Класи", Description = "ООП Класи", Filepath = "c/clases.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Конструктор і Деструктор", Description = "Конструктор і Деструктор", Filepath = "c/constructors.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Перегрузка операцій", Description = "Перегрузка операцій", Filepath = "c/peregruzka.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Наслідування", Description = "Наслідування", Filepath = "c/nasliduvanya.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Virtual", Description = "Virtual", Filepath = "c/virtual.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "Exeption", Description = "Exeption", Filepath = "c/exception.html", CourseId = 1 });
            db.Lessons.Add(new Lesson { Subject = "STL", Description = "STL", Filepath = "c/stl.html", CourseId = 1 });

            //Qt lessons
            db.Lessons.Add(new Lesson { Subject = "Qt Creator", Description = "Qt Creator", Filepath = "qt/qt_creator.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Віджети та компанування", Description = "Віджети та компанування", Filepath = "qt/Widgets.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Класи компанування", Description = "Класи компанування", Filepath = "qt/comp.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Модулі Qt", Description = "Модулі Qt", Filepath = "qt/Modul.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Знайомство з Qt Designer", Description = "Знайомство з Qt Designer", Filepath = "qt/qt_designer.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Сигнали і слоти", Description = "Сигнали і слоти", Filepath = "qt/signals.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Класи головного вікна", Description = "Класи головного вікна", Filepath = "qt/mainwindow.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Діалогові вікна", Description = "Діалогові вікна", Filepath = "qt/dialog.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Модальні і немодальні вікна", Description = "Модальні і немодальні вікна", Filepath = "qt/Modal.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Створення меню", Description = "Створення меню", Filepath = "qt/Menu.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Робота з файлами", Description = "Робота з файлами", Filepath = "qt/qfile.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Клас QDate", Description = "Клас QDate", Filepath = "qt/qdata.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Клас QTime", Description = "Клас QTime", Filepath = "qt/qtime.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Контейнери", Description = "Контейнери", Filepath = "qt/conteiner.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Ітератори", Description = "Ітератори", Filepath = "qt/iterator.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "foreach", Description = "foreach", Filepath = "qt/foreach.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "QtWebKit Guide", Description = "QtWebKit Guide", Filepath = "qt/Webkit.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Модуль QtSql", Description = "Модуль QtSql", Filepath = "qt/sql.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Система малювання в Qt", Description = "Система малювання в Qt", Filepath = "qt/paint.html", CourseId = 2 });
            db.Lessons.Add(new Lesson { Subject = "Тестування в Qt", Description = "Тестування в Qt", Filepath = "qt/test.html", CourseId = 2 });
            
            db.Articles.Add(new Article { Name = "Про сім основних методологій розробки",Description = "Розробка програмного продукту знає багато гідних методологій - інакше кажучи, усталених best practices. Вибір залежить від специфіки проекту, системи бюджетування, суб'єктивних переваг і навіть темпераменту керівника. У статті описані методології «Waterfall Model», «V-Model», «Incremental Model», «RAD Model», «Agile Model», «Iterative Model», «Spiral Model».", Filepath = "1.html" });
            db.Articles.Add(new Article { Name = "8 принципів планування розробки, що спрощують життя", Description = "Планування - фундамент, на якому будується будь-який проект. І чим він міцніше, тим більше вірогідності, що проект буде успішним. Для цього і існує project management plan, що складається з трьох блоків: активностей (цілей, концепції проекту, ресурсні призначення і т.д.), завдань та ресурсів (люди, обладнання, гроші і т.д.).",  Filepath = "2.html"});

            base.Seed(db);
        }
    }
}