using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names
{
  public static partial class BossNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string Eikthyr = nameof(Eikthyr);
    public static readonly string TheElder = "gd_king";
    public static readonly string Bonemass = nameof(Bonemass);
    public static readonly string Moder = "Dragon";
    public static readonly string Yagluth = "GoblinKing";
  }
}
