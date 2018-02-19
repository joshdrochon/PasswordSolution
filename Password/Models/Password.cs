using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PasswordProject.Models
{
  public class Password
  {
    public static int _score = 0;

    Regex rgx = new Regex("[^A-Za-z0-9]");

    public static int Reset()
    {
      Console.WriteLine("The score has been reset to 0");
      return _score = 0;
    }

    public int PasswordChecker(string password)
    {
      //condition 1
      if(password != "password" || password != "p4ssword")
      {
        _score++;
        Console.WriteLine("Your score increased by 1 in condition 1");
      }
      // //condition 2
      // if(rgx.IsMatch("8378", password))
      // {
      //   _score++;
      // }
      // if(password.Length >= 8)
      // {
      //   _score += 2;
      //   Console.WriteLine("Your score increased by 2");
      // }
      // else if(password.Length >= 6)
      // {
      //   _score++;
      //   Console.WriteLine("Your score increased by 1");
      // }
      return _score;
    }
  }

}
