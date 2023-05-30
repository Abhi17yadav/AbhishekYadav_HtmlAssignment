//===========================================================================
//Assignment 1
//===========================================================================
//class Medicine
//{
//    string MedicineCode;
//    string MedicineName;
//    string ManufactureName;
//    float UnitPrice;
//    int QuantityOnHand;
//    string ManufacutredDate;
//    string ExpiryDate;
//    int BatchNumber;

//    public Medicine(string medicineCode, string medicineName, string manufactureName, float unitPrice, int quantityOnHand, string manufacutredDate, string expiryDate, int batchNumber)
//    {
//        MedicineCode = medicineCode;
//        MedicineName = medicineName;
//        ManufactureName = manufactureName;
//        UnitPrice = unitPrice;
//        QuantityOnHand = quantityOnHand;
//        ManufacutredDate = manufacutredDate;
//        ExpiryDate = expiryDate;
//        BatchNumber = batchNumber;
//    }

//    public void print()
//    {
//        Console.WriteLine("Medicine Code : {0}", MedicineCode);
//        Console.WriteLine("Medicine Name : {0}", MedicineName);
//        Console.WriteLine("Manufacture Name: {0}", ManufactureName);
//        Console.WriteLine("Unit Price : {0}", UnitPrice);
//        Console.WriteLine("Quantity On Hand : {0}", QuantityOnHand);
//        Console.WriteLine("Manufacutred Date : {0}", ManufacutredDate);
//        Console.WriteLine("Expiry Date : {0}", ExpiryDate);
//        Console.WriteLine("Batch Number : {0}", BatchNumber);
//        Console.ReadLine();
//    }
//}


//class Sales
//{
//    string MedicineCode;
//    string QuantitySold;
//    string PlannedSales;
//    float ActualSales;
//    string Region;


//    public Sales(string medicineCode, string quantitySold, string plannedSales, float actualSales, string region)
//    {
//        MedicineCode = medicineCode;
//        QuantitySold = quantitySold;
//        PlannedSales = plannedSales;
//        ActualSales = actualSales;
//        Region = region;
//    }

//    public void Display()
//    {
//        Console.WriteLine("Medicine Code : {0}", MedicineCode);
//        Console.WriteLine("Quantity Sold : {0}", QuantitySold);
//        Console.WriteLine("Planned Sales: {0}", PlannedSales);
//        Console.WriteLine("Actual Sales : {0}", ActualSales);
//        Console.WriteLine("Region : {0}", Region);
//        Console.ReadLine();
//    }
//}

//class program
//{
//    public static void Main()
//    {
//        Medicine m = new Medicine("101", "Paracitamol", "ManKind", 100f, 10, "20/22/2020", "20/22/2020", 2);
//        m.print();

//        Sales s = new Sales("110", "1", "100", 33.3f, "North");
//        s.Display();
//    }
//}

//==============================================================================================================
//Assignment-2
//==============================================================================================================

//public delegate decimal CalculateInterest(decimal principal, decimal rate, int time);

//public class InterestCalculator
//{
//    public decimal CalculateSimpleInterest(decimal principal, decimal rate, int time)
//    {
//        decimal interest = principal * rate * time;
//        return interest;
//    }

//    public decimal CalculateCompoundInterest(decimal principal, decimal rate, int time)
//    {
//        decimal amount = principal * (decimal)Math.Pow((double)(1 + rate), time);
//        decimal interest = amount - principal;
//        return interest;
//    }

//    public decimal CalculateRealInterest(decimal principal, decimal rate, int time)
//    {
//        decimal simpleInterest = CalculateSimpleInterest(principal, rate, time);
//        decimal compoundInterest = CalculateCompoundInterest(principal, rate, time);
//        decimal realInterest = compoundInterest - simpleInterest;
//        return realInterest;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        InterestCalculator calculator = new InterestCalculator();

//        // Create delegates and assign methods
//        CalculateInterest simpleInterestDelegate = calculator.CalculateSimpleInterest;
//        CalculateInterest compoundInterestDelegate = calculator.CalculateCompoundInterest;
//        CalculateInterest realInterestDelegate = calculator.CalculateRealInterest;

//        // Calculate and display the results
//        decimal principal = 1000;
//        decimal rate = 0.05m;
//        int time = 3;

