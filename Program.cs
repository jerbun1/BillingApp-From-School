/*Date: Friday Oct 2 2020, 
  Name: Jermaine Henry
  Program: Creating a Object Program for Viewing */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BillingApp
{
   public class Program
    {
        //private Data members for the class Program 
        private string projectName;
        private double projectBudget;
        private double projectSpent;
        private double remainingHr;
        private string selectStatus;
        //Complete the rest mentioned in the description
        //Constructor with parameters set to class Program 
        public Program(string projectName, double projectBudget, double projectSpent, double remainingHr, string selectStatus) {
            this.projectName = projectName;
            this.projectBudget = projectBudget;
            this.projectSpent = projectSpent;
            this.remainingHr = remainingHr;
            this.selectStatus = selectStatus;
        
        }

        //Create constructor that needs to be complied and has no parameters
        public Program()
        {

        }

        //Getters and Stters for each of the private data members 
        //Getter and Setter for Project Name 
          public string ProjectName
           {    
           get {return this.projectName;}
           set {this.projectName = value;}
          }

        //Getter and Setter for Project Budget
        public double ProjectBudget {
            get { return this.projectBudget; }
            set { this.projectBudget = value; }
        }

        //Getter and Setter for Project Spent
        public double ProjectSpent
        {
            get { return this.projectSpent; }
            set { this.projectSpent = value; }
        }

        //Getter and Setter for Remaining Hours 
        public double Remaininghr
        {
            get { return this.remainingHr; }
            set { this.remainingHr = value; }
        }

        //Getter and Setter for Slected Status
        public string SelectStatus
        {
            get { return this.selectStatus; }
            set { this.selectStatus = value; }
        }

    }
}
