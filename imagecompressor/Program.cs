using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace imagecompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to compress or decompress a file?");
            string question = Console.ReadLine();
            if(question == "compress" || question == "Compress")
            {
                Console.WriteLine("Type the path of the image you would like to compress");
                string path = Console.ReadLine();
                byte[] imageArray = System.IO.File.ReadAllBytes(@path);
                string image = Convert.ToBase64String(imageArray);
                int length = image.Length;
                Console.WriteLine(length);
                Console.ReadLine();
                int one = 0;
                int two = 1;
                int three = 2;
                int four = 3;
                int compone = 4;
                int comptwo = 5;
                int compthree = 6;
                int compfour = 7;
                int backchars = compone - one;
                string finalcompressed = "";
                while(one != length)
                {
                   
                    if (image[one] + image[two] + image[three] + image[four] == image[compone] + image[comptwo] + image[compthree] + image[compfour] && image[compone] < length && image[comptwo] < length && image[compthree] < length && image[compfour] < length )
                    {
                        finalcompressed += "&" + backchars;
                        compone += 4;
                        comptwo += 3;
                        compthree += 2;
                        compfour += 1;
                    }else
                    {
                        finalcompressed += image[compone] + image[comptwo] + image[compthree] + image[compfour];
                        compone += 4;
                        comptwo += 3;
                        compthree += 2;
                        compfour += 1;
                        if (compone <= length - 6)
                        {
                            compone = one + 4;
                            comptwo = one + 3;
                            compthree = one + 2;
                            compfour = one + 1;
                                
                        }
                    }
                    
                }
                Console.WriteLine(finalcompressed.Length);
                Console.ReadLine();



            }
        }

    }

}

