using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwimmingTransitionEvents : LocomotionSwimmingEvents
	{
		private CFloat _maxDownwardSpeed;
		private CFloat _minDownwardsSpeed;
		private CFloat _upwardsImpulseStrength;

		[Ordinal(6)] 
		[RED("maxDownwardSpeed")] 
		public CFloat MaxDownwardSpeed
		{
			get => GetProperty(ref _maxDownwardSpeed);
			set => SetProperty(ref _maxDownwardSpeed, value);
		}

		[Ordinal(7)] 
		[RED("minDownwardsSpeed")] 
		public CFloat MinDownwardsSpeed
		{
			get => GetProperty(ref _minDownwardsSpeed);
			set => SetProperty(ref _minDownwardsSpeed, value);
		}

		[Ordinal(8)] 
		[RED("upwardsImpulseStrength")] 
		public CFloat UpwardsImpulseStrength
		{
			get => GetProperty(ref _upwardsImpulseStrength);
			set => SetProperty(ref _upwardsImpulseStrength, value);
		}

		public SwimmingTransitionEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
