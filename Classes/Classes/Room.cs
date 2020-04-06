//********************************************************************************
// File: Room.cs
//
// Purpose: Contains the class definitions for Room.
//          Controls the data for the class' ID, Location, 
//          and Capacity variables that will be used inside the 
//          main function within Program.cs
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
    public class Room
    {
        #region Private Member Variables
        private int ID;
        private string Location;
        private int Capacity;
        #endregion

        #region Methods
        //***************************************************************
        //Method: Room
        //
        //Purpose: Default constructor for Room, sets default values.
        //***************************************************************
        public Room()
        {
            ID = 0;
            Location = "";
            Capacity = 0;
        }
        //**************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print Room
        //         information with descriptive text in a neat format.
        //**************************************************************
        public override string ToString()
        {
            string s;
            //s = "ID: " + ID + "\n" + "Location: " + Location + "\n" + "Capacity: " + Capacity + "\n";      
            s = "ID: " + ID + ", " + "Location: " + Location + ", " + "Capacity: " + Capacity + ". ";
            return s;
        }
        #endregion

        #region C# Properties
        //***************************************************************
        //Method: n_ID
        //
        //Purpose: Uses C# Properties to perform get and set for ID
        //***************************************************************
        [DataMember(Name = "id")]
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
        //*****************************************************************
        //Method: n_Location
        //
        //Purpose: Uses C# Properties to perform get and set for Location
        //*****************************************************************
        [DataMember(Name = "location")]
        public string n_Location
        {
            get
            {
                return Location;
            }
            set
            {
                Location = value;
            }
        }
        //****************************************************************
        //Method: n_Capacity
        //
        //Purpose: Uses C# Properties to perform get and set for Capacity
        //****************************************************************
        [DataMember(Name = "capacity")]
        public int n_Capacity
        {
            get
            {
                return Capacity;
            }
            set
            {
                Capacity = value;
            }
        }
        #endregion
    }
}
