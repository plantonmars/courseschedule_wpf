//********************************************************************************
// File: CourseScheduleUnitTesting.cs
//
// Purpose: Contains the class definitions for CourseScheduleUnitTesting.
//          Contains methods that will utilize a new instance of either
//          the Course, CourseMeeting, Professor or Room classes and will perform
//          unit testing on all of the class' variables. This class will be used
//          for the menu application created inside the Main method of Program.cs         
//          
// Written By: Joseph Salinas
//
// Compiler: Visual Studio 2015
//
//********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CourseScheduleUnitTesting
    {
        #region Methods
        //************************************************************
        //Method: UnitTestCourse
        //
        //Purpose: Performs a Unit Test for the Course class instance.
        //************************************************************
        public void UnitTestCourse()
        {
            //Creates new Course instance
            Course ut_Course = new Course();
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("Unit Testing Course");
            Console.WriteLine("*********************");
            //Unit testing ID
            int TestID = 10;
            ut_Course.n_ID = TestID;
            if (ut_Course.n_ID == TestID)
            {
                Console.WriteLine("Course ID Property: Pass");
            }
            else
            {
                Console.WriteLine("Course ID Property: Fail");
            }
            //Unit testing Designator
            string TestDesignator = "Professor";
            ut_Course.n_Designator = TestDesignator;
            if (ut_Course.n_Designator == TestDesignator)
            {
                Console.WriteLine("Course Designator Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Designator Property: Fail");
            }
            //Unit testing Number
            string TestNumber = "BCS450";
            ut_Course.n_Number = TestNumber;
            if (ut_Course.n_Number == TestNumber)
            {
                Console.WriteLine("Course Number Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Number Property: Fail");
            }
            //Unit testing Title
            string TestTitle = "C# Programming";
            ut_Course.n_Title = TestTitle;
            if (ut_Course.n_Title == TestTitle)
            {
                Console.WriteLine("Course Title Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Title Property: Fail");
            }
            //Unit testing Description
            string TestDescription = "Course based on the C# langauage";
            ut_Course.n_Description = TestDescription;
            if (ut_Course.n_Description == TestDescription)
            {
                Console.WriteLine("Course Description Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Description Property: Fail");
            }
            //Unit testing Credits
            int TestCredits = 3;
            ut_Course.n_Credits = TestCredits;
            if (ut_Course.n_Credits == TestCredits)
            {
                Console.WriteLine("Course Credits Property: Pass");
            }
            else
            {
                Console.WriteLine("Course Credits Property: Fail");
            }
            Console.WriteLine();
        }
        //***************************************************************
        //Method: UnitTestProfessor
        //
        //Purpose: Performs a Unit Test for the Professor class instance.
        //***************************************************************
        public void UnitTestProfessor()
        {
            //Creates a new Professor instance
            Professor ut_Professor = new Professor();
            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("Unit Testing Professor");
            Console.WriteLine("***********************");
            //Unit testing ID
            int TestID = 10;
            ut_Professor.n_ID = TestID;
            if (TestID == ut_Professor.n_ID)
            {
                Console.WriteLine("Professor ID Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor ID Property: Fail");
            }
            //Unit testing Name
            string TestName = "Joe";
            ut_Professor.n_Name = TestName;
            if (TestName == ut_Professor.n_Name)
            {
                Console.WriteLine("Professor Name Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor Name Property: Fail");
            }
            //Unit testing Phone
            string TestPhone = "222-222-2222";
            ut_Professor.n_Phone = TestPhone;
            if (TestPhone == ut_Professor.n_Phone)
            {
                Console.WriteLine("Professor Phone Property: Pass");
            }
            else
            {
                Console.WriteLine("Professor Phone Property: Fail");
            }
            Console.WriteLine();
        }
        //**********************************************************
        //Method: UnitTestRoom
        //
        //Purpose: Performs a Unit Test for the Room class instance.
        //**********************************************************
        public void UnitTestRoom()
        {
            //Creating a new Room instance
            Room ut_Room = new Room();
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("Unit Testing Room");
            Console.WriteLine("*********************");
            //Unit testing ID
            int testID = 5;
            ut_Room.n_ID = testID;
            if (testID == ut_Room.n_ID)
            {
                Console.WriteLine("Room ID Property: Pass");
            }
            else
            {
                Console.WriteLine("Room ID Property: Fail");
            }
            //Unit testing Capacity
            int testCap = 10;
            ut_Room.n_Capacity = testCap;
            if (testCap == ut_Room.n_Capacity)
            {
                Console.WriteLine("Room Capacity Property: Pass");
            }
            else
            {
                Console.WriteLine("Room Capacity Property: Fail");
            }
            //Unit testing Location
            string testLoc = "Long Island";
            ut_Room.n_Location = testLoc;
            if (testLoc == ut_Room.n_Location)
            {
                Console.WriteLine("Room Location Property: Pass");
            }
            else
            {
                Console.WriteLine("Room Location Property: Fail");
            }
            Console.WriteLine();
        }

        //*******************************************************************
        //Method: UnitTestCourseMeeting
        //
        //Purpose: Performs a Unit Test for the CourseMeeting class instance.
        //*******************************************************************
        public void UnitTestCourseMeeting()
        {
            //Creates a new CourseMeeting instance
            CourseMeeting ut_CourseMeeting = new CourseMeeting();
            Console.WriteLine();
            Console.WriteLine("***************************");
            Console.WriteLine("Unit Testing CourseMeeting");
            Console.WriteLine("***************************");
            //Unit testing RoomID
            int testRoomID = 10;
            ut_CourseMeeting.n_RoomID = testRoomID;
            if (testRoomID == ut_CourseMeeting.n_RoomID)
            {
                Console.WriteLine("CourseMeeting RoomID Property Test: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting RoomID Property Test: Fail");
            }
            //Unit testing CourseID
            int testCourseID = 10;
            ut_CourseMeeting.n_CourseID = testCourseID;
            if (testCourseID == ut_CourseMeeting.n_CourseID)
            {
                Console.WriteLine("CourseMeeting CourseID Property Test: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting CourseID Property Test: Fail");
            }
            //Unit testing ProfessorID
            int testProfessorID = 10;
            ut_CourseMeeting.n_ProfessorID = testProfessorID;
            if (testProfessorID == ut_CourseMeeting.n_ProfessorID)
            {
                Console.WriteLine("CourseMeeting ProfessorID Property Test: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting ProfessorID Property Test: Fail");
            }
            //Unit testing dayTime
            string TestdayTime = "Afternoon";
            ut_CourseMeeting.n_dayTime = TestdayTime;
            if (TestdayTime == ut_CourseMeeting.n_dayTime)
            {
                Console.WriteLine("CourseMeeting dayTime Property Test: Pass");
            }
            else
            {
                Console.WriteLine("CourseMeeting dayTime Property Test: Fail");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
