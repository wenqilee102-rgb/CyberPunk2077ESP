using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetMessageDeviceOperation : DeviceOperationBase
	{
		private NodeRef _targetRef;
		private TweakDBID _messageRecordID;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;

		[Ordinal(5)] 
		[RED("targetRef")] 
		public NodeRef TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(6)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetProperty(ref _messageRecordID);
			set => SetProperty(ref _messageRecordID, value);
		}

		[Ordinal(7)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetProperty(ref _replaceTextWithCustomNumber);
			set => SetProperty(ref _replaceTextWithCustomNumber, value);
		}

		[Ordinal(8)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetProperty(ref _customNumber);
			set => SetProperty(ref _customNumber, value);
		}

		public SetMessageDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
