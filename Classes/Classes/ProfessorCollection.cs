//**************************************************************************
// File: ProfessorCollection.cs
//
// Purpose: Contains the class definitions for ProfessorCollection.
//          Controls the data for the class' professors variable
//          that contains a list of Professor objects to be used
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
    public class ProfessorCollection
    {
        #region Member Variables
        private List<Professor> professors;
        #endregion

        #region C# Propertites
        //*******************************************************************
        //Method: n_professors
        //
        //Purpose: Uses C# Properties to perform get and set for professors
        //*******************************************************************
        [DataMember(Name = "professors")]
        public List<Professor> n_professors
        {
            get
            {
                return professors;
            }
            set
            {
                professors = value;
            }
            
        }
        #endregion

        #region Methods
        //*********************************************************
        //Method: ProfessorCollection
        //
        //Purpose: Default constructor for ProfessorCollection,
        //         sets default values.
        //*********************************************************
        public ProfessorCollection()
        {
            professors = new List<Professor>();
        }
        //*************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print Professor
        //         information with descriptive text in a neat format,
        //         for each element in the list.
        //*************************************************************
        public override string ToString()
        {
            string s = "";
            foreach (Professor professor in professors)
            {
                s = s + professor.ToString() + "\n";
            }
            return s;
        }
        //***********************************************************************
        //Method: Find
        //
        //Purpose: Performs a search on Professor elements within the professors
        //         list, returns the instance that has a ProfessorID that matches 
        //         the passed in professorId value.
        //         
        //***********************************************************************
        public Professor Find(int professorId)
        {
            foreach (Professor professor in professors)
            {
                if (professor.n_ID == professorId)
                {
                    return professor;
                }
            }
            return null;
        }
        //***********************************************************************
        //Method: Find
        //
        //Purpose: Performs a search on Professor elements within the professors
        //         list, returns the instance that has a Name that matches 
        //         the passed in name value.
        //         
        //***********************************************************************
        public Professor Find(string name)
        {
            foreach (Professor professor in professors)
            {
                if (professor.n_Name == name)
                {
                    return professor;
                }
            }
            return null;
        }
        #endregion
    }
}
