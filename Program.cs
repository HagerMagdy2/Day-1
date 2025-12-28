namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            Console.WriteLine(" === User Registration === ");
            Console.Write("Enter a new Username: ");
           username= Console.ReadLine();
            Console.Write("Enter a new Password: ");
            password = Console.ReadLine();
            Console.WriteLine("Registration Successful! Press any key to continue to login");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" === User Login === ");
            string loginUsername, loginPassword;
            Console.Write("Enter your Username: ");
            loginUsername= Console.ReadLine();
            Console.Write("Enter your Password: ");
            loginPassword= Console.ReadLine();
            if (loginUsername == username && loginPassword == password)
            {
                Console.WriteLine("Login Successful! Welcome back, " + username);
            }
            else
            {
                Console.WriteLine("Login Failed! Invalid Username or Password.");
            }
        }
    }
}
