using System.Collections.Generic;

namespace LOC.WEB.MVC.Models
{
    public class NumeroViewModel
    {
        public int Valor { get;  set; }
        public List<int> Divisores { get;  set; }
        public List<int> DivisoresPrimos { get;  set; }
    }
}
