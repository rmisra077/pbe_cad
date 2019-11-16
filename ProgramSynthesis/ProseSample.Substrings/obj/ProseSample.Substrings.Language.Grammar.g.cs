// This file is auto-generated from the grammar "ProseSample.Substrings" using dslc.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// Please change "ProseSample.Substrings.grammar" instead.

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Microsoft.ProgramSynthesis;
using Microsoft.ProgramSynthesis.AST;
using Microsoft.ProgramSynthesis.Features;
using Microsoft.ProgramSynthesis.Learning;
using Microsoft.ProgramSynthesis.Rules;
using Microsoft.ProgramSynthesis.Rules.Concepts;
using Microsoft.ProgramSynthesis.Utils;
using Microsoft.ProgramSynthesis.VersionSpace;
using static Microsoft.ProgramSynthesis.Rules.OperatorRule;
using static Microsoft.ProgramSynthesis.Learning.WitnessFunction;
using static Microsoft.ProgramSynthesis.Utils.CSharpUtils;

using System.Text.RegularExpressions;
using Microsoft.ProgramSynthesis.DslLibrary;
using ProseSample.Substrings;

#pragma warning disable 1591


namespace ProseSample.Substrings {
    public static class Language {
        // Intentionally implemented with a backing field to avoid race conditions in static field initialization.
        private static readonly Lazy<Grammar> _grammar =
            new Lazy<Grammar>(Initialize, LazyThreadSafetyMode.ExecutionAndPublication);
        public static Grammar Grammar => _grammar.Value;

        public static ProseSample.Substrings.Build.GrammarBuilders Build =>
            ProseSample.Substrings.Build.GrammarBuilders.Instance(Grammar);

