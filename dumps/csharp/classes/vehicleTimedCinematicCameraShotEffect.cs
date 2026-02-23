using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleTimedCinematicCameraShotEffect : vehicleCinematicCameraShotEffect
	{
		private CFloat _startDelay;
		private CFloat _duration;
		private CBool _hasStarted;

		[Ordinal(0)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get => GetProperty(ref _startDelay);
			set => SetProperty(ref _startDelay, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("hasStarted")] 
		public CBool HasStarted
		{
			get => GetProperty(ref _hasStarted);
			set => SetProperty(ref _hasStarted, value);
		}

		public vehicleTimedCinematicCameraShotEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
