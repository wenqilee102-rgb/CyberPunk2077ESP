using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInGameNotificationViewData : gameuiGenericNotificationViewData
	{
		private wCHandle<inGameMenuAnimContainer> _animContainer;
		private CEnum<UIInGameNotificationType> _notificationType;

		[Ordinal(5)] 
		[RED("animContainer")] 
		public wCHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetProperty(ref _animContainer);
			set => SetProperty(ref _animContainer, value);
		}

		[Ordinal(6)] 
		[RED("notificationType")] 
		public CEnum<UIInGameNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		public UIInGameNotificationViewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
