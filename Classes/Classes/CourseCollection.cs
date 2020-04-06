//**************************************************************************
// File: CourseCollection.cs
//
// Purpose: Contains the class definitions for CourseCollection.
//          Controls the data for the class' courses variable
//          that contains a list of Course objects to be used
//          within the main function in Program.cs
//          
// Written By: Joseph Salinas
//
//*************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    [DataContract]
    public class CourseCollection
    {
        #region Member Variables
        private List<Course> courses;
        #endregion

        #region C# Propertities
        //*******************************************************************
        //Method: n_courses
        //
        //Purpose: Uses C# Properties to perform get and set for courses
        //*******************************************************************
        [DataMember(Name = "courses")]
        public List<Course> n_courses
        {

            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }

        }
        #endregion

        #region Methods
        //*********************************************************
        //Method: CourseCollection
        //
        //Purpose: Default constructor for CourseCollection,
        //         sets default values.
        //*********************************************************
        public CourseCollection()
        {
            courses = new List<Course>();
        }
        //*************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print Course
        //         information with descriptive text in a neat format,
        //         for each element in the list.
        //*************************************************************
        public override string ToString()
        {
            string s = "";
            foreach (Course course in courses)
            {
                s = s + course + "\n";
            }
            return s;
        }
        //***********************************************************************
        //Method: Find
        //
        //Purpose: Performs a search on Course elements within the courses list,
        //         returns the instance that has a CourseID that matches the 
        //         passed in courseId value.
        //         
        //***********************************************************************
        public Course Find(int courseId)
        {
            foreach (Course course in courses)
            {
                if (course.n_ID == courseId)
                {
                    return course;
                }
            }
            return null;
        }
        //***************************************************************************
        //Method: Find
        //
        //Purpose: Performs a search on Course elements within the courses list,
        //         returns the instance that has a Designator and Number 
        //         that matches the passed in designator and number value.
        //         
        //***************************************************************************
        public Course Find(string designator, string number)
        {
            foreach (Course course in courses)
            {
                if (course.n_Designator == designator && course.n_Number == number)
                {
                    return course;
                }
            }
            return null;
        }    
        #endregion
    }
}
