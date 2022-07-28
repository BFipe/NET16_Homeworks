using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
 /$$    /$$                                                                                       
| $$   | $$                                                                                       
| $$   | $$  /$$$$$$   /$$$$$$  /$$   /$$                                                         
|  $$ / $$/ /$$__  $$ /$$__  $$| $$  | $$                                                         
 \  $$ $$/ | $$$$$$$$| $$  \__/| $$  | $$                                                         
  \  $$$/  | $$_____/| $$      | $$  | $$                                                         
   \  $/   |  $$$$$$$| $$      |  $$$$$$$                                                         
    \_/     \_______/|__/       \____  $$                                                         
                                /$$  | $$                                                         
                               |  $$$$$$/                                                         
                                \______/                                                          
                               /$$                                                                
                              | $$                                                                
  /$$$$$$$  /$$$$$$   /$$$$$$ | $$                                                                
 /$$_____/ /$$__  $$ /$$__  $$| $$                                                                
| $$      | $$  \ $$| $$  \ $$| $$                                                                
| $$      | $$  | $$| $$  | $$| $$                                                                
|  $$$$$$$|  $$$$$$/|  $$$$$$/| $$                                                                
 \_______/ \______/  \______/ |__/                                                                
                                                                                                  
                                                                                                  
                                                                                                  
 /$$   /$$                                                                     /$$       /$$$$$$$ 
