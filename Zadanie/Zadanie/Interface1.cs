using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    interface Interface1
    {

        /// <summary>
        /// Gets solutions of the problem
        /// </summary>
        /// <param name="lowestMultiple">the number with is the lowest multiple</param>
        /// <usecase result="2">Calc(2)</usecase>
        /// <usecase result="6">Calc(3)</usecase>
        /// <usecase result="60">Calc(5)</usecase>
        /// <usecase result="420">Calc(7)</usecase>
        /// <usecase result="2520">Calc(10)</usecase>
        /// <usecase result="232792560">Calc(20)</usecase>
        /// <returns>solution</returns>
        static int Calc(int n);
    }
}

