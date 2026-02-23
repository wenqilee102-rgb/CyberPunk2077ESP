using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetLootIconsVisibility_NodeType : questIUIManagerNodeType
	{
		private CBool _lootIconsVisible;

		[Ordinal(0)] 
		[RED("lootIconsVisible")] 
		public CBool LootIconsVisible
		{
			get => GetProperty(ref _lootIconsVisible);
			set => SetProperty(ref _lootIconsVisible, value);
		}

		public questSetLootIconsVisibility_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
