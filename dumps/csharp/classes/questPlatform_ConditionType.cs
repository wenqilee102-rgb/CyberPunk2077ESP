using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlatform_ConditionType : questISystemConditionType
	{
		private CEnum<questPlatform> _platform;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("platform")] 
		public CEnum<questPlatform> Platform
		{
			get => GetProperty(ref _platform);
			set => SetProperty(ref _platform, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questPlatform_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
