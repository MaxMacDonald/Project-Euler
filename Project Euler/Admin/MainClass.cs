using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using Project_Euler.Projects;

namespace Project_Euler
{
    class MainClass
    {
        public static void Main()
        {
            string chosenProject;
            string chosenNumber;

            Console.WriteLine("Select which Project youd like to run:");
            chosenNumber = Console.ReadLine();
            chosenProject = "Project_Euler.Projects.Project" + chosenNumber;
            Console.WriteLine(chosenProject);

            Type t = Type.GetType(chosenProject);
            MethodInfo method = t.GetMethod("Solution", BindingFlags.Static | BindingFlags.Public);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            method.Invoke(null, null);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            //Formating of Timer
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("Runtime " + elapsedTime);

           
        }
    }
}
