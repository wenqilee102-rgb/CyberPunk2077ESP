using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetApartmentScreenMessageEvent : redEvent
	{
		private TweakDBID _messageRecordID;
		private CEnum<ERentStatus> _targetRentStatus;

		[Ordinal(0)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetProperty(ref _messageRecordID);
			set => SetProperty(ref _messageRecordID, value);
		}

		[Ordinal(1)] 
		[RED("targetRentStatus")] 
		public CEnum<ERentStatus> TargetRentStatus
		{
			get => GetProperty(ref _targetRentStatus);
			set => SetProperty(ref _targetRentStatus, value);
		}

		public SetApartmentScreenMessageEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
