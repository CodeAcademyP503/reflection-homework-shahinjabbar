using GameDevelopmentExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level5GameDevelopment
{
    public class Level5Game : IGameDevelopment
    {
        public string ButtonName { get; set; } = "Level5";

        public void Click(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("Level 5 succesfully completed");
        }
    }
}
