using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names
{
  public static class PrefabNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string Cauldron = "piece_cauldron";
    public static readonly string DraugrElite = "Draugr_Elite";
    public static readonly string Fenring = nameof(Fenring);
    public static readonly string FirePit = "fire_pit";
    public static readonly string ForceField = nameof(ForceField);
    public static readonly string GoblinBrute = nameof(GoblinBrute);
    public static readonly string GoblinShaman = nameof(GoblinShaman);
    public static readonly string Munin = nameof(Munin);
    public static readonly string Odin = "odin";
    public static readonly string Troll = nameof(Troll);
  }
}
