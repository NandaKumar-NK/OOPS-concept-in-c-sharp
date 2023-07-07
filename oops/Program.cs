using oops;
using System.Net;
using System.Security.Cryptography;

class Program
{
    public static void Main(String[] args)
    {
        //StaticDemo sd=new StaticDemo();
        
        StaticDemo.Calculate();
        Console.WriteLine(StaticDemo.Amt);
        StaticDemo.disp();

        //LE lE = new LE();
        //lE.BankExper();

       // JArr jArr = new JArr();
        //jArr.displayMULTI();

        //NonGenericCollectionsDemo ng=new NonGenericCollectionsDemo();
        //ng.ArrayListElements();
        //ng.SortedListElements();
        //ng.hashListElements();
        //ng.StackElements();
        //ng.QueueElements();
       // SortedListElements sortedListElements = new SortedListElements();
       // HashElements hashElements = new HashElements();
       //QueueElements queueElements=new QueueElements();
       //StackElements stackElements = new StackElements();

        //GenericCollectionsDemo genericCollectionsDemo = new GenericCollectionsDemo();
        //genericCollectionsDemo.ListElements();


        //FileOperations fileOperations = new FileOperations();
        //fileOperations.FileProperties();
        //fileOperations.ReadData();
        //fileOperations.CreateFile();
        //fileOperations.CopyMoveFile();
        //fileOperations.DeleteFile();
        //Console.WriteLine("Enter 2 numbers");

        // ExceptHandling exceptHandling = new ExceptHandling(10,10,0);

        //Console.WriteLine(exceptHandling.add());
        //Console.WriteLine(exceptHandling.mult());
        //Console.WriteLine(exceptHandling.div());
        //
        //try
        //{
        //    exceptHandling.CheckVal(-1);
        //} catch(ArithmeticException excep) {

        //    Console.WriteLine(excep.Message);

        //}
        //catch (ArgumentException excep)
        //{

        //    Console.WriteLine(excep.Message);

        //}

        //EnumsDemo enumsDemo = new EnumsDemo();
        //enumsDemo.display();

        //BankAccount bankAccount=new BankAccount(123,"nanda",1254698,1514,"inactive");

        //Console.WriteLine("1. custid 2. Accno ");
        //int ch=Convert.ToInt32(Console.ReadLine());
        //switch (ch)
        //{
        //    case 1:
        //        bankAccount.Checkaccstatus(123);
        //        Console.WriteLine(bankAccount.Accno+" "+bankAccount.Name+" "+
        //            bankAccount.Status+" "+bankAccount.Balance);
        //        break;

        //    case 2:
        //        bankAccount.Checkaccstatus(1254698);
        //        Console.WriteLine(bankAccount.Custid + " " + bankAccount.Name + " " +
        //            bankAccount.Status + " " + bankAccount.Balance);
        //        break;

        //    default:
        //        Console.WriteLine("Enter 1 or 2");
        //        break;
        //}

        //Animals dog = new Animals("dog",2,1,4,1,"sa","ch",95);
        //Animals cow = new Animals("cow",2,1,4,1,"lit", "ch", 90);
        //Animals cat = new Animals("cat", 2, 1, 4, 1, "sns", "cmb", 57);

        //cat.MakeSound(cat.Name);

        //cow.Type(cow.Name);

        //dog.MakeSound(dog.Name);
        //dog.Type(dog.Name);




        //Intersample intersample = new Intersample();
        //Console.WriteLine(intersample.intadd(5,8));
        //Console.WriteLine(intersample.strconcat("nan","da kumar"));

        //Interest interest=new Interest(10,1010101,"AAA",20000,0);
        //double intamt= interest.CalculateInterest();
        //Console.WriteLine(intamt);

        //Console.WriteLine("Enter Roll number ,Name" + "and 3 marks");
        //int rollno=Convert.ToInt32(Console.ReadLine());
        //string Name=Console.ReadLine();
        //double mark1=Convert.ToDouble(Console.ReadLine());
        //double mark2=Convert.ToDouble(Console.ReadLine());
        //double mark3=Convert.ToDouble(Console.ReadLine());

        ////inherit inherit = new inherit(rollno,Name,mark1,mark2,mark3);
        ////inherit.StudentCalculation();

        //StudentCalculation studentCalculation=new StudentCalculation
        //    (rollno, Name, mark1, mark2, mark3,0,0);
        //studentCalculation.Calculate();

        //Console.WriteLine("RollNo: " + studentCalculation.Rollno + " Name: " +
        //    studentCalculation.Name + " Total: " + studentCalculation.Tot + " Average: " + studentCalculation.Avg);

        //Console.WriteLine("Enter collegeName,Address,pin");
        // string CollegeName = Console.ReadLine();
        //string Address = Console.ReadLine();
        //int pin = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Teaching Staff - Eid , name, dept,"+ "fav sub,sal");
        //int Eid = Convert.ToInt32(Console.ReadLine());
        //string name = Console.ReadLine();
        //string dept = Console.ReadLine();
        //string favsub = Console.ReadLine();
        //double sal= Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Admin Staff - Eid , name, sal");

        //int aEid = Convert.ToInt32(Console.ReadLine());
        //string aname = Console.ReadLine();
        //double asal = Convert.ToDouble(Console.ReadLine());
        //TeachingStaff teachingStaff = new TeachingStaff( CollegeName,  Address,  pin,  Eid,
        //    name,  dept, favsub, sal);
        //double tsal=teachingStaff.CalculateSalary(sal);
        //Console.WriteLine("College Name " + teachingStaff.Collegename +
        //    "Teaching staff name " + teachingStaff.Name +
        //    "ts Salary " + tsal);

        //AdminStaff adminStaff = new AdminStaff( CollegeName, Address, pin,  aEid,
        //     aname, asal);
        //double adsal=adminStaff.CalculateSalary(asal);


        //Console.WriteLine("College Name " + adminStaff.Collegename +
        //    "Admin staff name " + adminStaff.Name +
        //    "Admin staff Salary " + adsal);

        //Console.WriteLine("enter two num");
        //int n1=10, n2=20;
        //int n3=5, n4=8;
        //addition addition=new addition();
        //addition.add(n3,n4,out  n1,out n2);
        //Console.WriteLine(n1+" "+n2);
        //Console.WriteLine(n3+" "+n4);
    }
}