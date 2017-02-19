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
                string finalcompressed = image;
                while (one != length)
                {

                    if (one < length - 6)
                    {


                        if (image[one] + image[two] + image[three] + image[four] == image[compone] + image[comptwo] + image[compthree] + image[compfour])
                        {
                            var aStringBuilder = new StringBuilder(finalcompressed);
                            aStringBuilder.Remove(compone, 4);
                            aStringBuilder.Insert(compone, "&" + backchars);
                            aStringBuilder.AppendLine(finalcompressed);
                            finalcompressed = aStringBuilder.ToString();
                            Console.ReadLine();
                            


                            Console.WriteLine("found");
                            compone += 4;
                            comptwo += 3;
                            compthree += 2;
                            compfour += 1;

                        }
                        else
                        {
                  
                            compone += 4;
                            comptwo += 3;
                            compthree += 2;
                            compfour += 1;
                            if (compone >= length - 6)
                            {
                                one += 4;
                                two += 3;
                                three += 2;
                                four += 1;
                                compone = one + 4;
                                comptwo = one + 3;
                                compthree = one + 2;
                                compfour = one + 1;



                            }

                        }
                        Console.WriteLine(one);

                    }else
                    {
                        Console.WriteLine("yeet" + finalcompressed.Length);
                    }
                }
                Console.WriteLine(finalcompressed.Length);
                Console.ReadLine();
                



            }
        }

    }

}

