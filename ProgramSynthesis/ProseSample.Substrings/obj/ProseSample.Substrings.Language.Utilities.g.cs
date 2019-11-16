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



namespace ProseSample.Substrings.Build {
    public class GrammarBuilders {
        private static readonly List<KeyValuePair<Grammar, GrammarBuilders>> _build =
            new List<KeyValuePair<Grammar, GrammarBuilders>>();

        public static GrammarBuilders Instance(Grammar grammar) {
            foreach (var kvp in _build) {
                if (grammar == kvp.Key) return kvp.Value;
            }
            GrammarBuilders newBuild = new GrammarBuilders(grammar);
            _build.Add(new KeyValuePair<Grammar, GrammarBuilders>(grammar, newBuild));
            return newBuild;
        }

        private readonly Lazy<GrammarSymbols> _symbol;
        public GrammarSymbols Symbol => _symbol.Value;
        public class GrammarSymbols {
            public Symbol sub { get; private set; }
            public Symbol posPair { get; private set; }
            public Symbol pos { get; private set; }
            public Symbol rr { get; private set; }
            public Symbol r { get; private set; }
            public Symbol v { get; private set; }
            public Symbol k { get; private set; }

            public GrammarSymbols(Grammar grammar) {
                sub = grammar.Symbol("sub");
                posPair = grammar.Symbol("posPair");
                pos = grammar.Symbol("pos");
                rr = grammar.Symbol("rr");
                r = grammar.Symbol("r");
                v = grammar.Symbol("v");
                k = grammar.Symbol("k");
            }
        }

        private readonly Lazy<GrammarRules> _rule;
        public GrammarRules Rule => _rule.Value;
        public class GrammarRules {
            public BlackBoxRule SubStr { get; private set; }
            public BlackBoxRule AbsPos { get; private set; }
            public BlackBoxRule RegPos { get; private set; }
            public ConceptRule PosPair { get; private set; }
            public ConceptRule BoundaryPair { get; private set; }

            public GrammarRules(Grammar grammar) {
                SubStr = (BlackBoxRule) grammar.Rule("SubStr");
                AbsPos = (BlackBoxRule) grammar.Rule("AbsPos");
                RegPos = (BlackBoxRule) grammar.Rule("RegPos");
                PosPair = (ConceptRule) grammar.Rule("PosPair");
                BoundaryPair = (ConceptRule) grammar.Rule("BoundaryPair");
            }
        }

        private readonly Lazy<GrammarUnnamedConversions> _unnamedConversion;
        public GrammarUnnamedConversions UnnamedConversion => _unnamedConversion.Value;
        public class GrammarUnnamedConversions {

            public GrammarUnnamedConversions(Grammar grammar) {
            }
        }

        private readonly Lazy<GrammarHoles> _hole;
        public GrammarHoles Hole => _hole.Value;
        public class GrammarHoles {
            public Hole sub { get; private set; }
            public Hole posPair { get; private set; }
            public Hole pos { get; private set; }
            public Hole rr { get; private set; }
            public Hole r { get; private set; }
            public Hole v { get; private set; }
            public Hole k { get; private set; }

            public GrammarHoles(GrammarBuilders builders) {
                sub = new Hole(builders.Symbol.sub);
                posPair = new Hole(builders.Symbol.posPair);
                pos = new Hole(builders.Symbol.pos);
                rr = new Hole(builders.Symbol.rr);
                r = new Hole(builders.Symbol.r);
                v = new Hole(builders.Symbol.v);
                k = new Hole(builders.Symbol.k);
            }
        }

        public Nodes Node { get; private set; }
        public class Nodes {
            public Nodes(GrammarBuilders builders) {
                Rule = new NodeRules(builders);
                UnnamedConversion = new NodeUnnamedConversionRules(builders);
                _variable = new Lazy<NodeVariables>(() => new NodeVariables(builders), LazyThreadSafetyMode.ExecutionAndPublication);
                _hole = new Lazy<NodeHoles>(() => new NodeHoles(builders), LazyThreadSafetyMode.ExecutionAndPublication);
                Unsafe = new NodeUnsafe();
                Cast = new NodeCast(builders);
                CastRule = new RuleCast(builders);
                Is = new NodeIs(builders);
                IsRule = new RuleIs(builders);
                As = new NodeAs(builders);
                AsRule = new RuleAs(builders);
            }

            public NodeRules Rule { get; private set; }
            public class NodeRules {
                private readonly GrammarBuilders _builders;

                public NodeRules(GrammarBuilders builders) {
                    _builders = builders;
                }

                public NodeTypes.r r(Microsoft.ProgramSynthesis.DslLibrary.RegularExpression value)
                    => new NodeTypes.r(_builders, value);
                public NodeTypes.k k(int value)
                    => new NodeTypes.k(_builders, value);

                /// <summary> Build a typed program node correponding to the SubStr rule.</summary>
                /// <remarks>
                ///     The return type could be RuleNodeTypes.SubStr, but it is useful in more cases to already
                ///     apply the implicit conversion to NodeTypes.sub.
                /// </remarks>
                public NodeTypes.sub SubStr(NodeTypes.v value0, NodeTypes.posPair value1)
                    => new RuleNodeTypes.SubStr(_builders, value0, value1);

                /// <summary> Build a typed program node correponding to the AbsPos rule.</summary>
                /// <remarks>
                ///     The return type could be RuleNodeTypes.AbsPos, but it is useful in more cases to already
                ///     apply the implicit conversion to NodeTypes.pos.
                /// </remarks>
                public NodeTypes.pos AbsPos(NodeTypes.v value0, NodeTypes.k value1)
                    => new RuleNodeTypes.AbsPos(_builders, value0, value1);

