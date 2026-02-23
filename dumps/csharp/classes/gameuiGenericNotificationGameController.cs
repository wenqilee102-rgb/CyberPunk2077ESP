using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _notificationsRoot;
		private CBool _exclusiveProcessing;

		[Ordinal(2)] 
		[RED("notificationsRoot")] 
		public inkCompoundWidgetReference NotificationsRoot
		{
			get => GetProperty(ref _notificationsRoot);
			set => SetProperty(ref _notificationsRoot, value);
		}

		[Ordinal(3)] 
		[RED("exclusiveProcessing")] 
		public CBool ExclusiveProcessing
		{
			get => GetProperty(ref _exclusiveProcessing);
			set => SetProperty(ref _exclusiveProcessing, value);
		}

		public gameuiGenericNotificationGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
