﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.ProgramSynthesis.DslLibrary;
using Microsoft.ProgramSynthesis.Utils;

namespace ProseSample.Substrings
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class Semantics
    {
        public static StringRegion SubStr(StringRegion v, Record<uint?, uint?>? posPair) {
            uint? start = posPair.Value.Item1;
            uint? end = posPair.Value.Item2;
            if (start == null || end == null || start < v.Start || start > v.End || end < v.Start || end > v.End)
                return null;
            return v.Slice((uint) start, (uint) end);
        }

        public static uint? AbsPos(StringRegion v, int k)
        {
            if (Math.Abs(k) > v.Length + 1) return null;
            return (uint) (k > 0 ? (v.Start + k - 1) : (v.End + k + 1));
        }

        public static uint? RegPos(StringRegion v, Record<RegularExpression, RegularExpression>? rr, int k)
        {
            List<PositionMatch> ms = rr.Value.Item1.Run(v).Where(m => rr.Value.Item2.MatchesAt(v, m.Right)).ToList();
            int index = k > 0 ? (k - 1) : (ms.Count + k);
            return index < 0 || index >= ms.Count ? null : (uint?) ms[index].Right;
        }
    }
}
