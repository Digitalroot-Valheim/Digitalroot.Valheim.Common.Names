using System;
using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names
{
  public static partial class BossNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(BossNames));
    public static readonly string Eikthyr = nameof(Eikthyr);
    public static readonly string TheElder = "gd_king";
    public static readonly string Bonemass = nameof(Bonemass);
    public static readonly string Moder = "Dragon";
    public static readonly string Yagluth = "GoblinKing";

    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Meadows:
          yield return Eikthyr;
          break;
        case Heightmap.Biome.Swamp:
          yield return Bonemass;
          break;
        case Heightmap.Biome.Mountain:
          yield return Moder;
          break;
        case Heightmap.Biome.BlackForest:
          yield return TheElder;
          break;
        case Heightmap.Biome.Plains:
          yield return Yagluth;
          break;
      }
    }
  }
}
