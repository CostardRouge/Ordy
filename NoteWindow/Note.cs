using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordy
{
    public class Note
    {
        #region Constructors / Destructors
        public Note()
        {
            // Init attributes
            this.checked_ = false;
            this.note = "Type something";
        }

        public Note(string noteval)
        {
            // Init attributes
            this.checked_ = false;
            this.note = noteval;
        }
        #endregion

        #region Methods

        #endregion

        #region Attributes
        public uint position { get; set; }
        public bool checked_ { get; set; }
        public string note { get; set; }
        #endregion
    }
}
