using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIMenuNotificationEvent : redEvent
	{
		private CEnum<UIMenuNotificationType> _notificationType;
		private CVariant _additionalInfo;
		private wCHandle<inGameMenuAnimContainer> _animContainer;

		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<UIMenuNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(1)] 
		[RED("additionalInfo")] 
		public CVariant AdditionalInfo
		{
			get => GetProperty(ref _additionalInfo);
			set => SetProperty(ref _additionalInfo, value);
		}

		[Ordinal(2)] 
		[RED("animContainer")] 
		public wCHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetProperty(ref _animContainer);
			set => SetProperty(ref _animContainer, value);
		}

		public UIMenuNotificationEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
