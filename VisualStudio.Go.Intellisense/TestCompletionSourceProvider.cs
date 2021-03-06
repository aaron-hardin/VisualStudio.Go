﻿using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.Utilities;

namespace VisualStudio.Go.Intellisense
{
	[Export(typeof(ICompletionSourceProvider))]
	[ContentType("go")]
	[Order(Before = "default")]
	[Name("token completion")]
	internal class TestCompletionSourceProvider : ICompletionSourceProvider
	{
		[Import]
		internal ITextStructureNavigatorSelectorService NavigatorService { get; set; }

		public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
		{
			return new TestCompletionSource(this, textBuffer);
		}
	}
}
