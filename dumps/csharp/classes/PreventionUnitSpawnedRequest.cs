using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionUnitSpawnedRequest : gameScriptableSystemRequest
	{
		private gameSpawnRequestResult _requestResult;

		[Ordinal(0)] 
		[RED("requestResult")] 
		public gameSpawnRequestResult RequestResult
		{
			get => GetProperty(ref _requestResult);
			set => SetProperty(ref _requestResult, value);
		}

		public PreventionUnitSpawnedRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
