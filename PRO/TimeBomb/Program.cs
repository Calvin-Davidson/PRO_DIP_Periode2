using System;
using System.Timers;

namespace TimeBomb
{
    class Program
    {
   public static int second = 10;
   private static Timer timer;
   
  public static void Main()
   {
      SetTimer();
      Console.Read();

      timer.Stop();
      timer.Dispose();
    }

   private static void SetTimer()
   {
        timer = new Timer(1000);

        // het OnTimedEvent word gerund wanneer de timer zijn doel heeft bereikt ( 1 sec )
        timer.Elapsed += OnTimedEvent;

        // Checked of de timer door gaat of niets
        if (second != 0) {
            timer.AutoReset = true;
                timer.Enabled = true;
        } else {
            timer.AutoReset = false;
                    timer.Enabled = false;
        }
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        if (second > 0) {
            Console.WriteLine(second);
            } else if (second == 0) {
                Console.SetWindowSize(33,8);
                Console.WriteLine("          _ ._  _ , _ ._         ");
                Console.WriteLine("        (_ ' ( `  )_  .__)       ");
                Console.WriteLine("      ( (  (    )   `)  ) _)     ");
                Console.WriteLine("     (__ (_   (_ . _) _) ,__)    ");
                Console.WriteLine("         `~~`|' . |`~~`         ");
                Console.WriteLine("              ;   ;              ");
                Console.WriteLine("              |   |              ");
                Console.WriteLine("_____________|_ __ |_____________");
            } else {
                return;
            }
            second--;
        }
    }    
}
