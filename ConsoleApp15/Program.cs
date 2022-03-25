using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //string variable = "salam,  dunya";


            ////Console.WriteLine(variable.Replace(" ",""));
            //var result = variable.Split(" ");
            //Console.WriteLine("words");
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //result =Array.Clear(result,)
            
            string text = "119 2019-02-20 09:26:301 0 1 0";
            string[] result = text.Replace('\t', ' ').text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            #endregion
            #region Task2
            //string word = "Bp202";
            //Console.WriteLine(DigitUpperLower(word));

            #endregion
            #region Task3       
            //Console.WriteLine("metin daxil edin:");
            //string text = Console.ReadLine();
            //Console.WriteLine(GetFirstWord(text));

            #endregion
            #region Task4

            #endregion
            #region Task6-7
            //Console.WriteLine("Saatliq maasi daxil edin:");
            //double payment = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ay erzinde islediyi saati daxil edin:");
            //int hours = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("iscinin adi:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Iscinin soyadi:");
            //string surname = Console.ReadLine();

            //Console.WriteLine("Iscinin yasini daxil edin:");
            //byte age = Convert.ToByte(Console.ReadLine());
            //if(age <18)
            //    Console.WriteLine("yas 18-den boyuk olmalidir!");
            //Worker workers = new Worker(payment, name, surname, age);
            //Console.WriteLine(workers.getSalaryMonthly());

            #endregion
        }
        //Task 3
        static string GetFirstWord(string text)
        {
            string firstName;
            firstName = text.Substring(0, text.IndexOf(" "));
            return firstName;
        }
            #region Task 5
        static void AddArray(ref int[] arr, int value)
        {

            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length] = value;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        //Task 2
        static bool DigitUpperLower(string text)
        {
            bool check = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))

                    if (char.IsLower(text[i]))

                        if (char.IsUpper(text[i])) ;
            }
            return check;
        }
        //Task 4
        static bool TwoUpperLetterWord(string text)
        {
            bool check = true;

            do 
                text.Split(" ")
                    
                    
                    

                    
            return check;
        }
    }
}

