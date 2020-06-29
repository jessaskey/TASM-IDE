using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASM_IDE
{
    public enum ObjectFileFormat : int
    {
        IntelHex,
        MOSFormat,
        MotorolaFormat,
        Binary,
        IntelHexWord,
    }

    public enum CompileOutputType : int
    {
        Information,
        Warning,
        Error
    }

    public enum MainTab : int
    {
        Files,
        Options,
        Configuration,
        Output
    }

    public enum OutputTab : int
    {
        Formatted,
        Raw
    }
}
