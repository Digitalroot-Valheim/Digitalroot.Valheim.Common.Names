using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Valheim.Common.Names
{
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static partial class MonsterLabZBossNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));

    public static readonly string Kraken = nameof(Kraken);
    public static readonly string KrakenLD = nameof(KrakenLD);
    public static readonly string SpiderBoss = "Spider_Boss";

  }
}
