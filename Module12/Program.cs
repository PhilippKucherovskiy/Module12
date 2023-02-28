static void AgeChecker()
{
    Console.WriteLine("Enter your age");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age > 13)
    {
        Console.WriteLine("Your registration is completed!");
    }else 
    { Console.WriteLine("Users under 14 years old can't be registered."); }

}