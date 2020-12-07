using System; 
using PingPongProject;

public class Program
{
  public static void Main()
  {
    PingPong number = new PingPong();
    Console.WriteLine("Enter a number");
    string userNumber = Console.ReadLine(); 
    int userInt = int.Parse(userNumber);
    Console.WriteLine(userInt); 
    number.returnNumber(userInt);
  }
}
