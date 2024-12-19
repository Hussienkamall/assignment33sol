namespace assignment_33
{
        internal class Program
        {
            static void Main(string[] args)
            {
                #region Q  1 ======== //Write a program that allows the user to enter a number then print it.


                int Number;
                Console.Write("Enter  YOR Number");
                Number = int.Parse(Console.ReadLine());
                Console.WriteLine(Number);




                #endregion

                #region Q 2--- Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen



                String Input = "123HKM";
                int Result = Convert.ToInt32(Input);





                #endregion

                #region Q 3

                //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

                double number1 = 0.4;
                double number2 = 0.5;
                double sum;
                sum = number1 + number2;
                Console.WriteLine($"Sum = {sum}"); //0.9



                #endregion

                #region Q 4-- Write C# program that Extract a substring from a given string.


                //string String = "Hello World";
                //string SubString = String.Substring(5);
                //Console.WriteLine($"Substring = {SubString}");



                #endregion

                #region Q 5

                //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
                int h = 3;
                int k = 4;

                h = k; //h=3 //k=4

                h = 7; //7

                Console.WriteLine($"h = {h}  k = {k}");

                #endregion



                #region Q 6
                //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


                int[] array1 = { 1, 2, 3 };

                int[] array2 = array1;

                array2[0] = 5;

                Console.WriteLine($" Array1 ={array1[0]}  Array2 ={array2[0]}");

                #endregion



                #region Q 7
                //Write C# program that take two string variables and print them as one variable 

                string strg1 = "Hi";
                string strg2 = "world";

                Console.WriteLine($"{strg1} {strg2}");




                #endregion

                #region Q 8
                // 8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

                double principal = 1000.0;
                double rate = 5.0;
                double time = 8.0;

                double interest = (principal * rate * time) / 100;
                Console.WriteLine($"interest = {interest}");



                #endregion

                #region Q 9
                //9 - Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

                double Weight = 90.0;
                double Height = 2.20;

                double BMI = (Weight) / (Height * Height);

                Console.WriteLine($"BMI = {BMI}");






                #endregion

                #region Q 10
                //10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result.Assume that below 10 degrees is "Too Cold", above 30 degrees is "Too Hot", and anything else is "Just Good".

                double Temp = 8.0;

                string Message = Temp < 10 ? "too cold" : Temp > 30 ? "Too Hot" : "Just Good";

                Console.WriteLine(Message);


                #endregion

                #region Q 11
                //11 - Write a program that takes the date from user and displays it in various formats using string interpolation.


                //Today’s date : 20 , 11 , 2001
                //Today's date : 20 / 11 / 2001
                //Today's date : 20 – 11 – 2001

                DateTime dateTime = DateTime.Now;

                string Fromate01 = $"{dateTime.Day} , {dateTime.Month} , {dateTime.Year}";
                string Fromate02 = $"{dateTime.Day} / {dateTime.Month} / {dateTime.Year}";
                string Fromate03 = $"{dateTime.Day} - {dateTime.Month} - {dateTime.Year}";

                Console.WriteLine(Fromate01);
                Console.WriteLine(Fromate02);
                Console.WriteLine(Fromate03);

                #endregion


                #region Q 12
                //What is the output of the following C# code?

                DateTime date = new DateTime(2024, 6, 14);
                Console.WriteLine($"The event is on {date:MM/dd/yyyy}");  // 06/14/2024

                ////a) The event is on 14/06/2024
                ////b) The event is on 2024-06-14
                ////c) The event is on 06/14/2024
                ////d) The event is on June 14, 2024

                //// Ansewr is    --> C



                #endregion


                #region Question 13
                //13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

                int Numb;
                bool flage;

                do
                {

                    Console.WriteLine("Enter Number");
                    flage = int.TryParse(Console.ReadLine(), out Number);


                } while (!flage);

                if (Number < 0)
                    Console.WriteLine("Negative");
                else if (Number > 0)
                    Console.WriteLine("Positive");
                else
                    Console.WriteLine("Zero");


                #endregion

                #region Question 14
                //14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
                int Number1;
                bool flage1;

                do
                {

                    Console.WriteLine("Enter Number1");
                    flage1 = int.TryParse(Console.ReadLine(), out Number1);


                } while (!flage1);
                int Number2;
                bool flage2;

                do
                {

                    Console.WriteLine("Enter Number2");
                    flage2 = int.TryParse(Console.ReadLine(), out Number2);


                } while (!flage2);
                int Number3;
                bool flage3;

                do
                {

                    Console.WriteLine("Enter Number3");
                    flage3 = int.TryParse(Console.ReadLine(), out Number3);


                } while (!flage3);

                if (Number1 > Number2 && Number1 > Number3)
                {
                    if (Number2 > Number3)
                        Console.WriteLine($"Max = {Number1} and Min ={Number3}");
                    else
                        Console.WriteLine($"Max = {Number1} and Min ={Number2}");

                }
                else if (Number2 > Number1 && Number2 > Number3)
                {
                    if (Number1 > Number3)
                        Console.WriteLine($"Max = {Number2} and Min ={Number3}");
                    else
                        Console.WriteLine($"Max = {Number2} and Min ={Number1}");

                }
                else if (Number3 > Number1 && Number3 > Number2)
                {
                    if (Number1 > Number2)
                        Console.WriteLine($"Max = {Number3} and Min ={Number2}");
                    else
                        Console.WriteLine($"Max = {Number3} and Min ={Number1}");
                }
                else
                    Console.WriteLine("Numbers are Equale");



                #endregion

                #region Question 14    تاني 
                //14- Write a program that allows the user to insert an integer number then check If a number is even or odd.

                //int Number;
                //bool flage;

                //do
                //{

                //    Console.WriteLine("Enter Number");
                //    flage = int.TryParse(Console.ReadLine(), out Number);


                //} while (!flage);

                //if (Number % 2 == 0)
                //    Console.WriteLine("Even");
                //else
                //    Console.WriteLine("Odd");

                #endregion

                #region Question 15
                //15- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

                char C;
                bool flage;

                do
                {
                    Console.WriteLine("Enter Character");
                    flage = char.TryParse(Console.ReadLine().ToLower(), out C);

                } while (!flage);

                switch (C)
                {
                    case 'a':
                    case 'e':
                    case 'u':
                    case 'i':
                    case 'o':
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("consonant");
                        break;


                }


                #endregion











                #region Q14
                //14-	Which of the following is the correct output for the C# code given below?
                Console.WriteLine(13 / 2 + " " + 13 % 2); //6 1

                //a)	6.5 1
                //b)	6.5 0
                //c)	6 0
                //d)	6 1
                //e)	6.5 6.5




                // Answer  is  // 6 1       --> d 



                #endregion

                #region Q15
                //What will be the output of the C# code given below?


                int num = 1, num2 = 5;


                if (!(num <= 0)) // if   it   True 
                                 //7  7
                    Console.WriteLine(++num + num2++ + " " + ++num2);
                else
                    Console.WriteLine(--num + num2-- + " " + --num2);

                //a)	5 6
                //b)	6 5
                //c)	6 6
                //d)	7 7


                // Answer --> d

                #endregion

                #region Question 17  ===17- Write a program to create a Simple Calculator.
                //

                int Number1;
                bool flage1;

                do
                {

                    Console.WriteLine("Enter Number 01");
                    flage1 = int.TryParse(Console.ReadLine(), out Number1);


                } while (!flage1);

                char OP;
                bool flage;

                do
                {

                    Console.WriteLine("Enter Operator");
                    flage = char.TryParse(Console.ReadLine(), out OP);


                } while (!flage);

                int Number2;
                bool flage2;

                do
                {

                    Console.WriteLine("Enter Number 02");
                    flage2 = int.TryParse(Console.ReadLine(), out Number2);


                } while (!flage2);

                switch (OP)
                {
                    case '+':
                        Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 + Number2}");
                        break;

                    case '-':
                        Console.WriteLine($"{Number1} {OP} {Number2}  = {Number1 - Number2}");
                        break;

                    case '*':
                        Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 * Number2}");
                        break;

                    case '/':
                        Console.WriteLine($"{Number1} {OP} {Number2} = {Number1 / Number2}"); break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }


                #endregion

                #region Question 18
                //18 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
                int Number;
                bool flage;

                do
                {

                    Console.WriteLine("Enter Number");
                    flage = int.TryParse(Console.ReadLine(), out Number);


                } while (!flage);

                for (int i = 1; i <= Number; i++)
                    Console.WriteLine(i);


                #endregion


                #region Question 19
                //19 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.

                int Number;
                bool flage;

                do
                {

                    Console.WriteLine("Enter Number");
                    flage = int.TryParse(Console.ReadLine(), out Number);


                } while (!flage);

                for (int i = 0; i <= 12; i++)
                    Console.WriteLine($"{i} * {Number} = {i * Number}");


                #endregion


                #region Question 20
                //20- Write a program that allows to user to insert number then print all even numbers between 1 to this number
                int Number;
                bool flage;

                do
                {

                    Console.WriteLine("Enter Number");
                    flage = int.TryParse(Console.ReadLine(), out Number);


                } while (!flage);
                if (Number > 0)
                {
                    for (int i = 1; i <= Number; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);

                    }
                }
                else if (Number < 0)
                {
                    for (int i = Number; i <= 1; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);

                    }

                }
                #endregion

                #region Question 21
                //21 - Write a program that takes two integers then prints the power.

                int Base;
                bool flage1;

                do
                {

                    Console.WriteLine("Enter Number Base");
                    flage1 = int.TryParse(Console.ReadLine(), out Base);


                } while (!flage1);
                int Power;
                bool flage2;
                double Result = 1;
                do
                {

                    Console.WriteLine("Enter Number Power");
                    flage2 = int.TryParse(Console.ReadLine(), out Power);


                } while (!flage2);

                if (Power > 0)
                {
                    for (int i = 0; i < Power; i++)
                    {
                        Result *= Base;
                    }
                    Console.WriteLine($"{Base} ^ {Power} = {Result}");

                }
                else if (Power < 0)
                {
                    for (int i = Power; i < 0; i++)
                    {
                        Result *= Base;
                    }
                    Console.WriteLine($"{Base} ^ {Power} = {1 / Result}");

                }
                else
                    Console.WriteLine($"{Base} ^ {Power} = 1");

                #endregion

                #region Question 22
                //22- Write a program to allow the user to enter int and print the REVERSED of it.  
                //123 -->321  


                //3*10+2 -->32


                int Number;
                bool flage;
                int Result = 0;

                do
                {

                    Console.WriteLine("Enter Number");
                    flage = int.TryParse(Console.ReadLine(), out Number);


                } while (!flage);

                while (Number > 0)
                {
                    int Remainder = Number % 10; //1
                    Result = (Result * 10) + Remainder; //321
                    Number = Number / 10; //1


                }
                Console.WriteLine($"Reversed Number = {Result}");


                #endregion


                #region Question 23
                //23 - Write a program in C# Sharp to find prime numbers within a range of numbers.
                //     Test Data:
                //                 Input starting number of range: 1
                //     Input ending number of range: 50
                //     Expected Output :
                //     The prime number between 1 and 50 are:
                //                 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47


                //int Start;
                //bool flage;


                //do
                //{

                //    Console.WriteLine("Enter Number");
                //    flage = int.TryParse(Console.ReadLine(), out Start);


                //} while (!flage);

                //int End;
                //bool flage02;


                //do
                //{

                //    Console.WriteLine("Enter Number");
                //    flage02 = int.TryParse(Console.ReadLine(), out End);


                //} while (!flage02);



                //for (int i = Start; i <= End; i++)
                //{
                //    int count = 0;
                //    for (int j = 2; j < i; j++)
                //    {
                //        if (i % j == 0)
                //        {
                //            count++;
                //            break;
                //        }


                //    }
                //    if (count == 0 & i !=1)
                //        Console.WriteLine(i);

                //}

                #endregion














            }
        }
    }


