using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShotStartCondition_MinSpeed : vehicleCinematicCameraShotStartCondition
	{
		private CFloat _minSpeed;

		[Ordinal(0)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		public vehicleCinematicCameraShotStartCondition_MinSpeed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
