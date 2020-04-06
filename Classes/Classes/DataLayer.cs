//**************************************************************************
// File: DataLayer.cs
//
// Purpose: Contains the class definitions for the DataLayer class.
//          Essientaily functions as a container for application data.
//          Contains nested classes, events and methods that will either
//          add or remove a specified instance of a class, and will handle
//          the firing of a specific event.
//          
// Written By: Joseph Salinas
//
// Compiler: Visual Studio 2015
//
//*************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Runtime.Serialization;

namespace Classes
{
    public class DataLayer
    {
        #region AddCourseCollectionEventArgs Class
        public class AddCourseCollectionEventArgs : EventArgs
        {
            public Course courseAdded { get; set; }
            //*************************************************************
            //Method: AddCourseCollectionEventArgs
            //
            //Purpose: Constructor for the AddCourseCollectionEventArgs
            //         class that assigns data from the passed in Course
            //         instance to the courseAdded member variable.
            //*************************************************************
            public AddCourseCollectionEventArgs(Course c)
            {
                courseAdded = c;
            }
        }
        #endregion

        #region RemoveCourseCollectionEventArgs Class
        public class RemoveCourseCollectionEventArgs : EventArgs
        {
            public Course courseRemoved { get; set; }
            //*************************************************************
            //Method: RemoveCourseCollectionEventArgs
            //
            //Purpose: Constructor for the RemoveCourseCollectionEventArgs
            //         class that assigns data from the passed in Course
            //         instance to the courseRemoved member variable.
            //*************************************************************
            public RemoveCourseCollectionEventArgs(Course c)
            {
                courseRemoved = c;
            }
        }
        #endregion

        #region AddProfessorCollectionEventArgs Class
        public class AddProfessorCollectionEventArgs : EventArgs
        {
            public Professor professorAdded { get; set; }
            //*************************************************************
            //Method: AddProfessorCollectionEventArgs
            //
            //Purpose: Constructor for the AddProfessorCollectionEventArgs
            //         class that assigns data from the passed in Professor
            //         instance to the professorAdded member variable.
            //*************************************************************
            public AddProfessorCollectionEventArgs(Professor p)
            {
                professorAdded = p;
            }
        }
        #endregion

        #region RemoveProfessorCollectionEventArgs Class
        public class RemoveProfessorCollectionEventArgs : EventArgs
        {
            public Professor professorRemoved { get; set; }
            //****************************************************************
            //Method: RemoveProfessorCollectionEventArgs
            //
            //Purpose: Constructor for the RemoveProfessorCollectionEventArgs
            //         class that assigns data from the passed in Professor
            //         instance to the professorRemoved member variable.
            //*****************************************************************
            public RemoveProfessorCollectionEventArgs(Professor p)
            {
                professorRemoved = p;
            }
        }
        #endregion

        #region AddRoomCollectionEventArgs Class
        public class AddRoomCollectionEventArgs : EventArgs
        {
            public Room roomAdded { get; set; }
            //*************************************************************
            //Method: AddRoomCollectionEventArgs
            //
            //Purpose: Constructor for the AddRoomCollectionEventArgs
            //         class that assigns data from the passed in Room
            //         instance to the roomAdded member variable.
            //*************************************************************
            public AddRoomCollectionEventArgs(Room r)
            {
                roomAdded = r;
            }
        }
        #endregion

        #region RemoveRoomCollectionEventArgs Class
        public class RemoveRoomCollectionEventArgs : EventArgs
        {
            public Room roomRemoved { get; set; }
            //*************************************************************
            //Method: RemoveRoomCollectionEventArgs
            //
            //Purpose: Constructor for the RemoveRoomCollectionEventArgs
            //         class that assigns data from the passed in Room
            //         instance to the roomRemoved member variable.
            //*************************************************************
            public RemoveRoomCollectionEventArgs(Room r)
            {
                roomRemoved = r;
            }
        }
        #endregion

        #region AddCourseMeetingCollectionEventArgs Class
        public class AddCourseMeetingCollectionEventArgs : EventArgs
        {
            public CourseMeeting coursemeetingAdded { get; set; }
            //*****************************************************************
            //Method: AddCourseMeetingCollectionEventArgs
            //
            //Purpose: Constructor for the AddCourseMeetingCollectionEventArgs
            //         class that assigns data from the passed in CourseMeeting
            //         instance to the coursemeetingAdded member variable.
            //*****************************************************************
            public AddCourseMeetingCollectionEventArgs(CourseMeeting cm)
            {
                coursemeetingAdded = cm;
            }
        }
        #endregion

