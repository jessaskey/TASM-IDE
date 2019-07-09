using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TASM_IDE.Containers
{
    public class Project
    {

        public int ProjectVersion = -1;
        public bool IsDirty = true;
        public List<ProjectFile> Files = new List<ProjectFile>();
        public List<Configuration> Configurations = new List<Configuration>();
        public bool ListingFileEnabled = true;
        public bool SymbolFileEnabled = true;
        public bool ExportFileEnabled = true;
        public FileOptions ListingFileOptions = new FileOptions();
        public FileOptions SymbolFileOptions = new FileOptions();
        public FileOptions ExportFileOptions = new FileOptions();
        public FileOptions ObjectFileOptions = new FileOptions();
        public ObjectFileFormat ObjectFileFormat = ObjectFileFormat.IntelHex;
        public int ObjectFillValue = 0;
        public Guid ActiveConfiguration = Guid.Empty;
        public int BuildsToRun = 1;

        public string PreBuildCommand { get; set; }
        public string PostBuildCommand { get; set; }
        public bool TimeAssembly { get; set; }
        public bool ExpandSourceInListing { get; set; }
        public bool IgnoreCaseInLabels { get; set; }
        public bool ContiguousBlockOutput { get; set; }
        public string Executable { get; set; }
        public string TableParameter { get; set; }

        //deprecated properties
        public string RunCommand { get; set; }

        public string RunDebugCommand { get; set; }

        public bool ShouldSerializeRunCommand() { return false; }
        public bool ShouldSerializeRunDebugCommand() { return false; }
    }
}
