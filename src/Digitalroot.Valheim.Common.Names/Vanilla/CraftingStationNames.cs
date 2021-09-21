using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names.Vanilla
{
  public static partial class CraftingStationNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string ArtisanTable = "piece_artisanstation";
    public static readonly string Cauldron = "piece_cauldron";
    public static readonly string Forge = "forge";
    public static readonly string Stonecutter = "piece_stonecutter";
    public static readonly string Workbench = "piece_workbench";
  }
}
