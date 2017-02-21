using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASM_IDE.Containers
{
    public class Project
    {
        public int ProjectVersion = -1;
        public bool IsDirty = true;
        public List<ProjectFile> Files = new List<ProjectFile>();
        public bool ListingFileEnabled = true;
        public bool SymbolFileEnabled = true;
        public bool ExportFileEnabled = true;
        public FileOptions ListingFileOptions = new FileOptions();
        public FileOptions SymbolFileOptions = new FileOptions();
        public FileOptions ExportFileOptions = new FileOptions();
        public FileOptions ObjectFileOptions = new FileOptions();
        public ObjectFileFormat ObjectFileFormat = ObjectFileFormat.IntelHex;
        public int ObjectFillValue = 0;

        public string PreBuildCommand { get; set; }
        public string PostBuildCommand { get; set; }
        public string RunCommand { get; set; }
        public bool TimeAssembly { get; set; }
        public bool ExpandSourceInListing { get; set; }
        public bool IgnoreCaseInLabels { get; set; }
        public string Executable { get; set; }
        public string TableParameter { get; set; }
    }
}
