using System;
using System.Collections.Generic;
using System.Text;

namespace P04.Recharge.Models
{
    public class RechargeStation
    {
        private IRechargeable rechargeable;

        public RechargeStation(IRechargeable rechargeable)
        {
            this.rechargeable = rechargeable;
        }
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}
