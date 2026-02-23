using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarController : gameuiHUDGameController
	{
		private inkWidgetReference _bar;
		private inkWidgetReference _barExtra;
		private inkTextWidgetReference _header;
		private inkTextWidgetReference _bottomText;
		private inkTextWidgetReference _percent;
		private inkTextWidgetReference _completed;
		private inkTextWidgetReference _failed;
		private inkWidgetReference _attencionIcon;
		private inkWidgetReference _neutralIcon;
		private inkWidgetReference _relicIcon;
		private inkWidgetReference _moneyIcon;
		private inkWidgetReference _twintoneIcon;
		private inkWidgetReference _connectionIcon;
		private inkImageWidgetReference _apartmentIcon;
		private inkImageWidgetReference _vehicleIcon;
		private inkImageWidgetReference _neutralInIcon;
		private inkWidgetReference _revealIcon;
		private inkWidgetReference _vahicleHackIcon;
		private inkWidgetReference _wrapper;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<gameIBlackboard> _progressBarBB;
		private CHandle<UI_HUDProgressBarDef> _progressBarDef;
		private CHandle<redCallbackObject> _activeBBID;
		private CHandle<redCallbackObject> _headerBBID;
		private CHandle<redCallbackObject> _typeBBID;
		private CHandle<redCallbackObject> _bottomTextBBID;
		private CHandle<redCallbackObject> _completedTextBBID;
		private CHandle<redCallbackObject> _failedTextBBID;
		private CHandle<redCallbackObject> _progressBBID;
		private CHandle<redCallbackObject> _progressBumpBBID;
		private wCHandle<gameIBlackboard> _bb;
		private CHandle<UIInteractionsDef> _bbUIInteractionsDef;
		private CHandle<redCallbackObject> _bbChoiceHubDataCallbackId;
		private CHandle<inkanimProxy> _outroAnimation;
		private CHandle<inkanimProxy> _loopAnimation;
		private CHandle<inkanimProxy> _vLoopAnimation;
		private CHandle<inkanimProxy> _introAnimation;
		private CBool _introWasPlayed;
		private CString _title;
		private CEnum<gameSimpleMessageType> _type;
		private CFloat _valueSaved;
		private CFloat _bumpValue;

		[Ordinal(9)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(10)] 
		[RED("barExtra")] 
		public inkWidgetReference BarExtra
		{
			get => GetProperty(ref _barExtra);
			set => SetProperty(ref _barExtra, value);
		}

		[Ordinal(11)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(12)] 
		[RED("bottomText")] 
		public inkTextWidgetReference BottomText
		{
			get => GetProperty(ref _bottomText);
			set => SetProperty(ref _bottomText, value);
		}

		[Ordinal(13)] 
		[RED("percent")] 
		public inkTextWidgetReference Percent
		{
			get => GetProperty(ref _percent);
			set => SetProperty(ref _percent, value);
		}

		[Ordinal(14)] 
		[RED("completed")] 
		public inkTextWidgetReference Completed
		{
			get => GetProperty(ref _completed);
			set => SetProperty(ref _completed, value);
		}

		[Ordinal(15)] 
		[RED("failed")] 
		public inkTextWidgetReference Failed
		{
			get => GetProperty(ref _failed);
			set => SetProperty(ref _failed, value);
		}

		[Ordinal(16)] 
		[RED("attencionIcon")] 
		public inkWidgetReference AttencionIcon
		{
			get => GetProperty(ref _attencionIcon);
			set => SetProperty(ref _attencionIcon, value);
		}

		[Ordinal(17)] 
		[RED("neutralIcon")] 
		public inkWidgetReference NeutralIcon
		{
			get => GetProperty(ref _neutralIcon);
			set => SetProperty(ref _neutralIcon, value);
		}

		[Ordinal(18)] 
		[RED("relicIcon")] 
		public inkWidgetReference RelicIcon
		{
			get => GetProperty(ref _relicIcon);
			set => SetProperty(ref _relicIcon, value);
		}

		[Ordinal(19)] 
		[RED("moneyIcon")] 
		public inkWidgetReference MoneyIcon
		{
			get => GetProperty(ref _moneyIcon);
			set => SetProperty(ref _moneyIcon, value);
		}

		[Ordinal(20)] 
		[RED("twintoneIcon")] 
		public inkWidgetReference TwintoneIcon
		{
			get => GetProperty(ref _twintoneIcon);
			set => SetProperty(ref _twintoneIcon, value);
		}

		[Ordinal(21)] 
		[RED("connectionIcon")] 
		public inkWidgetReference ConnectionIcon
		{
			get => GetProperty(ref _connectionIcon);
			set => SetProperty(ref _connectionIcon, value);
		}

		[Ordinal(22)] 
		[RED("apartmentIcon")] 
		public inkImageWidgetReference ApartmentIcon
		{
			get => GetProperty(ref _apartmentIcon);
			set => SetProperty(ref _apartmentIcon, value);
		}

		[Ordinal(23)] 
		[RED("vehicleIcon")] 
		public inkImageWidgetReference VehicleIcon
		{
			get => GetProperty(ref _vehicleIcon);
			set => SetProperty(ref _vehicleIcon, value);
		}

		[Ordinal(24)] 
		[RED("neutralInIcon")] 
		public inkImageWidgetReference NeutralInIcon
		{
			get => GetProperty(ref _neutralInIcon);
			set => SetProperty(ref _neutralInIcon, value);
		}

		[Ordinal(25)] 
		[RED("revealIcon")] 
		public inkWidgetReference RevealIcon
		{
			get => GetProperty(ref _revealIcon);
			set => SetProperty(ref _revealIcon, value);
		}

		[Ordinal(26)] 
		[RED("vahicleHackIcon")] 
		public inkWidgetReference VahicleHackIcon
		{
			get => GetProperty(ref _vahicleHackIcon);
			set => SetProperty(ref _vahicleHackIcon, value);
		}

		[Ordinal(27)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(28)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(29)] 
		[RED("progressBarBB")] 
		public wCHandle<gameIBlackboard> ProgressBarBB
		{
			get => GetProperty(ref _progressBarBB);
			set => SetProperty(ref _progressBarBB, value);
		}

		[Ordinal(30)] 
		[RED("progressBarDef")] 
		public CHandle<UI_HUDProgressBarDef> ProgressBarDef
		{
			get => GetProperty(ref _progressBarDef);
			set => SetProperty(ref _progressBarDef, value);
		}

		[Ordinal(31)] 
		[RED("activeBBID")] 
		public CHandle<redCallbackObject> ActiveBBID
		{
			get => GetProperty(ref _activeBBID);
			set => SetProperty(ref _activeBBID, value);
		}

		[Ordinal(32)] 
		[RED("headerBBID")] 
		public CHandle<redCallbackObject> HeaderBBID
		{
			get => GetProperty(ref _headerBBID);
			set => SetProperty(ref _headerBBID, value);
		}

		[Ordinal(33)] 
		[RED("typeBBID")] 
		public CHandle<redCallbackObject> TypeBBID
		{
			get => GetProperty(ref _typeBBID);
			set => SetProperty(ref _typeBBID, value);
		}

		[Ordinal(34)] 
		[RED("bottomTextBBID")] 
		public CHandle<redCallbackObject> BottomTextBBID
		{
			get => GetProperty(ref _bottomTextBBID);
			set => SetProperty(ref _bottomTextBBID, value);
		}

		[Ordinal(35)] 
		[RED("completedTextBBID")] 
		public CHandle<redCallbackObject> CompletedTextBBID
		{
			get => GetProperty(ref _completedTextBBID);
			set => SetProperty(ref _completedTextBBID, value);
		}

		[Ordinal(36)] 
		[RED("failedTextBBID")] 
		public CHandle<redCallbackObject> FailedTextBBID
		{
			get => GetProperty(ref _failedTextBBID);
			set => SetProperty(ref _failedTextBBID, value);
		}

		[Ordinal(37)] 
		[RED("progressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetProperty(ref _progressBBID);
			set => SetProperty(ref _progressBBID, value);
		}

		[Ordinal(38)] 
		[RED("progressBumpBBID")] 
		public CHandle<redCallbackObject> ProgressBumpBBID
		{
			get => GetProperty(ref _progressBumpBBID);
			set => SetProperty(ref _progressBumpBBID, value);
		}

		[Ordinal(39)] 
		[RED("bb")] 
		public wCHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}

		[Ordinal(40)] 
		[RED("bbUIInteractionsDef")] 
		public CHandle<UIInteractionsDef> BbUIInteractionsDef
		{
			get => GetProperty(ref _bbUIInteractionsDef);
			set => SetProperty(ref _bbUIInteractionsDef, value);
		}

		[Ordinal(41)] 
		[RED("bbChoiceHubDataCallbackId")] 
		public CHandle<redCallbackObject> BbChoiceHubDataCallbackId
		{
			get => GetProperty(ref _bbChoiceHubDataCallbackId);
			set => SetProperty(ref _bbChoiceHubDataCallbackId, value);
		}

		[Ordinal(42)] 
		[RED("OutroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get => GetProperty(ref _outroAnimation);
			set => SetProperty(ref _outroAnimation, value);
		}

		[Ordinal(43)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get => GetProperty(ref _loopAnimation);
			set => SetProperty(ref _loopAnimation, value);
		}

		[Ordinal(44)] 
		[RED("VLoopAnimation")] 
		public CHandle<inkanimProxy> VLoopAnimation
		{
			get => GetProperty(ref _vLoopAnimation);
			set => SetProperty(ref _vLoopAnimation, value);
		}

		[Ordinal(45)] 
		[RED("IntroAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(46)] 
		[RED("IntroWasPlayed")] 
		public CBool IntroWasPlayed
		{
			get => GetProperty(ref _introWasPlayed);
			set => SetProperty(ref _introWasPlayed, value);
		}

		[Ordinal(47)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(48)] 
		[RED("type")] 
		public CEnum<gameSimpleMessageType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(49)] 
		[RED("valueSaved")] 
		public CFloat ValueSaved
		{
			get => GetProperty(ref _valueSaved);
			set => SetProperty(ref _valueSaved, value);
		}

		[Ordinal(50)] 
		[RED("bumpValue")] 
		public CFloat BumpValue
		{
			get => GetProperty(ref _bumpValue);
			set => SetProperty(ref _bumpValue, value);
		}

		public HUDProgressBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
