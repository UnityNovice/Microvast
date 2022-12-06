using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Microvast.Common.Utils
{
    public class P_TRIG
    {
        public string Last { get; private set; }
        public string CLK
        {
            set
            {
                if (Last != value)
                {
                    Q = true;
                }
                else
                {
                    Q = false;
                }
                // Q = value && !Last;//我们知道上升沿是从0变1的一瞬间，所以本次扫描为真上次为假时就产生了上升沿
                Last = value;//每个扫描周期刷新参考位
            }
        }
        public bool Q { get; private set; }
    }
}
