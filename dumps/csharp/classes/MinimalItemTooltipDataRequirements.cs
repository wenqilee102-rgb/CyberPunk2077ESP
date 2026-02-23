using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipDataRequirements : IScriptable
	{
		private CBool _isLevelRequirementNotMet;
		private CBool _isSmartlinkRequirementNotMet;
		private CBool _isStrengthRequirementNotMet;
		private CBool _isReflexRequirementNotMet;
		private CBool _isAnyStatRequirementNotMet;
		private CBool _isHumanityStatRequirementNotMet;
		private CBool _isPerkRequirementNotMet;
		private CBool _isRarityRequirementNotMet;
		private CString _strengthOrReflexStatName;
		private CString _perkLocKey;
		private CInt32 _strengthOrReflexValue;
		private CInt32 _requiredLevel;
		private CArray<CHandle<MinimalItemTooltipDataStatRequirement>> _anyStatRequirements;

		[Ordinal(0)] 
		[RED("isLevelRequirementNotMet")] 
		public CBool IsLevelRequirementNotMet
		{
			get => GetProperty(ref _isLevelRequirementNotMet);
			set => SetProperty(ref _isLevelRequirementNotMet, value);
		}

		[Ordinal(1)] 
		[RED("isSmartlinkRequirementNotMet")] 
		public CBool IsSmartlinkRequirementNotMet
		{
			get => GetProperty(ref _isSmartlinkRequirementNotMet);
			set => SetProperty(ref _isSmartlinkRequirementNotMet, value);
		}

		[Ordinal(2)] 
		[RED("isStrengthRequirementNotMet")] 
		public CBool IsStrengthRequirementNotMet
		{
			get => GetProperty(ref _isStrengthRequirementNotMet);
			set => SetProperty(ref _isStrengthRequirementNotMet, value);
		}

		[Ordinal(3)] 
		[RED("isReflexRequirementNotMet")] 
		public CBool IsReflexRequirementNotMet
		{
			get => GetProperty(ref _isReflexRequirementNotMet);
			set => SetProperty(ref _isReflexRequirementNotMet, value);
		}

		[Ordinal(4)] 
		[RED("isAnyStatRequirementNotMet")] 
		public CBool IsAnyStatRequirementNotMet
		{
			get => GetProperty(ref _isAnyStatRequirementNotMet);
			set => SetProperty(ref _isAnyStatRequirementNotMet, value);
		}

		[Ordinal(5)] 
		[RED("isHumanityStatRequirementNotMet")] 
		public CBool IsHumanityStatRequirementNotMet
		{
			get => GetProperty(ref _isHumanityStatRequirementNotMet);
			set => SetProperty(ref _isHumanityStatRequirementNotMet, value);
		}

		[Ordinal(6)] 
		[RED("isPerkRequirementNotMet")] 
		public CBool IsPerkRequirementNotMet
		{
			get => GetProperty(ref _isPerkRequirementNotMet);
			set => SetProperty(ref _isPerkRequirementNotMet, value);
		}

		[Ordinal(7)] 
		[RED("isRarityRequirementNotMet")] 
		public CBool IsRarityRequirementNotMet
		{
			get => GetProperty(ref _isRarityRequirementNotMet);
			set => SetProperty(ref _isRarityRequirementNotMet, value);
		}

		[Ordinal(8)] 
		[RED("strengthOrReflexStatName")] 
		public CString StrengthOrReflexStatName
		{
			get => GetProperty(ref _strengthOrReflexStatName);
			set => SetProperty(ref _strengthOrReflexStatName, value);
		}

		[Ordinal(9)] 
		[RED("perkLocKey")] 
		public CString PerkLocKey
		{
			get => GetProperty(ref _perkLocKey);
			set => SetProperty(ref _perkLocKey, value);
		}

		[Ordinal(10)] 
		[RED("strengthOrReflexValue")] 
		public CInt32 StrengthOrReflexValue
		{
			get => GetProperty(ref _strengthOrReflexValue);
			set => SetProperty(ref _strengthOrReflexValue, value);
		}

		[Ordinal(11)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}

		[Ordinal(12)] 
		[RED("anyStatRequirements")] 
		public CArray<CHandle<MinimalItemTooltipDataStatRequirement>> AnyStatRequirements
		{
			get => GetProperty(ref _anyStatRequirements);
			set => SetProperty(ref _anyStatRequirements, value);
		}

		public MinimalItemTooltipDataRequirements(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
