using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Project;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AaronApp.VisualStudio_Go_Project
{
	public class GoProjectNode : ProjectNode
	{
		private GoProjectPackage package;

		internal static int imageIndex;
		public override int ImageIndex
		{
			get { return imageIndex; }
		}

		private static ImageList imageList;

		static GoProjectNode()
		{
			imageList =
				Utilities.GetImageList(
					typeof(GoProjectNode).Assembly.GetManifestResourceStream(
						"AaronApp.VisualStudio_Go_Project.Resources.GoProjectNode.bmp"));
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public GoProjectNode(GoProjectPackage package)
        {
			this.package = package;

			imageIndex = this.ImageHandler.ImageList.Images.Count;

			foreach (Image img in imageList.Images)
			{
				this.ImageHandler.AddImage(img);
			}

			this.SupportsProjectDesigner = true;
        }
        public override Guid ProjectGuid
        {
            get { return GuidList.guidGoProjectFactory; }
        }
        public override string ProjectType
        {
            get { return "GoProjectType"; }
        }

        public override void AddFileFromTemplate(string source, string target)
        {
			string nameSpace = this.FileTemplateProcessor.GetFileNamespace(target, this);
			string className = Path.GetFileNameWithoutExtension(target);

			// TODO: proper replacement
			this.FileTemplateProcessor.AddReplace("$nameSpace$", nameSpace);
			this.FileTemplateProcessor.AddReplace("$className$", className);

			this.FileTemplateProcessor.UntokenFile(source, target);
			this.FileTemplateProcessor.Reset();
        }

		protected override Guid[] GetConfigurationIndependentPropertyPages()
		{
			Guid[] result = new Guid[1];
			result[0] = typeof(GeneralPropertyPage).GUID;
			return result;
		}

		protected override Guid[] GetPriorityProjectDesignerPages()
		{
			Guid[] result = new Guid[1];
			result[0] = typeof(GeneralPropertyPage).GUID;
			return result;
		}

		protected override ConfigProvider CreateConfigProvider()
		{
			return new GoConfigProvider(this);
		}
	}
}
