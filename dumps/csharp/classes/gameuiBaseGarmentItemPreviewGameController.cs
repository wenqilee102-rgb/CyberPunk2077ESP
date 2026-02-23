using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseGarmentItemPreviewGameController : gameuiInventoryPuppetPreviewGameController
	{
		private TweakDBID _placementSlot;
		private gameItemID _givenItem;
		private gameItemID _initialItem;

		[Ordinal(15)] 
		[RED("placementSlot")] 
		public TweakDBID PlacementSlot
		{
			get => GetProperty(ref _placementSlot);
			set => SetProperty(ref _placementSlot, value);
		}

		[Ordinal(16)] 
		[RED("givenItem")] 
		public gameItemID GivenItem
		{
			get => GetProperty(ref _givenItem);
			set => SetProperty(ref _givenItem, value);
		}

		[Ordinal(17)] 
		[RED("initialItem")] 
		public gameItemID InitialItem
		{
			get => GetProperty(ref _initialItem);
			set => SetProperty(ref _initialItem, value);
		}

		public gameuiBaseGarmentItemPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
