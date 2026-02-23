using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneDecisions : VehicleTransition
	{
		private CHandle<redCallbackObject> _sceneTierCallback;

		[Ordinal(2)] 
		[RED("sceneTierCallback")] 
		public CHandle<redCallbackObject> SceneTierCallback
		{
			get => GetProperty(ref _sceneTierCallback);
			set => SetProperty(ref _sceneTierCallback, value);
		}

		public SceneDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
