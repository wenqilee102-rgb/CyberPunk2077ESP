using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerModeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataTriggerMode> _triggerMode;

		[Ordinal(3)] 
		[RED("triggerMode")] 
		public CEnum<gamedataTriggerMode> TriggerMode
		{
			get => GetProperty(ref _triggerMode);
			set => SetProperty(ref _triggerMode, value);
		}

		public TriggerModeHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
