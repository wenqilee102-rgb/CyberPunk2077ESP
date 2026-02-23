using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipController : AGenericTooltipControllerWithDebug
	{
		private inkCompoundWidgetReference _backgroundContainer;
		private inkWidgetReference _equipedWrapper;
		private inkWidgetReference _equipedCorner;
		private inkWidgetReference _recipeWrapper;
		private inkWidgetReference _recipeBG;
		private inkWidgetReference _root_144;
		private inkTextWidgetReference _nameText;
		private inkWidgetReference _nameTextContainer;
		private inkTextWidgetReference _nameForRecipeText;
		private inkTextWidgetReference _tierText;
		private inkWidgetReference _durationWidget;
		private inkWidgetReference _uploadTimeWidget;
		private inkWidgetReference _cooldownWidget;
		private inkTextWidgetReference _memoryCostValueText;
		private inkWidgetReference _damageWrapper;
		private inkTextWidgetReference _damageLabel;
		private inkTextWidgetReference _damageValue;
		private inkTextWidgetReference _damageContinuous;
		private inkTextWidgetReference _healthPercentageLabel;
		private inkWidgetReference _priceContainer;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _descriptionWrapper;
		private inkTextWidgetReference _descriptionText;
		private inkWidgetReference _hackTypeWrapper;
		private inkTextWidgetReference _hackTypeText;
		private inkWidgetReference _perkContainer;
		private inkTextWidgetReference _perkText;
		private inkWidgetReference _qualityContainer;
		private inkTextWidgetReference _qualityText;
		private inkCompoundWidgetReference _effectsList;
		private inkWidgetReference _headerSegment;
		private inkWidgetReference _typeSegment;
		private inkWidgetReference _dEBUG_iconErrorWrapper;
		private inkTextWidgetReference _dEBUG_iconErrorText;
		private CHandle<InventoryTooltipData> _data;
		private InventoryTooltipData_QuickhackData _quickHackData;
		private wCHandle<UIInventoryItem> _itemData;
		private CEnum<InventoryTooltipDisplayContext> _displayContext;
		private CEnum<gameItemDisplayContext> _itemDisplayContext;
		private CBool _isCrafting;

		[Ordinal(5)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get => GetProperty(ref _backgroundContainer);
			set => SetProperty(ref _backgroundContainer, value);
		}

		[Ordinal(6)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get => GetProperty(ref _equipedWrapper);
			set => SetProperty(ref _equipedWrapper, value);
		}

		[Ordinal(7)] 
		[RED("equipedCorner")] 
		public inkWidgetReference EquipedCorner
		{
			get => GetProperty(ref _equipedCorner);
			set => SetProperty(ref _equipedCorner, value);
		}

		[Ordinal(8)] 
		[RED("recipeWrapper")] 
		public inkWidgetReference RecipeWrapper
		{
			get => GetProperty(ref _recipeWrapper);
			set => SetProperty(ref _recipeWrapper, value);
		}

		[Ordinal(9)] 
		[RED("recipeBG")] 
		public inkWidgetReference RecipeBG
		{
			get => GetProperty(ref _recipeBG);
			set => SetProperty(ref _recipeBG, value);
		}

		[Ordinal(10)] 
		[RED("root")] 
		public inkWidgetReference Root_144
		{
			get => GetProperty(ref _root_144);
			set => SetProperty(ref _root_144, value);
		}

		[Ordinal(11)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
		}

		[Ordinal(12)] 
		[RED("nameTextContainer")] 
		public inkWidgetReference NameTextContainer
		{
			get => GetProperty(ref _nameTextContainer);
			set => SetProperty(ref _nameTextContainer, value);
		}

		[Ordinal(13)] 
		[RED("nameForRecipeText")] 
		public inkTextWidgetReference NameForRecipeText
		{
			get => GetProperty(ref _nameForRecipeText);
			set => SetProperty(ref _nameForRecipeText, value);
		}

		[Ordinal(14)] 
		[RED("tierText")] 
		public inkTextWidgetReference TierText
		{
			get => GetProperty(ref _tierText);
			set => SetProperty(ref _tierText, value);
		}

		[Ordinal(15)] 
		[RED("durationWidget")] 
		public inkWidgetReference DurationWidget
		{
			get => GetProperty(ref _durationWidget);
			set => SetProperty(ref _durationWidget, value);
		}

		[Ordinal(16)] 
		[RED("uploadTimeWidget")] 
		public inkWidgetReference UploadTimeWidget
		{
			get => GetProperty(ref _uploadTimeWidget);
			set => SetProperty(ref _uploadTimeWidget, value);
		}

		[Ordinal(17)] 
		[RED("cooldownWidget")] 
		public inkWidgetReference CooldownWidget
		{
			get => GetProperty(ref _cooldownWidget);
			set => SetProperty(ref _cooldownWidget, value);
		}

		[Ordinal(18)] 
		[RED("memoryCostValueText")] 
		public inkTextWidgetReference MemoryCostValueText
		{
			get => GetProperty(ref _memoryCostValueText);
			set => SetProperty(ref _memoryCostValueText, value);
		}

		[Ordinal(19)] 
		[RED("damageWrapper")] 
		public inkWidgetReference DamageWrapper
		{
			get => GetProperty(ref _damageWrapper);
			set => SetProperty(ref _damageWrapper, value);
		}

		[Ordinal(20)] 
		[RED("damageLabel")] 
		public inkTextWidgetReference DamageLabel
		{
			get => GetProperty(ref _damageLabel);
			set => SetProperty(ref _damageLabel, value);
		}

		[Ordinal(21)] 
		[RED("damageValue")] 
		public inkTextWidgetReference DamageValue
		{
			get => GetProperty(ref _damageValue);
			set => SetProperty(ref _damageValue, value);
		}

		[Ordinal(22)] 
		[RED("damageContinuous")] 
		public inkTextWidgetReference DamageContinuous
		{
			get => GetProperty(ref _damageContinuous);
			set => SetProperty(ref _damageContinuous, value);
		}

		[Ordinal(23)] 
		[RED("healthPercentageLabel")] 
		public inkTextWidgetReference HealthPercentageLabel
		{
			get => GetProperty(ref _healthPercentageLabel);
			set => SetProperty(ref _healthPercentageLabel, value);
		}

		[Ordinal(24)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get => GetProperty(ref _priceContainer);
			set => SetProperty(ref _priceContainer, value);
		}

		[Ordinal(25)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(26)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetProperty(ref _descriptionWrapper);
			set => SetProperty(ref _descriptionWrapper, value);
		}

		[Ordinal(27)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(28)] 
		[RED("hackTypeWrapper")] 
		public inkWidgetReference HackTypeWrapper
		{
			get => GetProperty(ref _hackTypeWrapper);
			set => SetProperty(ref _hackTypeWrapper, value);
		}

		[Ordinal(29)] 
		[RED("hackTypeText")] 
		public inkTextWidgetReference HackTypeText
		{
			get => GetProperty(ref _hackTypeText);
			set => SetProperty(ref _hackTypeText, value);
		}

		[Ordinal(30)] 
		[RED("perkContainer")] 
		public inkWidgetReference PerkContainer
		{
			get => GetProperty(ref _perkContainer);
			set => SetProperty(ref _perkContainer, value);
		}

		[Ordinal(31)] 
		[RED("perkText")] 
		public inkTextWidgetReference PerkText
		{
			get => GetProperty(ref _perkText);
			set => SetProperty(ref _perkText, value);
		}

		[Ordinal(32)] 
		[RED("qualityContainer")] 
		public inkWidgetReference QualityContainer
		{
			get => GetProperty(ref _qualityContainer);
			set => SetProperty(ref _qualityContainer, value);
		}

		[Ordinal(33)] 
		[RED("qualityText")] 
		public inkTextWidgetReference QualityText
		{
			get => GetProperty(ref _qualityText);
			set => SetProperty(ref _qualityText, value);
		}

		[Ordinal(34)] 
		[RED("effectsList")] 
		public inkCompoundWidgetReference EffectsList
		{
			get => GetProperty(ref _effectsList);
			set => SetProperty(ref _effectsList, value);
		}

		[Ordinal(35)] 
		[RED("headerSegment")] 
		public inkWidgetReference HeaderSegment
		{
			get => GetProperty(ref _headerSegment);
			set => SetProperty(ref _headerSegment, value);
		}

		[Ordinal(36)] 
		[RED("typeSegment")] 
		public inkWidgetReference TypeSegment
		{
			get => GetProperty(ref _typeSegment);
			set => SetProperty(ref _typeSegment, value);
		}

		[Ordinal(37)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetProperty(ref _dEBUG_iconErrorWrapper);
			set => SetProperty(ref _dEBUG_iconErrorWrapper, value);
		}

		[Ordinal(38)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetProperty(ref _dEBUG_iconErrorText);
			set => SetProperty(ref _dEBUG_iconErrorText, value);
		}

		[Ordinal(39)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(40)] 
		[RED("quickHackData")] 
		public InventoryTooltipData_QuickhackData QuickHackData
		{
			get => GetProperty(ref _quickHackData);
			set => SetProperty(ref _quickHackData, value);
		}

		[Ordinal(41)] 
		[RED("itemData")] 
		public wCHandle<UIInventoryItem> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(42)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(43)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		[Ordinal(44)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetProperty(ref _isCrafting);
			set => SetProperty(ref _isCrafting, value);
		}

		public ProgramTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
