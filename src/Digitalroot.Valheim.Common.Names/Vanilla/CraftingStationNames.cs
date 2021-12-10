using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names.Vanilla
{
  public static partial class CraftingStationNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(CraftingStationNames));
    public static readonly string ArtisanTable = PrefabNames.PieceArtisanstation;
    public static readonly string Cauldron = PrefabNames.PieceCauldron;
    public static readonly string Forge = PrefabNames.Forge;
    public static readonly string Stonecutter = PrefabNames.PieceStonecutter;
    public static readonly string Workbench = PrefabNames.PieceWorkbench;
  }
}
