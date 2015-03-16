using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Utilities;

namespace VisualStudio.Go.Intellisense
{
	[Export(typeof(IVsTextViewCreationListener))]
	[Name("token completion handler")]
	[ContentType("go")]
	[TextViewRole(PredefinedTextViewRoles.Editable)]
	internal class TestCompletionHandlerProvider : IVsTextViewCreationListener
	{
		[Import]
		internal IVsEditorAdaptersFactoryService AdapterService = null;
		[Import]
		internal ICompletionBroker CompletionBroker { get; set; }
		[Import]
		internal SVsServiceProvider ServiceProvider { get; set; }

		public void VsTextViewCreated(IVsTextView textViewAdapter)
		{
			ITextView textView = AdapterService.GetWpfTextView(textViewAdapter);
			if (textView == null)
				return;

			Func<TestCompletionCommandHandler> createCommandHandler =
				() => new TestCompletionCommandHandler(textViewAdapter, textView, this);
			textView.Properties.GetOrCreateSingletonProperty(createCommandHandler);
		}
	}
}
