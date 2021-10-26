using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Helper
{
    public static class Helper
    {
        //Chuyển tên sản phẩm thành metatitle
        public static string Str_Metatitle(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                string[] VietNamChar = new string[]
           {
                "aAeEoOuUiIdDyY",
                "áàạảãâấầậẩẫăắằặẳẵ",
                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "éèẹẻẽêếềệểễ",
                "ÉÈẸẺẼÊẾỀỆỂỄ",
                "óòọỏõôốồộổỗơớờợởỡ",
                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "úùụủũưứừựửữ",
                "ÚÙỤỦŨƯỨỪỰỬỮ",
                "íìịỉĩ",
                "ÍÌỊỈĨ",
                "đ",
                "Đ",
                "ýỳỵỷỹ",
                "ÝỲỴỶỸ:/"
           };
                //Thay thế và lọc dấu từng char      
                for (int i = 1; i < VietNamChar.Length; i++)
                {
                    for (int j = 0; j < VietNamChar[i].Length; j++)
                        str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
                string str1 = str.ToLower();
                string[] name = str1.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string meta = null;
                //Thêm dấu '-'
                foreach (var item in name)
                {
                    meta = meta + item + "-";
                }
                return meta;
            }
            return string.Empty;
        }

        //Thêm hình ảnh
        public static string UploadImage(IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = "";
                    var folderPath = "";
                    var url = "";

                    var nameFolderByDate = DateTime.Now.ToString("ddMMyyyy");
                    folderPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\Assets\\img\\product\\{nameFolderByDate}");
                    filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\Assets\\img\\product\\", nameFolderByDate, fileName);
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    url = $"//Assets/img/product{"//" + nameFolderByDate + "//"}{fileName}";
                    using (var fileSteam = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileSteam);
                    }

                    return url;
                }
                return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static void DeletePathOld(string filePath)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(filePath))
                {
                    var filePathFull = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{filePath}");
                    System.IO.File.Delete(filePathFull);
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
