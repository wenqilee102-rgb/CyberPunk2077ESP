using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingGarmentItemPreviewGameController : gameuiWardrobeSetPreviewGameController
	{
		private CArray<gameItemID> _initialItems;
		private gameItemID _previewedItem;

		[Ordinal(24)] 
		[RED("initialItems")] 
		public CArray<gameItemID> InitialItems
		{
			get => GetProperty(ref _initialItems);
			set => SetProperty(ref _initialItems, value);
		}

		[Ordinal(25)] 
		[RED("previewedItem")] 
		public gameItemID PreviewedItem
		{
			get => GetProperty(ref _previewedItem);
			set => SetProperty(ref _previewedItem, value);
		}

		public CraftingGarmentItemPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
