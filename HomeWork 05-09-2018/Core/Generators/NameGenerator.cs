using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfaTechnologies.Core.Generators
{
    public class NameGenerator : IGenerator
    {
        public string Generate()
        {
            StringBuilder st = new StringBuilder("user_");
            string datepart = DateTime.Now.ToString("yyyyMMddHHmmss");
            st.Append(datepart);
            return st.ToString();
        }
    }
}
