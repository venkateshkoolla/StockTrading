using System;
using System.Threading;

namespace ClassLibrary1
{

  /// <summary>
  /// Class/service that can publish/Broadcast the messages using Deligate/Envent using Publish and subscribe pattern
  /// </summary>
  public class Publisher
  {
    
    public delegate void PublisherDelegate(Publisher publisher, Broadcast broadcast);

    public event PublisherDelegate eventFired;


    /// <summary>
    /// Method that generates a new message to publish to clients
    /// </summary>
    public void NewUpdate()
    {
      if (eventFired != null)
      {

        Thread.Sleep(1000);
        var broadcast = new Broadcast
        {
          Stock1 = new Stock1() {Name = "stock1: ", Price = generateRandom(240, 270), datetime = DateTime.Now},
          Stock2 = new Stock2() {Name = "stock2: ", Price = generateRandom(180, 210), datetime = DateTime.Now}
        };
        eventFired?.Invoke(this, broadcast);
      }

    }

    /// <summary>
    /// Method to generate the random numbers
    /// </summary>
    /// <param name="range1"></param>
    /// <param name="range2"></param>
    /// <returns></returns>
    private int generateRandom(int range1, int range2)
    {
      var r = new Random();
      int result = r.Next(range1, range2);
      return result;
    }
  }
}
