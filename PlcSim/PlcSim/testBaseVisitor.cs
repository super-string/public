//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/download/study\test.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ItestVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class testBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ItestVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.input"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInput([NotNull] testParser.InputContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>mnemonic_inst</c>
	/// labeled alternative in <see cref="testParser.mnemonic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMnemonic_inst([NotNull] testParser.Mnemonic_instContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>mnemonic_instonly</c>
	/// labeled alternative in <see cref="testParser.mnemonic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMnemonic_instonly([NotNull] testParser.Mnemonic_instonlyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>mnemonic_comment</c>
	/// labeled alternative in <see cref="testParser.mnemonic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMnemonic_comment([NotNull] testParser.Mnemonic_commentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.inst"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInst([NotNull] testParser.InstContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_indirect</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_indirect([NotNull] testParser.Ope_indirectContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_indexref</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_indexref([NotNull] testParser.Ope_indexrefContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_device</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_device([NotNull] testParser.Ope_deviceContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_local</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_local([NotNull] testParser.Ope_localContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_tm</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_tm([NotNull] testParser.Ope_tmContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_direct</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_direct([NotNull] testParser.Ope_directContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_unknown</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_unknown([NotNull] testParser.Ope_unknownContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ope_literal</c>
	/// labeled alternative in <see cref="testParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpe_literal([NotNull] testParser.Ope_literalContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.device"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDevice([NotNull] testParser.DeviceContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>dv_real</c>
	/// labeled alternative in <see cref="testParser.direct_value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDv_real([NotNull] testParser.Dv_realContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>dv_dec</c>
	/// labeled alternative in <see cref="testParser.direct_value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDv_dec([NotNull] testParser.Dv_decContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>dev_exp</c>
	/// labeled alternative in <see cref="testParser.direct_value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDev_exp([NotNull] testParser.Dev_expContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.local"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLocal([NotNull] testParser.LocalContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.tm"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTm([NotNull] testParser.TmContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.indirect"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIndirect([NotNull] testParser.IndirectContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.index_ref"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIndex_ref([NotNull] testParser.Index_refContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="testParser.comment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComment([NotNull] testParser.CommentContext context) { return VisitChildren(context); }
}
