using JetBrains.Annotations;
using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names
{
  public static partial class EnemyNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(EnemyNames));
    public static readonly string Blob = nameof(Blob);
    public static readonly string BlobElite = nameof(BlobElite);
    public static readonly string Boar = nameof(Boar);
    public static readonly string BoarPiggy = "Boar_piggy";
    public static readonly string Crow = nameof(Crow);
    public static readonly string Deathsquito = nameof(Deathsquito);
    public static readonly string Deer = nameof(Deer);
    public static readonly string Drake = "Hatchling";
    public static readonly string Draugr = nameof(Draugr);
    public static readonly string DraugrElite = "Draugr_Elite";
    public static readonly string DraugrRanged = "Draugr_Ranged";
    public static readonly string Fenring = nameof(Fenring);
    public static readonly string Ghost = nameof(Ghost);
    public static readonly string Goblin = nameof(Goblin);
    public static readonly string GoblinArcher = nameof(GoblinArcher);
    public static readonly string GoblinBrute = nameof(GoblinBrute);
    public static readonly string GoblinShaman = nameof(GoblinShaman);
    public static readonly string Greydwarf = nameof(Greydwarf);
    public static readonly string GreydwarfElite = "Greydwarf_Elite";
    public static readonly string GreydwarfShaman = "Greydwarf_Shaman";
    public static readonly string Greyling = nameof(Greyling);
    public static readonly string Leech = nameof(Leech);
    public static readonly string Lox = nameof(Lox);
    public static readonly string Neck = nameof(Neck);
    public static readonly string Seagal = nameof(Seagal);
    public static readonly string Serpent = nameof(Serpent);
    public static readonly string Skeleton = nameof(Skeleton);
    public static readonly string SkeletonPoison = "Skeleton_Poison";
    public static readonly string StoneGolem = nameof(StoneGolem);
    public static readonly string Surtling = nameof(Surtling);
    public static readonly string Troll = nameof(Troll);
    public static readonly string Valkyrie = nameof(Valkyrie);
    public static readonly string Wolf = nameof(Wolf);
    public static readonly string WolfCub = "Wolf_cub";
    public static readonly string Wraith = nameof(Wraith);
    public static readonly string Bear = nameof(Bear);
    public static readonly string BearCub = "Bear_cub";

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Meadows:
          yield return Boar;
          yield return Deer;
          yield return Draugr;
          yield return Ghost;
          yield return Greyling;
          yield return Greydwarf;
          yield return GreydwarfElite;
          yield return GreydwarfShaman;
          yield return Neck;
          yield return Skeleton;
          break;

        case Heightmap.Biome.BlackForest:
          yield return Deer;
          yield return Ghost;
          yield return Greydwarf;
          yield return GreydwarfElite;
          yield return GreydwarfShaman;
          yield return Skeleton;
          yield return SkeletonPoison;
          yield return Troll;
          break;

        case Heightmap.Biome.Swamp:
          yield return Blob;
          yield return BlobElite;
          yield return Draugr;
          yield return DraugrElite;
          yield return DraugrRanged;
          yield return Leech;
          yield return Surtling;
          yield return Wraith;
          break;

        case Heightmap.Biome.Mountain:
          yield return Drake;
          yield return Fenring;
          yield return StoneGolem;
          yield return Wolf;
          break;

        case Heightmap.Biome.Plains:
          yield return Deathsquito;
          yield return Goblin;
          yield return GoblinArcher;
          yield return GoblinBrute;
          yield return GoblinShaman;
          yield return Lox;
          break;

        case Heightmap.Biome.Ocean:
          yield return Serpent;
          break;
      }
    }
  }
}
