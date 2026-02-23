using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionWaterContextSettings : CVariable
	{
		private CFloat _minDistanceBetweenImpulsesSquared;
		private CFloat _impulseStrength;
		private CFloat _impulseMinRadius;
		private CFloat _impulseMaxRadius;

		[Ordinal(0)] 
		[RED("minDistanceBetweenImpulsesSquared")] 
		public CFloat MinDistanceBetweenImpulsesSquared
		{
			get => GetProperty(ref _minDistanceBetweenImpulsesSquared);
			set => SetProperty(ref _minDistanceBetweenImpulsesSquared, value);
		}

		[Ordinal(1)] 
		[RED("impulseStrength")] 
		public CFloat ImpulseStrength
		{
			get => GetProperty(ref _impulseStrength);
			set => SetProperty(ref _impulseStrength, value);
		}

		[Ordinal(2)] 
		[RED("impulseMinRadius")] 
		public CFloat ImpulseMinRadius
		{
			get => GetProperty(ref _impulseMinRadius);
			set => SetProperty(ref _impulseMinRadius, value);
		}

		[Ordinal(3)] 
		[RED("impulseMaxRadius")] 
		public CFloat ImpulseMaxRadius
		{
			get => GetProperty(ref _impulseMaxRadius);
			set => SetProperty(ref _impulseMaxRadius, value);
		}

		public audioLocomotionWaterContextSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
