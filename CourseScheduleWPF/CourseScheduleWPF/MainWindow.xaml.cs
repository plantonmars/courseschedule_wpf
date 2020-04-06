//**************************************************************************
// File: MainWindow.xaml.cs
//
// Purpose: Contains the MainWindow partial class, performs various actions
//          with different button_Click events. Manages data from both
//          CourseCollection and ProfessorCollection member variables and
//          provides functionality to open and read data from .json files, 
//          as well as populate specified fields with data based on specific
//          criteria from the user.
//          
// Written By: Joseph Salinas
//
//*************************************************************************
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Classes;


namespace CourseScheduleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public CourseCollection cc = new CourseCollection();
        public ProfessorCollection pc = new ProfessorCollection();
        //*************************************************************************
        //Method: MainWindow
        //
        //Purpose: Default Constructor, will initialize the program and set all 
        //necessary textboxes to read only upon startup of the program.
        //*************************************************************************
        public MainWindow()
        {
            InitializeComponent();
            //Sets all appropriate textboxes to readonly, to prevent the user for entering in data.
            textBoxCourseFileName.IsReadOnly = true;
            textBoxCourseIdData.IsReadOnly = true;
            textBoxCreditsData.IsReadOnly = true;
            textBoxDescriptionData.IsReadOnly = true;
            textBoxDesignatorData.IsReadOnly = true;
            textBoxTitleData.IsReadOnly = true;
            textBoxNumberData.IsReadOnly = true;
            textBoxProfessorFileName.IsReadOnly = true;
        }
        //*************************************************************************
        //Method: OpenCoursebutton_Click
        //
        //Purpose: Button-click event handler for the OpenCoursebutton, it will
        //provide the user with an OpenFileDialog to open a .json file containing
        //course data, and will deseralize data into the cc CourseCollection 
        //member variable.
        //*************************************************************************
        private void OpenCoursebutton_Click(object sender, RoutedEventArgs e)
        {

            string name = "";
            //Creates an OpenFileDialog set to the current directory, will only open .json files.
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = Environment.CurrentDirectory;
            opf.Filter = "JSON files (*.json)|*.json";
            opf.FilterIndex = 1;
            opf.Title = "Open Course Collection From JSON";
            opf.RestoreDirectory = true;
            //If user selects a file it will go through this if-statement.
            if (opf.ShowDialog() == true)
            {
                name = opf.FileName;
                //Deseralizes data into the CourseCollection member variable.
                FileStream cReader = new FileStream(name, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer cInput;
                cInput = new DataContractJsonSerializer(typeof(CourseCollection));
                cc = (CourseCollection)cInput.ReadObject(cReader);
                cReader.Close();
                //Provides message to show file was opened.
                MessageBox.Show("File Opened Succesfully");
                //Sets the CourseFileName textbox to the name of the file location, 
                //if the user selects cancel or does not open a file, nothing will occur, and the 
                //previously opened filename will remain in the CourseFileName textbox.
                textBoxCourseFileName.Text = name;
            }
            //Clears all corresponding textboxes.
            textBoxCourseIdData.Text = "";
            textBoxCreditsData.Text = "";
            textBoxDescriptionData.Text = "";
            textBoxDesignatorData.Text = "";
            textBoxTitleData.Text = "";
            textBoxNumberData.Text = "";
            textBoxFindCourseId.Text = "";
            textBoxFindDesignator.Text = "";
            textBoxFindNumber.Text = "";
        }
        //*************************************************************************
        //Method: FindCourseIdbutton_Click
        //
        //Purpose: Button-click event handler for the FindCourseIdbutton, it will
        //find the course instance with the matching course Id provided by the user
        //and will populate all related textboxes with data from the found course
        //instance.
        //*************************************************************************
        private void FindCourseIdbutton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //********************************************************************************************
                //Uses the Find method on the CourseCollection variable cc, and finds the course
                //by its corresponding ID and stores the instance of the course into the FoundCourse variable.
                //Then all textboxes related to the course data are populated with information from
                //the course instance.
                //********************************************************************************************
                Course FoundCourse = cc.Find((Convert.ToInt32(textBoxFindCourseId.Text)));
                textBoxCourseIdData.Text = FoundCourse.n_ID.ToString();
                textBoxCreditsData.Text = FoundCourse.n_Credits.ToString();
                textBoxDescriptionData.Text = FoundCourse.n_Description;
                textBoxDesignatorData.Text = FoundCourse.n_Designator;
                textBoxTitleData.Text = FoundCourse.n_Title;
                textBoxNumberData.Text = FoundCourse.n_Number;
                //Provides user with a confirmation message with the Course Id they searched for.
                MessageBox.Show("Record Found with Course Id " + textBoxFindCourseId.Text + ".");
                //***********************************************************************************************
                //Clears any text the in the CourseId text box that the user previously entered to provide a neat
                //format, so user won't have to backspace data to start a new entry.
                //***********************************************************************************************
                textBoxFindCourseId.Text = "";
            }
            catch (Exception exc)
            {
                //************************************************************
                //If statement that prevents the application from crashing by
                //catching both NullReferenceException and FormatException.
                //************************************************************
                if (exc is NullReferenceException || exc is FormatException)
                {
                    //************************************************************************
                    //If no records are found the user will be provided with an error message,
                    //and all related textboxes will be cleared.
                    //************************************************************************
                    MessageBox.Show("No records match provided Course Id.");
                    textBoxCourseIdData.Text = "";
                    textBoxCreditsData.Text = "";
                    textBoxDescriptionData.Text = "";
                    textBoxDesignatorData.Text = "";
                    textBoxTitleData.Text = "";
                    textBoxNumberData.Text = "";
                    textBoxFindCourseId.Text = "";
                }
            }
        }
        //*************************************************************************
        //Method: FindDesNumbutton_Click
        //
        //Purpose: Button-click event handler for the FindDesNumbutton, it will
        //find the course instance with the matching course Designator and Number
        //provided by the user and will populate all related textboxes with data from 
        //the found course instance.
        //*************************************************************************
        private void FindDesNumbutton_Click(object sender, RoutedEventArgs e)
        {
            //***************************************************************
            //Try-catch block that will prevent the program from crashing by
            //catching a NullReferenceException.
            //***************************************************************
            try
            {
                //********************************************************************************************
                //Uses the Find method on the CourseCollection variable cc, and finds the course
                //by its corresponding Designator and Number and stores the instance of the course into the 
                //FoundCourse variable. Then all textboxes related to the course data are populated with 
                //information from the course instance.
                //********************************************************************************************
                Course FoundCourse = cc.Find(textBoxFindDesignator.Text, textBoxFindNumber.Text);
                textBoxCourseIdData.Text = FoundCourse.n_ID.ToString();
                textBoxCreditsData.Text = FoundCourse.n_Credits.ToString();
                textBoxDescriptionData.Text = FoundCourse.n_Description;
                textBoxDesignatorData.Text = FoundCourse.n_Designator;
                textBoxTitleData.Text = FoundCourse.n_Title;
                textBoxNumberData.Text = FoundCourse.n_Number;
                //Provides user with a confirmation message with the Course Designator and Number they searched for.
                MessageBox.Show("Record Found with Designator " + textBoxFindDesignator.Text + " and Number " + textBoxFindNumber.Text + ".");
                //***********************************************************************************************
                //Clears any text the in the text boxs that the user previously entered to provide a neat
                //format, so user won't have to backspace data to start a new entry.
                //***********************************************************************************************
                textBoxFindDesignator.Text = "";
                textBoxFindNumber.Text = "";
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show("No records match provided Designator and Number.");
                textBoxCourseIdData.Text = "";
                textBoxCreditsData.Text = "";
                textBoxDescriptionData.Text = "";
                textBoxDesignatorData.Text = "";
                textBoxTitleData.Text = "";
                textBoxNumberData.Text = "";
                textBoxFindDesignator.Text = "";
                textBoxFindNumber.Text = "";
            }
        }
        //*************************************************************************
        //Method: OpenProfbutton_Click
        //
        //Purpose: Button-click event handler for the OpenProfbutton, it will
        //provide the user with an OpenFileDialog to open a .json file containing
        //professor data, and will deseralize data into the pc ProfessorCollection 
        //member variable, update textBoxProfessorFileName field, and will add
        //each professor instance from the pc to the listViewProfessorCollection.
        //*************************************************************************
        private void OpenProfbutton_Click(object sender, RoutedEventArgs e)
        {
            string name = "";
            //Creates an OpenFileDialog set to the current directory, will only open .json files.
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = Environment.CurrentDirectory;
            opf.Filter = "JSON files (*.json)|*.json";
            opf.FilterIndex = 1;
            opf.Title = "Open Professor Collection From JSON";
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == true)
            {
                name = opf.FileName;
                FileStream pReader = new FileStream(name, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer pInput;
                pInput = new DataContractJsonSerializer(typeof(ProfessorCollection));
                pc = (ProfessorCollection)pInput.ReadObject(pReader);
                pReader.Close();
                MessageBox.Show("File Opened Succesfully");
                //Sets the ProfessorFileName textbox to the name of the file location, 
                //if the user selects cancel or does not open a file, nothing will occur, and the 
                //previously opened filename will remain in the CourseFileName textbox.
                textBoxProfessorFileName.Text = name;
            }
            //Adds each professor instance within the list to the listViewProfessorCollection.
            foreach (Professor p in pc.n_professors)
            {
                listViewProfessorCollection.Items.Add(p);
            }
        }
    }
}
