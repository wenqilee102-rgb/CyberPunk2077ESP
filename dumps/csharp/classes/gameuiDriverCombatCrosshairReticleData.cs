using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDriverCombatCrosshairReticleData : CVariable
	{
		private CEnum<gameuiDriverCombatCrosshairReticleDataState> _state;
		private CFloat _opacity;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameuiDriverCombatCrosshairReticleDataState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		public gameuiDriverCombatCrosshairReticleData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