                /// <summary> Build a typed program node correponding to the RegPos rule.</summary>
                /// <remarks>
                ///     The return type could be RuleNodeTypes.RegPos, but it is useful in more cases to already
                ///     apply the implicit conversion to NodeTypes.pos.
                /// </remarks>
                public NodeTypes.pos RegPos(NodeTypes.v value0, NodeTypes.rr value1, NodeTypes.k value2)
                    => new RuleNodeTypes.RegPos(_builders, value0, value1, value2);

                /// <summary> Build a typed program node correponding to the PosPair rule.</summary>
                /// <remarks>
                ///     The return type could be RuleNodeTypes.PosPair, but it is useful in more cases to already
                ///     apply the implicit conversion to NodeTypes.posPair.
                /// </remarks>
                public NodeTypes.posPair PosPair(NodeTypes.pos value0, NodeTypes.pos value1)
                    => new RuleNodeTypes.PosPair(_builders, value0, value1);

                /// <summary> Build a typed program node correponding to the BoundaryPair rule.</summary>
                /// <remarks>
                ///     The return type could be RuleNodeTypes.BoundaryPair, but it is useful in more cases to already
                ///     apply the implicit conversion to NodeTypes.rr.
                /// </remarks>
                public NodeTypes.rr BoundaryPair(NodeTypes.r value0, NodeTypes.r value1)
                    => new RuleNodeTypes.BoundaryPair(_builders, value0, value1);
            }

            public NodeUnnamedConversionRules UnnamedConversion { get; private set; }
            public class NodeUnnamedConversionRules {
                private readonly GrammarBuilders _builders;

                public NodeUnnamedConversionRules(GrammarBuilders builders) {
                    _builders = builders;
                }

            }

            private readonly Lazy<NodeVariables> _variable;
            public NodeVariables Variable => _variable.Value;
            public class NodeVariables {
                public NodeTypes.v v { get; private set; }

                public NodeVariables(GrammarBuilders builders) {
                    v = new NodeTypes.v(builders);
                }
            }

            private readonly Lazy<NodeHoles> _hole;
            public NodeHoles Hole => _hole.Value;
            public class NodeHoles {
                public NodeTypes.sub sub { get; private set; }
                public NodeTypes.posPair posPair { get; private set; }
                public NodeTypes.pos pos { get; private set; }
                public NodeTypes.rr rr { get; private set; }
                public NodeTypes.r r { get; private set; }
                public NodeTypes.k k { get; private set; }

                public NodeHoles(GrammarBuilders builders) {
                    sub = NodeTypes.sub.CreateHole(builders);
                    posPair = NodeTypes.posPair.CreateHole(builders);
                    pos = NodeTypes.pos.CreateHole(builders);
                    rr = NodeTypes.rr.CreateHole(builders);
                    r = NodeTypes.r.CreateHole(builders);
                    k = NodeTypes.k.CreateHole(builders);
                }
            }

            public NodeUnsafe Unsafe { get; private set; }
            public class NodeUnsafe {
                public NodeTypes.sub sub(ProgramNode node)
                    => NodeTypes.sub.CreateUnsafe(node);
                public NodeTypes.posPair posPair(ProgramNode node)
                    => NodeTypes.posPair.CreateUnsafe(node);
                public NodeTypes.pos pos(ProgramNode node)
                    => NodeTypes.pos.CreateUnsafe(node);
                public NodeTypes.rr rr(ProgramNode node)
                    => NodeTypes.rr.CreateUnsafe(node);
                public NodeTypes.r r(ProgramNode node)
                    => NodeTypes.r.CreateUnsafe(node);
                public NodeTypes.k k(ProgramNode node)
                    => NodeTypes.k.CreateUnsafe(node);
            }

            public NodeCast Cast { get; private set; }
            public class NodeCast {
                private readonly GrammarBuilders _builders;

                public NodeCast(GrammarBuilders builders) {
                    _builders = builders;
                }

                public NodeTypes.sub sub(ProgramNode node) {
                    NodeTypes.sub? result = NodeTypes.sub.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol sub but received " + node.Symbol);
                    return result.Value;
                }
                public NodeTypes.posPair posPair(ProgramNode node) {
                    NodeTypes.posPair? result = NodeTypes.posPair.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol posPair but received " + node.Symbol);
                    return result.Value;
                }
                public NodeTypes.pos pos(ProgramNode node) {
                    NodeTypes.pos? result = NodeTypes.pos.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol pos but received " + node.Symbol);
                    return result.Value;
                }
                public NodeTypes.rr rr(ProgramNode node) {
                    NodeTypes.rr? result = NodeTypes.rr.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol rr but received " + node.Symbol);
                    return result.Value;
                }
                public NodeTypes.r r(ProgramNode node) {
                    NodeTypes.r? result = NodeTypes.r.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol r but received " + node.Symbol);
                    return result.Value;
                }
                public NodeTypes.k k(ProgramNode node) {
                    NodeTypes.k? result = NodeTypes.k.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol k but received " + node.Symbol);
                    return result.Value;
                }
            }

            public RuleCast CastRule { get; private set; }
            public class RuleCast {
                private readonly GrammarBuilders _builders;

                public RuleCast(GrammarBuilders builders) {
                    _builders = builders;
                }

