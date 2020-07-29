using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Threading;

//Splits the string recieved by TSS and then adds relevant question adress to a .txt file.


namespace PageTurner
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\nzhs\questioninformation\QuestionLogTemp");
            DateTime currentTimeMS = DateTime.Now;
            string Username = Environment.UserName; //Get current user
            string arg0 = null; 
            string arg1 = null; //arbritrary showcard ID format.
            string arg2 = null;
            if (args.Length > 0) { arg0 = args[0]; }
            if (args.Length > 1) { arg1 = args[1]; }
            if (args.Length > 2) { arg2 = args[2]; }
            string check = "Arg1 = " + arg0 + " and Arg2 = " + arg1; //The string containing PageTurner.exe arguments.
            string Arguments = arg0 + " " + arg1 + " " + arg2;
            var myFile = File.Create(@"C:\nzhs\questioninformation\QuestionLogTemp\" + Arguments + ".txt");
            myFile.Close();
           
        }

    }

}
