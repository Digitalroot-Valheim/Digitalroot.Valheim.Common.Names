using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names.Vanilla;

public static partial class NpcNames
{
  public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(NpcNames));
  public static readonly string Haldor = PrefabNames.Haldor;
  public static readonly string Hildir = PrefabNames.Hildir;
  public static readonly string BogWitch = PrefabNames.BogWitch;
  public static readonly string Odin = PrefabNames.Odin;
  public static readonly string BogWitchKvastur = PrefabNames.BogWitchKvastur;
}
