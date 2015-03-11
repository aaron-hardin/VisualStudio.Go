using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace VisualStudio.Go
{
    internal static class VisualStudio.GoClassificationDefinition
    {
        /// <summary>
        /// Defines the "VisualStudio.Go" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("VisualStudio.Go")]
        internal static ClassificationTypeDefinition VisualStudio.GoType = null;
    }
}
