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

    if (summer && weekend) //are true?
    {
      Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend!");
    }
    else if (summer) //is true
    {
      Console.WriteLine("Your stay might be more expensive than normal due to it taking place during peak season!");
    }
    else if (weekend) //is true
    {
      Console.WriteLine("Your stay might be more expensive than normal due to it taking place during the weekend!");
    }
    else
    {
      Console.WriteLine("Your stay might be expensive, but it could be worse!");
    }
  }

}