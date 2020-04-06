//********************************************************************************
// File: Course.cs
//
// Purpose: Contains the class definitions for Course.
//          Controls the data for the class' ID, Designator,
//          Number, Description and Credits variables that will
//          be used inside the main function within Program.cs
//          
// Written By: Joseph Salinas
//
//********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Classes
{
    [DataContract]
    public class Course
    {
        #region Private Member Variables
        private int ID;
        private string Designator;
        private string Number;
        private string Title;
        private string Description;
        private int Credits;
        #endregion

        #region Methods
        //***************************************************************
        //Method: Room
        //
        //Purpose: Default constructor for Course, sets default values.
        //***************************************************************
        public Course()
        {
            ID = 0;
            Designator = "";
            Number = "";
            Title = "";
            Description = "";
            Credits = 0;
        }
        //*************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print Course
        //         information with descriptive text in a neat format.
        //*************************************************************
        override public String ToString()
        {
            /*string s = "ID: " + ID + "\n" + "Designator: " + Designator + "\n" + "Number: " + Number
            + "\n" + "Title: " + Title + "\n" + "Description: " + Description + "\n" + "Credits: " +
            Credits + "\n";*/

            string s = "ID: " + ID  + ", " + "Designator: " + Designator + ", " + "Number: " + Number
            + ", " + "Title: " + Title + ", " + "Description: " + Description + ", " + "Credits: " +
            Credits + ". ";
            return s;
        }
        #endregion

        #region C# Properties
        //*****************************************************************
        //Method: n_ID
        //
        //Purpose: Uses C# Properties to perform get and set for ID
        //*****************************************************************
        [DataMember(Name="id")]
        public int n_ID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        //*******************************************************************
        //Method: n_Designator
        //
        //Purpose: Uses C# Properties to perform get and set for Designator
        //*******************************************************************
        [DataMember(Name ="designator")]
        public string n_Designator
        {
            get
            {
                return Designator;
            }
            set
            {
                Designator = value;
            }
        }
        //*****************************************************************
        //Method: n_Number
        //
        //Purpose: Uses C# Properties to perform get and set for Number
        //*****************************************************************
        [DataMember(Name = "number")]
        public string n_Number
        {
            get
            {
                return Number;
            }
            set
            {
                Number = value;
            }
        }
        //*****************************************************************
        //Method: n_Title
        //
        //Purpose: Uses C# Properties to perform get and set for Title
        //*****************************************************************
        [DataMember(Name = "title")]
        public string n_Title
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }
        }
        //*******************************************************************
        //Method: n_Description
        //
        //Purpose: Uses C# Properties to perform get and set for Description
        //*******************************************************************
        [DataMember(Name = "description")]
        public string n_Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }
        //*****************************************************************
        //Method: n_Credits
        //
        //Purpose: Uses C# Properties to perform get and set for Credits
        //*****************************************************************
        [DataMember(Name = "credits")]
        public int n_Credits
        {
            get
            {
                return Credits;
            }
            set
            {
                Credits = value;
            }
        }
        #endregion
    }
}