//        decimal simpleInterest = simpleInterestDelegate(principal, rate, time);
//        Console.WriteLine("Simple Interest: " + simpleInterest);

//        decimal compoundInterest = compoundInterestDelegate(principal, rate, time);
//        Console.WriteLine("Compound Interest: " + compoundInterest);

//        decimal realInterest = realInterestDelegate(principal, rate, time);
//        Console.WriteLine("Real Interest: " + realInterest);
//    }
//}

//=============================================================================================================
//Assignment-3
//=============================================================================================================

//class ArrayListcollection
//{
//    static void Main()
//    {
//        ArrayList collection = new ArrayList();
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Enter patient name");
//            var data = Console.ReadLine();
//            collection.Add(data);
//            Console.WriteLine("Do you want to add more name? [Y/N]");
//            var data1 = Console.ReadLine();
//            if (data1 == "N")
//            {
//                break;
//            }
//        }
//        Console.WriteLine("List of patient");
//        foreach (var item in collection)
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine("Total number of patients: " + collection.Count);

//        Console.WriteLine("select one of the following options");
//        Console.WriteLine("1 - Sort");
//        Console.WriteLine("2 - Remove");
//        Console.WriteLine("3 - Reverse");
//        Console.WriteLine("4 - Search");
//        Console.WriteLine("5 - Exit");
//        Console.WriteLine("enter your choice :");
//        int Data3 = Convert.ToInt32(Console.ReadLine());

//        if (Data3 == 1)
//        {

//            collection.Sort();
//            foreach (var item in collection)
//            {
//                Console.WriteLine(item);
//            }

//        }
//        else if (Data3 == 2)
//        {
//            Console.WriteLine("Enter element you want to remove");
//            var Data4 = Console.ReadLine();
//            collection.Remove(Data4);
//            foreach (var item in collection)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        else if (Data3 == 3)
//        {
//            Console.WriteLine("Enter Reverse");
//            var Data4 = Console.ReadLine();
//            collection.Reverse();
//            foreach (var item in collection)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        else if (Data3 == 4)
//        {
//            Console.WriteLine("Enter element you want to search");
//            var Data4 = Console.ReadLine();
//            collection.Contains(Data4);
//            foreach (var item in collection)
//            {
//                Console.WriteLine(item);

//            }
//        }
//        Console.ReadLine();
//    }
//}

//=========================================================================================================
//Assignment-4
//=========================================================================================================
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Transactions;
//class Sign
//{
//    public int ID { get; set; }
//    public string TITLE { get; set; }
//    public string BOXOFFICE { get; set; }
//    public string ACTIVE { get; set; }
//    public string DATEOFLANUCH { get; set; }

//    public string GENRE { get; set; }
//    public string HASTEASER { get; set; }
//}


//class Movie
//{
//    static void Main()
//    {

//        Console.WriteLine("Specify Your Role");
//        Console.WriteLine("1.Admin");
//        Console.WriteLine("2.Customer");
//        Console.WriteLine("(Enter 1 or 2)");
//        int data1 = Convert.ToInt32(Console.ReadLine());


//        List<Sign> list = new List<Sign>()
//        {
//            new Sign() {ID=1001,TITLE="AVATAR",BOXOFFICE="$2787965087",ACTIVE="YES",DATEOFLANUCH="15-03-2017",GENRE="SCIENCEFRICTON",HASTEASER="YES"},
//            new Sign() {ID=1002,TITLE="IRONMAN",BOXOFFICE="$2787965087",ACTIVE="YES",DATEOFLANUCH="23-12-2017",GENRE="SCIENCEFRICTON",HASTEASER="NO"},
//            new Sign() {ID=1003,TITLE="TITANIC",BOXOFFICE="$2787965087",ACTIVE="YES",DATEOFLANUCH="21-08-2017",GENRE="SCIENCEFRICTON",HASTEASER="NO"},
//            new Sign() {ID=1004,TITLE="WORLD",BOXOFFICE="$2787965087",ACTIVE="NO",DATEOFLANUCH="02-07-2017",GENRE="SCIENCEFRICTON",HASTEASER="YES"},
//            new Sign() {ID=1005,TITLE="AVENGER",BOXOFFICE="$2787965087",ACTIVE="YES",DATEOFLANUCH="02-11-2022",GENRE="SUPERHERO",HASTEASER="YES" }
//         };
//        List<Sign> Clist = new List<Sign>()
//        {
//            new Sign() {ID=1001,TITLE="AVATAR",BOXOFFICE="$2787965087",ACTIVE="YES",DATEOFLANUCH="15-03-2017",GENRE="SCIENCEFRICTON",HASTEASER="YES"},
//            new Sign() {ID=1002,TITLE="IRONMAN",BOXOFFICE="$2787965087",ACTIVE="YES",DATEOFLANUCH="23-12-2017",GENRE="SCIENCEFRICTON",HASTEASER="NO"},
//            new Sign() {ID=1003,TITLE="TITANIC",BOXOFFICE="$2787965087",ACTIVE="YES",DATEOFLANUCH="21-08-2017",GENRE="SCIENCEFRICTON",HASTEASER="NO"},
//        };

