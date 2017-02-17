using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASM_IDE.Containers
{
    public class CompileOutputItem
    {
        public CompileOutputType OutputType { get; set; }
        public string Description { get; set; }
        public string Filename { get; set; }
        public int LineNumber { get; set; }
    }
}
