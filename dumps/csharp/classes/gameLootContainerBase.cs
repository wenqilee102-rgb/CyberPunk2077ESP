using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBase : gameObject
	{
		private CBool _useAreaLoot;
		private CArray<TweakDBID> _lootTables;
		private TweakDBID _contentAssignment;
		private CBool _isIllegal;
		private CBool _wasLootInitalized;
		private CEnum<gamedataContainerType> _containerType;
		private CEnum<gamedataQuality> _lootQuality;
		private CBool _hasQuestItems;
		private CBool _isInIconForcedVisibilityRange;
		private CBool _isIconic;
		private CName _activeQualityRangeInteraction;

		[Ordinal(36)] 
		[RED("useAreaLoot")] 
		public CBool UseAreaLoot
		{
			get => GetProperty(ref _useAreaLoot);
			set => SetProperty(ref _useAreaLoot, value);
		}

		[Ordinal(37)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get => GetProperty(ref _lootTables);
			set => SetProperty(ref _lootTables, value);
		}

		[Ordinal(38)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get => GetProperty(ref _contentAssignment);
			set => SetProperty(ref _contentAssignment, value);
		}

		[Ordinal(39)] 
		[RED("isIllegal")] 
		public CBool IsIllegal
		{
			get => GetProperty(ref _isIllegal);
			set => SetProperty(ref _isIllegal, value);
		}

		[Ordinal(40)] 
		[RED("wasLootInitalized")] 
		public CBool WasLootInitalized
		{
			get => GetProperty(ref _wasLootInitalized);
			set => SetProperty(ref _wasLootInitalized, value);
		}

		[Ordinal(41)] 
		[RED("containerType")] 
		public CEnum<gamedataContainerType> ContainerType
		{
			get => GetProperty(ref _containerType);
			set => SetProperty(ref _containerType, value);
		}

		[Ordinal(42)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetProperty(ref _lootQuality);
			set => SetProperty(ref _lootQuality, value);
		}

		[Ordinal(43)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetProperty(ref _hasQuestItems);
			set => SetProperty(ref _hasQuestItems, value);
		}

		[Ordinal(44)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetProperty(ref _isInIconForcedVisibilityRange);
			set => SetProperty(ref _isInIconForcedVisibilityRange, value);
		}

		[Ordinal(45)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(46)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetProperty(ref _activeQualityRangeInteraction);
			set => SetProperty(ref _activeQualityRangeInteraction, value);
		}

		public gameLootContainerBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
