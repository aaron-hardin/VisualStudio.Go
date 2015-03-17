using System.Diagnostics;
using System.IO;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace VisualStudio.Go.Build
{
    public class BuildGoAssembly : Task
    {
	    public override bool Execute()
	    {
		    Log.LogMessage(MessageImportance.Low, "Packing M-Files Application.");

			// TODO: system variable?
			const string binPath = @"C:\Go\bin";

			string goExecutable = Path.Combine(binPath, "go.exe");

			// TODO: path?
			string assemblyName = OutputFile;

			// TODO: allow main.go to be changed?
			string arguments = "build -o " + assemblyName + " main.go";

			// TODO: start headless
			Process p = Process.Start(goExecutable, arguments);
		    if(p != null)
		    {
			    p.WaitForExit(3*1000);
		    }
		    else
		    {
			    return false;
		    }

		    return true;
	    }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Guid { get; set; }

		[Required]
		public ITaskItem[] SourceFiles { get; set; }

		[Required]
		public string OutputFile { get; set; }

		public string Version { get; set; }
		public ITaskItem[] References { get; set; }
		public string[] DefaultEnvironments { get; set; }
    }
}
