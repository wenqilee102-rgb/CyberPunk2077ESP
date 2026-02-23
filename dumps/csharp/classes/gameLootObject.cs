using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootObject : gameObject
	{
		private TweakDBID _lootID;
		private CBool _isInIconForcedVisibilityRange;
		private CName _activeQualityRangeInteraction;
		private CEnum<gamedataQuality> _lootQuality;

		[Ordinal(36)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetProperty(ref _lootID);
			set => SetProperty(ref _lootID, value);
		}

		[Ordinal(37)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get => GetProperty(ref _isInIconForcedVisibilityRange);
			set => SetProperty(ref _isInIconForcedVisibilityRange, value);
		}

		[Ordinal(38)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetProperty(ref _activeQualityRangeInteraction);
			set => SetProperty(ref _activeQualityRangeInteraction, value);
		}

		[Ordinal(39)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetProperty(ref _lootQuality);
			set => SetProperty(ref _lootQuality, value);
		}

		public gameLootObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
