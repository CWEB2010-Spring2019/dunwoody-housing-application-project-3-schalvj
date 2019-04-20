using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Classes
{
    public abstract class Resident
    {
        public int ResidentID { get; set; }
        public string ResidentTypeName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FloorID { get; set; }
        public int DormID { get; set; }
        public double TotalRent { get; set; }

    }
    public class StudentWorker : Resident
    {
        
        public double HoursWorked { get; set; }
        public StudentWorker(int ID, string ResidentType, string FName, string LName, int Floor, 
            int Dorm, double hrsWorked, double totalRent)
        {
            ResidentID = ID;
            ResidentTypeName = ResidentType;
            FirstName = FName;
            LastName = LName;
            FloorID = Floor;
            DormID = Dorm;
            HoursWorked = hrsWorked;
            TotalRent = totalRent;


        }
        public StudentWorker()
        {
            
        }
    }
    class StudentAthlete : Resident
    {
        public StudentAthlete(int ID, string ResidentType, string FName, string LName, int Floor,
            int Dorm, double totalRent)
        {
            ResidentID = ID;
            ResidentTypeName = ResidentType;
            FirstName = FName;
            LastName = LastName;
            FloorID = Floor;
            DormID = Dorm;
            TotalRent = totalRent;
        }
        public StudentAthlete()
        {

        }
    }
    class ScholarshipRecipient : Resident
    {
        public ScholarshipRecipient(int ID, string ResidentType, string FName, string LName, int Floor,
            int Dorm, double totalRent)
        {
            ResidentID = ID;
            ResidentTypeName = ResidentType;
            FirstName = FName;
            LastName = LName;
            FloorID = Floor;
            DormID = Dorm;
            TotalRent = totalRent;
        }
        public ScholarshipRecipient()
        {

        }
    }
}
