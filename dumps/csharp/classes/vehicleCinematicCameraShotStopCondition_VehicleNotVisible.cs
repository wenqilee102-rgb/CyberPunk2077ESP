using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShotStopCondition_VehicleNotVisible : vehicleCinematicCameraShotStopCondition
	{
		private CFloat _timeOutOfSightBeforeStop;
		private CFloat _counter;

		[Ordinal(0)] 
		[RED("timeOutOfSightBeforeStop")] 
		public CFloat TimeOutOfSightBeforeStop
		{
			get => GetProperty(ref _timeOutOfSightBeforeStop);
			set => SetProperty(ref _timeOutOfSightBeforeStop, value);
		}

		[Ordinal(1)] 
		[RED("counter")] 
		public CFloat Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		public vehicleCinematicCameraShotStopCondition_VehicleNotVisible(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
