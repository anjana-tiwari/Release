using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using GSR.DAP.BO.Core;
using GSR.DAP.Shared;

namespace GSR.DAP.BO.CompanyGrid
{
    public class CGCell:CRCell
    {
        #region private members
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion


        public CGCell(int row, int col)
            : base(row, col)
        {
        }

        //public void SetValue(ValueSource type, DecimalRange value) { base.SetValue(type, value); }
        //public override void SetValue(ValueSource type, object value) { base.SetValue(type, value); }
        //public new DecimalRange GetValue(ValueSource src) { return base.GetValue(src) as DecimalRange; }
        //public new object GetValue(ValueSource src) { return base.GetValue(src); }
    }
}