                public RuleNodeTypes.SubStr SubStr(ProgramNode node) {
                    RuleNodeTypes.SubStr? result = RuleNodeTypes.SubStr.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol SubStr but received " + node.Symbol);
                    return result.Value;
                }
                public RuleNodeTypes.PosPair PosPair(ProgramNode node) {
                    RuleNodeTypes.PosPair? result = RuleNodeTypes.PosPair.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol PosPair but received " + node.Symbol);
                    return result.Value;
                }
                public RuleNodeTypes.AbsPos AbsPos(ProgramNode node) {
                    RuleNodeTypes.AbsPos? result = RuleNodeTypes.AbsPos.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol AbsPos but received " + node.Symbol);
                    return result.Value;
                }
                public RuleNodeTypes.RegPos RegPos(ProgramNode node) {
                    RuleNodeTypes.RegPos? result = RuleNodeTypes.RegPos.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol RegPos but received " + node.Symbol);
                    return result.Value;
                }
                public RuleNodeTypes.BoundaryPair BoundaryPair(ProgramNode node) {
                    RuleNodeTypes.BoundaryPair? result = RuleNodeTypes.BoundaryPair.CreateSafe(_builders, node);
                    if (result == null) throw new ArgumentException(nameof(node), "expected node for symbol BoundaryPair but received " + node.Symbol);
                    return result.Value;
                }
            }

            public NodeIs Is { get; private set; }
            public class NodeIs {
                private readonly GrammarBuilders _builders;

                public NodeIs(GrammarBuilders builders) {
                    _builders = builders;
                }

                public bool sub(ProgramNode node) {
                    return NodeTypes.sub.CreateSafe(_builders, node) != null;
                }

