using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.Common.Names
{
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static partial class RRRMBossNames
  {
    private const string Prefix = "RRRM_";
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string MotherDarkSpider = $"{Prefix}{nameof(MotherDarkSpider)}";
    public static readonly string Jotunn = $"{Prefix}{nameof(Jotunn)}";
    public static readonly string DevourerFenring = $"{Prefix}{nameof(DevourerFenring)}";
    public static readonly string ForgottenOne = $"{Prefix}{nameof(ForgottenOne)}";
    public static readonly string DamnedOne = $"{Prefix}{nameof(DamnedOne)}";
    public static readonly string BlazingDamnedOne = $"{Prefix}{nameof(BlazingDamnedOne)}";
    public static readonly string StormFenring = $"{Prefix}{nameof(StormFenring)}";
    public static readonly string SvartalfrQueen = $"RRRN_{nameof(SvartalfrQueen)}";
    public static readonly string wildbanditgiant = $"RRRN_{nameof(wildbanditgiant)}";
    public static readonly string mountainbandit3 = $"RRRN_{nameof(mountainbandit3)}";
    public static readonly string plainsbandit3 = $"RRRN_{nameof(plainsbandit3)}";
    public static readonly string wildbandit3 = $"RRRN_{nameof(wildbandit3)}";
    public static readonly string IceGolem = nameof(IceGolem);
    public static readonly string EikthyrLox = nameof(EikthyrLox);
    public static readonly string EikthyrNeckT3M = nameof(EikthyrNeckT3M);
    public static readonly string TrollT2Elite = nameof(TrollT2Elite);
    public static readonly string TrollT3Elite = nameof(TrollT3Elite);
    public static readonly string TrollT4Elite = nameof(TrollT4Elite);
    public static readonly string GDElderBrute = nameof(GDElderBrute);
    public static readonly string EikthyrNeckT4 = nameof(EikthyrNeckT4);
    public static readonly string GDBurningTorch = nameof(GDBurningTorch);
    public static readonly string UndeadHrungnir = nameof(UndeadHrungnir);
    public static readonly string SkeletonT3Captain = nameof(SkeletonT3Captain);
    public static readonly string SkeletonT4Captain = nameof(SkeletonT4Captain);
    public static readonly string WraithT3 = nameof(WraithT3);
  }
}
