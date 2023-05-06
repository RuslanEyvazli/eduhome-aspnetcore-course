using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Helpers
{
    public class Helper
    {
        public static void DeleteImg(string root, string folder, string image)
        {
            string filePath = Path.Combine(root, folder, image);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }
        public enum UserRoles
        {
            Admin,
            Members
        }
    }
}

