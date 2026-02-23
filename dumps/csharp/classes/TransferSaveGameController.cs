using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransferSaveGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _notificationController;

		[Ordinal(2)] 
		[RED("notificationController")] 
		public inkWidgetReference NotificationController
		{
			get => GetProperty(ref _notificationController);
			set => SetProperty(ref _notificationController, value);
		}

		public TransferSaveGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
