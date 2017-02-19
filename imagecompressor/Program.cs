using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//& for triplits
//

namespace imagecompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to compress or decompress a file?");
            string instruction = Console.ReadLine();
            if(instruction == "compress" || instruction == "Compress"){
                Console.WriteLine("Type the path of the uncompressed image.");
                string path = Console.ReadLine();
                byte[] imageArray = System.IO.File.ReadAllBytes(@path);
                string image = Convert.ToBase64String(imageArray);
                int letter = 0;
                int comparison = 1;
                int two = 2;
                int three = 3;
                int length = image.Length;
                string compressed;
                bool iscompressed = false;
                while(iscompressed == false)
                {
                    string firsttwo = "" + image[comparison] + image[letter];
                    string secondtwo = "" + image[two] + image[three];
                    if (firsttwo == secondtwo)
                    {

                    }
                }
                

            }
            else
            {
                Console.WriteLine("Please type the path of the compressed image");
                string compressedpath = Console.ReadLine();
                string compressedfile = System.IO.File.ReadAllText(@compressedpath);
                int compressedlength = compressedfile.Length;

            }
        }

    }

}

