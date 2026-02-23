using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ManageSirensAndLightsInPoliceCar : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _turnOnLights;
		private CHandle<AIArgumentMapping> _turnOnSirens;

		[Ordinal(0)] 
		[RED("turnOnLights")] 
		public CHandle<AIArgumentMapping> TurnOnLights
		{
			get => GetProperty(ref _turnOnLights);
			set => SetProperty(ref _turnOnLights, value);
		}

		[Ordinal(1)] 
		[RED("turnOnSirens")] 
		public CHandle<AIArgumentMapping> TurnOnSirens
		{
			get => GetProperty(ref _turnOnSirens);
			set => SetProperty(ref _turnOnSirens, value);
		}

		public ManageSirensAndLightsInPoliceCar(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
