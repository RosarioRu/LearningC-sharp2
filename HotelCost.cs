using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine().ToUpper();
    Console.WriteLine("Can they be strung?: " + season);
    
    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine().ToUpper();
  
    bool summer = season == "SUMMER";
    bool weekend = dayOfWeek == "WEEKEND";
  }
}