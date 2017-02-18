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
            string instruction = Console.ReadLine();
            if (instruction == "compress" || instruction == "Compress")
            {
                Console.WriteLine("Please upload an image, and we'll compress it for you!");
                Console.WriteLine("Type the path of the image you want to compress");
                string path = Console.ReadLine();
                Console.WriteLine("Type the export path");
                string export = Console.ReadLine();
                byte[] imageArray = System.IO.File.ReadAllBytes(@path);
                string image = Convert.ToBase64String(imageArray);
                int length = image.Length;
                Console.WriteLine(length);
                Console.ReadLine();
                int count = 0;
                int secondnumber = 1;
                int thirdnumber = 2;
                string compressed = "";
                while (thirdnumber != length)
                {
                    if (image[count] == image[secondnumber] && image[count] == image[thirdnumber])
                    {
                        compressed += image[count] + "&";
                        if (count != length)
                        {
                            count += 3;
                        }
                        if (secondnumber != length)
                        {
                            secondnumber += 2;
                        }
                        if (thirdnumber != length)
                        {
                            thirdnumber += 3;
                        }

                    }
                    else
                    {
                        compressed += image[count];
                        if (count != length)
                        {
                            count++;
                        }
                        if (secondnumber != length)
                        {
                            secondnumber++;
                        }
                        if (thirdnumber != length)
                        {
                            thirdnumber++;

                        }

                    }
                }
                System.IO.File.WriteAllText(@export, compressed);

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

