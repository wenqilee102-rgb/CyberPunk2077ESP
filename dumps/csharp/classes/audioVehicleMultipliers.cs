using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleMultipliers : CVariable
	{
		private CFloat _throttleInputMultiplier;
		private CFloat _rpmMultiplier;

		[Ordinal(0)] 
		[RED("throttleInputMultiplier")] 
		public CFloat ThrottleInputMultiplier
		{
			get => GetProperty(ref _throttleInputMultiplier);
			set => SetProperty(ref _throttleInputMultiplier, value);
		}

		[Ordinal(1)] 
		[RED("rpmMultiplier")] 
		public CFloat RpmMultiplier
		{
			get => GetProperty(ref _rpmMultiplier);
			set => SetProperty(ref _rpmMultiplier, value);
		}

		public audioVehicleMultipliers(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
