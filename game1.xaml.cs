using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;
using System.Threading.Tasks;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class game1 : Page
    {
        int[,] ray = new int[6, 7]{ {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0},
                     {0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0}  };
       int randomNumber;
       Boolean eveOccured;
       int s = 0;
       int f = 0;
        public game1()
        {
            this.InitializeComponent();
            eveOccured=false;
            if(f==0)
            startGame();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        

        private async void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            eveOccured = true;
            double x = Canvas.GetLeft(myText);
            double y = Canvas.GetTop(myText);
            int m = (int)(x / 50);
            if(ray[3,m]!=0)
            {
                f = 1;
                Frame.Navigate(typeof(gover));
                return;
            }
           int a,b;
                while(y<250)
                {
                 a = (int)(x)/ 50;
                 b =( (int)(y) / 50)+1;
                 if (ray[b, a] == 0)
                   y=y+50;
                 else
                  {
                    //ray[b, a] = randomNumber;
                    break;
                  }
                 
                 Canvas.SetTop(myText, y);   
                 await Task.Delay(500);
                }
                a = (int)(x) / 50;
                if (y < 250)
                    b = ((int)(y) / 50) + 1;
                else
                    b = ((int)(y) / 50);
                if (y == 250)
                {
                    ray[b, a] = randomNumber;
                      if(x==0)
                      {
                          T1.Text = myText.Text;
                      }
                      if (x == 50)
                      {
                          T2.Text = myText.Text;
                      }
                      if (x == 100)
                      {
                          T3.Text = myText.Text;
                      }
                      if (x == 150)
                      {
                          T4.Text = myText.Text;
                      }
                      if (x == 200)
                      {
                          T5.Text = myText.Text;
                      }
                      if (x == 250)
                      {
                          T6.Text = myText.Text;
                      }
                      if (x == 300)
                      {
                          tb1.Text = myText.Text;
                      }
                }
                else
                {
                    int max,min;
                    if(ray[b,a]>randomNumber)
                    {
                        max=ray[b,a];
                        min=randomNumber;
                    }
                    else{
                         min=ray[b,a];
                        max=randomNumber;
                    }
                    if (max % min == 0)
                    {
                        int change = max / min;
                        ray[b, a] = change;
                        s = s + change;
                        
                        Scorebox.Text = s.ToString();
                        if (s >= 30)
                        {
                            Frame.Navigate(typeof(winpage));
                        }
                        //  myText.Text=change.ToString();

                        if (x == 0 && y == 200)
                        {
                            T7.Text = " ";
                            T1.Text = change.ToString();
                        }
                        if (x == 50 && y == 200)
                        {
                            T8.Text = " ";
                            T2.Text = change.ToString();
                        }
                        if (x == 100 && y == 200)
                        {
                            T9.Text = " ";
                            T3.Text = change.ToString();
                        }
                        if (x == 150 && y == 200)
                        {
                            T10.Text = " ";
                            T4.Text = change.ToString();
                        }
                        if (x == 200 && y == 200)
                        {
                            T11.Text = " ";
                            T5.Text = change.ToString();
                        }
                        if (x == 250 && y == 200)
                        {
                            T12.Text = " ";
                            T6.Text = change.ToString();
                        }
                        if (x == 300 && y == 200)
                        {
                            tb2.Text = " ";
                            tb1.Text = change.ToString();
                        }
                        if (x == 0 && y == 150)
                        {
                            T13.Text = " ";
                            T7.Text = change.ToString();
                        }
                        if (x == 50 && y == 150)
                        {
                            T14.Text = " ";
                            T8.Text = change.ToString();
                        }
                        if (x == 100 && y == 150)
                        {
                            T15.Text = " ";
                            T9.Text = change.ToString();
                        }
                        if (x == 150 && y == 150)
                        {
                            T16.Text = " ";
                            T10.Text = change.ToString();
                        }
                        if (x == 200 && y == 150)
                        {
                            T17.Text = " ";
                            T11.Text = change.ToString();
                        }
                        if (x == 250 && y == 150)
                        {
                            T18.Text = " ";
                            T12.Text = change.ToString();
                        }
                        if (x == 300 && y == 150)
                        {
                            tb3.Text = " ";
                            tb2.Text = change.ToString();
                        }
                    }
                    else
                    {
                        
                        ray[b-1, a] = randomNumber;
                        if (x == 0 && y == 200)
                        {
                            T7.Text = myText.Text;
                            
                        }
                        if (x == 50 && y == 200)
                        {
                            T8.Text = myText.Text;
                        }
                        if (x == 100 && y == 200)
                        {
                            T9.Text = myText.Text;
                        }
                        if (x == 150 && y == 200)
                        {
                            T10.Text = myText.Text;
                        }
                        if (x == 200 && y == 200)
                        {
                            T11.Text = myText.Text;
                        }
                        if (x == 250 && y == 200)
                        {
                            T12.Text = myText.Text;
                        }
                        if (x == 300 && y == 200)
                        {
                            tb2.Text = myText.Text;
                        }
                        if (x == 0 && y == 150)
                        {
                            T13.Text = myText.Text;

                        }
                        if (x == 50 && y == 150)
                        {
                            T14.Text = myText.Text;
                        }
                        if (x == 100 && y == 150)
                        {
                            T15.Text = myText.Text;
                        }
                        if (x == 150 && y == 150)
                        {
                            T16.Text = myText.Text;
                        }
                        if (x == 200 && y == 150)
                        {
                            T17.Text = myText.Text;
                        }
                        if (x == 250 && y == 150)
                        {
                            T18.Text = myText.Text;
                        }
                        if (x == 300 && y == 150)
                        {
                            tb3.Text = myText.Text;
                        }
                    }
                  }
                Canvas.SetLeft(myText, 0);
                Canvas.SetTop(myText, 0);
                eveOccured = false;
                startGame();

        }
       
      
        

        
        private async void startGame()
        {
            double x = Canvas.GetLeft(myText);
            double y = Canvas.GetTop(myText);

            Random random = new Random();
            randomNumber = random.Next(1, 20);
            
            myText.Text = randomNumber.ToString();
            int a,b;
            
            while (y < 250 && eveOccured==false)
            {
                while (x < 300 && eveOccured == false)
                {
                    Canvas.SetLeft(myText, x+50);
                    x = x + 50;
                    await Task.Delay(500);
                }
                await Task.Delay(500);
                while (x >= 0 && eveOccured == false)
                {

                    if(x>=0)
                    Canvas.SetLeft(myText, x);
                    x = x - 50;
                    await Task.Delay(500);
                }
              
                  await Task.Delay(500);
            }
            
          /*  a = (int)(x / 50);
            b = (int)(y / 50);
            if (y == 250)
            {
                ray[b, a] = randomNumber;
            }
            else
            {
                int max, min;
                if (ray[b, a] > randomNumber)
                {
                    max = ray[b, a];
                    min = randomNumber;
                }
                else
                {
                    min = ray[b, a];
                    max = randomNumber;
                }
                if (max % min == 0)
                {
                    int change = max / min;
                    ray[b, a] = change;
                    //  myText.Text=change.ToString();
                }
              
            }  */
            
            }

        private void Text1_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void over_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
         

        

        

      



        
        
    }
}
