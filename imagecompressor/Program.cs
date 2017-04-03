using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace imagecompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Console.WriteLine("Type the path of the image you want to compress");
			Console.WriteLine("File will be exported to a .txt");
            string path = Console.ReadLine();
            byte[] imageArray = System.IO.File.ReadAllBytes(@path);
            string image = Convert.ToBase64String(imageArray); //creates string named image that holds the base64 string
            Console.WriteLine("Original image length: " + image.Length);
            Console.ReadLine();
            int length = image.Length;
            int one = 0;
            int two = 1;
            int three = 2;
            int four = 3;
            int compone = 4;
            int comptwo = 5;
            int compthree = 6;
            int compfour = 7;
            int redundencys = 0;
            string finalcompressed = image;
            StringBuilder sb = new StringBuilder(finalcompressed);
            sb.ToString();
            int count = 0;
            Random rnd = new Random();
            timer.Start();
            while (one < length - 6)
            {
                int rnum = rnd.Next(1, 5);
                int back = compone - one;
                if (compone < length - 6 && compone < length - 6 - count)
                {
                    if(sb[one] + sb[two] + sb[three] + sb[four] == sb[compone] + sb[comptwo] + sb[compthree] + sb[compfour] && back < 100)
                    {
                        
                        Console.WriteLine("found!");
                        sb.Remove(compone, 4);
                        sb.Insert(compone, "&" + back);
                        sb.ToString();
                        Console.WriteLine(back);
                        compone += 2;
                        comptwo += 2;
                        compthree += 2;
                        compfour += 2;
                        count += 2;
                        redundencys++;
                    }
                    else
                    {
                        compone++;
                        comptwo++;
                        compthree++;
                        compfour++;
                    }
                }else
                {

                    if(one == 100)
                    {
                        timer.Stop();
                        double seconds = timer.Elapsed.TotalSeconds;
                        int intseconds = (int)seconds;
                        int multiplythis = sb.Length / 100;
                        int lengthmultiply = multiplythis * intseconds;
                        int estimatedTime = lengthmultiply / 60;
                        Console.WriteLine("Estimated time remaining (in minutes): " + estimatedTime);
                        Console.ReadLine();
                        
                    }
                    one++;
                    two++;
                    three++;
                    four++;
                    compone = one + 4;
                    comptwo = two + 4;
                    compthree = three + 4;
                    compfour = four + 4;
                    Console.WriteLine(one + " / " + sb.Length);
                }
            }
            
            Console.WriteLine("Your original length is: " + image.Length + "Now, it's " + sb.Length + " Redundencys found: " + redundencys);
            Console.ReadLine();
            System.IO.File.WriteAllText(@"C:/users/paulpc/desktop/file.txt", sb.ToString());



        }

    }

}

