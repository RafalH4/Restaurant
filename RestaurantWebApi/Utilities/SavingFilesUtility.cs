using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.Utilities
{
    public static class SavingFilesUtility
    {
        public static string GetPath(IFormFile file)
        {
            
            using (var stream = System.IO.File.Create("wwwroot/images/"+ file.FileName))
            {
                file.CopyToAsync(stream);
            }
            return "https://localhost:44390/images/"+file.FileName;
        }
    }
}
