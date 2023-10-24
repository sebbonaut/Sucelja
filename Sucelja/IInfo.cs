using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja
{
    internal interface IOsnovniInfo
    {
        void KratkiInfo();
        string Id { get; }
    }
    internal interface IInfo : IOsnovniInfo
    {
        void Info();
    }
}
