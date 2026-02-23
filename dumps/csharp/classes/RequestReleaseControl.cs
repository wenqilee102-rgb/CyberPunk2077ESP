using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestReleaseControl : gameScriptableSystemRequest
	{
		private CHandle<redEvent> _followupEvent;
		private entEntityID _followupEventEntityID;

		[Ordinal(0)] 
		[RED("followupEvent")] 
		public CHandle<redEvent> FollowupEvent
		{
			get => GetProperty(ref _followupEvent);
			set => SetProperty(ref _followupEvent, value);
		}

		[Ordinal(1)] 
		[RED("followupEventEntityID")] 
		public entEntityID FollowupEventEntityID
		{
			get => GetProperty(ref _followupEventEntityID);
			set => SetProperty(ref _followupEventEntityID, value);
		}

		public RequestReleaseControl(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
