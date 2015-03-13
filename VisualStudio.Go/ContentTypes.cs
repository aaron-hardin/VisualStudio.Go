using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;

namespace VisualStudio.Go
{
	internal static class ContentTypes
    {
        [Export]
        [Name("go")]
        [DisplayName("go")]
        [BaseDefinition("text")]
        internal static ContentTypeDefinition GoContentTypeDefinition;

        [Export]
        [FileExtension(".go")]
        [ContentType("go")]
        internal static FileExtensionToContentTypeDefinition GoFileExtensionDefinition;
    }
}
