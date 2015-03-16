using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Project;
using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

namespace AaronApp.VisualStudio_Go_Project
{
	[Guid(GuidList.guidGoProjectFactoryString)]
	internal class GoProjectFactory : ProjectFactory
	{
		protected override ProjectNode CreateProject()
		{
			GoProjectNode project = new GoProjectNode(this.package);

			project.SetSite((IOleServiceProvider)((IServiceProvider)this.package).GetService(typeof(IOleServiceProvider)));
			return project;
		}

		private GoProjectPackage package;

		public GoProjectFactory(GoProjectPackage package)
			: base(package)
		{
			this.package = package;
		}
	}
}
