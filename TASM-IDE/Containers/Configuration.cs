using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASM_IDE.Containers
{
    public class Configuration
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RunCommand { get; set; }
        public string Arguments { get; set; }
    }
}