        #region RemoveCourseMeetingCollectionEventArgs Class
        public class RemoveCourseMeetingCollectionEventArgs : EventArgs
        {
            public CourseMeeting coursemeetingRemoved { get; set; }
            //********************************************************************
            //Method: RemoveCourseMeetingCollectionEventArgs
            //
            //Purpose: Constructor for the RemoveCourseMeetingCollectionEventArgs
            //         class that assigns data from the passed in CourseMeeting
            //         instance to the coursemeetingRemoved member variable.
            //********************************************************************
            public RemoveCourseMeetingCollectionEventArgs(CourseMeeting cm)
            {
                coursemeetingRemoved = cm;
            }
        }
        #endregion

        #region Member Variables
        private CourseCollection courses;
        private ProfessorCollection professors;
        private RoomCollection rooms;
        private CourseMeetingCollection courseMeetings;
        #endregion

        #region C# Properties
        //*********************************************************************
        //Method: dl_courses
        //
        //Purpose: Uses C# Properties to perform get and set for courses
        //*********************************************************************
        public CourseCollection dl_courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = dl_courses;
            }
        }
        //*********************************************************************
        //Method: dl_professors
        //
        //Purpose: Uses C# Properties to perform get and set for professors
        //*********************************************************************
        public ProfessorCollection dl_professors
        {
            get
            {
                return professors;
            }
            set
            {
                professors = dl_professors;
            }
        }
        //*********************************************************************
        //Method: dl_rooms
        //
        //Purpose: Uses C# Properties to perform get and set for rooms
        //*********************************************************************
        public RoomCollection dl_rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = dl_rooms;
            }
        }
        //**********************************************************************
        //Method: dl_courseMeetings
        //
        //Purpose: Uses C# Properties to perform get and set for courseMeetings
        //**********************************************************************
        public CourseMeetingCollection dl_courseMeetings
        {
            get
            {
                return courseMeetings;
            }
            set
            {
                courseMeetings = dl_courseMeetings;
            }
        }
        #endregion

        #region Event Declarations
        //*************************************************************************
        //Method: CourseAdded
        //
        //Purpose: Declares the CourseAdded event, will contain list of listeners.
        //*************************************************************************
        public event EventHandler<AddCourseCollectionEventArgs> CourseAdded;
        //****************************************************************************
        //Method: ProfessorAdded
        //
        //Purpose: Declares the ProfessorAdded event, will contain list of listeners.
        //****************************************************************************
        public event EventHandler<AddProfessorCollectionEventArgs> ProfessorAdded;
        //****************************************************************************
        //Method: RoomAdded
        //
        //Purpose: Declares the RoomAdded event, will contain list of listeners.
        //****************************************************************************
        public event EventHandler<AddRoomCollectionEventArgs> RoomAdded;
        //*******************************************************************************
        //Method: CourseMeetingAdded
        //
        //Purpose: Declares the CourseMeetingAdded event, will contain list of listeners.
        //*******************************************************************************
        public event EventHandler<AddCourseMeetingCollectionEventArgs> CourseMeetingAdded;
        //*******************************************************************************
        //Method: CourseRemoved
        //
        //Purpose: Declares the CourseRemoved event, will contain list of listeners.
        //*******************************************************************************
        public event EventHandler<RemoveCourseCollectionEventArgs> CourseRemoved;
        //*******************************************************************************
        //Method: ProfessorRemoved
        //
        //Purpose: Declares the ProfessorRemoved event, will contain list of listeners.
        //*******************************************************************************
        public event EventHandler<RemoveProfessorCollectionEventArgs> ProfessorRemoved;
        //*******************************************************************************
        //Method: RoomRemoved
        //
        //Purpose: Declares the RoomRemoved event, will contain list of listeners.
        //*******************************************************************************
        public event EventHandler<RemoveRoomCollectionEventArgs> RoomRemoved;
        //*********************************************************************************
        //Method: CourseMeetingRemoved
        //
        //Purpose: Declares the CourseMeetingRemoved event, will contain list of listeners.
        //*********************************************************************************
        public event EventHandler<RemoveCourseMeetingCollectionEventArgs> CourseMeetingRemoved;
        #endregion

        #region Methods
        //*************************************************************
        //Method: DataLayer
        //
        //Purpose: Constructor for the DataLayer class that assigns
        //         default values.
        //*************************************************************
        public DataLayer()
        {
            courses = new CourseCollection();
            professors = new ProfessorCollection();
            rooms = new RoomCollection();
            courseMeetings = new CourseMeetingCollection();
        }
        //*************************************************************
        //Method: InitializeProf
        //
        //Purpose: Initializes the DataLayer, with ProfessorCollection
        //data, will deseralize data from a specified filename passed
        //as an argument.
        //*************************************************************
        public void InitializeProf(string newname)
        {
            //Desearlizes Professor information into the professors member variable.
            FileStream pReader = new FileStream(newname, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer pInput;
            pInput = new DataContractJsonSerializer(typeof(ProfessorCollection));
            professors = (ProfessorCollection)pInput.ReadObject(pReader);
            pReader.Close();
        }
        //*************************************************************
        //Method: InitializeCourse
        //
        //Purpose: Initializes the DataLayer, with CourseCollection
        //data, will deseralize data from a specified filename passed
        //as an argument.
        //*************************************************************
        public void InitializeCourse(string newname)
        {
            //Desearlizes Course information into the courses member variable.
            FileStream cReader = new FileStream(newname, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer cInput;
            cInput = new DataContractJsonSerializer(typeof(CourseCollection));
            courses = (CourseCollection)cInput.ReadObject(cReader);
            cReader.Close();
        }
        //*************************************************************
        //Method: Initialize
        //
        //Purpose: Initializes the DataLayer, will deserialize data
        //         from JSON files into the class' member variables.
        //*************************************************************
        public void Initialize()
        {
            //Desearlizes Course information into the courses member variable.
            FileStream cReader = new FileStream("TestCourse.json", FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer cInput;
            cInput = new DataContractJsonSerializer(typeof(CourseCollection));
            courses = (CourseCollection)cInput.ReadObject(cReader);
            cReader.Close();
            //Desearlizes Professor information into the professors member variable.
            FileStream pReader = new FileStream("TestProfessor.json", FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer pInput;
            pInput = new DataContractJsonSerializer(typeof(ProfessorCollection));
            professors = (ProfessorCollection)pInput.ReadObject(pReader);
            pReader.Close();
            //Desearlizes Room information into the rooms member variable.
            FileStream rReader = new FileStream("TestRoom.json", FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer rInput;
            rInput = new DataContractJsonSerializer(typeof(RoomCollection));
            rooms = (RoomCollection)rInput.ReadObject(rReader);
            rReader.Close();
            //Desearlizes CourseMeeting information into the courseMeeting member variable.
            FileStream cmReader = new FileStream("TestCourseMeet.json", FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer cmInput;
            cmInput = new DataContractJsonSerializer(typeof(CourseMeetingCollection));
            courseMeetings = (CourseMeetingCollection)cmInput.ReadObject(cmReader);
            cmReader.Close();
        }
        //*************************************************************
        //Method: ToString
        //
        //Purpose: Overrides the DataLayer ToString method to display
        //         all the information within the DataLayer in a 
        //         neat format.
        //*************************************************************
        public override string ToString()
        {
            string s = "[Courses]: " + courses.ToString() + "[Professors]: " + professors.ToString()
                + "[Rooms]: " + rooms.ToString() + "[CourseMeetings]: " + courseMeetings.ToString();
            return s;
        }
        //*************************************************************
        //Method: AddCourse
        //
        //Purpose: Adds a passed in Course instance to the DataLayer's
        //         courses member variable's list, Then fires the
        //         CourseAdded event.
        //*************************************************************
        public bool AddCourse(Course c)
        {
            //********************************************************
            //Checks if the CourseAdded value is null, and will
            //return false, and will not fire any events if the value 
            //is null.
            //********************************************************
            if (CourseAdded == null)
            {
                return false;
            }
            courses.n_courses.Add(c);
            AddCourseCollectionEventArgs evtArgs = new AddCourseCollectionEventArgs(c);
            CourseAdded(this, evtArgs);
            return true;
        }
        //*****************************************************************
        //Method: RemoveCourse
        //
        //Purpose: Removes a Course instance from DataLayer's
        //         courses member variable's list according to the
        //         passed in courseId, Then fires the CourseRemoved event.
        //*****************************************************************
        public void RemoveCourse(int courseId)
        {
            if (courses.Find(courseId) != null)
            {
                courses.n_courses.Remove(courses.Find(courseId));
                RemoveCourseCollectionEventArgs evtArgs = new RemoveCourseCollectionEventArgs(courses.Find(courseId));
                CourseRemoved(this, evtArgs);
            }
            else if (courses.Find(courseId) == null)
            {
                Console.WriteLine("Course could not be found.");
            }
        }
        //*****************************************************************
        //Method: AddProfessor
        //
        //Purpose: Adds a passed in Professor instance to the DataLayer's
        //         professors member variable's list, Then fires the
        //         ProfessorAdded event.
        //*****************************************************************
        public bool AddProfessor(Professor p)
        {
            //********************************************************
            //Checks if the ProfessorAdded value is null, and will
            //return false, and will not fire any events if the value 
            //is null.
            //********************************************************
            if (ProfessorAdded == null)
            {
                return false;
            }
            AddProfessorCollectionEventArgs evtArgs = new AddProfessorCollectionEventArgs(p);
            professors.n_professors.Add(p);
            ProfessorAdded(this, evtArgs);
            return true;
        }
        //**********************************************************************
        //Method: RemoveProfessor
        //
        //Purpose: Removes a Professor instance from DataLayer's
        //         professors member variable's list according to the
        //         passed in professorId, Then fires the ProfessorRemoved event.
        //**********************************************************************
        public void RemoveProfessor(int professorId)
        {
            if (professors.Find(professorId) != null)
            {
                professors.n_professors.Remove(professors.Find(professorId));
                RemoveProfessorCollectionEventArgs evtArgs = new RemoveProfessorCollectionEventArgs(professors.Find(professorId));
                ProfessorRemoved(this, evtArgs);
            }
            else if (professors.Find(professorId) == null)
            {
                Console.WriteLine("Professor could not be found.");
            }
        }
        //***************************************************************
        //Method: AddRoom
        //
        //Purpose: Adds a passed in Room instance to the DataLayer's
        //         rooms member variable's list, Then fires the
        //         RoomAdded event.
        //***************************************************************
        public bool AddRoom(Room r)
        {
            //********************************************************
            //Checks if the RoomAdded value is null, and will
            //return false, and will not fire any events if the value 
            //is null.
            //********************************************************
            if (RoomAdded == null)
            {
                return false;
            }
            AddRoomCollectionEventArgs evtArgs = new AddRoomCollectionEventArgs(r);
            RoomAdded(this, evtArgs);
            return true;
        }
        //*****************************************************************
        //Method: RemoveRoom
        //
        //Purpose: Removes a Room instance from DataLayer's
        //         rooms member variable's list according to the
        //         passed in roomId, Then fires the RoomRemoved event.
        //*****************************************************************
        public void RemoveRoom(int roomId)
        {
            if (rooms.Find(roomId) != null)
            {
                rooms.n_rooms.Remove(rooms.Find(roomId));
                RemoveRoomCollectionEventArgs evtArgs = new RemoveRoomCollectionEventArgs(rooms.Find(roomId));
                RoomRemoved(this, evtArgs);
            }
            else if (rooms.Find(roomId) == null)
            {
                Console.WriteLine("Room could not be found.");
            }

        }
        //********************************************************************
        //Method: AddCourseMeeting
        //
        //Purpose: Adds a passed in CourseMeeting instance to the DataLayer's
        //         courseMeetings member variable's list, Then fires the
        //         CourseMeetingAdded event.
        //********************************************************************
        public bool AddCourseMeeting(CourseMeeting cm)
        {
            //********************************************************
            //Checks if the CourseMeetingAdded value is null, and will
            //return false, and will not fire any events if the value 
            //is null.
            //********************************************************
            if (CourseMeetingAdded == null)
            {
                return false;
            }
            AddCourseMeetingCollectionEventArgs evtArgs = new AddCourseMeetingCollectionEventArgs(cm);
            courseMeetings.n_courseMeetings.Add(cm);
            CourseMeetingAdded(this, evtArgs);
            return true;
        }
        //*****************************************************************
        //Method: RemoveCourseMeeting
        //
        //Purpose: Removes a CourseMeeting instance from DataLayer's
        //         courseMeeting member variable's list according to the
        //         passed in courseId, professorId, roomId, daytime values.
        //         Then fires the CourseMeetingRemoved event.
        //*****************************************************************
        public void RemoveCourseMeeting(int courseId, int professorId, int roomId, string daytime)
        {
            //****************************************************
            //Utilizes a for-loop in order to iterate through each 
            //CourseMeeting element within the DataLayer's 
            //courseMeetings member variable's list
            //****************************************************
            for (int i = 0; i < courseMeetings.n_courseMeetings.Count; i++)
            {
                //****************************************************************
                //An if-statement is used to check if all the passed in parameters
                //to the method match a CourseMeeting instance within the list.
                //****************************************************************
                if (courseMeetings.n_courseMeetings[i].n_CourseID == courseId 
                    && courseMeetings.n_courseMeetings[i].n_ProfessorID == professorId 
                    && courseMeetings.n_courseMeetings[i].n_RoomID == roomId
                    && courseMeetings.n_courseMeetings[i].n_dayTime == daytime)
                {
                    //Removes the CourseMeeting instance that matches all of the passed-in parameters.
                    courseMeetings.n_courseMeetings.Remove(courseMeetings.n_courseMeetings[i]);
                }
            }
        }
        #endregion
    }
}
