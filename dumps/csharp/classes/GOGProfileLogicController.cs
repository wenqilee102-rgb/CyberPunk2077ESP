using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GOGProfileLogicController : inkWidgetLogicController
	{
		private CEnum<EGOGMenuState> _gogMenuState;

		[Ordinal(1)] 
		[RED("gogMenuState")] 
		public CEnum<EGOGMenuState> GogMenuState
		{
			get => GetProperty(ref _gogMenuState);
			set => SetProperty(ref _gogMenuState, value);
		}

		public GOGProfileLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
