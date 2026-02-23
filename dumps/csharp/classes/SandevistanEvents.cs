using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SandevistanEvents : TimeDilationEventsTransitions
	{
		private CFloat _lastTimeDilation;

		[Ordinal(0)] 
		[RED("lastTimeDilation")] 
		public CFloat LastTimeDilation
		{
			get => GetProperty(ref _lastTimeDilation);
			set => SetProperty(ref _lastTimeDilation, value);
		}

		public SandevistanEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
