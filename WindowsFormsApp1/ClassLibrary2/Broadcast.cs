using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
  /// <summary>
  /// Class that broadcasts the messages by the publisher
  /// </summary>
  public class Broadcast
  {
    public Stock1 Stock1 { get; set; }
    public Stock2 Stock2 { get; set; }

  }

  public class Stock1
  {

    public string Name { get; set; }
    public double Price { get; set; }

    public DateTime datetime { get; set; }

  }

  public class Stock2
  {

    public string Name { get; set; }
    public double Price { get; set; }

    public DateTime datetime { get; set; }
  }
}
