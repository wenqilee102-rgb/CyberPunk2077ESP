using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestDelayedHornEvent : redEvent
	{
		private CFloat _honkTime;
		private CFloat _delayTime;

		[Ordinal(0)] 
		[RED("honkTime")] 
		public CFloat HonkTime
		{
			get => GetProperty(ref _honkTime);
			set => SetProperty(ref _honkTime, value);
		}

		[Ordinal(1)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetProperty(ref _delayTime);
			set => SetProperty(ref _delayTime, value);
		}

		public VehicleQuestDelayedHornEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
