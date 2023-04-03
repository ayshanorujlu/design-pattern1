using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1.Abstract
{
    public abstract class Dialog
    {
        public virtual void Render()
        {
            Console.WriteLine("R");
        }
        public abstract IButton CreateButton();
    }
}
