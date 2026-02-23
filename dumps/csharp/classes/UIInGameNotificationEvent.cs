using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInGameNotificationEvent : redEvent
	{
		private CEnum<UIInGameNotificationType> _notificationType;
		private wCHandle<inGameMenuAnimContainer> _animContainer;
		private CString _title;
		private CBool _overrideCurrentNotification;

		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<UIInGameNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(1)] 
		[RED("animContainer")] 
		public wCHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetProperty(ref _animContainer);
			set => SetProperty(ref _animContainer, value);
		}

		[Ordinal(2)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("overrideCurrentNotification")] 
		public CBool OverrideCurrentNotification
		{
			get => GetProperty(ref _overrideCurrentNotification);
			set => SetProperty(ref _overrideCurrentNotification, value);
		}

		public UIInGameNotificationEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
