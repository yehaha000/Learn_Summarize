using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson4
{
    public partial class MyForm
    {
        public void ButtonClicked()
        {
            Console.WriteLine("Button '{0}' is clicked", this.buttonText);
        }
    }
}
