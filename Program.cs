using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      

      Console.WriteLine("What's your name ?");
      string userName = Console.ReadLine();

      Console.WriteLine($"Well, Hello {userName}, nice to meet you, i'm your personal password checker here. Willing to share your password security here.");

      Console.WriteLine("Please input your password here to help us identify it :");
      string password = Console.ReadLine();


      // Cehcker
      int minLength = 6;
      string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
      string lowercase = "qwertyuiopasdfghjklzxcvbnm";
      string digits = "1234567890";
      string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
      int score = 0;

      int len = password.Length;


      if (len >= minLength) 
      {
        score ++;
      } if (Tools.Contains(password,uppercase))
      {
        score ++;
      } if (Tools.Contains(password,lowercase))
      {
        score ++;
      } if (Tools.Contains(password,digits))
      {
        score ++;
      } if (Tools.Contains(password,specialChars))
      {
        score ++;
      } 

    Console.WriteLine("Hmm..we are retrieveing your score... please wait a second");
    Console.WriteLine($"We got it ! your score is {score}");


    // Score classification
    switch (score) {

    case 4 :
    case 5 :
    Console.WriteLine("Your password is extremely strong");
    break;

    case 3:
    Console.WriteLine("Your password is strong");
    break;

    case 2:
    Console.WriteLine("Your password is medium");
    break;

    case 1:
    Console.WriteLine("Your password is weak");
    break;

    default:
    Console.WriteLine("The password doesn’t meet any of the standards");
    break;

    }  


    }
  }
}

