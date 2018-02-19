using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


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
      //condition 2
      if(Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
      {
        _score++;
        Console.WriteLine("The score increased by 1 in condition 2");
      }
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
