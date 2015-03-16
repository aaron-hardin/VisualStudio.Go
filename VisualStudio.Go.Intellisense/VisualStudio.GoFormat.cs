using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace VisualStudio.Go
{
    #region Format definition
    /// <summary>
    /// Defines an editor format for the VisualStudio.Go type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "VisualStudio.Go")]
    [Name("VisualStudio.Go")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class VisualStudio.GoFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "VisualStudio.Go" classification type
        /// </summary>
        public VisualStudio.GoFormat()
        {
            this.DisplayName = "VisualStudio.Go"; //human readable version of the name
            this.BackgroundColor = Colors.BlueViolet;
            this.TextDecorations = System.Windows.TextDecorations.Underline;
        }
    }
    #endregion //Format definition
}
