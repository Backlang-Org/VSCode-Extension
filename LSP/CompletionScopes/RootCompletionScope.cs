﻿using Loyc;
using Loyc.Syntax;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using Socordia.LSP.Core;

namespace Socordia.LSP.CompletionScopes;

public class RootCompletionScope : ContextCompletionHandler
{
    public override Symbol[] MatchingSymbols => [];

    public override IEnumerable<CompletionItem> GetItems(LNode node)
    {
        yield return new CompletionItem { Label = "using", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "import", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "unit", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "implement", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "func", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "type", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "union", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "unit", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "class", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "struct", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "interface", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "bitfield", Kind = CompletionItemKind.Keyword };
        yield return new CompletionItem { Label = "module", Kind = CompletionItemKind.Keyword };
    }
}