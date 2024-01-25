using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){

                new Course(){
                    Id=1,
                    Title= "Asp.Net Kursu",
                    Image="1.jpg",
                    Description= "Guzel",
                    Tags= new string[]{"AspNet","webgelistirme"},
                    IsActive=true,
                    IsHome=true
                    },

                new Course(){
                    Id=2,
                    Title= "Django Kursu",
                    Image="2.jpg",
                    Description= "Guzel",
                    Tags= new string[]{"Django","webgelistirme"},
                    IsActive=true,
                    IsHome=true
                    },

                new Course(){
                    Id=3,
                    Title= "C# Kursu",
                    Image="3.jpg",
                    Description= "Guzel",
                    Tags= new string[]{"c#","UygulamaGelistirme"},
                    IsActive=true,
                    IsHome=false
                    },

                new Course(){
                    Id=4,
                    Title="Java Script Kursu",
                    Image="4.jpg",
                    Description= "Guzel",
                    Tags= new string[]{"JavaScript","webgelistirme"},
                    IsActive=false,
                    IsHome=true
                    }
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}