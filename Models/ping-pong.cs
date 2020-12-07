using System;  

namespace PingPongProject {
  public class PingPong 
  {
    public void returnNumber(int number1)
    {
      for (int i = 1; i <= number1; i++) {
        if(i % 3 == 0 && i % 5 == 0) {
          Console.WriteLine("ping-pong");
        } else if (i % 3 == 0) {
          Console.WriteLine("ping");
        } else if (i % 5 == 0) {
          Console.WriteLine("pong");
        } else {
        Console.WriteLine(i);
        }
      }
    }
  }
}
