using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemPreviewGameController : gameuiItemPreviewGameController
	{
		private inkWidgetReference _colliderWidgetRef;
		private wCHandle<inkWidget> _colliderWidget;
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemDescriptionText;
		private inkWidgetReference _perkLine;
		private inkImageWidgetReference _perkIcon;
		private inkTextWidgetReference _perkText;
		private inkWidgetReference _typeLine;
		private inkImageWidgetReference _typeIcon;
		private inkTextWidgetReference _typeText;
		private inkTextWidgetReference _itemLevelText;
		private inkWidgetReference _itemRarityWidget;
		private CHandle<InventoryItemPreviewData> _data;
		private CBool _isMouseDown;
		private CFloat _c_ITEM_ROTATION_SPEED;

		[Ordinal(12)] 
		[RED("colliderWidgetRef")] 
		public inkWidgetReference ColliderWidgetRef
		{
			get => GetProperty(ref _colliderWidgetRef);
			set => SetProperty(ref _colliderWidgetRef, value);
		}

		[Ordinal(13)] 
		[RED("colliderWidget")] 
		public wCHandle<inkWidget> ColliderWidget
		{
			get => GetProperty(ref _colliderWidget);
			set => SetProperty(ref _colliderWidget, value);
		}

		[Ordinal(14)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(15)] 
		[RED("itemDescriptionText")] 
		public inkTextWidgetReference ItemDescriptionText
		{
			get => GetProperty(ref _itemDescriptionText);
			set => SetProperty(ref _itemDescriptionText, value);
		}

		[Ordinal(16)] 
		[RED("perkLine")] 
		public inkWidgetReference PerkLine
		{
			get => GetProperty(ref _perkLine);
			set => SetProperty(ref _perkLine, value);
		}

		[Ordinal(17)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetProperty(ref _perkIcon);
			set => SetProperty(ref _perkIcon, value);
		}

		[Ordinal(18)] 
		[RED("perkText")] 
		public inkTextWidgetReference PerkText
		{
			get => GetProperty(ref _perkText);
			set => SetProperty(ref _perkText, value);
		}

		[Ordinal(19)] 
		[RED("typeLine")] 
		public inkWidgetReference TypeLine
		{
			get => GetProperty(ref _typeLine);
			set => SetProperty(ref _typeLine, value);
		}

		[Ordinal(20)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetProperty(ref _typeIcon);
			set => SetProperty(ref _typeIcon, value);
		}

		[Ordinal(21)] 
		[RED("typeText")] 
		public inkTextWidgetReference TypeText
		{
			get => GetProperty(ref _typeText);
			set => SetProperty(ref _typeText, value);
		}

		[Ordinal(22)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get => GetProperty(ref _itemLevelText);
			set => SetProperty(ref _itemLevelText, value);
		}

		[Ordinal(23)] 
		[RED("itemRarityWidget")] 
		public inkWidgetReference ItemRarityWidget
		{
			get => GetProperty(ref _itemRarityWidget);
			set => SetProperty(ref _itemRarityWidget, value);
		}

		[Ordinal(24)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(25)] 
		[RED("isMouseDown")] 
		public CBool IsMouseDown
		{
			get => GetProperty(ref _isMouseDown);
			set => SetProperty(ref _isMouseDown, value);
		}

		[Ordinal(26)] 
		[RED("c_ITEM_ROTATION_SPEED")] 
		public CFloat C_ITEM_ROTATION_SPEED
		{
			get => GetProperty(ref _c_ITEM_ROTATION_SPEED);
			set => SetProperty(ref _c_ITEM_ROTATION_SPEED, value);
		}

		public ItemPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
