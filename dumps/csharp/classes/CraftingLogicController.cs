using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingLogicController : CraftingMainLogicController
	{
		private inkCompoundWidgetReference _ingredientsWeaponContainer;
		private inkWidgetReference _itemPreviewContainer;
		private inkWidgetReference _weaponPreviewContainer;
		private inkWidgetReference _garmentPreviewContainer;
		private inkWidgetReference _perkNotificationContainer;
		private inkTextWidgetReference _perkNotificationText;
		private wCHandle<AGenericTooltipController> _itemTooltipController;
		private wCHandle<AGenericTooltipController> _quickHackTooltipController;
		private CHandle<ATooltipData> _tooltipData;
		private wCHandle<InventoryWeaponDisplayController> _ingredientWeaponController;
		private wCHandle<InventoryWeaponDisplayController> _ingredientClothingController;
		private CHandle<gameItemData> _selectedItemGameData;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private wCHandle<CraftBook> _playerCraftBook;
		private CBool _hasSpawnedQuickHackTooltip;
		private CFloat _timeUntilReset;

		[Ordinal(51)] 
		[RED("ingredientsWeaponContainer")] 
		public inkCompoundWidgetReference IngredientsWeaponContainer
		{
			get => GetProperty(ref _ingredientsWeaponContainer);
			set => SetProperty(ref _ingredientsWeaponContainer, value);
		}

		[Ordinal(52)] 
		[RED("itemPreviewContainer")] 
		public inkWidgetReference ItemPreviewContainer
		{
			get => GetProperty(ref _itemPreviewContainer);
			set => SetProperty(ref _itemPreviewContainer, value);
		}

		[Ordinal(53)] 
		[RED("weaponPreviewContainer")] 
		public inkWidgetReference WeaponPreviewContainer
		{
			get => GetProperty(ref _weaponPreviewContainer);
			set => SetProperty(ref _weaponPreviewContainer, value);
		}

		[Ordinal(54)] 
		[RED("garmentPreviewContainer")] 
		public inkWidgetReference GarmentPreviewContainer
		{
			get => GetProperty(ref _garmentPreviewContainer);
			set => SetProperty(ref _garmentPreviewContainer, value);
		}

		[Ordinal(55)] 
		[RED("perkNotificationContainer")] 
		public inkWidgetReference PerkNotificationContainer
		{
			get => GetProperty(ref _perkNotificationContainer);
			set => SetProperty(ref _perkNotificationContainer, value);
		}

		[Ordinal(56)] 
		[RED("perkNotificationText")] 
		public inkTextWidgetReference PerkNotificationText
		{
			get => GetProperty(ref _perkNotificationText);
			set => SetProperty(ref _perkNotificationText, value);
		}

		[Ordinal(57)] 
		[RED("itemTooltipController")] 
		public wCHandle<AGenericTooltipController> ItemTooltipController
		{
			get => GetProperty(ref _itemTooltipController);
			set => SetProperty(ref _itemTooltipController, value);
		}

		[Ordinal(58)] 
		[RED("quickHackTooltipController")] 
		public wCHandle<AGenericTooltipController> QuickHackTooltipController
		{
			get => GetProperty(ref _quickHackTooltipController);
			set => SetProperty(ref _quickHackTooltipController, value);
		}

		[Ordinal(59)] 
		[RED("tooltipData")] 
		public CHandle<ATooltipData> TooltipData
		{
			get => GetProperty(ref _tooltipData);
			set => SetProperty(ref _tooltipData, value);
		}

		[Ordinal(60)] 
		[RED("ingredientWeaponController")] 
		public wCHandle<InventoryWeaponDisplayController> IngredientWeaponController
		{
			get => GetProperty(ref _ingredientWeaponController);
			set => SetProperty(ref _ingredientWeaponController, value);
		}

		[Ordinal(61)] 
		[RED("ingredientClothingController")] 
		public wCHandle<InventoryWeaponDisplayController> IngredientClothingController
		{
			get => GetProperty(ref _ingredientClothingController);
			set => SetProperty(ref _ingredientClothingController, value);
		}

		[Ordinal(62)] 
		[RED("selectedItemGameData")] 
		public CHandle<gameItemData> SelectedItemGameData
		{
			get => GetProperty(ref _selectedItemGameData);
			set => SetProperty(ref _selectedItemGameData, value);
		}

		[Ordinal(63)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetProperty(ref _quantityPickerPopupToken);
			set => SetProperty(ref _quantityPickerPopupToken, value);
		}

		[Ordinal(64)] 
		[RED("playerCraftBook")] 
		public wCHandle<CraftBook> PlayerCraftBook
		{
			get => GetProperty(ref _playerCraftBook);
			set => SetProperty(ref _playerCraftBook, value);
		}

		[Ordinal(65)] 
		[RED("hasSpawnedQuickHackTooltip")] 
		public CBool HasSpawnedQuickHackTooltip
		{
			get => GetProperty(ref _hasSpawnedQuickHackTooltip);
			set => SetProperty(ref _hasSpawnedQuickHackTooltip, value);
		}

		[Ordinal(66)] 
		[RED("timeUntilReset")] 
		public CFloat TimeUntilReset
		{
			get => GetProperty(ref _timeUntilReset);
			set => SetProperty(ref _timeUntilReset, value);
		}

		public CraftingLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
