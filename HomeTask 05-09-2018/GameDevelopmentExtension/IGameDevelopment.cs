using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevelopmentExtension
{
    public  interface IGameDevelopment
    {
        string ButtonName { get; set; }
        void Click(object sender, EventArgs eventArgs);
    }
}
