﻿using Backlang.Codeanalysis.Parsing.AST;
using Loyc;
using Loyc.Syntax;
using LSP_Server.Core;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

namespace LSP_Server.CompletionScopes;

public class LetCompletionScope : ContextCompletionHandler
{
    public override Symbol[] MatchingSymbols => [CodeSymbols.Var];

    public override IEnumerable<CompletionItem> GetItems(LNode node)
    {
        //ToDo: add completion for type

        if (!node.Attrs.Contains(LNode.Id(Symbols.Mutable)))
            yield return new CompletionItem { Label = "mut", Kind = CompletionItemKind.Keyword };
    }
}