//        if (data1 == 1)
//        {
//            Console.WriteLine("=======================================================================================");
//            Console.WriteLine("                             Display movie for the Admin                               ");
//            Console.WriteLine("=======================================================================================");
//            Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//            Console.WriteLine("=======================================================================================");
//            foreach (var num in list)
//            {
//                Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

//            }
//            Console.WriteLine("=======================================================================================");
//            Console.WriteLine("1.Add Movie");
//            Console.WriteLine("2.Search Movie");
//            Console.WriteLine("3.Remove Movie");
//            Console.WriteLine("4.Exit");
//            Console.WriteLine("(Enter 1 or 2 or 3 or 4)");
//            int data8 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("=======================================================================================");
//            if (data8 == 1)
//            {
//                Console.WriteLine("Enter the number of movies do you want to add");
//                int data4 = Convert.ToInt32(Console.ReadLine());
//                Sign sign = new Sign();
//                for (int i = 0; i < data4; i++)
//                {
//                    Console.WriteLine("Enter the Id");
//                    sign.ID = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Enter the Title");
//                    sign.TITLE = Console.ReadLine();
//                    Console.WriteLine("Enter the BOXOFFICE");
//                    sign.BOXOFFICE = Console.ReadLine();
//                    Console.WriteLine("Enter the ACTIVE");
//                    sign.ACTIVE = Console.ReadLine();
//                    Console.WriteLine("Enter the DATEOFLANUCH");
//                    sign.DATEOFLANUCH = Console.ReadLine();
//                    Console.WriteLine("Enter the GENRE");
//                    sign.GENRE = Console.ReadLine();
//                    Console.WriteLine("Enter the HASTEASER");
//                    sign.HASTEASER = Console.ReadLine();
//                    list.Add(sign);
//;
//                    Console.WriteLine("Movie added to favorites!");
//                }
//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("                             Display movie for the Admin                               ");
//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//                Console.WriteLine("=======================================================================================");
//                foreach (var num in list)
//                {
//                    Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

//                }
//                Console.WriteLine("=======================================================================================");

//            }
//            else if (data8 == 3)
//            {
//                Console.Write("Enter the movie ID to remove: ");
//                int movieId = Convert.ToInt32(Console.ReadLine());
//                Sign movieToRemove = list.Find(movie => movie.ID == movieId);
//                if (movieToRemove != null)
//                {
//                    list.Remove(movieToRemove);
//                    Console.WriteLine("Movie removed successfully!");
//                }
//                else
//                {
//                    Console.WriteLine("Movie not found.");
//                }


//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("                             Display movie for the Admin                               ");
//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//                Console.WriteLine("=======================================================================================");
//                foreach (var num in list)
//                {
//                    Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

//                }
//                Console.WriteLine("=======================================================================================");
//            }
//            else if (data8==2)
//            {
//                Console.WriteLine("Enter the Movie You want to search");
//                var data6 = Convert.ToInt32(Console.ReadLine());
//                Sign A = list.Find(movie => movie.ID == data6);
//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("                             Search movie for the Customer                               ");
//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//                Console.WriteLine("=======================================================================================");

//                for (int i = 0; i < 1; i++)
//                {
//                    Console.WriteLine(A.ID + "\t" + A.TITLE + "\t" + A.BOXOFFICE + "\t" + A.ACTIVE + "\t" + A.DATEOFLANUCH + "\t" + A.GENRE + "\t" + A.HASTEASER);

