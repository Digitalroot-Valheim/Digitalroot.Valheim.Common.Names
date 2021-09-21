using JetBrains.Annotations;
using System.Collections.Generic;

namespace Digitalroot.Valheim.Common.Names.BearsMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string Bear = nameof(Bear);
    public const string BearCub = "Bear_cub";
  }
}
