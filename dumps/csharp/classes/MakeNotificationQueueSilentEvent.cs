using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MakeNotificationQueueSilentEvent : redEvent
	{
		private CEnum<GenericNotificationType> _notificationType;
		private CBool _makeSilent;

		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<GenericNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(1)] 
		[RED("makeSilent")] 
		public CBool MakeSilent
		{
			get => GetProperty(ref _makeSilent);
			set => SetProperty(ref _makeSilent, value);
		}

		public MakeNotificationQueueSilentEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
