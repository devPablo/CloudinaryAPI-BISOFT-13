using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        public static Cloudinary cloudinary;

        public const string CLOUD_NAME = "cloud_name";
        public const string API_KEY = "api_key";
        public const string API_SECRET = "api_secret";
   
        static void Main(string[] args)
        {
            Account account = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            cloudinary = new Cloudinary(account);

            Console.WriteLine("[Please specify image path]");
            string imagePath = Console.ReadLine();
            uploadImage(imagePath);
            Console.ReadLine();
        }

        public static void uploadImage(string imagePath)
        {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imagePath)
                };

                var uploadResult = cloudinary.Upload(uploadParams);
                Console.WriteLine("[Image was uploaded successfully]");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }         
        }
    }
}
