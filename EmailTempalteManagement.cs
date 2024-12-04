using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCShapSession
{
    public static class EmailTempalteManagement
    {
        public static string ReplaceTemplate(Dictionary<string,string> replace,string mailTempalte)
        {
            var d = new StringBuilder(mailTempalte);

            foreach (var key in replace)
            {
                d.Replace(key.Key, key.Value);  
            }

            return d.ToString();    
        }
    }
}
