using System;
using System.Threading;


    Timer _timer = null;

      _timer = new Timer(TimerCallback, null, 0, 2000);
      // Wait for the user to hit <Enter>
      Console.ReadLine();


   void TimerCallback(Object o) 
   {
      // Display the date/time when this method got called.
      Console.WriteLine("In TimerCallback: " + DateTime.Now);
      Console.WriteLine("Hello");

   }