//                }
//                Console.WriteLine("=======================================================================================");
//            }
//        }
//        else if (data1 == 2)
//        {

//            Console.WriteLine("=======================================================================================");
//            Console.WriteLine("                             Display movie for the Customer                            ");
//            Console.WriteLine("=======================================================================================");
//            Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//            Console.WriteLine("=======================================================================================");
//            foreach (var num in Clist)
//            {
//                Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

//            }
//            Console.WriteLine("=======================================================================================");
//            Console.WriteLine("1.Modify Data");
//            Console.WriteLine("2.Search Data");
//            Console.WriteLine("3.Exit");
//            Console.WriteLine("(Enter 1 or 2)");
//            int data2 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("=======================================================================================");
//            if (data2 == 1)
//            {
//                Console.WriteLine("Enter the operation performed on the favourities");
//                Console.WriteLine("1.Add to favourities");
//                Console.WriteLine("2.Remove from favourities");
//                Console.WriteLine("3.Exit");
//                Console.WriteLine("(Enter 1 or 2 or 3)");
//                int data3 = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("=======================================================================================");
//                if (data3 == 1)
//                {
//                    Console.WriteLine("Enter the number of movies do you want to add");
//                    int data4 = Convert.ToInt32(Console.ReadLine());

//                    for (int i = 0; i < data4; i++)
//                    {
//                        Console.WriteLine("Enter the Id to add to favorite");
//                        var data5 = Convert.ToInt32(Console.ReadLine());

//                        Sign movieToAdd = list.Find(movie => movie.ID == data5);
//                        if (movieToAdd != null)
//                        {
//                            Clist.Add(movieToAdd);
//                            Console.WriteLine("Movie added to favorites!");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Movie not found.");
//                        }
//                    }

//                    Console.WriteLine("=======================================================================================");
//                    Console.WriteLine("                             Display movie for the Customer                               ");
//                    Console.WriteLine("=======================================================================================");
//                    Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//                    Console.WriteLine("=======================================================================================");
//                    foreach (var num in Clist)
//                    {
//                        Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

//                    }
//                    Console.WriteLine("=======================================================================================");
//                }
//                else if (data3 == 2)
//                {
//                    Console.Write("Enter the fav movie ID to remove: ");
//                    int movieId = Convert.ToInt32(Console.ReadLine());
//                    Sign movieToRemove = Clist.Find(movie => movie.ID == movieId);
//                    if (movieToRemove != null)
//                    {
//                        Clist.Remove(movieToRemove);
//                        Console.WriteLine("Movie removed successfully!");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Movie not found.");
//                    }

//                    Console.WriteLine("=======================================================================================");
//                    Console.WriteLine("                             Display movie for the Customer                               ");
//                    Console.WriteLine("=======================================================================================");
//                    Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//                    Console.WriteLine("=======================================================================================");
//                    foreach (var num in Clist)
//                    {
//                        Console.WriteLine(num.ID + "\t" + num.TITLE + "\t" + num.BOXOFFICE + "\t" + num.ACTIVE + "\t" + num.DATEOFLANUCH + "\t" + num.GENRE + "\t" + num.HASTEASER);

//                    }
//                    Console.WriteLine("=======================================================================================");
//                }
//                else if(data3==3){
//                    Console.WriteLine("Exit");
//                }
//            }
//            else if (data2 == 2)
//            {
//                Console.WriteLine("Enter the Movie You want to search");
//                var data6 = Convert.ToInt32(Console.ReadLine());
//                Sign A = Clist.Find(movie => movie.ID == data6);
//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("                             Search movie for the Customer                               ");
//                Console.WriteLine("=======================================================================================");
//                Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "BOXOFFICE" + "\t" + "ACTIVE" + "\t" + "DATEOFLANUCH" + "\t" + "GENRE" + "\t" + "        HASTEASER");
//                Console.WriteLine("=======================================================================================");

//                for (int i = 0; i < 1; i++)
//                {
//                    Console.WriteLine(A.ID + "\t" + A.TITLE + "\t" + A.BOXOFFICE + "\t" + A.ACTIVE + "\t" + A.DATEOFLANUCH + "\t" + A.GENRE + "\t" + A.HASTEASER);

//                }
//                Console.WriteLine("=======================================================================================");
//            }
//            else if(data2==3){
//                Console.WriteLine("Exit");
//            }
//        }
//    }
//}


