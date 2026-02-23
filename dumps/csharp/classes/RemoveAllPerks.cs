using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveAllPerks : gamePlayerScriptableSystemRequest
	{
		private CBool _unequipPerkItems;
		private CBool _removeCost;

		[Ordinal(1)] 
		[RED("unequipPerkItems")] 
		public CBool UnequipPerkItems
		{
			get => GetProperty(ref _unequipPerkItems);
			set => SetProperty(ref _unequipPerkItems, value);
		}

		[Ordinal(2)] 
		[RED("removeCost")] 
		public CBool RemoveCost
		{
			get => GetProperty(ref _removeCost);
			set => SetProperty(ref _removeCost, value);
		}

		public RemoveAllPerks(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
