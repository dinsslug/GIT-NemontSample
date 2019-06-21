using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemont.Sample.Xml.Model.Base
{
    public class HistoryModelBase : BindingModelBase
    {
        public HistoryModelBase()
        {

        }

        public void SetValue(ref int property, int _value)
        {
            property = _value;
        }
    }
}
