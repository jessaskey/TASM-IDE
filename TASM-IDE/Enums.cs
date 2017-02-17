using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASM_IDE
{
    public enum ObjectFileFormat
    {
        IntelHex,
        MOSFormat,
        MotorolaFormat,
        Binary,
        IntelHexWord,
    }

    public enum CompileOutputType
    {
        Information,
        Warning,
        Error
    }
}
