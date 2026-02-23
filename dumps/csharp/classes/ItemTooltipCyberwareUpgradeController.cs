using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipCyberwareUpgradeController : ItemTooltipModuleController
	{
		private inkCompoundWidgetReference _componentsContainer;
		private inkCompoundWidgetReference _moneyContainer;
		private inkTextWidgetReference _moneyCostLabel;
		private inkWidgetReference _upgradeProgressBarRef;
		private CName _upgradeCWInputName;
		private CName _progressEffectName;
		private CName _progressBarAnimName;
		private inkCompoundWidgetReference _ripperdocContainer;
		private inkCompoundWidgetReference _inventoryContainer;
		private inkWidgetReference _inputHint;
		private inkTextWidgetReference _rarityLabel;
		private CName _upgradeIconAnimName;
		private CName _reqNotMetAnimName;
		private wCHandle<inkWidget> _root;
		private wCHandle<CrafringMaterialItemController> _componentsController;
		private CHandle<CachedCraftingMaterial> _craftingMaterial;
		private CBool _isUpgradable;
		private CBool _isUpgradeScreen;
		private CBool _isRipperdoc;
		private CHandle<inkanimProxy> _upgradeIconAnimProxy;
		private inkanimPlaybackOptions _upgradeIconAnimOptions;
		private wCHandle<inkWidget> _upgradeProgressBar;
		private CBool _progressStarted;
		private CHandle<inkanimProxy> _progressBarAnimProxy;

		[Ordinal(5)] 
		[RED("componentsContainer")] 
		public inkCompoundWidgetReference ComponentsContainer
		{
			get => GetProperty(ref _componentsContainer);
			set => SetProperty(ref _componentsContainer, value);
		}

		[Ordinal(6)] 
		[RED("moneyContainer")] 
		public inkCompoundWidgetReference MoneyContainer
		{
			get => GetProperty(ref _moneyContainer);
			set => SetProperty(ref _moneyContainer, value);
		}

		[Ordinal(7)] 
		[RED("moneyCostLabel")] 
		public inkTextWidgetReference MoneyCostLabel
		{
			get => GetProperty(ref _moneyCostLabel);
			set => SetProperty(ref _moneyCostLabel, value);
		}

		[Ordinal(8)] 
		[RED("upgradeProgressBarRef")] 
		public inkWidgetReference UpgradeProgressBarRef
		{
			get => GetProperty(ref _upgradeProgressBarRef);
			set => SetProperty(ref _upgradeProgressBarRef, value);
		}

		[Ordinal(9)] 
		[RED("upgradeCWInputName")] 
		public CName UpgradeCWInputName
		{
			get => GetProperty(ref _upgradeCWInputName);
			set => SetProperty(ref _upgradeCWInputName, value);
		}

		[Ordinal(10)] 
		[RED("progressEffectName")] 
		public CName ProgressEffectName
		{
			get => GetProperty(ref _progressEffectName);
			set => SetProperty(ref _progressEffectName, value);
		}

		[Ordinal(11)] 
		[RED("progressBarAnimName")] 
		public CName ProgressBarAnimName
		{
			get => GetProperty(ref _progressBarAnimName);
			set => SetProperty(ref _progressBarAnimName, value);
		}

		[Ordinal(12)] 
		[RED("ripperdocContainer")] 
		public inkCompoundWidgetReference RipperdocContainer
		{
			get => GetProperty(ref _ripperdocContainer);
			set => SetProperty(ref _ripperdocContainer, value);
		}

		[Ordinal(13)] 
		[RED("inventoryContainer")] 
		public inkCompoundWidgetReference InventoryContainer
		{
			get => GetProperty(ref _inventoryContainer);
			set => SetProperty(ref _inventoryContainer, value);
		}

		[Ordinal(14)] 
		[RED("inputHint")] 
		public inkWidgetReference InputHint
		{
			get => GetProperty(ref _inputHint);
			set => SetProperty(ref _inputHint, value);
		}

		[Ordinal(15)] 
		[RED("rarityLabel")] 
		public inkTextWidgetReference RarityLabel
		{
			get => GetProperty(ref _rarityLabel);
			set => SetProperty(ref _rarityLabel, value);
		}

		[Ordinal(16)] 
		[RED("upgradeIconAnimName")] 
		public CName UpgradeIconAnimName
		{
			get => GetProperty(ref _upgradeIconAnimName);
			set => SetProperty(ref _upgradeIconAnimName, value);
		}

		[Ordinal(17)] 
		[RED("reqNotMetAnimName")] 
		public CName ReqNotMetAnimName
		{
			get => GetProperty(ref _reqNotMetAnimName);
			set => SetProperty(ref _reqNotMetAnimName, value);
		}

		[Ordinal(18)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(19)] 
		[RED("componentsController")] 
		public wCHandle<CrafringMaterialItemController> ComponentsController
		{
			get => GetProperty(ref _componentsController);
			set => SetProperty(ref _componentsController, value);
		}

		[Ordinal(20)] 
		[RED("craftingMaterial")] 
		public CHandle<CachedCraftingMaterial> CraftingMaterial
		{
			get => GetProperty(ref _craftingMaterial);
			set => SetProperty(ref _craftingMaterial, value);
		}

		[Ordinal(21)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetProperty(ref _isUpgradable);
			set => SetProperty(ref _isUpgradable, value);
		}

		[Ordinal(22)] 
		[RED("isUpgradeScreen")] 
		public CBool IsUpgradeScreen
		{
			get => GetProperty(ref _isUpgradeScreen);
			set => SetProperty(ref _isUpgradeScreen, value);
		}

		[Ordinal(23)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetProperty(ref _isRipperdoc);
			set => SetProperty(ref _isRipperdoc, value);
		}

		[Ordinal(24)] 
		[RED("upgradeIconAnimProxy")] 
		public CHandle<inkanimProxy> UpgradeIconAnimProxy
		{
			get => GetProperty(ref _upgradeIconAnimProxy);
			set => SetProperty(ref _upgradeIconAnimProxy, value);
		}

		[Ordinal(25)] 
		[RED("upgradeIconAnimOptions")] 
		public inkanimPlaybackOptions UpgradeIconAnimOptions
		{
			get => GetProperty(ref _upgradeIconAnimOptions);
			set => SetProperty(ref _upgradeIconAnimOptions, value);
		}

		[Ordinal(26)] 
		[RED("upgradeProgressBar")] 
		public wCHandle<inkWidget> UpgradeProgressBar
		{
			get => GetProperty(ref _upgradeProgressBar);
			set => SetProperty(ref _upgradeProgressBar, value);
		}

		[Ordinal(27)] 
		[RED("progressStarted")] 
		public CBool ProgressStarted
		{
			get => GetProperty(ref _progressStarted);
			set => SetProperty(ref _progressStarted, value);
		}

		[Ordinal(28)] 
		[RED("progressBarAnimProxy")] 
		public CHandle<inkanimProxy> ProgressBarAnimProxy
		{
			get => GetProperty(ref _progressBarAnimProxy);
			set => SetProperty(ref _progressBarAnimProxy, value);
		}

		public ItemTooltipCyberwareUpgradeController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
