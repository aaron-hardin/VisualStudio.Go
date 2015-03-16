using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Project;

namespace AaronApp.VisualStudio_Go_Project
{
	/// <summary>
	/// A provider to hook our own ProjectConfig into the Application project.
	/// </summary>
	class GoConfigProvider : ConfigProvider
	{
		GoProjectNode project;

		public GoConfigProvider(GoProjectNode project)
			: base(project)
		{
			this.project = project;
		}

		protected override ProjectConfig CreateProjectConfiguration(string configName)
		{
			return new GoConfig(this.project, configName);
		}
	}
}
