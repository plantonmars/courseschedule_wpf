//********************************************************************************
// File: Professor.cs
//
// Purpose: Contains the class definitions for Professor.
//          Controls the data for the class' ID, Name, and
//          Phone variables that will be used inside the main
//          function within Program.cs
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
    public class Professor
    {
        #region Private Member Variables
        private int ID;
        private string Name;
        private string Phone;
        #endregion

        #region Methods
        //******************************************************************
        //Method: Professor
        //
        //Purpose: Default constructor for Professor, sets default values.
        //******************************************************************
        public Professor()
        {
            ID = 0;
            Name = "";
            Phone = "";
        }
        //**************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print Professor
        //         information with descriptive text in a neat format.
        //**************************************************************
        public override String ToString()
        {
            string s;
            //s = "ID: " + ID + "\n" + "Name: " + Name + "\n" + "Phone: " + Phone + "\n";
            s = "ID: " + ID + ", " + "Name: " + Name + ", " + "Phone: " + Phone + ". ";
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
        //***************************************************************
        //Method: n_Name
        //
        //Purpose: Uses C# Properties to perform get and set for Name
        //***************************************************************
        [DataMember(Name = "name")]
        public string n_Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        //***************************************************************
        //Method: n_Phone
        //
        //Purpose: Uses C# Properties to perform get and set for Phone
        //***************************************************************
        [DataMember(Name = "phone")]
        public string n_Phone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        #endregion
    }
}