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
            Console.WriteLine("Please upload an image, and we'll compress it for you!");
            Console.WriteLine("Type the path of the image you want to compress");
            string path = Console.ReadLine();
            byte[] imageArray = System.IO.File.ReadAllBytes(@path);
            //string image = Convert.ToBase64String(imageArray);
            string image = "AAAABBBBCC";

            int length = image.Length;
            Console.WriteLine(length);
            Console.ReadLine();
            int count = 1;
            int secondnumber = 2;
            int thirdnumber = 3;
            string compressed = "";
            while(count != length)
            {
                if (image[count] == image[secondnumber] && image[count] == image[thirdnumber])
                {
                    compressed += image[count] + "&";
                    count++;
                    secondnumber++;
                    thirdnumber++;
                }else
                {
                    compressed += image[count];
                    count++;
                    secondnumber++;
                    thirdnumber++;
                }
            }
            Console.WriteLine(compressed.Length);
            Console.ReadLine();
        }
    }

}

