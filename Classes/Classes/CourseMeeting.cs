//********************************************************************************
// File: CourseMeeting.cs
//
// Purpose: Contains the class definitions for CourseMeeting.
//          Controls the data for the class' RoomID, CourseID,
//          ProfessorID, and dayTime variables that will
//          be used inside the main function within Program.cs
//          
// Written By: Joseph Salinas
//
//********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    [DataContract]
    public class CourseMeeting
    {
        #region Private Member Variables
        private int RoomID;
        private int CourseID;
        private int ProfessorID;
        private string dayTime;
        #endregion

        #region Methods
        //**********************************************************************
        //Method: CourseMeeting
        //
        //Purpose: Default constructor for CourseMeeting, sets default values.
        //**********************************************************************
        public CourseMeeting()
        {
            RoomID = 0;
            CourseID = 0;
            ProfessorID = 0;
            dayTime = "";
        }
        //**************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print CourseMeeting 
        //         information with descriptive text in a neat format.
        //**************************************************************
        public override String ToString()
        {
            string s;
            /*s = "RoomID: " + RoomID + "\n" + "CourseID: " + CourseID + "\n" + "ProfessorID: " +
            ProfessorID + "\n" + "DayTime: " + dayTime + "\n";*/
            s = "RoomID: " + RoomID + ", " + "CourseID: " + CourseID + ", " + "ProfessorID: " +
            ProfessorID + ", " + "DayTime: " + dayTime + ". ";
            return s;
        }
        #endregion

        #region C# Properties
        //****************************************************************
        //Method: n_RoomID
        //
        //Purpose: Uses C# Properties to perform get and set for RoomID.
        //****************************************************************
        [DataMember(Name = "roomId")]
        public int n_RoomID
        {
            get
            {
                return RoomID;
            }
            set
            {
                RoomID = value;
            }
        }
        //******************************************************************
        //Method: n_CourseID
        //
        //Purpose: Uses C# Properties to perform get and set for CourseID.
        //******************************************************************
        [DataMember(Name = "courseId")]
        public int n_CourseID
        {
            get
            {
                return CourseID;
            }
            set
            {
                CourseID = value;
            }
        }
        //*********************************************************************
        //Method: n_ProfessorID
        //
        //Purpose: Uses C# Properties to perform get and set for ProfessorID.
        //*********************************************************************
        [DataMember(Name = "professorId")]
        public int n_ProfessorID
        {
            get
            {
                return ProfessorID;
            }
            set
            {
                ProfessorID = value;
            }
        }
        //*****************************************************************
        //Method: n_dayTime
        //
        //Purpose: Uses C# Properties to perform get and set for dayTime.
        //*****************************************************************
        [DataMember(Name = "dayTime")]
        public string n_dayTime
        {
            get
            {
                return dayTime;
            }
            set
            {
                dayTime = value;
            }
        }
        #endregion
    }
}
