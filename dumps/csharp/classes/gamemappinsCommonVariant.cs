using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsCommonVariant : gamemappinsIPointOfInterestVariant
	{
		private CEnum<gamedataMappinVariant> _variant;

		[Ordinal(0)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get => GetProperty(ref _variant);
			set => SetProperty(ref _variant, value);
		}

		public gamemappinsCommonVariant(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
