using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASM_IDE.Containers
{
    public class ProjectFile
    {
        public string Filename { get; set; }

        public ProjectFile()
        {

        }

        public ProjectFile(string filename)
        {
            Filename = filename;
        }
    }
}
