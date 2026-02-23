using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedForceAboutToExplodeStateRequest : gameScriptableSystemRequest
	{
		private CHandle<VehiclePreventionHackState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CHandle<VehiclePreventionHackState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public DelayedForceAboutToExplodeStateRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
