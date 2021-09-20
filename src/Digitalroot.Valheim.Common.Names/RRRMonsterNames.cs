using JetBrains.Annotations;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.Common.Names
{
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static partial class RRRMonsterNames
  {
    private const string PrefixBase = "RRR_";
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(RRRMonsterNames));
    public static readonly string TrollTosser = $"{PrefixBase}{nameof(TrollTosser)}";
    public static readonly string GDThornweaver = $"{PrefixBase}{nameof(GDThornweaver)}";
    public static readonly string GhostVengeful = $"{PrefixBase}{nameof(GhostVengeful)}";
    public static readonly string Grig = $"{PrefixBase}{nameof(Grig)}";

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.BlackForest:
          yield return TrollTosser;
          yield return GDThornweaver;
          break;

        case Heightmap.Biome.Swamp:
          yield return GhostVengeful;
          break;

        case Heightmap.Biome.Mistlands:
          yield return Grig;
          break;
      }
    }
  }
}
