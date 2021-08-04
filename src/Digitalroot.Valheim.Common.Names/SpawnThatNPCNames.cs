using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.Common.Names
{
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static partial class SpawnThatNPCNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));

    public static readonly string Freki = nameof(Freki);
    public static readonly string Geri = nameof(Geri);
    public static readonly string Groot = nameof(Groot);
    public static readonly string MiniSkelly = nameof(MiniSkelly);
    public static readonly string MiniSquito = nameof(MiniSquito);
    public static readonly string Trundle = nameof(Trundle);
    public static readonly string DarkWolf = nameof(DarkWolf);
    public static readonly string LightWolf = nameof(LightWolf);
  }
}
