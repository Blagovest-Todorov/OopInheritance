using System;

namespace _17.OopInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //inheritance is concept in which you defione parent class and child class
            // the child classes inherits all methods and properties form the Parent classes! but at the same time
            //they can modify the behavior at he child class methods if requred
            // the child class can make its own methods ! 

            Guru99Tutorial pTutor = new Guru99Tutorial(); // creating  an object of a child class Guru99Tutorial
            pTutor.RenameTutorial(".Net by Guru99");
            Console.WriteLine(pTutor.GetTutorial()); //we call Parent method, becasue we have public modifier
        }
        
    }
    public class Tutorial  // Parent Class defining
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public string GetTutorial()   //defining metod 
        {
            return TutorialName;
        }
    }
    // defining the child class

    public class Guru99Tutorial : Tutorial // derived  child class creation inherits base Class -Tutorial
    {
        public void RenameTutorial(string pNewName) //defining a method, used to rename the TutorialName property fierld
        {
            TutorialName = pNewName;  //setting the field to pNewName/ 
        }
    } // even though the TutorialName is not  declared here, we can access it and change its value, //
      // because of inherirtance and access modifiers ->  protected in the Parents class 
      //inheritance--posibility to reuse the parent method, properties into the child class ! 
}
