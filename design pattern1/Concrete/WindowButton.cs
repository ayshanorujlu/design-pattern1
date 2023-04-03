using design_pattern1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1.Concrete
{
    public class WindowButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Windows");
            //throw new NotImplementedException();
        }

        public void Render()
        {
            Console.WriteLine("Windows");
            //throw new NotImplementedException();
        }
    }
}
