using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseBAse
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Requests());
        }
    }
    public static class DataBase
    {
        public static string connection = @"Data Source=Practik-2.db;Integrated Security=False; MultipleActiveResultSets=True";
    }
    public static class Doctors
    {
        public static string main = "doctor";
        public static string id = "id";
        public static string firstName = "docFam";
        public static string lastName = "docName";
        public static string middleName = "docOtch";
        public static string docSpec = "docSpec";
        public static string price = "price";
        public static string procent = "procent";
        public static string salary = "salary";
        public static string maxProcent = "maxProcent";



    }
    public static class Patient
    {
        public static string main = "patient";
        public static string id = "id";
        public static string firstName = "patientName";
        public static string lastName = "patientFam";
        public static string middleName = "patientOtch";
        public static string birthday = "patientBirthday";
    }

    public static class Reception
    {
        public static string main = "patient_reception";
        public static string id = "idRecep";
        public static string idDoc = "idDoc";
        public static string idPatient = "idPatient";
        public static string dateRecep = "dateRecep";
        public static string avgPrice = "avgPrice";
    }

}
