using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Views
{
    abstract class BaseView
    {
        public string Title { get; }

        //protected kan nås av alla som ärver av den
        protected BaseView(string title)
        {
            Title = title;

            Console.Title = title;
        }
    }
}
