using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RarityOfEquippedConsumableItemPrereq : gameIScriptablePrereq
	{
		private CName _consumableItemTag;
		private CEnum<gamedataQuality> _qualityLessThan;

		[Ordinal(0)] 
		[RED("consumableItemTag")] 
		public CName ConsumableItemTag
		{
			get => GetProperty(ref _consumableItemTag);
			set => SetProperty(ref _consumableItemTag, value);
		}

		[Ordinal(1)] 
		[RED("qualityLessThan")] 
		public CEnum<gamedataQuality> QualityLessThan
		{
			get => GetProperty(ref _qualityLessThan);
			set => SetProperty(ref _qualityLessThan, value);
		}

		public RarityOfEquippedConsumableItemPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