                public bool sub(ProgramNode node, out NodeTypes.sub value) {
                    NodeTypes.sub? maybe = NodeTypes.sub.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(NodeTypes.sub);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool posPair(ProgramNode node) {
                    return NodeTypes.posPair.CreateSafe(_builders, node) != null;
                }

                public bool posPair(ProgramNode node, out NodeTypes.posPair value) {
                    NodeTypes.posPair? maybe = NodeTypes.posPair.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(NodeTypes.posPair);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool pos(ProgramNode node) {
                    return NodeTypes.pos.CreateSafe(_builders, node) != null;
                }

                public bool pos(ProgramNode node, out NodeTypes.pos value) {
                    NodeTypes.pos? maybe = NodeTypes.pos.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(NodeTypes.pos);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool rr(ProgramNode node) {
                    return NodeTypes.rr.CreateSafe(_builders, node) != null;
                }

                public bool rr(ProgramNode node, out NodeTypes.rr value) {
                    NodeTypes.rr? maybe = NodeTypes.rr.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(NodeTypes.rr);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool r(ProgramNode node) {
                    return NodeTypes.r.CreateSafe(_builders, node) != null;
                }

                public bool r(ProgramNode node, out NodeTypes.r value) {
                    NodeTypes.r? maybe = NodeTypes.r.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(NodeTypes.r);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool k(ProgramNode node) {
                    return NodeTypes.k.CreateSafe(_builders, node) != null;
                }

                public bool k(ProgramNode node, out NodeTypes.k value) {
                    NodeTypes.k? maybe = NodeTypes.k.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(NodeTypes.k);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

            }

            public RuleIs IsRule { get; private set; }
            public class RuleIs {
                private readonly GrammarBuilders _builders;

                public RuleIs(GrammarBuilders builders) {
                    _builders = builders;
                }

                public bool SubStr(ProgramNode node) {
                    return RuleNodeTypes.SubStr.CreateSafe(_builders, node) != null;
                }

                public bool SubStr(ProgramNode node, out RuleNodeTypes.SubStr value) {
                    RuleNodeTypes.SubStr? maybe = RuleNodeTypes.SubStr.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(RuleNodeTypes.SubStr);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool PosPair(ProgramNode node) {
                    return RuleNodeTypes.PosPair.CreateSafe(_builders, node) != null;
                }

                public bool PosPair(ProgramNode node, out RuleNodeTypes.PosPair value) {
                    RuleNodeTypes.PosPair? maybe = RuleNodeTypes.PosPair.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(RuleNodeTypes.PosPair);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool AbsPos(ProgramNode node) {
                    return RuleNodeTypes.AbsPos.CreateSafe(_builders, node) != null;
                }

                public bool AbsPos(ProgramNode node, out RuleNodeTypes.AbsPos value) {
                    RuleNodeTypes.AbsPos? maybe = RuleNodeTypes.AbsPos.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(RuleNodeTypes.AbsPos);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool RegPos(ProgramNode node) {
                    return RuleNodeTypes.RegPos.CreateSafe(_builders, node) != null;
                }

                public bool RegPos(ProgramNode node, out RuleNodeTypes.RegPos value) {
                    RuleNodeTypes.RegPos? maybe = RuleNodeTypes.RegPos.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(RuleNodeTypes.RegPos);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

                public bool BoundaryPair(ProgramNode node) {
                    return RuleNodeTypes.BoundaryPair.CreateSafe(_builders, node) != null;
                }

                public bool BoundaryPair(ProgramNode node, out RuleNodeTypes.BoundaryPair value) {
                    RuleNodeTypes.BoundaryPair? maybe = RuleNodeTypes.BoundaryPair.CreateSafe(_builders, node);
                    if (maybe == null) {
                        value = default(RuleNodeTypes.BoundaryPair);
                        return false;
                    }
                    value = maybe.Value;
                    return true;
                }

            }
            public NodeAs As { get; private set; }
            public class NodeAs {
                private readonly GrammarBuilders _builders;

                public NodeAs(GrammarBuilders builders) {
                    _builders = builders;
                }

                public NodeTypes.sub? sub(ProgramNode node)
                    => NodeTypes.sub.CreateSafe(_builders, node);
                public NodeTypes.posPair? posPair(ProgramNode node)
                    => NodeTypes.posPair.CreateSafe(_builders, node);
                public NodeTypes.pos? pos(ProgramNode node)
                    => NodeTypes.pos.CreateSafe(_builders, node);
                public NodeTypes.rr? rr(ProgramNode node)
                    => NodeTypes.rr.CreateSafe(_builders, node);
                public NodeTypes.r? r(ProgramNode node)
                    => NodeTypes.r.CreateSafe(_builders, node);
                public NodeTypes.k? k(ProgramNode node)
                    => NodeTypes.k.CreateSafe(_builders, node);
            }

            public RuleAs AsRule { get; private set; }
            public class RuleAs {
                private readonly GrammarBuilders _builders;

                public RuleAs(GrammarBuilders builders) {
                    _builders = builders;
                }

                public RuleNodeTypes.SubStr? SubStr(ProgramNode node)
                    => RuleNodeTypes.SubStr.CreateSafe(_builders, node);
                public RuleNodeTypes.PosPair? PosPair(ProgramNode node)
                    => RuleNodeTypes.PosPair.CreateSafe(_builders, node);
                public RuleNodeTypes.AbsPos? AbsPos(ProgramNode node)
                    => RuleNodeTypes.AbsPos.CreateSafe(_builders, node);
                public RuleNodeTypes.RegPos? RegPos(ProgramNode node)
                    => RuleNodeTypes.RegPos.CreateSafe(_builders, node);
                public RuleNodeTypes.BoundaryPair? BoundaryPair(ProgramNode node)
                    => RuleNodeTypes.BoundaryPair.CreateSafe(_builders, node);
            }
        }

        public Sets Set { get; private set; }
        public class Sets {
            public Sets(GrammarBuilders builders) {
                Join = new Joins(builders);
                ExplicitJoin = new ExplicitJoins(builders);
                UnnamedConversion = new JoinUnnamedConversions(builders);
                ExplicitUnnamedConversion = new ExplicitJoinUnnamedConversions(builders);
                Cast = new Casts(builders);
            }

            public Joins Join { get; private set; }
            public class Joins {
                private readonly GrammarBuilders _builders;

                public Joins(GrammarBuilders builders) {
                    _builders = builders;
                }

                public ProgramSetBuilder<NodeTypes.sub> SubStr(ProgramSetBuilder<NodeTypes.v> value0, ProgramSetBuilder<NodeTypes.posPair> value1)
                    => ProgramSetBuilder<NodeTypes.sub>.CreateUnsafe(ProgramSet.Join(_builders.Rule.SubStr, value0?.Set, value1?.Set));
                public ProgramSetBuilder<NodeTypes.pos> AbsPos(ProgramSetBuilder<NodeTypes.v> value0, ProgramSetBuilder<NodeTypes.k> value1)
                    => ProgramSetBuilder<NodeTypes.pos>.CreateUnsafe(ProgramSet.Join(_builders.Rule.AbsPos, value0?.Set, value1?.Set));
                public ProgramSetBuilder<NodeTypes.pos> RegPos(ProgramSetBuilder<NodeTypes.v> value0, ProgramSetBuilder<NodeTypes.rr> value1, ProgramSetBuilder<NodeTypes.k> value2)
                    => ProgramSetBuilder<NodeTypes.pos>.CreateUnsafe(ProgramSet.Join(_builders.Rule.RegPos, value0?.Set, value1?.Set, value2?.Set));
                public ProgramSetBuilder<NodeTypes.posPair> PosPair(ProgramSetBuilder<NodeTypes.pos> value0, ProgramSetBuilder<NodeTypes.pos> value1)
                    => ProgramSetBuilder<NodeTypes.posPair>.CreateUnsafe(ProgramSet.Join(_builders.Rule.PosPair, value0?.Set, value1?.Set));
                public ProgramSetBuilder<NodeTypes.rr> BoundaryPair(ProgramSetBuilder<NodeTypes.r> value0, ProgramSetBuilder<NodeTypes.r> value1)
                    => ProgramSetBuilder<NodeTypes.rr>.CreateUnsafe(ProgramSet.Join(_builders.Rule.BoundaryPair, value0?.Set, value1?.Set));
            }

            public ExplicitJoins ExplicitJoin { get; private set; }
            public class ExplicitJoins {
                private readonly GrammarBuilders _builders;

                public ExplicitJoins(GrammarBuilders builders) {
                    _builders = builders;
                }

                public JoinProgramSetBuilder<NodeTypes.sub> SubStr(ProgramSetBuilder<NodeTypes.v> value0, ProgramSetBuilder<NodeTypes.posPair> value1)
                    => JoinProgramSetBuilder<NodeTypes.sub>.CreateUnsafe(new JoinProgramSet(_builders.Rule.SubStr, value0?.Set, value1?.Set));
                public JoinProgramSetBuilder<NodeTypes.pos> AbsPos(ProgramSetBuilder<NodeTypes.v> value0, ProgramSetBuilder<NodeTypes.k> value1)
                    => JoinProgramSetBuilder<NodeTypes.pos>.CreateUnsafe(new JoinProgramSet(_builders.Rule.AbsPos, value0?.Set, value1?.Set));
                public JoinProgramSetBuilder<NodeTypes.pos> RegPos(ProgramSetBuilder<NodeTypes.v> value0, ProgramSetBuilder<NodeTypes.rr> value1, ProgramSetBuilder<NodeTypes.k> value2)
                    => JoinProgramSetBuilder<NodeTypes.pos>.CreateUnsafe(new JoinProgramSet(_builders.Rule.RegPos, value0?.Set, value1?.Set, value2?.Set));
                public JoinProgramSetBuilder<NodeTypes.posPair> PosPair(ProgramSetBuilder<NodeTypes.pos> value0, ProgramSetBuilder<NodeTypes.pos> value1)
                    => JoinProgramSetBuilder<NodeTypes.posPair>.CreateUnsafe(new JoinProgramSet(_builders.Rule.PosPair, value0?.Set, value1?.Set));
                public JoinProgramSetBuilder<NodeTypes.rr> BoundaryPair(ProgramSetBuilder<NodeTypes.r> value0, ProgramSetBuilder<NodeTypes.r> value1)
                    => JoinProgramSetBuilder<NodeTypes.rr>.CreateUnsafe(new JoinProgramSet(_builders.Rule.BoundaryPair, value0?.Set, value1?.Set));
            }

            public JoinUnnamedConversions UnnamedConversion { get; private set; }
            public class JoinUnnamedConversions {
                private readonly GrammarBuilders _builders;

                public JoinUnnamedConversions(GrammarBuilders builders) {
                    _builders = builders;
                }

            }

            public ExplicitJoinUnnamedConversions ExplicitUnnamedConversion { get; private set; }
            public class ExplicitJoinUnnamedConversions {
                private readonly GrammarBuilders _builders;

                public ExplicitJoinUnnamedConversions(GrammarBuilders builders) {
                    _builders = builders;
                }

            }

            public Casts Cast { get; private set; }
            public class Casts {
                private readonly GrammarBuilders _builders;

                public Casts(GrammarBuilders builders) {
                    _builders = builders;
                }

                public ProgramSetBuilder<NodeTypes.sub> sub(ProgramSet set) {
                    if (set.Symbol != _builders.Symbol.sub) {
                        throw new ArgumentException(nameof(set), "expected program set for symbol sub but received " + set.Symbol);
                    }
                    return ProgramSetBuilder<NodeTypes.sub>.CreateUnsafe(set);
                }
                public ProgramSetBuilder<NodeTypes.posPair> posPair(ProgramSet set) {
                    if (set.Symbol != _builders.Symbol.posPair) {
                        throw new ArgumentException(nameof(set), "expected program set for symbol posPair but received " + set.Symbol);
                    }
                    return ProgramSetBuilder<NodeTypes.posPair>.CreateUnsafe(set);
                }
                public ProgramSetBuilder<NodeTypes.pos> pos(ProgramSet set) {
                    if (set.Symbol != _builders.Symbol.pos) {
                        throw new ArgumentException(nameof(set), "expected program set for symbol pos but received " + set.Symbol);
                    }
                    return ProgramSetBuilder<NodeTypes.pos>.CreateUnsafe(set);
                }
                public ProgramSetBuilder<NodeTypes.rr> rr(ProgramSet set) {
                    if (set.Symbol != _builders.Symbol.rr) {
                        throw new ArgumentException(nameof(set), "expected program set for symbol rr but received " + set.Symbol);
                    }
                    return ProgramSetBuilder<NodeTypes.rr>.CreateUnsafe(set);
                }
                public ProgramSetBuilder<NodeTypes.r> r(ProgramSet set) {
                    if (set.Symbol != _builders.Symbol.r) {
                        throw new ArgumentException(nameof(set), "expected program set for symbol r but received " + set.Symbol);
                    }
                    return ProgramSetBuilder<NodeTypes.r>.CreateUnsafe(set);
                }
                public ProgramSetBuilder<NodeTypes.k> k(ProgramSet set) {
                    if (set.Symbol != _builders.Symbol.k) {
                        throw new ArgumentException(nameof(set), "expected program set for symbol k but received " + set.Symbol);
                    }
                    return ProgramSetBuilder<NodeTypes.k>.CreateUnsafe(set);
                }
            }
        }

        public GrammarBuilders(Grammar grammar) {
            _symbol = new Lazy<GrammarSymbols>(() => new GrammarSymbols(grammar), LazyThreadSafetyMode.ExecutionAndPublication);
            _rule = new Lazy<GrammarRules>(() => new GrammarRules(grammar), LazyThreadSafetyMode.ExecutionAndPublication);
            _unnamedConversion = new Lazy<GrammarUnnamedConversions>(() => new GrammarUnnamedConversions(grammar), LazyThreadSafetyMode.ExecutionAndPublication);
            _hole = new Lazy<GrammarHoles>(() => new GrammarHoles(this), LazyThreadSafetyMode.ExecutionAndPublication);
            Node = new Nodes(this);
            Set = new Sets(this);
        }
    }

    public static class Cluster {
        private static Optional<T> CastValue<T>(object obj) => obj is Bottom ? Optional<T>.Nothing : ((T) obj).Some();

        public static IEnumerable<KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.StringRegion>, ProgramSetBuilder<NodeTypes.sub>>>
            ClusterOnInput(this ProgramSetBuilder<NodeTypes.sub> set, State state)
            => set.Set.ClusterOnInput(state).Select(kvp => new KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.StringRegion>, ProgramSetBuilder<NodeTypes.sub>>(CastValue<Microsoft.ProgramSynthesis.DslLibrary.StringRegion>(kvp.Key), ProgramSetBuilder<NodeTypes.sub>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>>, ProgramSetBuilder<NodeTypes.posPair>>>
            ClusterOnInput(this ProgramSetBuilder<NodeTypes.posPair> set, State state)
            => set.Set.ClusterOnInput(state).Select(kvp => new KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>>, ProgramSetBuilder<NodeTypes.posPair>>(CastValue<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>>(kvp.Key), ProgramSetBuilder<NodeTypes.posPair>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<System.Nullable<uint>>, ProgramSetBuilder<NodeTypes.pos>>>
            ClusterOnInput(this ProgramSetBuilder<NodeTypes.pos> set, State state)
            => set.Set.ClusterOnInput(state).Select(kvp => new KeyValuePair<Optional<System.Nullable<uint>>, ProgramSetBuilder<NodeTypes.pos>>(CastValue<System.Nullable<uint>>(kvp.Key), ProgramSetBuilder<NodeTypes.pos>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>>, ProgramSetBuilder<NodeTypes.rr>>>
            ClusterOnInput(this ProgramSetBuilder<NodeTypes.rr> set, State state)
            => set.Set.ClusterOnInput(state).Select(kvp => new KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>>, ProgramSetBuilder<NodeTypes.rr>>(CastValue<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>>(kvp.Key), ProgramSetBuilder<NodeTypes.rr>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>, ProgramSetBuilder<NodeTypes.r>>>
            ClusterOnInput(this ProgramSetBuilder<NodeTypes.r> set, State state)
            => set.Set.ClusterOnInput(state).Select(kvp => new KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>, ProgramSetBuilder<NodeTypes.r>>(CastValue<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>(kvp.Key), ProgramSetBuilder<NodeTypes.r>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<int>, ProgramSetBuilder<NodeTypes.k>>>
            ClusterOnInput(this ProgramSetBuilder<NodeTypes.k> set, State state)
            => set.Set.ClusterOnInput(state).Select(kvp => new KeyValuePair<Optional<int>, ProgramSetBuilder<NodeTypes.k>>(CastValue<int>(kvp.Key), ProgramSetBuilder<NodeTypes.k>.CreateUnsafe(kvp.Value)));

        public static IEnumerable<KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.StringRegion>[], ProgramSetBuilder<NodeTypes.sub>>>
            ClusterOnInputTuple(this ProgramSetBuilder<NodeTypes.sub> set, IEnumerable<State> states)
            => set.Set.ClusterOnInputTuple(states).Select(kvp => new KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.StringRegion>[], ProgramSetBuilder<NodeTypes.sub>>(kvp.Key.Select(CastValue<Microsoft.ProgramSynthesis.DslLibrary.StringRegion>).ToArray(), ProgramSetBuilder<NodeTypes.sub>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>>[], ProgramSetBuilder<NodeTypes.posPair>>>
            ClusterOnInputTuple(this ProgramSetBuilder<NodeTypes.posPair> set, IEnumerable<State> states)
            => set.Set.ClusterOnInputTuple(states).Select(kvp => new KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>>[], ProgramSetBuilder<NodeTypes.posPair>>(kvp.Key.Select(CastValue<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<System.Nullable<uint>, System.Nullable<uint>>>>).ToArray(), ProgramSetBuilder<NodeTypes.posPair>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<System.Nullable<uint>>[], ProgramSetBuilder<NodeTypes.pos>>>
            ClusterOnInputTuple(this ProgramSetBuilder<NodeTypes.pos> set, IEnumerable<State> states)
            => set.Set.ClusterOnInputTuple(states).Select(kvp => new KeyValuePair<Optional<System.Nullable<uint>>[], ProgramSetBuilder<NodeTypes.pos>>(kvp.Key.Select(CastValue<System.Nullable<uint>>).ToArray(), ProgramSetBuilder<NodeTypes.pos>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>>[], ProgramSetBuilder<NodeTypes.rr>>>
            ClusterOnInputTuple(this ProgramSetBuilder<NodeTypes.rr> set, IEnumerable<State> states)
            => set.Set.ClusterOnInputTuple(states).Select(kvp => new KeyValuePair<Optional<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>>[], ProgramSetBuilder<NodeTypes.rr>>(kvp.Key.Select(CastValue<System.Nullable<Microsoft.ProgramSynthesis.Utils.Record<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>>>).ToArray(), ProgramSetBuilder<NodeTypes.rr>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>[], ProgramSetBuilder<NodeTypes.r>>>
            ClusterOnInputTuple(this ProgramSetBuilder<NodeTypes.r> set, IEnumerable<State> states)
            => set.Set.ClusterOnInputTuple(states).Select(kvp => new KeyValuePair<Optional<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>[], ProgramSetBuilder<NodeTypes.r>>(kvp.Key.Select(CastValue<Microsoft.ProgramSynthesis.DslLibrary.RegularExpression>).ToArray(), ProgramSetBuilder<NodeTypes.r>.CreateUnsafe(kvp.Value)));
        public static IEnumerable<KeyValuePair<Optional<int>[], ProgramSetBuilder<NodeTypes.k>>>
            ClusterOnInputTuple(this ProgramSetBuilder<NodeTypes.k> set, IEnumerable<State> states)
            => set.Set.ClusterOnInputTuple(states).Select(kvp => new KeyValuePair<Optional<int>[], ProgramSetBuilder<NodeTypes.k>>(kvp.Key.Select(CastValue<int>).ToArray(), ProgramSetBuilder<NodeTypes.k>.CreateUnsafe(kvp.Value)));
    }
}

namespace ProseSample.Substrings.Build.NodeTypes {
    public struct sub : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<sub> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private sub(ProgramNode node) { _node = node; }

        public static sub CreateUnsafe(ProgramNode node)
            => new sub(node);

        public static sub? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.Symbol != g.Symbol.sub) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public static sub CreateHole(GrammarBuilders g, string holeId = null)
            => new sub(new Microsoft.ProgramSynthesis.AST.Hole(g.Symbol.sub, holeId));

        public RuleNodeTypes.SubStr Cast_SubStr() => RuleNodeTypes.SubStr.CreateUnsafe(Node);


        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(sub other) {
            return Node.Equals(other.Node);
        }
    }

    public struct posPair : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<posPair> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private posPair(ProgramNode node) { _node = node; }

        public static posPair CreateUnsafe(ProgramNode node)
            => new posPair(node);

        public static posPair? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.Symbol != g.Symbol.posPair) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public static posPair CreateHole(GrammarBuilders g, string holeId = null)
            => new posPair(new Microsoft.ProgramSynthesis.AST.Hole(g.Symbol.posPair, holeId));

        public RuleNodeTypes.PosPair Cast_PosPair() => RuleNodeTypes.PosPair.CreateUnsafe(Node);


        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(posPair other) {
            return Node.Equals(other.Node);
        }
    }

    public struct pos : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<pos> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private pos(ProgramNode node) { _node = node; }

        public static pos CreateUnsafe(ProgramNode node)
            => new pos(node);

        public static pos? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.Symbol != g.Symbol.pos) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public static pos CreateHole(GrammarBuilders g, string holeId = null)
            => new pos(new Microsoft.ProgramSynthesis.AST.Hole(g.Symbol.pos, holeId));

        public bool Is_AbsPos(GrammarBuilders g)
            => Node.GrammarRule == g.Rule.AbsPos;

        public bool Is_AbsPos(GrammarBuilders g, out RuleNodeTypes.AbsPos value) {
            if (Node.GrammarRule == g.Rule.AbsPos) {
                value = RuleNodeTypes.AbsPos.CreateUnsafe(Node);
                return true;
            }
            value = default(RuleNodeTypes.AbsPos);
            return false;
        }

        public RuleNodeTypes.AbsPos? As_AbsPos(GrammarBuilders g)
            => Node.GrammarRule == g.Rule.AbsPos ? RuleNodeTypes.AbsPos.CreateUnsafe(Node) : (RuleNodeTypes.AbsPos?) null;

        public RuleNodeTypes.AbsPos Cast_AbsPos(GrammarBuilders g) {
            if (Node.GrammarRule == g.Rule.AbsPos) {
                return RuleNodeTypes.AbsPos.CreateUnsafe(Node);
            }
            throw new InvalidOperationException("Cast_AbsPos is not valid on a " + Node.GrammarRule.Id + " node");
        }

        public bool Is_RegPos(GrammarBuilders g)
            => Node.GrammarRule == g.Rule.RegPos;

        public bool Is_RegPos(GrammarBuilders g, out RuleNodeTypes.RegPos value) {
            if (Node.GrammarRule == g.Rule.RegPos) {
                value = RuleNodeTypes.RegPos.CreateUnsafe(Node);
                return true;
            }
            value = default(RuleNodeTypes.RegPos);
            return false;
        }

        public RuleNodeTypes.RegPos? As_RegPos(GrammarBuilders g)
            => Node.GrammarRule == g.Rule.RegPos ? RuleNodeTypes.RegPos.CreateUnsafe(Node) : (RuleNodeTypes.RegPos?) null;

        public RuleNodeTypes.RegPos Cast_RegPos(GrammarBuilders g) {
            if (Node.GrammarRule == g.Rule.RegPos) {
                return RuleNodeTypes.RegPos.CreateUnsafe(Node);
            }
            throw new InvalidOperationException("Cast_RegPos is not valid on a " + Node.GrammarRule.Id + " node");
        }


        public T Switch<T>(GrammarBuilders g,
            System.Func<RuleNodeTypes.AbsPos, T> func0,
            System.Func<RuleNodeTypes.RegPos, T> func1
        ) {
            RuleNodeTypes.AbsPos local0;
            if (Is_AbsPos(g, out local0)) return func0(local0);
            RuleNodeTypes.RegPos local1;
            if (Is_RegPos(g, out local1)) return func1(local1);
            throw new InvalidOperationException("Rule " + Node.GrammarRule.Id + " is not valid for a Switch operation from symbol pos");
        }

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(pos other) {
            return Node.Equals(other.Node);
        }
    }

    public struct rr : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<rr> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private rr(ProgramNode node) { _node = node; }

        public static rr CreateUnsafe(ProgramNode node)
            => new rr(node);

        public static rr? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.Symbol != g.Symbol.rr) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public static rr CreateHole(GrammarBuilders g, string holeId = null)
            => new rr(new Microsoft.ProgramSynthesis.AST.Hole(g.Symbol.rr, holeId));

        public RuleNodeTypes.BoundaryPair Cast_BoundaryPair() => RuleNodeTypes.BoundaryPair.CreateUnsafe(Node);


        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(rr other) {
            return Node.Equals(other.Node);
        }
    }

    public struct r : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<r> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private r(ProgramNode node) { _node = node; }

        public static r CreateUnsafe(ProgramNode node)
            => new r(node);

        public static r? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.Symbol != g.Symbol.r) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public static r CreateHole(GrammarBuilders g, string holeId = null)
            => new r(new Microsoft.ProgramSynthesis.AST.Hole(g.Symbol.r, holeId));

        public r(GrammarBuilders g, Microsoft.ProgramSynthesis.DslLibrary.RegularExpression value)
            : this(new LiteralNode(g.Symbol.r, value)) { }

        public Microsoft.ProgramSynthesis.DslLibrary.RegularExpression Value => (Microsoft.ProgramSynthesis.DslLibrary.RegularExpression) (((LiteralNode) Node).Value);

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(r other) {
            return Node.Equals(other.Node);
        }
    }

    public struct k : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<k> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private k(ProgramNode node) { _node = node; }

        public static k CreateUnsafe(ProgramNode node)
            => new k(node);

        public static k? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.Symbol != g.Symbol.k) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public static k CreateHole(GrammarBuilders g, string holeId = null)
            => new k(new Microsoft.ProgramSynthesis.AST.Hole(g.Symbol.k, holeId));

        public k(GrammarBuilders g, int value)
            : this(new LiteralNode(g.Symbol.k, value)) { }

        public int Value => (int) (((LiteralNode) Node).Value);

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(k other) {
            return Node.Equals(other.Node);
        }
    }

    public struct v : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<v> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private v(ProgramNode node) { _node = node; }

        public static v CreateUnsafe(ProgramNode node)
            => new v(node);

        public static v? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.Symbol != g.Symbol.v) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public static v CreateHole(GrammarBuilders g, string holeId = null)
            => new v(new Microsoft.ProgramSynthesis.AST.Hole(g.Symbol.v, holeId));

        public v(GrammarBuilders g)
            : this(new VariableNode(g.Symbol.v)) { }

        public VariableNode Variable => (VariableNode) Node;

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(v other) {
            return Node.Equals(other.Node);
        }
    }

}

namespace ProseSample.Substrings.Build.RuleNodeTypes {
    public struct SubStr : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<SubStr> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private SubStr(ProgramNode node) { _node = node; }

        public static SubStr CreateUnsafe(ProgramNode node)
            => new SubStr(node);

        public static SubStr? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.GrammarRule != g.Rule.SubStr) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public SubStr(GrammarBuilders g, NodeTypes.v value0, NodeTypes.posPair value1) {
            _node = g.Rule.SubStr.BuildASTNode(value0.Node, value1.Node);
        }

        public static implicit operator NodeTypes.sub(SubStr arg)
            => NodeTypes.sub.CreateUnsafe(arg.Node);

        public NodeTypes.v v => NodeTypes.v.CreateUnsafe(Node.Children[0]);
        public NodeTypes.posPair posPair => NodeTypes.posPair.CreateUnsafe(Node.Children[1]);

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(SubStr other) {
            return Node.Equals(other.Node);
        }
    }

    public struct AbsPos : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<AbsPos> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private AbsPos(ProgramNode node) { _node = node; }

        public static AbsPos CreateUnsafe(ProgramNode node)
            => new AbsPos(node);

        public static AbsPos? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.GrammarRule != g.Rule.AbsPos) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public AbsPos(GrammarBuilders g, NodeTypes.v value0, NodeTypes.k value1) {
            _node = g.Rule.AbsPos.BuildASTNode(value0.Node, value1.Node);
        }

        public static implicit operator NodeTypes.pos(AbsPos arg)
            => NodeTypes.pos.CreateUnsafe(arg.Node);

        public NodeTypes.v v => NodeTypes.v.CreateUnsafe(Node.Children[0]);
        public NodeTypes.k k => NodeTypes.k.CreateUnsafe(Node.Children[1]);

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(AbsPos other) {
            return Node.Equals(other.Node);
        }
    }

    public struct RegPos : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<RegPos> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private RegPos(ProgramNode node) { _node = node; }

        public static RegPos CreateUnsafe(ProgramNode node)
            => new RegPos(node);

        public static RegPos? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.GrammarRule != g.Rule.RegPos) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public RegPos(GrammarBuilders g, NodeTypes.v value0, NodeTypes.rr value1, NodeTypes.k value2) {
            _node = g.Rule.RegPos.BuildASTNode(value0.Node, value1.Node, value2.Node);
        }

        public static implicit operator NodeTypes.pos(RegPos arg)
            => NodeTypes.pos.CreateUnsafe(arg.Node);

        public NodeTypes.v v => NodeTypes.v.CreateUnsafe(Node.Children[0]);
        public NodeTypes.rr rr => NodeTypes.rr.CreateUnsafe(Node.Children[1]);
        public NodeTypes.k k => NodeTypes.k.CreateUnsafe(Node.Children[2]);

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(RegPos other) {
            return Node.Equals(other.Node);
        }
    }

    public struct PosPair : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<PosPair> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private PosPair(ProgramNode node) { _node = node; }

        public static PosPair CreateUnsafe(ProgramNode node)
            => new PosPair(node);

        public static PosPair? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.GrammarRule != g.Rule.PosPair) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public PosPair(GrammarBuilders g, NodeTypes.pos value0, NodeTypes.pos value1) {
            _node = g.Rule.PosPair.BuildConceptASTFromDslAST(value0.Node, value1.Node);
        }

        public static implicit operator NodeTypes.posPair(PosPair arg)
            => NodeTypes.posPair.CreateUnsafe(arg.Node);

        public NodeTypes.pos pos1 => NodeTypes.pos.CreateUnsafe(Node.Children[0]);
        public NodeTypes.pos pos2 => NodeTypes.pos.CreateUnsafe(Node.Children[1]);

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(PosPair other) {
            return Node.Equals(other.Node);
        }
    }

    public struct BoundaryPair : Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder, System.IEquatable<BoundaryPair> {
        private ProgramNode _node;

        public ProgramNode Node => _node;

        // Use of this constructor directly is unsafe (no type check is performed)
        private BoundaryPair(ProgramNode node) { _node = node; }

        public static BoundaryPair CreateUnsafe(ProgramNode node)
            => new BoundaryPair(node);

        public static BoundaryPair? CreateSafe(GrammarBuilders g, ProgramNode node) {
            if (node.GrammarRule != g.Rule.BoundaryPair) {
                return null;
            }
            return CreateUnsafe(node);
        }

        public BoundaryPair(GrammarBuilders g, NodeTypes.r value0, NodeTypes.r value1) {
            _node = g.Rule.BoundaryPair.BuildConceptASTFromDslAST(value0.Node, value1.Node);
        }

        public static implicit operator NodeTypes.rr(BoundaryPair arg)
            => NodeTypes.rr.CreateUnsafe(arg.Node);

        public NodeTypes.r r1 => NodeTypes.r.CreateUnsafe(Node.Children[0]);
        public NodeTypes.r r2 => NodeTypes.r.CreateUnsafe(Node.Children[1]);

        public override int GetHashCode() => Node?.GetHashCode() ?? 0;

        public override bool Equals(object other) {
            Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder otherBase = other as Microsoft.ProgramSynthesis.AST.IProgramNodeBuilder;
            return (otherBase != null) && Node.Equals(otherBase.Node);
        }

        public bool Equals(BoundaryPair other) {
            return Node.Equals(other.Node);
        }
    }

}

namespace ProseSample.Substrings.Build.UnnamedConversionNodeTypes {
}




#pragma warning restore 1591
