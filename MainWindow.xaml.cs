/*Date: Friday Oct 2 2020, 
  Name: Jermaine Henry
  Program: Creating a Object Program for Viewing */
using BillingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NETD3202._04_Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProjectChanged(object sender, TextChangedEventArgs e) {
          //Data members from Program class 
         string projectName;
         double projectBudget;
         double projectSpent;
         double remainingHr;
         string selectStatus;

            //Checks to see if the Project Budget, Spent and remaining Hours are a number
            double.TryParse(txtBudget.Text, out projectBudget);
            double.TryParse(txtSpent.Text, out projectSpent);
            double.TryParse(txtHoursRemain.Text, out remainingHr);




    }
        //Display the data of the object when clicked 
        private void listBoxClick(object sender, RoutedEventArgs e){

            Program myProgram = new Program();

            //Data members of the Program class
            string projectName = myProgram.ProjectName;
            double projectBudget = myProgram.ProjectBudget;
            double projectSpent = myProgram.ProjectSpent;
            double remainingHr = myProgram.Remaininghr;
            string selectStatus = myProgram.SelectStatus;

        }

        //Creates a Project in the list view on the click 
        private void createProject_Click(object sender, RoutedEventArgs e)
        {
            
            List<Program> listOfPrograms = new List<Program>();
            
            //creates a new Program object 
            Program myProgram = new Program();

            //Adds the Program object to the list view displaying the name
            listBox.Items.Add(this.txtProjectName.Text);

           





        }
    }
}
