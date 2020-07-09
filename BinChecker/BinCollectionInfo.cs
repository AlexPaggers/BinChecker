using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinChecker
{
    public class BinCollectionInfo
    {
        public DateTime NextCollectionDate { get; }

        public DateTime PreviousCollectionDate { get; }

        public BinType BinToCollect { get; }

        public BinCollectionInfo(
            DateTime NextCollectionDate,
            DateTime PreviousCollectionDate,
            BinType BinToCollect)
        {
            this.NextCollectionDate = NextCollectionDate;
            this.PreviousCollectionDate = PreviousCollectionDate;
            this.BinToCollect = BinToCollect;
        }
    }
}
