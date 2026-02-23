using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WarningMessageGameController : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _root;
		private inkTextWidgetReference _mainTextWidget;
		private inkWidgetReference _attencionIcon;
		private inkWidgetReference _neutralIcon;
		private inkWidgetReference _vehicleIcon;
		private inkWidgetReference _apartmentIcon;
		private inkWidgetReference _relicIcon;
		private inkWidgetReference _moneyIcon;
		private inkWidgetReference _twintoneIcon;
		private inkWidgetReference _autodriveIcon;
		private inkWidgetReference _delamainIcon;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_NotificationsDef> _blackboardDef;
		private CHandle<redCallbackObject> _warningMessageCallbackId;
		private gameSimpleScreenMessage _simpleMessage;
		private CHandle<inkanimDefinition> _blinkingAnim;
		private CHandle<inkanimDefinition> _showAnim;
		private CHandle<inkanimDefinition> _hideAnim;
		private CHandle<inkanimProxy> _animProxyShow;
		private CHandle<inkanimProxy> _animProxyHide;
		private CHandle<inkanimProxy> _animProxyTimeout;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("mainTextWidget")] 
		public inkTextWidgetReference MainTextWidget
		{
			get => GetProperty(ref _mainTextWidget);
			set => SetProperty(ref _mainTextWidget, value);
		}

		[Ordinal(11)] 
		[RED("attencionIcon")] 
		public inkWidgetReference AttencionIcon
		{
			get => GetProperty(ref _attencionIcon);
			set => SetProperty(ref _attencionIcon, value);
		}

		[Ordinal(12)] 
		[RED("neutralIcon")] 
		public inkWidgetReference NeutralIcon
		{
			get => GetProperty(ref _neutralIcon);
			set => SetProperty(ref _neutralIcon, value);
		}

		[Ordinal(13)] 
		[RED("vehicleIcon")] 
		public inkWidgetReference VehicleIcon
		{
			get => GetProperty(ref _vehicleIcon);
			set => SetProperty(ref _vehicleIcon, value);
		}

		[Ordinal(14)] 
		[RED("apartmentIcon")] 
		public inkWidgetReference ApartmentIcon
		{
			get => GetProperty(ref _apartmentIcon);
			set => SetProperty(ref _apartmentIcon, value);
		}

		[Ordinal(15)] 
		[RED("relicIcon")] 
		public inkWidgetReference RelicIcon
		{
			get => GetProperty(ref _relicIcon);
			set => SetProperty(ref _relicIcon, value);
		}

		[Ordinal(16)] 
		[RED("moneyIcon")] 
		public inkWidgetReference MoneyIcon
		{
			get => GetProperty(ref _moneyIcon);
			set => SetProperty(ref _moneyIcon, value);
		}

		[Ordinal(17)] 
		[RED("twintoneIcon")] 
		public inkWidgetReference TwintoneIcon
		{
			get => GetProperty(ref _twintoneIcon);
			set => SetProperty(ref _twintoneIcon, value);
		}

		[Ordinal(18)] 
		[RED("autodriveIcon")] 
		public inkWidgetReference AutodriveIcon
		{
			get => GetProperty(ref _autodriveIcon);
			set => SetProperty(ref _autodriveIcon, value);
		}

		[Ordinal(19)] 
		[RED("delamainIcon")] 
		public inkWidgetReference DelamainIcon
		{
			get => GetProperty(ref _delamainIcon);
			set => SetProperty(ref _delamainIcon, value);
		}

		[Ordinal(20)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(21)] 
		[RED("blackboardDef")] 
		public CHandle<UI_NotificationsDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(22)] 
		[RED("warningMessageCallbackId")] 
		public CHandle<redCallbackObject> WarningMessageCallbackId
		{
			get => GetProperty(ref _warningMessageCallbackId);
			set => SetProperty(ref _warningMessageCallbackId, value);
		}

		[Ordinal(23)] 
		[RED("simpleMessage")] 
		public gameSimpleScreenMessage SimpleMessage
		{
			get => GetProperty(ref _simpleMessage);
			set => SetProperty(ref _simpleMessage, value);
		}

		[Ordinal(24)] 
		[RED("blinkingAnim")] 
		public CHandle<inkanimDefinition> BlinkingAnim
		{
			get => GetProperty(ref _blinkingAnim);
			set => SetProperty(ref _blinkingAnim, value);
		}

		[Ordinal(25)] 
		[RED("showAnim")] 
		public CHandle<inkanimDefinition> ShowAnim
		{
			get => GetProperty(ref _showAnim);
			set => SetProperty(ref _showAnim, value);
		}

		[Ordinal(26)] 
		[RED("hideAnim")] 
		public CHandle<inkanimDefinition> HideAnim
		{
			get => GetProperty(ref _hideAnim);
			set => SetProperty(ref _hideAnim, value);
		}

		[Ordinal(27)] 
		[RED("animProxyShow")] 
		public CHandle<inkanimProxy> AnimProxyShow
		{
			get => GetProperty(ref _animProxyShow);
			set => SetProperty(ref _animProxyShow, value);
		}

		[Ordinal(28)] 
		[RED("animProxyHide")] 
		public CHandle<inkanimProxy> AnimProxyHide
		{
			get => GetProperty(ref _animProxyHide);
			set => SetProperty(ref _animProxyHide, value);
		}

		[Ordinal(29)] 
		[RED("animProxyTimeout")] 
		public CHandle<inkanimProxy> AnimProxyTimeout
		{
			get => GetProperty(ref _animProxyTimeout);
			set => SetProperty(ref _animProxyTimeout, value);
		}

		public WarningMessageGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
