using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {

    //Subscribing  to Publisher
    readonly Publisher publisher = new Publisher();
    public Form1()
    {
      InitializeComponent();
      
    }

    /// <summary>
    /// Listener to the publisher
    /// </summary>
    /// <param name="publisher"></param>
    public void Listener(Publisher publisher)
    {
      publisher.eventFired += P_EventFired;
    }

    /// <summary>
    /// Event handler
    /// </summary>
    /// <param name="publisher"></param>
    /// <param name="broadcast"></param>
    void P_EventFired(Publisher publisher, Broadcast broadcast)
    {

      Stock1.Text = string.Format(broadcast.Stock1.Name + "" + broadcast.Stock1.Price);
      Stock2.Text = string.Format(broadcast.Stock2.Name + "" + broadcast.Stock2.Price);
      string path = @".\StockTrading.txt";
      if (!File.Exists(path))
      {
        File.WriteAllLines(path, new[]{ Stock1.Text + @":" + broadcast.Stock1.datetime, Stock2.Text + @":" + broadcast.Stock2.datetime } );
      }
      else
      {
        File.AppendAllText(path, Stock1.Text + @":" + broadcast.Stock1.datetime + Environment.NewLine);
        File.AppendAllText(path, Stock2.Text + @":" + broadcast.Stock2.datetime + Environment.NewLine);
      }

    }

    /// <summary>
    /// Method to subscribe to publisher
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Tick(object sender, EventArgs e)
    {
      
      Listener(publisher);
      publisher.NewUpdate();
    }
    
  }
}
