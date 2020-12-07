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
    number.returnNumber(userInt);
    for (int i = 1; i <= userInt; i++) {
      Console.Write(number.numberList[i-1]);
      if (i != userInt) {
        Console.Write(", ");
      }
    }
  }
}