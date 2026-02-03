using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Linq;
using System.Diagnostics;


class Logic
{
    Random gandon = new Random();

    public Array Create_Parol()
    {
        int[] parol = new int[3];

        parol[0] = gandon.Next(9);
        parol[1] = gandon.Next(9);
        parol[2] = gandon.Next(9);

        //Console.WriteLine(parol[0]);
        //Console.WriteLine(parol[1]);
        //Console.WriteLine(parol[2]);

        return parol;
    }

    public void Otgadka(Array array)
    {
        Array readqq = array;


        int[] GOTOVO = new int[] { 1, 2, 3 };
        GOTOVO[0] = (int)array.GetValue(0);
        GOTOVO[1] = (int)array.GetValue(1);
        GOTOVO[2] = (int)array.GetValue(2);



        int[] temp_nums = new int[3];

        temp_nums[0] = 0;
        temp_nums[1] = 0;
        temp_nums[2] = 0;

        for (int w = 0; w <= 9; w++)
        {
            if (!Enumerable.SequenceEqual(temp_nums, GOTOVO))
            {
                temp_nums[0] = w;
                for (int q = 0; q <= 9; q++)
                {
                    if (!Enumerable.SequenceEqual(temp_nums, GOTOVO))
                    {
                        temp_nums[1] = q;
                        for (int i = 0; i <= 9; i++)
                        {
                            if (!Enumerable.SequenceEqual(temp_nums, GOTOVO))
                            {
                                temp_nums[2] = i;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Find your pass, that pass: {temp_nums[0]}" + "," + $"{temp_nums[1]}" + "," + $"{temp_nums[2]}");
                break;
            }
        }
    }

    public Array Debug_Create_Parol()
    {
        int[] parol = new int[3];

        parol[0] = gandon.Next(9);
        parol[1] = gandon.Next(9);
        parol[2] = gandon.Next(9);

        Console.WriteLine("Program generate new pass for you");

        Console.WriteLine($"First num:{parol[0]}");
        Console.WriteLine($"Second num:{parol[1]}");
        Console.WriteLine($"Third num:{parol[2]}");

        return parol;
    }

    public void Debug_Otgadka(Array array)
    {
        Array readqq = array;


        int[] GOTOVO = new int[] { 1, 2, 3 };
        GOTOVO[0] = (int)array.GetValue(0);
        GOTOVO[1] = (int)array.GetValue(1);
        GOTOVO[2] = (int)array.GetValue(2);



        int[] temp_nums = new int[3];

        temp_nums[0] = 0;
        temp_nums[1] = 0;
        temp_nums[2] = 0;

        for (int w = 0; w <= 9; w++)
        {
            if (!Enumerable.SequenceEqual(temp_nums, GOTOVO))
            {
                temp_nums[0] = w;
                Console.Write(w);
                Console.Write(" ");
                for (int q = 0; q <= 9; q++)
                {
                    if (!Enumerable.SequenceEqual(temp_nums, GOTOVO))
                    {
                        temp_nums[1] = q;
                        Console.Write(q);
                        Console.Write(" ");
                        for (int i = 0; i <= 9; i++)
                        {
                            if (!Enumerable.SequenceEqual(temp_nums, GOTOVO))
                            {
                                temp_nums[2] = i;
                                Console.Write(i);
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.WriteLine("break 3lvl");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("break 2lvl");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("break 1lvl");
                Console.WriteLine($"Im find your password, that pass: {temp_nums[0]}" + "," + $"{temp_nums[1]}" + "," + $"{temp_nums[2]}");
                break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logic logic = new Logic();
        Console.WriteLine("Hack 3 simbyols pass:");

        logic.Otgadka(logic.Create_Parol());
        Console.WriteLine("Debug for watch how create pass -- Debug");
        string msg = Console.ReadLine();

        switch (msg)
        {
            case "Debug":
                logic.Debug_Otgadka(logic.Debug_Create_Parol());
                break;
            default:
                break;
        }


    }
}