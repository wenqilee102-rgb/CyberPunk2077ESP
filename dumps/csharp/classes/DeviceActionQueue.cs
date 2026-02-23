using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceActionQueue : IScriptable
	{
		private CArray<CHandle<gamedeviceAction>> _actionsInQueue;
		private CInt32 _maxQueueSize;
		private CBool _locked;

		[Ordinal(0)] 
		[RED("actionsInQueue")] 
		public CArray<CHandle<gamedeviceAction>> ActionsInQueue
		{
			get => GetProperty(ref _actionsInQueue);
			set => SetProperty(ref _actionsInQueue, value);
		}

		[Ordinal(1)] 
		[RED("maxQueueSize")] 
		public CInt32 MaxQueueSize
		{
			get => GetProperty(ref _maxQueueSize);
			set => SetProperty(ref _maxQueueSize, value);
		}

		[Ordinal(2)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetProperty(ref _locked);
			set => SetProperty(ref _locked, value);
		}

		public DeviceActionQueue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
