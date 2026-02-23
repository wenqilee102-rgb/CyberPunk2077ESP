using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwimmingSurfaceFastEvents : LocomotionSwimmingEvents
	{
		private CFloat _lapsedTime;
		private CFloat _timeSinceLastImpulse;
		private CFloat _timeBetweenMovementImpulses;
		private CFloat _movementImpulseRadius;
		private CFloat _movementImpulseStrength;
		private CFloat _movementImpulseOffset;

		[Ordinal(6)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetProperty(ref _lapsedTime);
			set => SetProperty(ref _lapsedTime, value);
		}

		[Ordinal(7)] 
		[RED("timeSinceLastImpulse")] 
		public CFloat TimeSinceLastImpulse
		{
			get => GetProperty(ref _timeSinceLastImpulse);
			set => SetProperty(ref _timeSinceLastImpulse, value);
		}

		[Ordinal(8)] 
		[RED("timeBetweenMovementImpulses")] 
		public CFloat TimeBetweenMovementImpulses
		{
			get => GetProperty(ref _timeBetweenMovementImpulses);
			set => SetProperty(ref _timeBetweenMovementImpulses, value);
		}

		[Ordinal(9)] 
		[RED("movementImpulseRadius")] 
		public CFloat MovementImpulseRadius
		{
			get => GetProperty(ref _movementImpulseRadius);
			set => SetProperty(ref _movementImpulseRadius, value);
		}

		[Ordinal(10)] 
		[RED("movementImpulseStrength")] 
		public CFloat MovementImpulseStrength
		{
			get => GetProperty(ref _movementImpulseStrength);
			set => SetProperty(ref _movementImpulseStrength, value);
		}

		[Ordinal(11)] 
		[RED("movementImpulseOffset")] 
		public CFloat MovementImpulseOffset
		{
			get => GetProperty(ref _movementImpulseOffset);
			set => SetProperty(ref _movementImpulseOffset, value);
		}

		public SwimmingSurfaceFastEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
