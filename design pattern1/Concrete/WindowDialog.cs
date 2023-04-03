using design_pattern1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1.Concrete
{
    public class WindowDialog : Dialog
    {
        public override void Render()
        {
            Console.WriteLine("WindowsDialog");
        }
        public override IButton CreateButton()
        {
            return new WindowButton();
        }
    }
}
