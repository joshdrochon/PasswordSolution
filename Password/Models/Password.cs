using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace PasswordProject.Models
{
  public class Password
  {
    public static int _score = 0;

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
        Console.WriteLine("The score increased by 1 in condition 1");
      }
      //condition 2
      if(Regex.IsMatch(password, @"\d")) //password contains numbers
      {
        _score++;
        Console.WriteLine("The score increased by 1 in condition 2");
      }
      //condition 3
      if(Regex.Match(password, @"^[A-Z]").Success) //password contains capital letters
      {
        _score++;
        Console.WriteLine("The score increased by 1 in condition 3");
      }
      //condition 4
      if(password.Length >= 12)
      {
        _score += 2;
        Console.WriteLine("The score increased by 2 in condition 4");
      }
      //condition 5
      else if(password.Length >= 10)
      {
        _score ++;
        Console.WriteLine("The score increased by 1 in condition 5");
      }

      return _score;
    }
  }

}
