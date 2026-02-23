using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackDescriptionGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _subHeader;
		private inkTextWidgetReference _tier;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _recompileTimer;
		private inkTextWidgetReference _duration;
		private inkWidgetReference _durationRoot;
		private inkTextWidgetReference _cooldown;
		private inkWidgetReference _cooldownRoot;
		private inkTextWidgetReference _uploadTime;
		private inkWidgetReference _uploadTimeRoot;
		private inkTextWidgetReference _memoryCost;
		private inkTextWidgetReference _memoryRawCost;
		private inkTextWidgetReference _categoryText;
		private inkWidgetReference _categoryContainer;
		private inkWidgetReference _damageWrapper;
		private inkTextWidgetReference _damageLabel;
		private inkTextWidgetReference _damageValue;
		private inkTextWidgetReference _healthPercentageLabel;
		private inkCompoundWidgetReference _effectsList;
		private CHandle<redCallbackObject> _quickHackDataCallbackID;
		private CHandle<QuickhackData> _selectedData;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<EquippedQuickHackData> _equippedQuickHackData;
		private CHandle<UIScriptableSystem> _uiScriptableSystem;

		[Ordinal(5)] 
		[RED("subHeader")] 
		public inkTextWidgetReference SubHeader
		{
			get => GetProperty(ref _subHeader);
			set => SetProperty(ref _subHeader, value);
		}

		[Ordinal(6)] 
		[RED("tier")] 
		public inkTextWidgetReference Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(8)] 
		[RED("recompileTimer")] 
		public inkTextWidgetReference RecompileTimer
		{
			get => GetProperty(ref _recompileTimer);
			set => SetProperty(ref _recompileTimer, value);
		}

		[Ordinal(9)] 
		[RED("duration")] 
		public inkTextWidgetReference Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(10)] 
		[RED("durationRoot")] 
		public inkWidgetReference DurationRoot
		{
			get => GetProperty(ref _durationRoot);
			set => SetProperty(ref _durationRoot, value);
		}

		[Ordinal(11)] 
		[RED("cooldown")] 
		public inkTextWidgetReference Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(12)] 
		[RED("cooldownRoot")] 
		public inkWidgetReference CooldownRoot
		{
			get => GetProperty(ref _cooldownRoot);
			set => SetProperty(ref _cooldownRoot, value);
		}

		[Ordinal(13)] 
		[RED("uploadTime")] 
		public inkTextWidgetReference UploadTime
		{
			get => GetProperty(ref _uploadTime);
			set => SetProperty(ref _uploadTime, value);
		}

		[Ordinal(14)] 
		[RED("uploadTimeRoot")] 
		public inkWidgetReference UploadTimeRoot
		{
			get => GetProperty(ref _uploadTimeRoot);
			set => SetProperty(ref _uploadTimeRoot, value);
		}

		[Ordinal(15)] 
		[RED("memoryCost")] 
		public inkTextWidgetReference MemoryCost
		{
			get => GetProperty(ref _memoryCost);
			set => SetProperty(ref _memoryCost, value);
		}

		[Ordinal(16)] 
		[RED("memoryRawCost")] 
		public inkTextWidgetReference MemoryRawCost
		{
			get => GetProperty(ref _memoryRawCost);
			set => SetProperty(ref _memoryRawCost, value);
		}

		[Ordinal(17)] 
		[RED("categoryText")] 
		public inkTextWidgetReference CategoryText
		{
			get => GetProperty(ref _categoryText);
			set => SetProperty(ref _categoryText, value);
		}

		[Ordinal(18)] 
		[RED("categoryContainer")] 
		public inkWidgetReference CategoryContainer
		{
			get => GetProperty(ref _categoryContainer);
			set => SetProperty(ref _categoryContainer, value);
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
		[RED("healthPercentageLabel")] 
		public inkTextWidgetReference HealthPercentageLabel
		{
			get => GetProperty(ref _healthPercentageLabel);
			set => SetProperty(ref _healthPercentageLabel, value);
		}

		[Ordinal(23)] 
		[RED("effectsList")] 
		public inkCompoundWidgetReference EffectsList
		{
			get => GetProperty(ref _effectsList);
			set => SetProperty(ref _effectsList, value);
		}

		[Ordinal(24)] 
		[RED("quickHackDataCallbackID")] 
		public CHandle<redCallbackObject> QuickHackDataCallbackID
		{
			get => GetProperty(ref _quickHackDataCallbackID);
			set => SetProperty(ref _quickHackDataCallbackID, value);
		}

		[Ordinal(25)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get => GetProperty(ref _selectedData);
			set => SetProperty(ref _selectedData, value);
		}

		[Ordinal(26)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(27)] 
		[RED("equippedQuickHackData")] 
		public CHandle<EquippedQuickHackData> EquippedQuickHackData
		{
			get => GetProperty(ref _equippedQuickHackData);
			set => SetProperty(ref _equippedQuickHackData, value);
		}

		[Ordinal(28)] 
		[RED("uiScriptableSystem")] 
		public CHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		public QuickHackDescriptionGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
