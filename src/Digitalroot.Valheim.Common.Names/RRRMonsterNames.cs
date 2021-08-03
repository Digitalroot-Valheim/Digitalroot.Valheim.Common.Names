using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.Common.Names
{
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static partial class RRRMonsterNames
  {
    private const string PrefixM = "RRRM_";
    private const string PrefixBase = "RRR_";
    private const string PrefixNpc = "RRRN_";
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string AngrySpirit = $"{PrefixM}{nameof(AngrySpirit)}";
    public static readonly string AngryFrozenCorpse = $"{PrefixM}{nameof(AngryFrozenCorpse)}";
    public static readonly string AshHatchling = $"{PrefixM}{nameof(AshHatchling)}";
    public static readonly string AshMosquito = $"{PrefixM}{nameof(AshMosquito)}";
    public static readonly string AshNeck = $"{PrefixM}{nameof(AshNeck)}";
    public static readonly string CalmSpirit = $"{PrefixM}{nameof(CalmSpirit)}";
    public static readonly string DarkMosquito = $"{PrefixM}{nameof(DarkMosquito)}";
    public static readonly string DarkProtector = $"{PrefixM}{nameof(DarkProtector)}";
    public static readonly string DarkSpider = $"{PrefixM}{nameof(DarkSpider)}";
    public static readonly string ElderSurtling = $"{PrefixM}{nameof(ElderSurtling)}";
    public static readonly string FrozenCorpse = $"{PrefixM}{nameof(FrozenCorpse)}";
    public static readonly string PoisonDarkSpider = $"{PrefixM}{nameof(PoisonDarkSpider)}";
    public static readonly string PolarFenring = $"{PrefixM}{nameof(PolarFenring)}";
    public static readonly string PolarLox = $"{PrefixM}{nameof(PolarLox)}";
    public static readonly string DrownedSoul = $"{PrefixM}{nameof(DrownedSoul)}";
    public static readonly string SilverGolem = $"{PrefixM}{nameof(SilverGolem)}";
    public static readonly string SmallAshNeck = $"{PrefixM}{nameof(SmallAshNeck)}";
    public static readonly string SmallDarkSpider = $"{PrefixM}{nameof(SmallDarkSpider)}";
    public static readonly string SmallPolarSerpent = $"{PrefixM}{nameof(SmallPolarSerpent)}";
    public static readonly string SmallPolarLox = $"{PrefixM}{nameof(SmallPolarLox)}";
    public static readonly string StormHatchling = $"{PrefixM}{nameof(StormHatchling)}";
    public static readonly string SwollenBody = $"{PrefixM}{nameof(SwollenBody)}";
    public static readonly string StormWolf = $"{PrefixM}{nameof(StormWolf)}";
    public static readonly string BurnedBones = $"{PrefixM}{nameof(BurnedBones)}";
    public static readonly string GreenSpider = $"{PrefixM}{nameof(GreenSpider)}";
    public static readonly string BlackSpider = $"{PrefixM}{nameof(BlackSpider)}";
    public static readonly string TreeSpider = $"{PrefixM}{nameof(TreeSpider)}";
    public static readonly string FrigidSpider = $"{PrefixM}{nameof(FrigidSpider)}";
    public static readonly string FrostSpider = $"{PrefixM}{nameof(FrostSpider)}";
    public static readonly string BrownSpider = $"{PrefixM}{nameof(BrownSpider)}";
    public static readonly string ForestSpider = $"{PrefixM}{nameof(ForestSpider)}";
    public static readonly string GhostWarrior = $"{PrefixM}{nameof(GhostWarrior)}";
    public static readonly string SkeletonWarrior = $"{PrefixM}{nameof(SkeletonWarrior)}";
    public static readonly string SkeletonWarriorFire = $"{PrefixM}{nameof(SkeletonWarriorFire)}";
    public static readonly string SkeletonWarriorIce = $"{PrefixM}{nameof(SkeletonWarriorIce)}";
    public static readonly string TanSpider = $"{PrefixM}{nameof(TanSpider)}";
    public static readonly string IceGolem = $"{PrefixM}{nameof(IceGolem)}";
    public static readonly string FireGolem = $"{PrefixM}{nameof(FireGolem)}";
    public static readonly string BlazingBones = $"{PrefixM}{nameof(BlazingBones)}";
    public static readonly string EikthyrBoar = $"{PrefixM}{nameof(EikthyrBoar)}";
    public static readonly string DeathsquitoT1 = $"{PrefixM}{nameof(DeathsquitoT1)}";
    public static readonly string EikthyrWolf = $"{PrefixM}{nameof(EikthyrWolf)}";
    public static readonly string TrollT1R = $"{PrefixM}{nameof(TrollT1R)}";
    public static readonly string TrollT1M = $"{PrefixM}{nameof(TrollT1M)}";
    public static readonly string EikthyrNeckT3R = $"{PrefixM}{nameof(EikthyrNeckT3R)}";
    public static readonly string GDTosser = $"{PrefixM}{nameof(GDTosser)}";
    public static readonly string SkeletonT4MageIce = $"{PrefixM}{nameof(SkeletonT4MageIce)}";
    public static readonly string SkeletonT2M = $"{PrefixM}{nameof(SkeletonT2M)}";
    public static readonly string SkeletonT3M = $"{PrefixM}{nameof(SkeletonT3M)}";
    public static readonly string SkeletonT4M = $"{PrefixM}{nameof(SkeletonT4M)}";
    public static readonly string SkeletonT5M = $"{PrefixM}{nameof(SkeletonT5M)}";
    public static readonly string WraithT1 = $"{PrefixM}{nameof(WraithT1)}";
    public static readonly string SkeletonT4MageFire = $"{PrefixM}{nameof(SkeletonT4MageFire)}";
    public static readonly string SkeletonT1 = $"{PrefixM}{nameof(SkeletonT1)}";
    public static readonly string SkeletonT2R = $"{PrefixM}{nameof(SkeletonT2R)}";
    public static readonly string SkeletonT3R = $"{PrefixM}{nameof(SkeletonT3R)}";
    public static readonly string WraithT2 = $"{PrefixM}{nameof(WraithT2)}";

    public static readonly string Svartalfr = $"{PrefixNpc}{nameof(Svartalfr)}";
    public static readonly string SvartalfrArcher = $"{PrefixNpc}{nameof(SvartalfrArcher)}";
    public static readonly string SvartalfrMage = $"{PrefixNpc}{nameof(SvartalfrMage)}";
    public static readonly string SvartalfrHeavy = $"{PrefixNpc}{nameof(SvartalfrHeavy)}";
    public static readonly string SvartalfrBrigade = $"{PrefixNpc}{nameof(SvartalfrBrigade)}";
    public static readonly string mountainbandit2 = $"{PrefixNpc}{nameof(mountainbandit2)}";
    public static readonly string plainsbandit1 = $"{PrefixNpc}{nameof(plainsbandit1)}";
    public static readonly string plainsbandit2 = $"{PrefixNpc}{nameof(plainsbandit2)}";
    public static readonly string wildbandit1 = $"{PrefixNpc}{nameof(wildbandit1)}";
    public static readonly string wildbandit2 = $"{PrefixNpc}{nameof(wildbandit2)}";
    public static readonly string wildbandit3 = $"{PrefixNpc}{nameof(wildbandit3)}";
    public static readonly string mountainbandit1 = $"{PrefixNpc}{nameof(mountainbandit1)}";

    public static readonly string TrollTosser = $"{PrefixBase}{nameof(TrollTosser)}";
  }
}
