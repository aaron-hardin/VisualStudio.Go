using System.Windows.Forms;

namespace AaronApp.VisualStudio_Go_Project
{
	/// <summary>
	/// Interface for property page UI controls.
	/// </summary>
	public interface IGoPropertyPage
	{
		Control Control { get; }
		bool IsDirty { get; }
		void WriteProperties(ProjectProperties properties);
		void ReadProperties(ProjectProperties properties);
	}
}
