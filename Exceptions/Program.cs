#define dev
using System;
using System.Diagnostics;
using System.IO;
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            //----------StandardExceptions---
            try
            {
                Methods_Throw_Exceptions.SearchFile();
            }
            catch (Exception e)
            {
                throw new Exception("some message", e);
                Console.WriteLine("file exception");
            }
            Methods_Throw_Exceptions.GetElementFromArray(10);
#endif
            //----------CustomExceptions-------
            Console.WriteLine(CustomExceptions.Exponentiation(1,0));
            CustomExceptions.Get_Year(2020);
            //--------TryCatchFinally-------
#if dev
            string personal_name="1 name";
#endif
            int j = 0;
            for (int i = 0; i < personal_name.Length; i++)
            {
                try
                {
                    CustomExceptions.Get_Name(personal_name[i], i, j, personal_name);
                }
                catch (DigitException ex)
                {
                    Console.WriteLine("Personal name \"{0}\" has digit", personal_name);                    
                }
                catch (WhiteSpaceException ex)
                {
                    Console.WriteLine("Personal name \"{0}\" has white space", personal_name);                    
                }
                catch (FirstLowerException ex)
                {
                    Console.WriteLine("Personal name \"{0}\" starts with first lower letter", personal_name);
                }
                catch (LengthException ex) when (j++ < personal_name.Length)
                {
                    Console.WriteLine("Total Length of personal name \"{0}\" not achieved yet!", personal_name);
                }

                finally
                {
                    if (i == personal_name.Length - 1)
                        Console.WriteLine("Personal name has been checked succesfully!");
                }
            }                
            //-----------var---
            var a = "sads";
            Console.WriteLine(a);
            var obj = new { name = "name", age = 20 };
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.GetType());
            
        }
    }
}
