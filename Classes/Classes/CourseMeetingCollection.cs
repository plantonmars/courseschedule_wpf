//**************************************************************************
// File: CourseMeetingCollection.cs
//
// Purpose: Contains the class definitions for CourseMeetingCollection.
//          Controls the data for the class' courseMeetings variable
//          that contains a list of CourseMeeting objects to be used
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
    public class CourseMeetingCollection
    {
        #region Member Variables
        private List<CourseMeeting> courseMeetings;
        #endregion

        #region C# Properties
        //*********************************************************************
        //Method: n_courseMeetings
        //
        //Purpose: Uses C# Properties to perform get and set for courseMeetings
        //*********************************************************************
        [DataMember(Name = "courseMeetings")]
        public List<CourseMeeting> n_courseMeetings
        {
            get
            {
                return courseMeetings;
            }
            set
            {
                courseMeetings = value;
            }
        }
        #endregion

        #region Methods
        //**************************************************************
        //Method: CourseMeetingCollection
        //
        //Purpose: Default constructor for CourseMeetingCollection,
        //         sets default values.
        //**************************************************************
        public CourseMeetingCollection()
        {
            courseMeetings = new List<CourseMeeting>();
        }
        //*************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print CourseMeeting
        //         information with descriptive text in a neat format,
        //         for each element in the list.
        //*************************************************************
        public override string ToString()
        {
            string s = "";
            foreach (CourseMeeting courseMeeting in courseMeetings)
            {
                s = s + courseMeeting + "\n";
            }
            return s;
        }
        //********************************************************************
        //Method: FindByCourse
        //
        //Purpose: Performs a search on CourseMeeting elements, elements
        //         that have a CourseID that matches the passed in courseId
        //         will be added to a list and returned.        
        //********************************************************************
        public CourseMeetingCollection FindByCourse(int courseId)
        {
            CourseMeetingCollection cmc = new CourseMeetingCollection();
            cmc.courseMeetings = new List<CourseMeeting>();

            foreach (CourseMeeting coursemeeting in courseMeetings)
            {
                if (coursemeeting.n_CourseID == courseId)
                {
                    cmc.courseMeetings.Add(coursemeeting);
                }

            }
            return cmc;
        }
        //************************************************************************
        //Method: FindByProfessor
        //
        //Purpose: Performs a search on CourseMeeting elements, elements
        //         that have a ProfessorID that matches the passed in professorId
        //         will be added to a list and returned.      
        //************************************************************************
        public CourseMeetingCollection FindByProfessor(int professorId)
        {
            CourseMeetingCollection cmc = new CourseMeetingCollection();
            cmc.courseMeetings = new List<CourseMeeting>();
            foreach (CourseMeeting coursemeeting in courseMeetings)
            {
                if (coursemeeting.n_ProfessorID == professorId)
                {
                    cmc.courseMeetings.Add(coursemeeting);
                }
            }
            return cmc;
        }
        //********************************************************************
        //Method: FindByRoom
        //
        //Purpose: Performs a search on CourseMeeting elements, elements
        //         that have a RoomID that matches the passed in roomId
        //         will be added to a list and returned.     
        //********************************************************************
        public CourseMeetingCollection FindByRoom(int roomId)
        {
            CourseMeetingCollection cmc = new CourseMeetingCollection();
            cmc.courseMeetings = new List<CourseMeeting>();
            foreach (CourseMeeting coursemeeting in courseMeetings)
            {
                if (coursemeeting.n_RoomID == roomId)
                {
                    cmc.courseMeetings.Add(coursemeeting);
                }
            }
            return cmc;
        }
        #endregion
    }
}
