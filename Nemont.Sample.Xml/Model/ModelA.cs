using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nemont.Sample.Xml.Model.Base;

namespace Nemont.Sample.Xml.Model
{
    public class ModelA : HistoryModelBase
    {
        private int intValue;
        public int IntValue { get { return intValue; } set { SetValue(ref intValue, value); } }
    }
}
