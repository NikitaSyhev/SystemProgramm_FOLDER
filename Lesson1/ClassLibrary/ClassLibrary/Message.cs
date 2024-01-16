using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Message
    {
        public static void GetMessage(string message) 
        {
            MessageBox.Show(message);
        }

    }
}
