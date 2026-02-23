using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CRenderSimWaterImpulse : IDynamicTextureGenerator
	{
		private CInt32 _resolution;
		private CFloat _simulationSpeed;

		[Ordinal(0)] 
		[RED("resolution")] 
		public CInt32 Resolution
		{
			get => GetProperty(ref _resolution);
			set => SetProperty(ref _resolution, value);
		}

		[Ordinal(1)] 
		[RED("simulationSpeed")] 
		public CFloat SimulationSpeed
		{
			get => GetProperty(ref _simulationSpeed);
			set => SetProperty(ref _simulationSpeed, value);
		}

		public CRenderSimWaterImpulse(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
