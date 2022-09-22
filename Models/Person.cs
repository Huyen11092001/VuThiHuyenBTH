using Microsoft.AspNetCore.Mvc;

namespace VuThiHuyenBTH.Models
{
    public class Person 
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public string Address { get; set; }
    }
}
