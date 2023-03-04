using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Enums
{
    public interface IMission 
    {
        string CodeName { get; }    

        State State { get; }

        void CompleteMission();

    }
}
