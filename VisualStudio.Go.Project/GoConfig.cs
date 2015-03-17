using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Project;
using Microsoft.Win32;

namespace AaronApp.VisualStudio_Go_Project
{
	/// <summary>
	/// Go Project configuration.
	/// </summary>
	class GoConfig : ProjectConfig
	{
		GoProjectNode project;

		public GoConfig(GoProjectNode project, string config)
			: base(project, config)
		{
			this.project = project;
		}

		/// <summary>
		/// Deploys the M-Files Application to a client and launches it.
		/// </summary>
		/// <param name="grfLaunch">Launch flags</param>
		/// <returns>Success code</returns>
		public override int DebugLaunch(uint grfLaunch)
		{
			// TODO: For debugging, check the grfLaunch flags.
			// The flags differ for "Launch" and "Launch with debugging".

			// TODO: move this to another project that defines build process, this should just be running it
			//// TODO: system variable?
			//const string binPath = @"C:\Go\bin";

			//string goExecutable = Path.Combine(binPath, "go.exe");

			//// TODO: path?
			//string assemblyName = project.GetAssemblyName(ConfigName);

			//// TODO: allow main.go to be changed?
			//string arguments = "build -o " + assemblyName + " main.go";

			//Process.Start(goExecutable, arguments);

			return VSConstants.S_OK;
		}
	}
}
