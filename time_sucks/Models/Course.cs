﻿using Microsoft.AspNetCore.Server.Kestrel.Internal.System.Collections.Sequences;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace time_sucks.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string name { get; set;}

        public string instructorID { get; set; }

        public bool isActive { get; set; }

        // public int UserID { get; set; }
        public List<Project> Projects { get; set; }

        public List<User> Users { get; set; }

        public Course()
        {
            isActive = true;
            name = "New Course";
            Projects = new List<Project>();
            Users = new List<User>();
        }

        public Course(String instID)
        {
            instructorID = instID;
            isActive = true;
            name = "New Course";
            Projects = new List<Project>();
            Users = new List<User>();
        }

        public Course(String newName, String instID)
        {
            name = newName;
            instructorID = instID;
            isActive = true;
            Projects = new List<Project>();
            Users = new List<User>();
        }

        public Course(Course course)
        {
            //_id = course._id;
            name = course.name;
            instructorID = course.instructorID;
            isActive = course.isActive;
            Projects = course.Projects;
            Users = course.Users;
        }

    }
}
