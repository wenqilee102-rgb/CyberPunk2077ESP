using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackCraftingMaterialItemCallbackData : IScriptable
	{
		private CHandle<CachedCraftingMaterial> _craftingMaterial;

		[Ordinal(0)] 
		[RED("craftingMaterial")] 
		public CHandle<CachedCraftingMaterial> CraftingMaterial
		{
			get => GetProperty(ref _craftingMaterial);
			set => SetProperty(ref _craftingMaterial, value);
		}

		public BackpackCraftingMaterialItemCallbackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
