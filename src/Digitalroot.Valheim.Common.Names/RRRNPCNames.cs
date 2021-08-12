using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.Common.Names
{
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static partial class RRRNPCNames
  {
    private const string PrefixBase = "RRR_";
    private const string PrefixNpc = "RRRN_";
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(RRRNPCNames));

    public static readonly string NPC = $"{PrefixBase}{nameof(NPC)}";

    public static readonly string DvergrEvent = $"{PrefixNpc}{nameof(DvergrEvent)}";
    public static readonly string Dvergr = $"{PrefixNpc}{nameof(Dvergr)}";
    public static readonly string Ashe = $"{PrefixNpc}{nameof(Ashe)}";
    public static readonly string Dvorah = $"{PrefixNpc}{nameof(Dvorah)}";
    public static readonly string Dwarf = $"{PrefixNpc}{nameof(Dwarf)}";
    public static readonly string Eir = $"{PrefixNpc}{nameof(Eir)}";
    public static readonly string Mage = $"{PrefixNpc}{nameof(Mage)}";
    public static readonly string Necromancer = $"{PrefixNpc}{nameof(Necromancer)}";
    public static readonly string Friendly1 = $"{PrefixNpc}{nameof(Friendly1)}";
    public static readonly string FriendlyMeleeFem0 = $"{PrefixNpc}FriendlyMelee_Fem_0";
    public static readonly string FriendlyMeleeMale0 = $"{PrefixNpc}FriendlyMelee_Male_0";
    public static readonly string Friendly2 = $"{PrefixNpc}{nameof(Friendly2)}";
    public static readonly string Friendly3 = $"{PrefixNpc}{nameof(Friendly3)}";
    public static readonly string Friendly4 = $"{PrefixNpc}{nameof(Friendly4)}";
    public static readonly string Friendly05 = $"{PrefixNpc}{nameof(Friendly05)}";
    public static readonly string Friendly15 = $"{PrefixNpc}{nameof(Friendly15)}";
    public static readonly string Friendly25 = $"{PrefixNpc}{nameof(Friendly25)}";
    public static readonly string Friendly35 = $"{PrefixNpc}{nameof(Friendly35)}";
    public static readonly string Friendly45 = $"{PrefixNpc}{nameof(Friendly45)}";
  }
}
