using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cutTheSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //путь

            string inputpath = "D:\\SolutionsForSpaceApp\\2012\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2012\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.Create);
            fsout.Close();


            string lineWithTwoNumbers;
            using (var reader = new StreamReader(inputpath))
            {
                lineWithTwoNumbers = reader.ReadLine();  // записываем в переменную
            }
            //запись из строки в массив строк с разделением
            string[] secondLineToInt = lineWithTwoNumbers.Split(' ');

            int[] A;
            A = new int[2];
            int count = 0;
            foreach (var s in secondLineToInt)
            {
                A[count] = Convert.ToInt32(s);
                count++;
            }
            int a1, a2, b1, b2;
            a1 = A[0];
            a2 = A[1];


            lineWithTwoNumbers ="";
            using (var reader = new StreamReader(inputpath))
            {
                reader.ReadLine();
                lineWithTwoNumbers = reader.ReadLine();  // записываем в переменную
            }
            //запись из строки в массив строк с разделением
            secondLineToInt = lineWithTwoNumbers.Split(' ');

            count = 0;
            foreach (var s in secondLineToInt)
            {
                A[count] = Convert.ToInt32(s);
                count++;
            }
            b1 = A[0];
            b2 = A[1];
            #endregion



            if(   (((a1 + a2) == b1) & (b1 == b2)) | (((a1 + b2) == b1)&(b1 == a2)) | (((b1 + a2) == a1)&(a1 == b2)) | (((b1 + b2) == a1)&(a1 == a2)))
            {
                File.WriteAllText(outputpath,"Yes");
            }
            else
            {
                File.WriteAllText(outputpath, "No");
            }
        }
    }
}
