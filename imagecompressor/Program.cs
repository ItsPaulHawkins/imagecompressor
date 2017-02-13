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
            string image = Convert.ToBase64String(imageArray);
            System.IO.File.WriteAllText(@"C:/Users/PaulPc/desktop/file.txt", image);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }

}

