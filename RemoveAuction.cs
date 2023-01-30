using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAuction
{
    public class RemoveAuction
    {
        public bool TryRemoveAuction(int BidCount)
        {
            if (BidCount == 0)
            {
                return true;
            }
            else { return false; }
        }

    }
}
