using Anthera.API.Extension;
using Microsoft.AspNetCore.Http;
using System;

namespace Anthera.API.misc
{
    public static class AntheraMisc
    {
        public static void ValidateFile(IFormFile file)
        {
            if (file.FileName.Contains(".asp", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".exe", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".bat", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".py", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".msi", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".vbs", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".deb", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".sh", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".sql", StringComparison.OrdinalIgnoreCase) ||
                file.FileName.Contains(".php", StringComparison.OrdinalIgnoreCase))
            {
                throw new AntheraException().Throw("Sorry, you image name contains a unwanted file extension(s).");
            }

            //check for file size.
            if (file.Length > AntheraConstant.Requests.User.FileSize)
            {
                throw new AntheraException().Throw("Sorry, image must be less than 5mb.");
            }

            if (file.FileName.Length > 180)
            {
                throw new Exception("Sorry, image name must be less than 180 characters.");
            }
        }

        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
    }
}
