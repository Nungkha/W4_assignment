namespace W4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Question 1:

            Car obj = new Car("tesla",2022, 70000);

            Console.WriteLine(obj.getBrand());
            Console.WriteLine(obj.getYear());
            Console.WriteLine(obj.getPrice());

            Console.WriteLine("\n\n");

            // question 2:

            BankAccount bankAcObj = new BankAccount("0835D");
                
            bankAcObj.Deposit(1000);
            bankAcObj.Withdraw(500);
            Console.WriteLine("Balance : " + bankAcObj.GetBalance());

            Console.WriteLine("\n\n");

            // question 3:

            Rectangle rec = new Rectangle(4.5f, 3.2f);
            Console.WriteLine($"Area : {rec.CalculateArea()}");

            Console.WriteLine("\n\n");

            // question 4:

            Cirlcle circle = new Cirlcle(5);
            Console.WriteLine($"The area of circle is {circle.CalculateArea()}");

            Console.WriteLine("\n\n");

            // question 5:

            Student std = new Student("John Doe", 20, "Computer Science.");
            std.Introduce();

            Console.WriteLine("\n\n");

            // question 6:

            Stack<int> numbers = new Stack<int>();
            numbers.Push(20);
            numbers.Push(25);
            numbers.Push(30);
            numbers.Push(55);

            numbers.DisplayItems();

            //foreach( var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            Console.WriteLine($"Popped item: {numbers.Pop()}");
            //Console.WriteLine($"List after pooping 1 item: {numbers.DisplayItems()}");
            numbers.DisplayItems();

            Console.WriteLine($"Peeked item: {numbers.Peek()}");


            Console.WriteLine("\n\n");

            // question 7:

            Calendar calendar = new Calendar();

            calendar.PrintWeekdays();

            Console.WriteLine("\n\n");

            // question 8:



        }
    }

    public class Car
    {
        private string _brand;
        private int _year;
        private float _price;

        public Car(string brand, int year, float price)
        {
            this._brand = brand;
            this._year = year;
            this._price = price;
        }

        public string getBrand()
        {
            return _brand;
        }

        public int getYear()
        {
            return _year;
        }

        public float getPrice()
        {
            return _price;
        }



    }
}