namespace User_input_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartOne();
            PartTwo();
            PartThree();
            PartFour();
            PartFive();

        }
        public static void PartOne()
        {
            String name;
            String age;
            String income;

            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "! How old are you?");
            age = Console.ReadLine();
            Console.WriteLine("So you're " + age + " years old, eh? That's not old at all! How much do you make?");
            income = Console.ReadLine();
            Console.WriteLine("$" + income + "! I hope that's per hour and not per year!");
        }
        public static void PartTwo()
        {
            String FirstName;
            String LastName;
            String LoginName;
            String Grade;
            String StudentIDNumber;
            String Average;
            Console.WriteLine("Please enter the following data so i can sell it for a profit");
            Console.WriteLine("first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("last name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("login name: ");
            LoginName = Console.ReadLine();
            Console.WriteLine("grade: ");
            Grade = Console.ReadLine();
            Console.WriteLine("student ID number: ");
            StudentIDNumber = Console.ReadLine();
            Console.WriteLine("average: ");
            Average = Console.ReadLine();
            Console.WriteLine("Your information");
            Console.WriteLine("Login:\t\t" + LoginName);
            Console.WriteLine("ID:\t\t" + StudentIDNumber);
            Console.WriteLine("Name:\t\t" + LastName + ", " + FirstName);
            Console.WriteLine("Average:\t" + Average + "%");
            Console.WriteLine("Grade:\t\t" + Grade);
        }
        public static void PartThree()
        {
            String Name;
            String Age;
            Console.WriteLine("Hello, what is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("Hi, " + Name + "! How old are you?");
            Age = Console.ReadLine();
            Console.WriteLine("Did you know that in five years you will be " + (int.Parse(Age) + 5) + " years old? And five years ago you were " + (int.Parse(Age) - 5) + "! Imagine that!");
        }
        public static void PartFour()
        {
            String num1;
            String num2;
            String num3;
            Console.WriteLine("Enter first number:");
            num1 = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            num2 = Console.ReadLine();
            Console.WriteLine("Enter third number:");
            num3 = Console.ReadLine();
            Console.WriteLine("The sum of the three numbers devided by 2 is: " + ((int.Parse(num1) + int.Parse(num2) + int.Parse(num3)) / 2));
        }
        public static void PartFive()
        {
            string item1;
            string item2;
            string price1;
            string price2;
            Console.WriteLine("Enter item name:");
            item1 = Console.ReadLine();
            Console.WriteLine("Enter price of item:");
            price1 = Console.ReadLine();
            Console.WriteLine("Enter item name:");
            item2 = Console.ReadLine();
            Console.WriteLine("Enter price of item:");
            price2 = Console.ReadLine();
            Console.WriteLine("Sales receipt:");
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price: $" + price1);
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Price: $" + price2);
            Console.WriteLine("============================");
            Console.WriteLine("Total: $" + (double.Parse(price1) + double.Parse(price2)));
            Console.WriteLine("Discount (20%): $" + ((double.Parse(price1) + double.Parse(price2)) * 0.2));
            Console.WriteLine("Subtotal: $" + ((double.Parse(price1) + double.Parse(price2)) - ((double.Parse(price1) + double.Parse(price2)) * 0.2)));
            Console.WriteLine("Tax (13%): $" + (((double.Parse(price1) + double.Parse(price2)) - ((double.Parse(price1) + double.Parse(price2)) * 0.2)) * 0.13));
            Console.WriteLine("============================");
            Console.WriteLine("Total Owed: $" + (((double.Parse(price1) + double.Parse(price2)) - ((double.Parse(price1) + double.Parse(price2)) * 0.2)) + (((double.Parse(price1) + double.Parse(price2)) - ((double.Parse(price1) + double.Parse(price2)) * 0.2)) * 0.13)));

        }
    }
}