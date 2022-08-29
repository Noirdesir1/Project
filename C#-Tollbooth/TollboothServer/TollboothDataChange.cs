using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollboothServer
{
    public class TollboothDataChange
    {
        public enum ChangeType { ADD, UPDATE, REMOVE };
        public ChangeType Change { get; }
        public Tollbooth Tollbooth { get; }

        public TollboothDataChange(ChangeType Change, Tollbooth Tollbooth)
        {
            this.Change = Change;
            this.Tollbooth = Tollbooth;
        }
    }
}
