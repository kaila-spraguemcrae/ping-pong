using System;  
using System.Collections.Generic;

namespace PingPongProject {
  public class PingPong 
  {
    public List<string> numberList = new List<string> {};
    public void returnNumber(int number1)
    {
      for (int i = 1; i <= number1; i++) {
        if(i % 3 == 0 && i % 5 == 0) {
          numberList.Add("ping-pong");
        } else if (i % 3 == 0) {
          numberList.Add("ping");
        } else if (i % 5 == 0) {
          numberList.Add("pong");
        } else {
          numberList.Add(i.ToString());
        }
      }
    }
  }
}