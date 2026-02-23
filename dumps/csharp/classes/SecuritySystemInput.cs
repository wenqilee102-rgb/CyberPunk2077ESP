using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemInput : SecurityAreaEvent
	{
		private Vector4 _lastKnownPosition;
		private CHandle<SharedGameplayPS> _notifier;
		private CEnum<ESecurityNotificationType> _type;
		private wCHandle<gameObject> _objectOfInterest;
		private CBool _canPerformReprimand;
		private CBool _shouldLeadReprimend;
		private CInt32 _id;
		private CArray<entEntityID> _customRecipientsList;
		private CBool _isSharingRestricted;
		private CHandle<gamedataCharacter_Record> _debugReporterCharRecord;
		private CEnum<gamedataStimType> _stimTypeTriggeredAlarm;

		[Ordinal(41)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetProperty(ref _lastKnownPosition);
			set => SetProperty(ref _lastKnownPosition, value);
		}

		[Ordinal(42)] 
		[RED("notifier")] 
		public CHandle<SharedGameplayPS> Notifier
		{
			get => GetProperty(ref _notifier);
			set => SetProperty(ref _notifier, value);
		}

		[Ordinal(43)] 
		[RED("type")] 
		public CEnum<ESecurityNotificationType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(44)] 
		[RED("objectOfInterest")] 
		public wCHandle<gameObject> ObjectOfInterest
		{
			get => GetProperty(ref _objectOfInterest);
			set => SetProperty(ref _objectOfInterest, value);
		}

		[Ordinal(45)] 
		[RED("canPerformReprimand")] 
		public CBool CanPerformReprimand
		{
			get => GetProperty(ref _canPerformReprimand);
			set => SetProperty(ref _canPerformReprimand, value);
		}

		[Ordinal(46)] 
		[RED("shouldLeadReprimend")] 
		public CBool ShouldLeadReprimend
		{
			get => GetProperty(ref _shouldLeadReprimend);
			set => SetProperty(ref _shouldLeadReprimend, value);
		}

		[Ordinal(47)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(48)] 
		[RED("customRecipientsList")] 
		public CArray<entEntityID> CustomRecipientsList
		{
			get => GetProperty(ref _customRecipientsList);
			set => SetProperty(ref _customRecipientsList, value);
		}

		[Ordinal(49)] 
		[RED("isSharingRestricted")] 
		public CBool IsSharingRestricted
		{
			get => GetProperty(ref _isSharingRestricted);
			set => SetProperty(ref _isSharingRestricted, value);
		}

		[Ordinal(50)] 
		[RED("debugReporterCharRecord")] 
		public CHandle<gamedataCharacter_Record> DebugReporterCharRecord
		{
			get => GetProperty(ref _debugReporterCharRecord);
			set => SetProperty(ref _debugReporterCharRecord, value);
		}

		[Ordinal(51)] 
		[RED("stimTypeTriggeredAlarm")] 
		public CEnum<gamedataStimType> StimTypeTriggeredAlarm
		{
			get => GetProperty(ref _stimTypeTriggeredAlarm);
			set => SetProperty(ref _stimTypeTriggeredAlarm, value);
		}

		public SecuritySystemInput(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
