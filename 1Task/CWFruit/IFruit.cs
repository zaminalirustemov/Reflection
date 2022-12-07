using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWFruit
{
    internal interface IFruit
    {
        void ShowFruit<T>(T item);
        void AddFruit(FruitBase value);
        void ShowAllFruit();
    }
}
