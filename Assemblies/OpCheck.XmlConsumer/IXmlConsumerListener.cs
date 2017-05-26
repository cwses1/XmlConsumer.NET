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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="XmlConsumerParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IXmlConsumerListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="XmlConsumerParser.xmlConsumerExpressionFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlConsumerExpressionFile([NotNull] XmlConsumerParser.XmlConsumerExpressionFileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XmlConsumerParser.xmlConsumerExpressionFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlConsumerExpressionFile([NotNull] XmlConsumerParser.XmlConsumerExpressionFileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XmlConsumerParser.xmlConsumerScript"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlConsumerScript([NotNull] XmlConsumerParser.XmlConsumerScriptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XmlConsumerParser.xmlConsumerScript"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlConsumerScript([NotNull] XmlConsumerParser.XmlConsumerScriptContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XmlConsumerParser.optionsTuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionsTuple([NotNull] XmlConsumerParser.OptionsTupleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XmlConsumerParser.optionsTuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionsTuple([NotNull] XmlConsumerParser.OptionsTupleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XmlConsumerParser.optionsList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionsList([NotNull] XmlConsumerParser.OptionsListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XmlConsumerParser.optionsList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionsList([NotNull] XmlConsumerParser.OptionsListContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionTypeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionTypeOption([NotNull] XmlConsumerParser.ExpressionTypeOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionTypeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionTypeOption([NotNull] XmlConsumerParser.ExpressionTypeOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>EncodingOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEncodingOption([NotNull] XmlConsumerParser.EncodingOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EncodingOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEncodingOption([NotNull] XmlConsumerParser.EncodingOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PrefixOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefixOption([NotNull] XmlConsumerParser.PrefixOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PrefixOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefixOption([NotNull] XmlConsumerParser.PrefixOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BindingOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBindingOption([NotNull] XmlConsumerParser.BindingOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BindingOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBindingOption([NotNull] XmlConsumerParser.BindingOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BindingsOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBindingsOption([NotNull] XmlConsumerParser.BindingsOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BindingsOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBindingsOption([NotNull] XmlConsumerParser.BindingsOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParseMethodOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParseMethodOption([NotNull] XmlConsumerParser.ParseMethodOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParseMethodOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParseMethodOption([NotNull] XmlConsumerParser.ParseMethodOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AutoParseModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAutoParseModeOption([NotNull] XmlConsumerParser.AutoParseModeOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AutoParseModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAutoParseModeOption([NotNull] XmlConsumerParser.AutoParseModeOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AutoCreateModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAutoCreateModeOption([NotNull] XmlConsumerParser.AutoCreateModeOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AutoCreateModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAutoCreateModeOption([NotNull] XmlConsumerParser.AutoCreateModeOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NullObjectTreatmentModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullObjectTreatmentModeOption([NotNull] XmlConsumerParser.NullObjectTreatmentModeOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NullObjectTreatmentModeOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullObjectTreatmentModeOption([NotNull] XmlConsumerParser.NullObjectTreatmentModeOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CollectivityOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollectivityOption([NotNull] XmlConsumerParser.CollectivityOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CollectivityOption</c>
	/// labeled alternative in <see cref="XmlConsumerParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollectivityOption([NotNull] XmlConsumerParser.CollectivityOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XmlConsumerParser.stringLiteralsList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringLiteralsList([NotNull] XmlConsumerParser.StringLiteralsListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XmlConsumerParser.stringLiteralsList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringLiteralsList([NotNull] XmlConsumerParser.StringLiteralsListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XmlConsumerParser.objectMappingBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectMappingBlock([NotNull] XmlConsumerParser.ObjectMappingBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XmlConsumerParser.objectMappingBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectMappingBlock([NotNull] XmlConsumerParser.ObjectMappingBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="XmlConsumerParser.mappingList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMappingList([NotNull] XmlConsumerParser.MappingListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="XmlConsumerParser.mappingList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMappingList([NotNull] XmlConsumerParser.MappingListContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NullMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullMapping([NotNull] XmlConsumerParser.NullMappingContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NullMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullMapping([NotNull] XmlConsumerParser.NullMappingContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NullMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullMappingWithOptions([NotNull] XmlConsumerParser.NullMappingWithOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NullMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullMappingWithOptions([NotNull] XmlConsumerParser.NullMappingWithOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>StringMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringMapping([NotNull] XmlConsumerParser.StringMappingContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StringMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringMapping([NotNull] XmlConsumerParser.StringMappingContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>StringMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringMappingWithOptions([NotNull] XmlConsumerParser.StringMappingWithOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StringMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.simpleMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringMappingWithOptions([NotNull] XmlConsumerParser.StringMappingWithOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ObjectMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.complexMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectMapping([NotNull] XmlConsumerParser.ObjectMappingContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ObjectMapping</c>
	/// labeled alternative in <see cref="XmlConsumerParser.complexMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectMapping([NotNull] XmlConsumerParser.ObjectMappingContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ObjectMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.complexMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectMappingWithOptions([NotNull] XmlConsumerParser.ObjectMappingWithOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ObjectMappingWithOptions</c>
	/// labeled alternative in <see cref="XmlConsumerParser.complexMapping"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectMappingWithOptions([NotNull] XmlConsumerParser.ObjectMappingWithOptionsContext context);
}
} // namespace OpCheck.XmlConsumer
