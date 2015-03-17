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

			string assemblyName = project.GetOutputAssembly(ConfigName);

			Process.Start(assemblyName);

			return VSConstants.S_OK;
		}
	}
}
