using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SAttributeData : CVariable
	{
		private CEnum<gamedataAttributeDataType> _type;
		private CArray<SNewPerk> _unlockedPerks;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataAttributeDataType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("unlockedPerks")] 
		public CArray<SNewPerk> UnlockedPerks
		{
			get => GetProperty(ref _unlockedPerks);
			set => SetProperty(ref _unlockedPerks, value);
		}

		public SAttributeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
