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
            password = "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

         
                if (key.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password = password.Remove(password.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
   
                    password += key.KeyChar;
                    Console.Write("*");
                }
            }
            Console.WriteLine("Registration Successful! Press any key to continue to login");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" === User Login === ");
            string loginUsername, loginPassword;
            Console.Write("Enter your Username: ");
            loginUsername= Console.ReadLine();
            Console.Write("Enter your Password: ");
            loginPassword= "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    if (loginPassword.Length > 0)
                    {
                        loginPassword = loginPassword.Remove(loginPassword.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    loginPassword += key.KeyChar;
                    Console.Write("*");
                }
            }
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
