using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestCLSStateChangeDeviceOperation : DeviceOperationBase
	{
		private CEnum<ECLSForcedState> _state;
		private CName _sourceName;
		private CEnum<EPriority> _priority;
		private CBool _removePreviousRequests;

		[Ordinal(5)] 
		[RED("state")] 
		public CEnum<ECLSForcedState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(6)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(7)] 
		[RED("priority")] 
		public CEnum<EPriority> Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(8)] 
		[RED("removePreviousRequests")] 
		public CBool RemovePreviousRequests
		{
			get => GetProperty(ref _removePreviousRequests);
			set => SetProperty(ref _removePreviousRequests, value);
		}

		public RequestCLSStateChangeDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