| $$  | $$                                                                    | $$      | $$____/ 
| $$  | $$  /$$$$$$  /$$$$$$/$$$$   /$$$$$$  /$$  /$$  /$$  /$$$$$$   /$$$$$$ | $$   /$$| $$      
| $$$$$$$$ /$$__  $$| $$_  $$_  $$ /$$__  $$| $$ | $$ | $$ /$$__  $$ /$$__  $$| $$  /$$/| $$$$$$$ 
| $$__  $$| $$  \ $$| $$ \ $$ \ $$| $$$$$$$$| $$ | $$ | $$| $$  \ $$| $$  \__/| $$$$$$/ |_____  $$
| $$  | $$| $$  | $$| $$ | $$ | $$| $$_____/| $$ | $$ | $$| $$  | $$| $$      | $$_  $$  /$$  \ $$
| $$  | $$|  $$$$$$/| $$ | $$ | $$|  $$$$$$$|  $$$$$/$$$$/|  $$$$$$/| $$      | $$ \  $$|  $$$$$$/
|__/  |__/ \______/ |__/ |__/ |__/ \_______/ \_____/\___/  \______/ |__/      |__/  \__/ \______/ 
");


            Dictionary<string, int> class_marks = new Dictionary<string, int>()
            {
               {"Anya", 10},
               {"Misha", 9},
               {"Vlad", 8},
               {"Ilya", 10 }
            };


            while (true)
            {
                int _menu, add_mark, custom_value_mark = 0;
                bool task;
                string pupil_name;
                float averange = 0;

                Console.WriteLine(@"
1 - add pupil
2 - change mark
3 - remove pupil
4 - show all
5 - averange value of marks
6 - highest mark in the class
7 - list of pupils with mark greater/equal 8
8 - list of pupils with mark smaller/equal 4
9 - execute program
");
                Console.WriteLine("Enter operation");
                do
                {
                    int.TryParse(Console.ReadLine(), out _menu);
                } while (_menu > 9 || _menu < 1);

                menu_operations menu = (menu_operations)_menu;


                switch (menu)
                {
                    #region add_mark
                    case menu_operations.add_mark:
                        Console.WriteLine("Enter pupil name");
                        pupil_name = Console.ReadLine();
                        pupil_name = pupil_name.TrimStart();
                        pupil_name = pupil_name.TrimEnd();

                        if (!class_marks.ContainsKey(pupil_name))
                        {
                            Console.WriteLine("Enter mark");
                            do
                            {
                                task = int.TryParse(Console.ReadLine(), out add_mark);
                            } while (task == false);

                            if (add_mark <= 10 && add_mark >= 1)
                            {
                                class_marks.Add(pupil_name, add_mark);
                                Console.WriteLine("Sucess!");
                            }

                            else
                            {
                                Console.WriteLine("Mark must be >= 1 and <= 10");
                            }

                        }

                        else
                        {
                            Console.WriteLine("Already existed");
                        }
                        break;
                    #endregion

                    #region change_mark
                    case menu_operations.change_mark:
                        Console.WriteLine("Enter pupil name");
                        pupil_name = Console.ReadLine();
                        pupil_name = pupil_name.TrimStart();
                        pupil_name = pupil_name.TrimEnd();

                        if (class_marks.ContainsKey(pupil_name))
                        {
                            Console.WriteLine("Enter mark");
                            do
                            {
                                task = int.TryParse(Console.ReadLine(), out add_mark);
                            } while (task == false);

                            if (add_mark <= 10 && add_mark >= 1)
                            {
                                class_marks[pupil_name] = add_mark;
                                Console.WriteLine("Sucess!");
                            }

                            else
                            {
                                Console.WriteLine("Mark must be >= 1 and <= 10");
                            }

                        }

                        else
                        {
                            Console.WriteLine("This pupil is not exist");
                        }

                        break;
                    #endregion

                    #region remove_mark
                    case menu_operations.remove_mark:
                        Console.WriteLine("Enter pupil name");
                        pupil_name = Console.ReadLine();
                        pupil_name = pupil_name.TrimStart();
                        pupil_name = pupil_name.TrimEnd();

                        if (class_marks.ContainsKey(pupil_name))
                        {
                            class_marks.Remove(pupil_name);
                            Console.WriteLine("Sucess!");
                        }

                        else
                        {
                            Console.WriteLine("This pupil is not exist");
                        }
                        break;
                    #endregion

                    #region show_all
                    case menu_operations.show_all:
                        
                        foreach (var mark in class_marks)
                        {
                            Console.WriteLine($"{mark.Key} - {mark.Value}");
                        }
                        break;
                    #endregion

                    #region mid_value_mark
                    case menu_operations.mid_value_mark:

                        foreach (var mark in class_marks)
                        {
                            averange += mark.Value;
                        }
                        
                        Console.WriteLine($"Averange value of marks in class = {averange / class_marks.Count}");
                        break;
                    #endregion

                    #region surname_list_highest_mark
                    case menu_operations.surnames_list_highest_mark:

                        foreach (var mark in class_marks)
                        {
                            if (custom_value_mark <= mark.Value)
                            {
                                custom_value_mark = mark.Value;
                            }
                        }
                        Console.WriteLine($"Highest mark in class - {custom_value_mark}");
                        Console.WriteLine($"List of the pupils with that mark:");
                        foreach (var mark in class_marks)
                        {
                            if (custom_value_mark == mark.Value)
                            {
                                Console.WriteLine($"{mark.Key}");
                            }
                        }
                        break;
                    #endregion

                    #region surnames_list_>=8
                    case menu_operations.surnames_list_morethan8:
                        Console.WriteLine("List of the pupils with marks >= 8 :");
                        foreach (var mark in class_marks)
                        {
                            if (mark.Value >= 8)
                            {
                                Console.WriteLine($"{mark.Key} - {mark.Value}");
                            }
                        }
                        break;
                    #endregion

                    #region surnames_list_<=4
                    case menu_operations.surnames_list_lessthan4:
                        Console.WriteLine("List of the pupils with marks <= 4 :");
                        foreach (var mark in class_marks)
                        {
                            if (mark.Value <= 4)
                            {
                                Console.WriteLine($"{mark.Key} - {mark.Value}");
                            }
                        }
                        break;
                    #endregion

                    #region execute
                    case menu_operations.execute:
                        Console.WriteLine("Executing process...");
                        return;
                    #endregion

                    default:
                        break;
                }
            }
        }
    }
}
