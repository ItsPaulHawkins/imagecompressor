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
            if(instruction == "compress" || instruction == "Compress"){
                Console.WriteLine("Type the path of the uncompressed image.");
                string path = Console.ReadLine();
                byte[] imageArray = System.IO.File.ReadAllBytes(@path);
                string image = Convert.ToBase64String(imageArray);
                string compresseddouble;
                string compressedtripple;
                string compressedquadruple; //randomly check for quadruple redundencys

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

