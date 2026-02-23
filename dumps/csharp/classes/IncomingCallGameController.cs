using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncomingCallGameController : gameuiNewPhoneRelatedHUDGameController
	{
		private inkTextWidgetReference _contactNameWidget;
		private inkWidgetReference _buttonHint;
		private wCHandle<gameIBlackboard> _phoneBlackboard;
		private CHandle<UI_ComDeviceDef> _phoneBBDefinition;
		private CHandle<redCallbackObject> _phoneCallInfoBBID;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(15)] 
		[RED("contactNameWidget")] 
		public inkTextWidgetReference ContactNameWidget
		{
			get => GetProperty(ref _contactNameWidget);
			set => SetProperty(ref _contactNameWidget, value);
		}

		[Ordinal(16)] 
		[RED("buttonHint")] 
		public inkWidgetReference ButtonHint
		{
			get => GetProperty(ref _buttonHint);
			set => SetProperty(ref _buttonHint, value);
		}

		[Ordinal(17)] 
		[RED("phoneBlackboard")] 
		public wCHandle<gameIBlackboard> PhoneBlackboard
		{
			get => GetProperty(ref _phoneBlackboard);
			set => SetProperty(ref _phoneBlackboard, value);
		}

		[Ordinal(18)] 
		[RED("phoneBBDefinition")] 
		public CHandle<UI_ComDeviceDef> PhoneBBDefinition
		{
			get => GetProperty(ref _phoneBBDefinition);
			set => SetProperty(ref _phoneBBDefinition, value);
		}

		[Ordinal(19)] 
		[RED("phoneCallInfoBBID")] 
		public CHandle<redCallbackObject> PhoneCallInfoBBID
		{
			get => GetProperty(ref _phoneCallInfoBBID);
			set => SetProperty(ref _phoneCallInfoBBID, value);
		}

		[Ordinal(20)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public IncomingCallGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
