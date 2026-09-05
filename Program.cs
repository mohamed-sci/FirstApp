using System.Collections.Generic ;
using Microsoft.Win32.SafeHandles;

namespace FirstApp
{
    class FirstApp
    {
       static void Main()
        {
           List<int> numbers= new List<int>() ;
           char choice;
           int input;
           int max;
           int min;
           int sum;
           double mean;

           do
           {
            Console.WriteLine(@"P - Print numbers
                           A - Add a number
                           M - Display mean of the numbers
                           S - Display the smallest number
                           L - Display the largest number
                           Q - Quit");
           Console.Write("Enter Your Choise: ");
           choice=char.Parse(Console.ReadLine());


              if (choice=='p'||choice=='P')
            {
               
                    if (numbers.Count==0)
                    {
                      Console.Write("The list is empty") ; 
                    }
                    else
                    {
                      for(int i=0 ; i<numbers.Count ; i++)
                        {
                            Console.WriteLine($"Items is:{numbers[i]}");
                        }  
                    }
            }

                if (choice == 'A'||choice =='a')
                {
                  Console.Write("Enter intger Number: ");
                  input=int.Parse(Console.ReadLine());
                  if (numbers.Contains(input))
                {
                    Console.WriteLine("dublication is not allowed");

                }
                else{
                  numbers.Add(input);
                  Console.WriteLine("item added") ;
                } 
                }

                if (choice == 'S'||choice == 's')
                {
                    
                        if (numbers.Count == 0)
                        {
                            Console.Write("List is Empty");
                        }

                        else 
                    {
                        min=numbers[0];
                       for(int i=1 ; i<numbers.Count ; i++)
                        {
                            if(numbers[i] < min)
                            {
                                min=numbers[i];
                            }
                        
                        }
                        Console.WriteLine($"The smallest number is {min}");
                    }
     

                }

                if (choice == 'L' || choice == 'l')
                {
                    
                        if (numbers.Count == 0)
                        {
                            Console.Write("List is Empty");
                        }

                        else 
                    {
                        max=numbers[0];
                       for(int i=1 ; i<numbers.Count ; i++)
                        {
                            if(numbers[i] > max)
                            {
                                max=numbers[i];
                            }
                            
                        }
                        Console.WriteLine($"The largest number is {max}");
                    }  
                }

                if (choice == 'M' || choice == 'm')
                {
                   if (numbers.Count == 0)
                        {
                            Console.Write("List is Empty");
                        }

                    else
                    {
                        sum=0;
                     for(int i=0 ; i<numbers.Count ; i++)
                        {
                            
                            sum+=numbers[i];

                        } 
                        mean=(double)sum/numbers.Count;
                        Console.Write($"the maen is{mean}");  
                    }     

                }
                



            }
           
           
            while (choice!='Q'&&choice!='q');
            


            }
                          


        }






    }





