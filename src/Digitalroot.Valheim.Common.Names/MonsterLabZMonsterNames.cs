using JetBrains.Annotations;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.Common.Names
{
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static partial class MonsterLabZMonsterNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(MonsterLabZMonsterNames));

    public static readonly string BrownSpider = nameof(BrownSpider);
    public static readonly string FrostSpider = nameof(FrostSpider);
    public static readonly string FrigidSpider = nameof(FrigidSpider);
    public static readonly string GreenSpider = nameof(GreenSpider);
    public static readonly string GhostWarrior = nameof(GhostWarrior);
    public static readonly string SkeletonWarrior = nameof(SkeletonWarrior);
    public static readonly string SkeletonWarriorFire = nameof(SkeletonWarriorFire);
    public static readonly string SkeletonWarriorIce = nameof(SkeletonWarriorIce);
    public static readonly string TanSpider = nameof(TanSpider);
    public static readonly string IceGolem = nameof(IceGolem);
    public static readonly string BlackSpider = nameof(BlackSpider);
    public static readonly string TreeSpider = nameof(TreeSpider);
    public static readonly string ForestSpider = nameof(ForestSpider);
    public static readonly string FireGolem = nameof(FireGolem);
    public static readonly string GoblinLoot = nameof(GoblinLoot);
    public static readonly string GoblinBase = nameof(GoblinBase);
    public static readonly string GoblinShamanNew = nameof(GoblinShamanNew);
    public static readonly string GreydwarfPurpleShroom = "Greydwarf_Purple_Shroom";
    public static readonly string GreydwarfPurple = "Greydwarf_Purple";
    public static readonly string RainbowButterfly = "Rainbow_Butterfly";
    public static readonly string SilkwormButterfly = "Silkworm_Butterfly";
    public static readonly string Molluscan = nameof(Molluscan);
    public static readonly string ObsidianGolem = nameof(ObsidianGolem);
    public static readonly string GoblinShip2 = nameof(GoblinShip2);
    public static readonly string GoblinBoat = nameof(GoblinBoat);

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.BlackForest:
          yield return GhostWarrior;
          yield return SkeletonWarrior;
          yield return SkeletonWarriorIce;
          yield return SkeletonWarriorFire;
          yield return TanSpider;
          yield return ForestSpider;
          yield return GreydwarfPurple;
          yield return GreydwarfPurpleShroom;
          yield return Molluscan;
          break;

        case Heightmap.Biome.Swamp:
          yield return GreenSpider;
          break;

        case Heightmap.Biome.Mountain:
          yield return IceGolem;
          yield return SkeletonWarriorIce;
          yield return FrigidSpider;
          yield return FrostSpider;
          yield return ObsidianGolem;
          break;

        case Heightmap.Biome.Plains:
          yield return GoblinBase;
          yield return GoblinLoot;
          yield return GoblinShamanNew;
          yield return BrownSpider;
          break;

        case Heightmap.Biome.Mistlands:
          yield return TreeSpider;
          break;

        case Heightmap.Biome.AshLands:
          yield return FireGolem;
          yield return SkeletonWarriorFire;
          break;

        case Heightmap.Biome.DeepNorth:
          yield return SkeletonWarriorIce;
          yield return IceGolem;
          break;
      }
    }
  }
}
