//**************************************************************************
// File: RoomCollection.cs
//
// Purpose: Contains the class definitions for RoomCollection.
//          Controls the data for the class' rooms variable
//          that contains a list of Room objects to be used
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
    public class RoomCollection
    {
        #region Member Variables
        private List<Room> rooms;
        #endregion

        #region C# Propertites
        //*******************************************************************
        //Method: n_rooms
        //
        //Purpose: Uses C# Properties to perform get and set for rooms
        //*******************************************************************
        [DataMember(Name = "rooms")]
        public List<Room> n_rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
            }
        }
        #endregion

        #region Methods
        //*********************************************************
        //Method: RoomCollection
        //
        //Purpose: Default constructor for RoomCollection,
        //         sets default values.
        //*********************************************************
        public RoomCollection()
        {
            rooms = new List<Room>();
        }
        //*************************************************************
        //Method: ToString
        //
        //Purpose: Overrides ToString method to print Room
        //         information with descriptive text in a neat format,
        //         for each element in the list.
        //*************************************************************
        public override string ToString()
        {
            string s = "";
            foreach (Room room in rooms)
            {
                s = s + room + "\n";
            }
            return s;
        }
        //********************************************************************
        //Method: Find
        //
        //Purpose: Performs a search on Room elements within the rooms list,
        //         returns the instance that has a RoomID that matches the 
        //         passed in roomId value.
        //         
        //********************************************************************
        public Room Find(int roomId)
        {
            
            foreach (Room room in rooms)
            {
                if(room.n_ID == roomId)
                {
                    return room;
                }

            }
            return null;
        }
        //********************************************************************
        //Method: Find
        //
        //Purpose: Performs a search on Room elements within the rooms list,
        //         returns the instance that has a Location that matches the 
        //         passed in location value.
        //         
        //********************************************************************
        public Room Find(string location)
        {
            foreach (Room room in rooms)
            {
                if (room.n_Location == location)
                {
                    return room;
                }

            }
            return null;
        }
        #endregion
    }
}
