//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from XmlConsumer.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace OpCheck.XmlConsumer {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IXmlConsumerVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class XmlConsumerBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IXmlConsumerVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="XmlConsumerParser.xmlConsumerExpressionFile"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitXmlConsumerExpressionFile([NotNull] XmlConsumerParser.XmlConsumerExpressionFileContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="XmlConsumerParser.xmlConsumerScript"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitXmlConsumerScript([NotNull] XmlConsumerParser.XmlConsumerScriptContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="XmlConsumerParser.optionsTuple"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOptionsTuple([NotNull] XmlConsumerParser.OptionsTupleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="XmlConsumerParser.optionsList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOptionsList([NotNull] XmlConsumerParser.OptionsListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionTypeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpressionTypeOption([NotNull] XmlConsumerParser.ExpressionTypeOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>EncodingOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEncodingOption([NotNull] XmlConsumerParser.EncodingOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>PrefixOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrefixOption([NotNull] XmlConsumerParser.PrefixOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>BindingOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBindingOption([NotNull] XmlConsumerParser.BindingOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>BindingsOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBindingsOption([NotNull] XmlConsumerParser.BindingsOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ParseMethodOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParseMethodOption([NotNull] XmlConsumerParser.ParseMethodOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>AutoParseModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAutoParseModeOption([NotNull] XmlConsumerParser.AutoParseModeOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>AutoCreateModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAutoCreateModeOption([NotNull] XmlConsumerParser.AutoCreateModeOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>NullObjectTreatmentModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNullObjectTreatmentModeOption([NotNull] XmlConsumerParser.NullObjectTreatmentModeOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>CollectivityOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCollectivityOption([NotNull] XmlConsumerParser.CollectivityOptionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="XmlConsumerParser.stringLiteralsList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringLiteralsList([NotNull] XmlConsumerParser.StringLiteralsListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="XmlConsumerParser.objectMappingBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObjectMappingBlock([NotNull] XmlConsumerParser.ObjectMappingBlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="XmlConsumerParser.mappingList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMappingList([NotNull] XmlConsumerParser.MappingListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>NullMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNullMapping([NotNull] XmlConsumerParser.NullMappingContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>NullMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNullMappingWithOptions([NotNull] XmlConsumerParser.NullMappingWithOptionsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>StringMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringMapping([NotNull] XmlConsumerParser.StringMappingContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>StringMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringMappingWithOptions([NotNull] XmlConsumerParser.StringMappingWithOptionsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ObjectMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.complexMapping"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObjectMapping([NotNull] XmlConsumerParser.ObjectMappingContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ObjectMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.complexMapping"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObjectMappingWithOptions([NotNull] XmlConsumerParser.ObjectMappingWithOptionsContext context) { return VisitChildren(context); }
}
} // namespace OpCheck.XmlConsumer
