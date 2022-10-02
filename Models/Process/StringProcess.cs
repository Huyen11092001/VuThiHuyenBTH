using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace VuThiHuyenBTH.Models.Process
{
    public class StringProcess
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
            string result = " ";
            // viet code xu lý 
            //xóa bỏ ký tự trắng
            strInput = strInput.Trim();
            // Xóa bỏ chuỗi
            int index = strInput.IndexOf("  ");
            while (strInput.IndexOf("  ") > 0) {
                strInput = strInput.Replace("  ", " ");
            }
            result = strInput;
            return result;
        }
        public string LowerToUpper(string strInput)
        {
            string strResult = "";
            strInput = strInput.ToUpper();
            strResult = strInput;
        
            return strResult;
        }
        public string UpperToLower(string strInput)
        {
            string upto = "";
            strInput = strInput.ToLower();
            upto = strInput;

            return upto;
        }
        public string CapitalizeOneFirstCharacter(string strInput)
        {
            string capione = "";
            // lay ra ky tu dau tien cua chuoi
            string firstCharacter = strInput.Substring(0, 1).ToUpper();
            capione = firstCharacter + strInput.Substring(1);
            return capione;
        }
        public string CapitalizeFirstCharacter(string strInput)
        {
            string capifirt = "";
            //tach cac tu trong chuoi dua vao 1 mang
            string[] chuoi = strInput.Split(" ");
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] != "")
                {
                    chuoi[i] = CapitalizeOneFirstCharacter(chuoi[i]);
                }
            }
            capifirt = String.Join(" ", chuoi);
            return capifirt;
            //string FirtChar = chuoi[i].Substring(0, 1);
            //string OtherChar = chuoi[i].Substring(1);
            // chuoi[i] = FirtChar.ToUpper() + OtherChar.ToLower();
            // de tach ra moi mang( tach ra moi chu)
            //capifirt += chuoi[i] + " ";
        }
        public string RemoveVietnameseAccents( string strInput)
            {
            string remove = "";
                string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                            "đ",
                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                            "í","ì","ỉ","ĩ","ị",
                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                            "ý","ỳ","ỷ","ỹ","ỵ"};
                string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                            "d",
                            "e","e","e","e","e","e","e","e","e","e","e",
                            "i","i","i","i","i",
                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                            "u","u","u","u","u","u","u","u","u","u","u",
                            "y","y","y","y","y"};
                for (int i = 0; i < arr1.Length; i++)
                {
                    strInput = strInput.Replace(arr1[i], arr2[i]);
                    strInput = strInput.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
                }
                remove = strInput;
                return remove;
            }


        }
    }

