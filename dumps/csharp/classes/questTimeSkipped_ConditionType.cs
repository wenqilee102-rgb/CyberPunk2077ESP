using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeSkipped_ConditionType : questIUIConditionType
	{
		private CEnum<questTimeSkipMode> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questTimeSkipMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public questTimeSkipped_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
