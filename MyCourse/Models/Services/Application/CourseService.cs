using System;
using System.Collections.Generic;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{
    public class CourseService
    {
        public List<CourseViewModel> GetCourses()
        {
            var courseList = new List<CourseViewModel>();
            var ACaso = new Random();
             for (int i=1; i <= 20;i++)
             {
                var prezzo = Convert.ToDecimal(ACaso.NextDouble()*10+10);
                var course = new CourseViewModel
                {
                    Id=i,
                    Title = $"Corso{i}",
                    CurrentPrice = prezzo,
                    FullPrice= prezzo + 5,
                    Author = "Nome Cognome",
                    Rating = ACaso.NextDouble() * 5.0,
                    ImagePath = "/Logo.svg"

                };
                
                courseList.Add(course);



             }


            return courseList;
            //throw new NotImplementedException();
        }

        public  CourseDetailViewModel GetCourse(int id)
        {

            var ACaso = new Random();
            var prezzo = Convert.ToDecimal(ACaso.NextDouble()*10+10);
            var course = new CourseDetailViewModel
                {
                    Id=id,
                    Title = $"Corso{id}",
                    CurrentPrice = prezzo,
                    FullPrice= prezzo + 5,
                    Author = "Nome Cognome",
                    Rating = ACaso.NextDouble() * 5.0,
                    ImagePath = "/Logo.svg",
                    Description=$"Descrizione {id}",
                    Lessons = new List<LessonViewModel>()

                };
            
            for (int i=1;i<=5;i++)
            {
                var lesson = new LessonViewModel {
                    Title=$"Lezione {i}",
                    Duration = TimeSpan.FromSeconds(ACaso.Next(40,90))
                };
                course.Lessons.Add(lesson);

            }

            return course;

            //throw new NotImplementedException();
        }
    }
}