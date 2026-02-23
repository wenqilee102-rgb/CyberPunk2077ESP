using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemRequirementsManager : IScriptable
	{
		private CInt32 _itemRequiredLevel;
		private CInt32 _requiredStrength;
		private CInt32 _requiredReflex;
		private CString _perkRequirementName;
		private CBool _isSmartlinkRequirementMet;
		private CBool _isLevelRequirementMet;
		private CBool _isStrengthRequirementMet;
		private CBool _isReflexRequirementMet;
		private CBool _isPerkRequirementMet;
		private CBool _isHumanityRequirementMet;
		private CBool _isEquippable;
		private CBool _isEquippableAdditionalValue;
		private CBool _isEquippableFetched;
		private CArray<gameSItemStackRequirementData> _equipRequirements;
		private CBool _equipRequirementsFetched;
		private wCHandle<gameObject> _player;
		private wCHandle<UIInventoryItem> _attachedItem;

		[Ordinal(0)] 
		[RED("itemRequiredLevel")] 
		public CInt32 ItemRequiredLevel
		{
			get => GetProperty(ref _itemRequiredLevel);
			set => SetProperty(ref _itemRequiredLevel, value);
		}

		[Ordinal(1)] 
		[RED("requiredStrength")] 
		public CInt32 RequiredStrength
		{
			get => GetProperty(ref _requiredStrength);
			set => SetProperty(ref _requiredStrength, value);
		}

		[Ordinal(2)] 
		[RED("requiredReflex")] 
		public CInt32 RequiredReflex
		{
			get => GetProperty(ref _requiredReflex);
			set => SetProperty(ref _requiredReflex, value);
		}

		[Ordinal(3)] 
		[RED("perkRequirementName")] 
		public CString PerkRequirementName
		{
			get => GetProperty(ref _perkRequirementName);
			set => SetProperty(ref _perkRequirementName, value);
		}

		[Ordinal(4)] 
		[RED("isSmartlinkRequirementMet")] 
		public CBool IsSmartlinkRequirementMet
		{
			get => GetProperty(ref _isSmartlinkRequirementMet);
			set => SetProperty(ref _isSmartlinkRequirementMet, value);
		}

		[Ordinal(5)] 
		[RED("isLevelRequirementMet")] 
		public CBool IsLevelRequirementMet
		{
			get => GetProperty(ref _isLevelRequirementMet);
			set => SetProperty(ref _isLevelRequirementMet, value);
		}

		[Ordinal(6)] 
		[RED("isStrengthRequirementMet")] 
		public CBool IsStrengthRequirementMet
		{
			get => GetProperty(ref _isStrengthRequirementMet);
			set => SetProperty(ref _isStrengthRequirementMet, value);
		}

		[Ordinal(7)] 
		[RED("isReflexRequirementMet")] 
		public CBool IsReflexRequirementMet
		{
			get => GetProperty(ref _isReflexRequirementMet);
			set => SetProperty(ref _isReflexRequirementMet, value);
		}

		[Ordinal(8)] 
		[RED("isPerkRequirementMet")] 
		public CBool IsPerkRequirementMet
		{
			get => GetProperty(ref _isPerkRequirementMet);
			set => SetProperty(ref _isPerkRequirementMet, value);
		}

		[Ordinal(9)] 
		[RED("isHumanityRequirementMet")] 
		public CBool IsHumanityRequirementMet
		{
			get => GetProperty(ref _isHumanityRequirementMet);
			set => SetProperty(ref _isHumanityRequirementMet, value);
		}

		[Ordinal(10)] 
		[RED("isEquippable")] 
		public CBool IsEquippable
		{
			get => GetProperty(ref _isEquippable);
			set => SetProperty(ref _isEquippable, value);
		}

		[Ordinal(11)] 
		[RED("isEquippableAdditionalValue")] 
		public CBool IsEquippableAdditionalValue
		{
			get => GetProperty(ref _isEquippableAdditionalValue);
			set => SetProperty(ref _isEquippableAdditionalValue, value);
		}

		[Ordinal(12)] 
		[RED("isEquippableFetched")] 
		public CBool IsEquippableFetched
		{
			get => GetProperty(ref _isEquippableFetched);
			set => SetProperty(ref _isEquippableFetched, value);
		}

		[Ordinal(13)] 
		[RED("equipRequirements")] 
		public CArray<gameSItemStackRequirementData> EquipRequirements
		{
			get => GetProperty(ref _equipRequirements);
			set => SetProperty(ref _equipRequirements, value);
		}

		[Ordinal(14)] 
		[RED("equipRequirementsFetched")] 
		public CBool EquipRequirementsFetched
		{
			get => GetProperty(ref _equipRequirementsFetched);
			set => SetProperty(ref _equipRequirementsFetched, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("attachedItem")] 
		public wCHandle<UIInventoryItem> AttachedItem
		{
			get => GetProperty(ref _attachedItem);
			set => SetProperty(ref _attachedItem, value);
		}

		public UIInventoryItemRequirementsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