        private static readonly Assembly MPSAssembly = typeof(GrammarRule).GetTypeInfo().Assembly;
        private const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        private static Grammar Initialize() {
{            var _Microsoft_ProgramSynthesis_Grammar_1 =
                (Microsoft.ProgramSynthesis.Grammar)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Grammar>();
            var _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1 = new System.Collections.Generic.Dictionary<Microsoft.ProgramSynthesis.Symbol, System.Collections.Generic.List<Microsoft.ProgramSynthesis.Rules.GrammarRule>>();
            var _Microsoft_ProgramSynthesis_Symbol_1 =
                (Microsoft.ProgramSynthesis.Symbol)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Symbol>();
            var _Microsoft_ProgramSynthesis_Utils_ResolvedType_1 =
                (Microsoft.ProgramSynthesis.Utils.ResolvedType)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.ResolvedType>();
            var _System_RuntimeType_1 = typeof(Microsoft.ProgramSynthesis.DslLibrary.StringRegion);
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__1 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1 =
                (Microsoft.ProgramSynthesis.Rules.BlackBoxRule)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.BlackBoxRule>();
            Microsoft.ProgramSynthesis.Utils.MethodReference _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__1 =
                Microsoft.ProgramSynthesis.Utils.MethodReference.WithoutReference<Microsoft.ProgramSynthesis.Rules.OperatorRule.OperatorSemantics>
                ((object[] arg0) =>
                { object value = ProseSample.Substrings.Semantics.SubStr((Microsoft.ProgramSynthesis.DslLibrary.StringRegion) arg0[0], (System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>) arg0[1]);
                return (object) value; });
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____1 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 2);
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__1 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__2 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__1 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 2).ToList();
            var _Microsoft_ProgramSynthesis_Symbol_2 =
                (Microsoft.ProgramSynthesis.Symbol)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Symbol>();
            var _Microsoft_ProgramSynthesis_Symbol_3 =
                (Microsoft.ProgramSynthesis.Symbol)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Symbol>();
            var _Microsoft_ProgramSynthesis_Utils_ResolvedType_2 =
                (Microsoft.ProgramSynthesis.Utils.ResolvedType)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.ResolvedType>();
            var _System_RuntimeType_2 = typeof(System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>);
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___1 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _Microsoft_ProgramSynthesis_Symbol_4 =
                (Microsoft.ProgramSynthesis.Symbol)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Symbol>();
            var _Microsoft_ProgramSynthesis_Utils_ResolvedType_3 =
                (Microsoft.ProgramSynthesis.Utils.ResolvedType)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.ResolvedType>();
            var _System_RuntimeType_3 = typeof(System.Nullable<uint>);
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__2 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 2).ToList();
            var _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2 =
                (Microsoft.ProgramSynthesis.Rules.BlackBoxRule)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.BlackBoxRule>();
            Microsoft.ProgramSynthesis.Utils.MethodReference _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__2 =
                Microsoft.ProgramSynthesis.Utils.MethodReference.WithoutReference<Microsoft.ProgramSynthesis.Rules.OperatorRule.OperatorSemantics>
                ((object[] arg0) =>
                { object value = ProseSample.Substrings.Semantics.AbsPos((Microsoft.ProgramSynthesis.DslLibrary.StringRegion) arg0[0], (int) arg0[1]);
                return (object) value; });
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____2 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 2);
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__3 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__4 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__2 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 2).ToList();
            var _Microsoft_ProgramSynthesis_Symbol_5 =
                (Microsoft.ProgramSynthesis.Symbol)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Symbol>();
            var _Microsoft_ProgramSynthesis_Utils_ResolvedType_4 =
                (Microsoft.ProgramSynthesis.Utils.ResolvedType)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.ResolvedType>();
            var _System_RuntimeType_4 = typeof(int);
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___2 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3 =
                (Microsoft.ProgramSynthesis.Rules.BlackBoxRule)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.BlackBoxRule>();
            Microsoft.ProgramSynthesis.Utils.MethodReference _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__3 =
                Microsoft.ProgramSynthesis.Utils.MethodReference.WithoutReference<Microsoft.ProgramSynthesis.Rules.OperatorRule.OperatorSemantics>
                ((object[] arg0) =>
                { object value = ProseSample.Substrings.Semantics.RegPos((Microsoft.ProgramSynthesis.DslLibrary.StringRegion) arg0[0], (System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>) arg0[1], (int) arg0[2]);
                return (object) value; });
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____3 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 3);
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__5 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__6 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__7 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__3 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 3).ToList();
            var _Microsoft_ProgramSynthesis_Symbol_6 =
                (Microsoft.ProgramSynthesis.Symbol)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Symbol>();
            var _Microsoft_ProgramSynthesis_Utils_ResolvedType_5 =
                (Microsoft.ProgramSynthesis.Utils.ResolvedType)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.ResolvedType>();
            var _System_RuntimeType_5 = typeof(System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>);
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___3 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__3 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1 =
                (Microsoft.ProgramSynthesis.Rules.Concepts.Pair)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.Concepts.Pair>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__1 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage), 2).ToList();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1 =
                (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__8 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_1 = Microsoft.ProgramSynthesis.Rules.Concepts.ParameterUsage.FillIn;
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2 =
                (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__9 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_2 = Microsoft.ProgramSynthesis.Rules.Concepts.ParameterUsage.FillIn;
            Microsoft.ProgramSynthesis.Utils.MethodReference _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__4 = null;
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____4 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 2);
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__10 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__11 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__4 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 2).ToList();
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___4 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _Microsoft_ProgramSynthesis_Symbol_7 =
                (Microsoft.ProgramSynthesis.Symbol)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Symbol>();
            var _Microsoft_ProgramSynthesis_Utils_ResolvedType_6 =
                (Microsoft.ProgramSynthesis.Utils.ResolvedType)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.ResolvedType>();
            var _System_RuntimeType_6 = typeof(Microsoft.ProgramSynthesis.DslLibrary.RegularExpression);
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__4 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _Microsoft_ProgramSynthesis_Rules_TerminalRule_1 =
                (Microsoft.ProgramSynthesis.Rules.TerminalRule)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.TerminalRule>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____5 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 0);
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__5 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 0).ToList();
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___5 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__5 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2 =
                (Microsoft.ProgramSynthesis.Rules.Concepts.Pair)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.Concepts.Pair>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__2 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage), 2).ToList();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3 =
                (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__12 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_3 = Microsoft.ProgramSynthesis.Rules.Concepts.ParameterUsage.FillIn;
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4 =
                (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__13 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_4 = Microsoft.ProgramSynthesis.Rules.Concepts.ParameterUsage.FillIn;
            Microsoft.ProgramSynthesis.Utils.MethodReference _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__5 = null;
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____6 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 2);
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__14 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int__15 =
                (Microsoft.ProgramSynthesis.Utils.Optional<int>)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Utils.Optional<int>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__6 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 2).ToList();
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___6 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__6 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _Microsoft_ProgramSynthesis_Rules_TerminalRule_2 =
                (Microsoft.ProgramSynthesis.Rules.TerminalRule)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.TerminalRule>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____7 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 0);
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__7 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 0).ToList();
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___7 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__7 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _Microsoft_ProgramSynthesis_Rules_TerminalRule_3 =
                (Microsoft.ProgramSynthesis.Rules.TerminalRule)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Rules.TerminalRule>();
            var _Microsoft_ProgramSynthesis_Utils_Optional_int____8 = (Microsoft.ProgramSynthesis.Utils.Optional<int>[]) Array.CreateInstance(typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>), 0);
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__8 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Symbol), 0).ToList();
            var _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___8 = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.MultiValueDictionary<System.Type, Microsoft.ProgramSynthesis.Learning.WitnessFunction>>();
            var _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2 = new System.Collections.Generic.Dictionary<Microsoft.ProgramSynthesis.Symbol, System.Collections.Generic.List<Microsoft.ProgramSynthesis.Rules.GrammarRule>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__8 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__9 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__10 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 2).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__11 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__12 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__13 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__14 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3 = new System.Collections.Generic.Dictionary<Microsoft.ProgramSynthesis.Symbol, System.Collections.Generic.List<Microsoft.ProgramSynthesis.Rules.GrammarRule>>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__15 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 3).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__16 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__17 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 2).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__18 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 2).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__19 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 1).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__20 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 2).ToList();
            var _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1 = new System.Collections.Generic.Dictionary<string, Microsoft.ProgramSynthesis.Rules.GrammarRule>();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Rules.GrammarRule), 8).ToList();
            var _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Features_FeatureInfo__1 = Enumerable.Repeat(default(Microsoft.ProgramSynthesis.Features.FeatureInfo), 1).ToList();
            var _Microsoft_ProgramSynthesis_Features_FeatureInfo_1 =
                (Microsoft.ProgramSynthesis.Features.FeatureInfo)
                GetUninitializedObject<Microsoft.ProgramSynthesis.Features.FeatureInfo>();
            var _System_RuntimeType_7 = typeof(double);
            var _System_Collections_Generic_List_System_Type__1 = Enumerable.Repeat(default(System.Type), 1).ToList();
            var _System_RuntimeType_8 = typeof(ProseSample.Substrings.RankingScore);
            var _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Grammar__1 = new System.Collections.Generic.Dictionary<string, Microsoft.ProgramSynthesis.Grammar>();
            var _System_Collections_Generic_List_System_Type__2 = Enumerable.Repeat(default(System.Type), 1).ToList();
            var _System_RuntimeType_9 = typeof(ProseSample.Substrings.Semantics);
            var _System_Collections_Generic_List_System_Type__3 = Enumerable.Repeat(default(System.Type), 1).ToList();
            var _System_RuntimeType_10 = typeof(ProseSample.Substrings.WitnessFunctions);
            var _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1 = new System.Collections.Generic.Dictionary<string, Microsoft.ProgramSynthesis.Symbol>();
{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__15 = _Microsoft_ProgramSynthesis_Utils_Optional_int__15;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__15, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__15, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__15 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__15;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__14 = _Microsoft_ProgramSynthesis_Utils_Optional_int__14;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__14, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__14, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__14 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__14;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__13 = _Microsoft_ProgramSynthesis_Utils_Optional_int__13;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__13, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__13, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__13 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__13;
}{            object _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4 = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4;
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4, _Microsoft_ProgramSynthesis_Utils_Optional_int__13);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("DSLParameter", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4, _Microsoft_ProgramSynthesis_Symbol_7);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("ConceptIndex", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4, 1);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("Usage", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4, _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_4);
            _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4 = (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage) _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__12 = _Microsoft_ProgramSynthesis_Utils_Optional_int__12;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__12, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__12, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__12 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__12;
}{            object _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3 = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3;
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3, _Microsoft_ProgramSynthesis_Utils_Optional_int__12);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("DSLParameter", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3, _Microsoft_ProgramSynthesis_Symbol_7);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("ConceptIndex", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3, 0);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("Usage", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3, _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_3);
            _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3 = (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage) _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__11 = _Microsoft_ProgramSynthesis_Utils_Optional_int__11;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__11, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__11, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__11 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__11;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__10 = _Microsoft_ProgramSynthesis_Utils_Optional_int__10;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__10, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__10, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__10 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__10;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__9 = _Microsoft_ProgramSynthesis_Utils_Optional_int__9;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__9, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__9, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__9 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__9;
}{            object _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2 = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2;
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2, _Microsoft_ProgramSynthesis_Utils_Optional_int__9);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("DSLParameter", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2, _Microsoft_ProgramSynthesis_Symbol_4);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("ConceptIndex", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2, 1);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("Usage", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2, _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_2);
            _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2 = (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage) _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__8 = _Microsoft_ProgramSynthesis_Utils_Optional_int__8;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__8, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__8, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__8 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__8;
}{            object _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1 = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1;
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1, _Microsoft_ProgramSynthesis_Utils_Optional_int__8);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("DSLParameter", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1, _Microsoft_ProgramSynthesis_Symbol_4);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("ConceptIndex", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1, 0);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage)
                .GetProperty("Usage", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1, _Microsoft_ProgramSynthesis_Rules_Concepts_ParameterUsage_1);
            _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1 = (Microsoft.ProgramSynthesis.Rules.Concepts.ConceptParameterUsage) _boxed__Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__7 = _Microsoft_ProgramSynthesis_Utils_Optional_int__7;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__7, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__7, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__7 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__7;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__6 = _Microsoft_ProgramSynthesis_Utils_Optional_int__6;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__6, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__6, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__6 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__6;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__5 = _Microsoft_ProgramSynthesis_Utils_Optional_int__5;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__5, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__5, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__5 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__5;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__4 = _Microsoft_ProgramSynthesis_Utils_Optional_int__4;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__4, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__4, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__4 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__4;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__3 = _Microsoft_ProgramSynthesis_Utils_Optional_int__3;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__3, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__3, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__3 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__3;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__2 = _Microsoft_ProgramSynthesis_Utils_Optional_int__2;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__2, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__2, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__2 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__2;
}{            object _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__1 = _Microsoft_ProgramSynthesis_Utils_Optional_int__1;
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_value", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__1, 0);
            typeof(Microsoft.ProgramSynthesis.Utils.Optional<int>)
                .GetField("_hasValue", Flags)
                .SetValue(_boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__1, false);
            _Microsoft_ProgramSynthesis_Utils_Optional_int__1 = (Microsoft.ProgramSynthesis.Utils.Optional<int>) _boxed__Microsoft_ProgramSynthesis_Utils_Optional_int__1;
}{            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, "ProseSample.Substrings");
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_rulesByHead", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_nonDeprecatedRulesByHead", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_rulesByBody", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_rulesByName", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_rules", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_features", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Features_FeatureInfo__1);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_grammarReferences", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Grammar__1);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_semanticsLocations", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_List_System_Type__2);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_learnerLocations", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_List_System_Type__3);
            typeof(Microsoft.ProgramSynthesis.Grammar)
                .GetField("_symbols", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Grammar_1, _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1);
}{            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Grammar", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_1, _Microsoft_ProgramSynthesis_Grammar_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("GrammarType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_1, _Microsoft_ProgramSynthesis_Utils_ResolvedType_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_1, "sub");
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("IsStart", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_1, true);
}{            typeof(Microsoft.ProgramSynthesis.Utils.ResolvedType)
                .GetField("_typeField", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Utils_ResolvedType_1, _System_RuntimeType_1);
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__1[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1;
}{            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, "SubStr");
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("Lazy", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, false);
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("_semantics", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__1);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, _Microsoft_ProgramSynthesis_Symbol_1);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, "SubStr");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, _Microsoft_ProgramSynthesis_Utils_Optional_int____1);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__1);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___1);
}{            _Microsoft_ProgramSynthesis_Utils_Optional_int____1[0] = _Microsoft_ProgramSynthesis_Utils_Optional_int__1;
            _Microsoft_ProgramSynthesis_Utils_Optional_int____1[1] = _Microsoft_ProgramSynthesis_Utils_Optional_int__2;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__1[0] = _Microsoft_ProgramSynthesis_Symbol_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__1[1] = _Microsoft_ProgramSynthesis_Symbol_3;
}{            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Grammar", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_2, _Microsoft_ProgramSynthesis_Grammar_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("GrammarType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_2, _Microsoft_ProgramSynthesis_Utils_ResolvedType_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_2, "v");
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("IsStart", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_2, false);
}{            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Grammar", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_3, _Microsoft_ProgramSynthesis_Grammar_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("GrammarType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_3, _Microsoft_ProgramSynthesis_Utils_ResolvedType_2);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_3, "posPair");
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("IsStart", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_3, false);
}{            typeof(Microsoft.ProgramSynthesis.Utils.ResolvedType)
                .GetField("_typeField", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Utils_ResolvedType_2, _System_RuntimeType_2);
}{}{            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Grammar", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_4, _Microsoft_ProgramSynthesis_Grammar_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("GrammarType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_4, _Microsoft_ProgramSynthesis_Utils_ResolvedType_3);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_4, "pos");
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("IsStart", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_4, false);
}{            typeof(Microsoft.ProgramSynthesis.Utils.ResolvedType)
                .GetField("_typeField", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Utils_ResolvedType_3, _System_RuntimeType_3);
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__2[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__2[1] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3;
}{            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, "AbsPos");
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("Lazy", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, false);
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("_semantics", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__2);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, _Microsoft_ProgramSynthesis_Symbol_4);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, "AbsPos");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, _Microsoft_ProgramSynthesis_Utils_Optional_int____2);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__2);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___2);
}{            _Microsoft_ProgramSynthesis_Utils_Optional_int____2[0] = _Microsoft_ProgramSynthesis_Utils_Optional_int__3;
            _Microsoft_ProgramSynthesis_Utils_Optional_int____2[1] = _Microsoft_ProgramSynthesis_Utils_Optional_int__4;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__2[0] = _Microsoft_ProgramSynthesis_Symbol_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__2[1] = _Microsoft_ProgramSynthesis_Symbol_5;
}{            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Grammar", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_5, _Microsoft_ProgramSynthesis_Grammar_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("GrammarType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_5, _Microsoft_ProgramSynthesis_Utils_ResolvedType_4);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_5, "k");
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("IsStart", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_5, false);
}{            typeof(Microsoft.ProgramSynthesis.Utils.ResolvedType)
                .GetField("_typeField", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Utils_ResolvedType_4, _System_RuntimeType_4);
}{}{            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, "RegPos");
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("Lazy", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, false);
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("_semantics", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__3);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, _Microsoft_ProgramSynthesis_Symbol_4);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, "RegPos");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, _Microsoft_ProgramSynthesis_Utils_Optional_int____3);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__3);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___3);
}{            _Microsoft_ProgramSynthesis_Utils_Optional_int____3[0] = _Microsoft_ProgramSynthesis_Utils_Optional_int__5;
            _Microsoft_ProgramSynthesis_Utils_Optional_int____3[1] = _Microsoft_ProgramSynthesis_Utils_Optional_int__6;
            _Microsoft_ProgramSynthesis_Utils_Optional_int____3[2] = _Microsoft_ProgramSynthesis_Utils_Optional_int__7;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__3[0] = _Microsoft_ProgramSynthesis_Symbol_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__3[1] = _Microsoft_ProgramSynthesis_Symbol_6;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__3[2] = _Microsoft_ProgramSynthesis_Symbol_5;
}{            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Grammar", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_6, _Microsoft_ProgramSynthesis_Grammar_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("GrammarType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_6, _Microsoft_ProgramSynthesis_Utils_ResolvedType_5);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_6, "rr");
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("IsStart", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_6, false);
}{            typeof(Microsoft.ProgramSynthesis.Utils.ResolvedType)
                .GetField("_typeField", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Utils_ResolvedType_5, _System_RuntimeType_5);
}{}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__3[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1;
}{            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptRule)
                .GetField("DslBodyMapping", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__1);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptRule)
                .GetField("_dslBody", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, null);
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, "Pair");
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("Lazy", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, false);
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("_semantics", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__4);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, _Microsoft_ProgramSynthesis_Symbol_3);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, "PosPair");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, _Microsoft_ProgramSynthesis_Utils_Optional_int____4);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__4);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___4);
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__1[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_1;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__1[1] = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_2;
}{            _Microsoft_ProgramSynthesis_Utils_Optional_int____4[0] = _Microsoft_ProgramSynthesis_Utils_Optional_int__10;
            _Microsoft_ProgramSynthesis_Utils_Optional_int____4[1] = _Microsoft_ProgramSynthesis_Utils_Optional_int__11;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__4[0] = _Microsoft_ProgramSynthesis_Symbol_4;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__4[1] = _Microsoft_ProgramSynthesis_Symbol_4;
}{}{            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Grammar", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_7, _Microsoft_ProgramSynthesis_Grammar_1);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("GrammarType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_7, _Microsoft_ProgramSynthesis_Utils_ResolvedType_6);
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_7, "r");
            typeof(Microsoft.ProgramSynthesis.Symbol)
                .GetProperty("IsStart", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Symbol_7, false);
}{            typeof(Microsoft.ProgramSynthesis.Utils.ResolvedType)
                .GetField("_typeField", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Utils_ResolvedType_6, _System_RuntimeType_6);
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__4[0] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_1;
}{            typeof(Microsoft.ProgramSynthesis.Rules.TerminalRule)
                .GetProperty("IsInput", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, false);
            typeof(Microsoft.ProgramSynthesis.Rules.TerminalRule)
                .GetProperty("GeneratorReference", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, null);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, _Microsoft_ProgramSynthesis_Symbol_7);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, "r");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, _Microsoft_ProgramSynthesis_Utils_Optional_int____5);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__5);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_1, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___5);
}{}{}{}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__5[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2;
}{            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptRule)
                .GetField("DslBodyMapping", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__2);
            typeof(Microsoft.ProgramSynthesis.Rules.Concepts.ConceptRule)
                .GetField("_dslBody", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, null);
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, "Pair");
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("Lazy", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, false);
            typeof(Microsoft.ProgramSynthesis.Rules.OperatorRule)
                .GetField("_semantics", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, _Microsoft_ProgramSynthesis_Utils_MethodReference_Microsoft_ProgramSynthesis_Rules_OperatorRule_OperatorSemantics__5);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, _Microsoft_ProgramSynthesis_Symbol_6);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, "BoundaryPair");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, _Microsoft_ProgramSynthesis_Utils_Optional_int____6);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__6);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___6);
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__2[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_3;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage__2[1] = _Microsoft_ProgramSynthesis_Rules_Concepts_ConceptParameterUsage_4;
}{            _Microsoft_ProgramSynthesis_Utils_Optional_int____6[0] = _Microsoft_ProgramSynthesis_Utils_Optional_int__14;
            _Microsoft_ProgramSynthesis_Utils_Optional_int____6[1] = _Microsoft_ProgramSynthesis_Utils_Optional_int__15;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__6[0] = _Microsoft_ProgramSynthesis_Symbol_7;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__6[1] = _Microsoft_ProgramSynthesis_Symbol_7;
}{}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__6[0] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_2;
}{            typeof(Microsoft.ProgramSynthesis.Rules.TerminalRule)
                .GetProperty("IsInput", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, true);
            typeof(Microsoft.ProgramSynthesis.Rules.TerminalRule)
                .GetProperty("GeneratorReference", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, null);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, _Microsoft_ProgramSynthesis_Symbol_2);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, "v");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, _Microsoft_ProgramSynthesis_Utils_Optional_int____7);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__7);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_2, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___7);
}{}{}{}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__7[0] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_3;
}{            typeof(Microsoft.ProgramSynthesis.Rules.TerminalRule)
                .GetProperty("IsInput", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, false);
            typeof(Microsoft.ProgramSynthesis.Rules.TerminalRule)
                .GetProperty("GeneratorReference", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, null);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Head", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, _Microsoft_ProgramSynthesis_Symbol_5);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Id", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, "k");
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("Deprecated", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, false);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetProperty("RecursionLimit", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, _Microsoft_ProgramSynthesis_Utils_Optional_int____8);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_body", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Symbol__8);
            typeof(Microsoft.ProgramSynthesis.Rules.GrammarRule)
                .GetField("_stdWitnessFunctions", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Rules_TerminalRule_3, _System_Collections_Generic_Dictionary_int__System_Collections_Generic_MultiValueDictionary_System_Type__Microsoft_ProgramSynthesis_Learning_WitnessFunction___8);
}{}{}{}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__8[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__9[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__10[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__10[1] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__11[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__12[0] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_1;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__13[0] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_2;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__14[0] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_3;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__15[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__15[1] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__15[2] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__16[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__17[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__17[1] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__18[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__18[1] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__19[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__20[0] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__20[1] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[0] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[1] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[2] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[3] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[4] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[5] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_1;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[6] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_2;
            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__21[7] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_3;
}{            _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Features_FeatureInfo__1[0] = _Microsoft_ProgramSynthesis_Features_FeatureInfo_1;
}{            typeof(Microsoft.ProgramSynthesis.Features.FeatureInfo)
                .GetProperty("PropertyType", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Features_FeatureInfo_1, _System_RuntimeType_7);
            typeof(Microsoft.ProgramSynthesis.Features.FeatureInfo)
                .GetProperty("Name", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Features_FeatureInfo_1, "Score");
            typeof(Microsoft.ProgramSynthesis.Features.FeatureInfo)
                .GetProperty("Holders", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Features_FeatureInfo_1, _System_Collections_Generic_List_System_Type__1);
            typeof(Microsoft.ProgramSynthesis.Features.FeatureInfo)
                .GetProperty("IsComplete", Flags)
                .SetValue(_Microsoft_ProgramSynthesis_Features_FeatureInfo_1, true);
}{            _System_Collections_Generic_List_System_Type__1[0] = _System_RuntimeType_8;
}{}{            _System_Collections_Generic_List_System_Type__2[0] = _System_RuntimeType_9;
}{            _System_Collections_Generic_List_System_Type__3[0] = _System_RuntimeType_10;
}{            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1["sub"] = _Microsoft_ProgramSynthesis_Symbol_1;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1["posPair"] = _Microsoft_ProgramSynthesis_Symbol_3;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1["pos"] = _Microsoft_ProgramSynthesis_Symbol_4;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1["rr"] = _Microsoft_ProgramSynthesis_Symbol_6;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1["r"] = _Microsoft_ProgramSynthesis_Symbol_7;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1["v"] = _Microsoft_ProgramSynthesis_Symbol_2;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Symbol__1["k"] = _Microsoft_ProgramSynthesis_Symbol_5;
}{            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["SubStr"] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_1;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["PosPair"] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_1;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["AbsPos"] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_2;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["RegPos"] = _Microsoft_ProgramSynthesis_Rules_BlackBoxRule_3;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["BoundaryPair"] = _Microsoft_ProgramSynthesis_Rules_Concepts_Pair_2;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["r"] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_1;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["v"] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_2;
            _System_Collections_Generic_Dictionary_string__Microsoft_ProgramSynthesis_Rules_GrammarRule__1["k"] = _Microsoft_ProgramSynthesis_Rules_TerminalRule_3;
}{            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3[_Microsoft_ProgramSynthesis_Symbol_2] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__15;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3[_Microsoft_ProgramSynthesis_Symbol_3] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__16;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3[_Microsoft_ProgramSynthesis_Symbol_4] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__17;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3[_Microsoft_ProgramSynthesis_Symbol_5] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__18;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3[_Microsoft_ProgramSynthesis_Symbol_6] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__19;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___3[_Microsoft_ProgramSynthesis_Symbol_7] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__20;
}{            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2[_Microsoft_ProgramSynthesis_Symbol_1] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__8;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2[_Microsoft_ProgramSynthesis_Symbol_3] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__9;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2[_Microsoft_ProgramSynthesis_Symbol_4] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__10;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2[_Microsoft_ProgramSynthesis_Symbol_6] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__11;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2[_Microsoft_ProgramSynthesis_Symbol_7] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__12;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2[_Microsoft_ProgramSynthesis_Symbol_2] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__13;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___2[_Microsoft_ProgramSynthesis_Symbol_5] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__14;
}{            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1[_Microsoft_ProgramSynthesis_Symbol_1] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__1;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1[_Microsoft_ProgramSynthesis_Symbol_4] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__2;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1[_Microsoft_ProgramSynthesis_Symbol_3] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__3;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1[_Microsoft_ProgramSynthesis_Symbol_7] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__4;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1[_Microsoft_ProgramSynthesis_Symbol_6] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__5;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1[_Microsoft_ProgramSynthesis_Symbol_2] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__6;
            _System_Collections_Generic_Dictionary_Microsoft_ProgramSynthesis_Symbol__System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule___1[_Microsoft_ProgramSynthesis_Symbol_5] = _System_Collections_Generic_List_Microsoft_ProgramSynthesis_Rules_GrammarRule__7;
}return _Microsoft_ProgramSynthesis_Grammar_1;}
        }
    }
}





#pragma warning restore 1591
