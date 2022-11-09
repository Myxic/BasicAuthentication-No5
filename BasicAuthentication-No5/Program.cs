// See https://aka.ms/new-console-template for more information



using System.Linq;


var User = new Dictionary<string, string>(){
            { "goodness", "benedictt123"}, {"john", "boy78345"}
            };

while (true)
{
    

    Console.WriteLine(" ");
    Console.WriteLine("Enter 1: For Register, 2: For Login ");
    var option = Console.ReadLine();

    Console.WriteLine("Enter username");
    var username1 = Console.ReadLine();

    string username = username1.ToLower();

    Console.WriteLine("Enter password");
    var password = Console.ReadLine();

    Console.WriteLine("");

    if (option == "1")
    {
        if (password.Length < 8 || password == " " || password == null)
        {
            Console.WriteLine("Password must be more than 8 characters");
            break;

        }
        else if (User.Keys.Contains(username))
        {
            Console.WriteLine("username already exist");
            break;

        }
        else if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Valid");
            User.Add(username, password);
        }
        
    }else if (option == "2")
    {
        foreach (KeyValuePair<string, string> userLogin in User)
        {
            if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
            {
                if (userLogin.Key == username && userLogin.Value == password)
                {
                    Console.WriteLine("you have successfully logged in");
                    break;
                }
                else
                {
                    Console.WriteLine("invalid username or password");
                    break;
                }
           
            }
            else
            {
                Console.WriteLine("empty input");
                break;
            }
        }
        break;
    }
    else
    {
        Console.WriteLine("Enter a Valid Option (1 or 2)");
    }



}