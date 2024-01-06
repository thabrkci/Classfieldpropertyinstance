using System;

namespace ShoppingPersonnelList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A&D Shopping Personnel List");

            // Creating an instance of the Shopping class for the first personnel
            Shopping personnelList1 = new Shopping();
            personnelList1.Name = "Taha";
            personnelList1.Surname = "BÖREKCİ";
            personnelList1.PersonnelNo = 351;
            personnelList1.Department = "Sales Consultant";
            personnelList1.DisplayPersonnel();

            Console.WriteLine("*****************************************************");

            // Creating another instance of the Shopping class for the second personnel
            Shopping personnelList2 = new Shopping();
            personnelList2.Name = "Barış";
            personnelList2.Surname = "AKAN";
            personnelList2.PersonnelNo = 355;
            personnelList2.Department = "Administrator";
            personnelList2.DisplayPersonnel();
        }
    }

    // Shopping class definition
    class Shopping
    {
        // Properties for the shopping personnel
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int PersonnelNo { get; set; }
        public string? Department { get; set; }

        // Method to display shopping personnel information
        public void DisplayPersonnel()
        {
            Console.WriteLine("Personnel Name: {0}", Name);
            Console.WriteLine("Personnel Surname: {0}", Surname);
            Console.WriteLine("Personnel PersonnelNo: {0}", PersonnelNo);
            Console.WriteLine("Personnel Department: {0}", Department);
        }
    }
}
