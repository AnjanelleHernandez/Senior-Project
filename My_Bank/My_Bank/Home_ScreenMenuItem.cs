using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank
{

    public class Home_ScreenMenuItem
    {
        public Home_ScreenMenuItem()
        {
            TargetType = typeof(Home_ScreenDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}