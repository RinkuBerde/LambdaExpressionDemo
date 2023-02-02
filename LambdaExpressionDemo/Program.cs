namespace LambdaExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression Demo!!!");
            Console.WriteLine("1.Retrieving Top Two Record ForAgels Less Than Sixty ");
            Console.WriteLine("2.Checking For Teenager Person");
            Console.WriteLine("3.Count All Persons Average Age");
            Console.WriteLine("4.Check Name is Exist Or Not");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter the option : ");
            int num = Convert.ToInt32(Console.ReadLine());
            List<Person> listPersonInCity = new List<Person>();
            LambdaDemo.AddRecords(listPersonInCity);
            switch (num)
            {
                case 1:
                    LambdaDemo.Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
                    break;
                case 2:
                    LambdaDemo.CheckingForTeenagerPerson(listPersonInCity);
                    break;
                case 3:
                    LambdaDemo.AllPersonsAverageAge(listPersonInCity);
                    break;
                case 4:
                    LambdaDemo.CheckNameExistOrNot(listPersonInCity);
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }
        }
    }
}