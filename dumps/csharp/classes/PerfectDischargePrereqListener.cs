using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerfectDischargePrereqListener : gameScriptStatPoolsListener
	{
		private wCHandle<PerfectDischargePrereqState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public wCHandle<PerfectDischargePrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public PerfectDischargePrereqListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
