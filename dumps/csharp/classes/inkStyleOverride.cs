using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleOverride : CVariable
	{
		private CEnum<inkStyleOverrideType> _overrideType;
		private rRef<inkStyleResource> _styleResource;

		[Ordinal(0)] 
		[RED("overrideType")] 
		public CEnum<inkStyleOverrideType> OverrideType
		{
			get => GetProperty(ref _overrideType);
			set => SetProperty(ref _overrideType, value);
		}

		[Ordinal(1)] 
		[RED("styleResource")] 
		public rRef<inkStyleResource> StyleResource
		{
			get => GetProperty(ref _styleResource);
			set => SetProperty(ref _styleResource, value);
		}

		public inkStyleOverride(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
