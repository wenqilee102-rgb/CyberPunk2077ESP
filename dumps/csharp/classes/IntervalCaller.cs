using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IntervalCaller : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<PreventionSystem> _preventionSystem;
		private CHandle<gameScriptableSystemRequest> _request;
		private CFloat _intervalSeconds;
		private gameDelayID _selfDelayID;

		[Ordinal(0)] 
		[RED("preventionSystem")] 
		public wCHandle<PreventionSystem> PreventionSystem
		{
			get => GetProperty(ref _preventionSystem);
			set => SetProperty(ref _preventionSystem, value);
		}

		[Ordinal(1)] 
		[RED("request")] 
		public CHandle<gameScriptableSystemRequest> Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		[Ordinal(2)] 
		[RED("intervalSeconds")] 
		public CFloat IntervalSeconds
		{
			get => GetProperty(ref _intervalSeconds);
			set => SetProperty(ref _intervalSeconds, value);
		}

		[Ordinal(3)] 
		[RED("selfDelayID")] 
		public gameDelayID SelfDelayID
		{
			get => GetProperty(ref _selfDelayID);
			set => SetProperty(ref _selfDelayID, value);
		}

		public IntervalCaller(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
