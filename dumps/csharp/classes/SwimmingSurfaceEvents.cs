using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwimmingSurfaceEvents : LocomotionSwimmingEvents
	{
		private CFloat _lapsedTime;
		private CBool _isDead;
		private CFloat _timeSinceLastImpulse;
		private CFloat _minSpeedForMovementImpulses;
		private CFloat _timeBetweenIdleImpulses;
		private CFloat _timeBetweenMovementImpulses;
		private CFloat _idleImpulseRadius;
		private CFloat _idleImpulseStrength;
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
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(8)] 
		[RED("timeSinceLastImpulse")] 
		public CFloat TimeSinceLastImpulse
		{
			get => GetProperty(ref _timeSinceLastImpulse);
			set => SetProperty(ref _timeSinceLastImpulse, value);
		}

		[Ordinal(9)] 
		[RED("minSpeedForMovementImpulses")] 
		public CFloat MinSpeedForMovementImpulses
		{
			get => GetProperty(ref _minSpeedForMovementImpulses);
			set => SetProperty(ref _minSpeedForMovementImpulses, value);
		}

		[Ordinal(10)] 
		[RED("timeBetweenIdleImpulses")] 
		public CFloat TimeBetweenIdleImpulses
		{
			get => GetProperty(ref _timeBetweenIdleImpulses);
			set => SetProperty(ref _timeBetweenIdleImpulses, value);
		}

		[Ordinal(11)] 
		[RED("timeBetweenMovementImpulses")] 
		public CFloat TimeBetweenMovementImpulses
		{
			get => GetProperty(ref _timeBetweenMovementImpulses);
			set => SetProperty(ref _timeBetweenMovementImpulses, value);
		}

		[Ordinal(12)] 
		[RED("idleImpulseRadius")] 
		public CFloat IdleImpulseRadius
		{
			get => GetProperty(ref _idleImpulseRadius);
			set => SetProperty(ref _idleImpulseRadius, value);
		}

		[Ordinal(13)] 
		[RED("idleImpulseStrength")] 
		public CFloat IdleImpulseStrength
		{
			get => GetProperty(ref _idleImpulseStrength);
			set => SetProperty(ref _idleImpulseStrength, value);
		}

		[Ordinal(14)] 
		[RED("movementImpulseRadius")] 
		public CFloat MovementImpulseRadius
		{
			get => GetProperty(ref _movementImpulseRadius);
			set => SetProperty(ref _movementImpulseRadius, value);
		}

		[Ordinal(15)] 
		[RED("movementImpulseStrength")] 
		public CFloat MovementImpulseStrength
		{
			get => GetProperty(ref _movementImpulseStrength);
			set => SetProperty(ref _movementImpulseStrength, value);
		}

		[Ordinal(16)] 
		[RED("movementImpulseOffset")] 
		public CFloat MovementImpulseOffset
		{
			get => GetProperty(ref _movementImpulseOffset);
			set => SetProperty(ref _movementImpulseOffset, value);
		}

		public SwimmingSurfaceEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
