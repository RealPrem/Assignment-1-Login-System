using System;

namespace Assignment_1_Login_System
{
    class Program
    {
        static void Main(string[] args)
        {
            User bob = new User("Bobby","bob123","NotBob");
            Console.WriteLine("User logged in:" + bob.loggedIn);
            Console.WriteLine(bob.CheckLogin("Adam", "adam123"));
            Console.WriteLine(bob.CheckLogin("Bobby", "bob123"));
            Console.WriteLine("User logged in:" + bob.loggedIn);

            Console.WriteLine(bob.RealName);

            bob.LogOut();
            Console.WriteLine("User Logged in:" + bob.loggedIn);

            bob.ChangePassword("IAMBOB");
            Console.WriteLine(bob.CheckLogin("Bobby","IAMBOB"));

            
            
        }
    }
}
