using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleQuestListItemController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _description;
		private inkImageWidgetReference _typeIcon;
		private inkImageWidgetReference _difficultIcon;
		private inkImageWidgetReference _fixerIcon;
		private inkImageWidgetReference _ep1Icon;
		private inkWidgetReference _toggleAnimatedIndicator;
		private inkWidgetReference _hoverIndicator;
		private inkWidgetReference _questItemFrame;
		private inkWidgetReference _questItemBg;
		private inkWidgetReference _questItemBgButton;
		private inkWidgetReference _distanceContainer;
		private inkTextWidgetReference _defaultDistance;
		private inkTextWidgetReference _trackedDistance;
		private inkWidgetReference _isNewMarker;
		private CName _toggleMarkAnimation;
		private CName _trackMarkAnimation;
		private CName _distanceAnim_toDefault;
		private CName _distanceAnim_toHover;
		private CName _distanceAnim_toTracked;
		private CFloat _distanceAnim_toHover_delay;
		private CName _pinIcon_toHover;
		private CName _pinIcon_toDefault;
		private CHandle<inkanimProxy> _toggleOnAnimProxy;
		private CHandle<inkanimProxy> _toggleOffAnimProxy;
		private CHandle<inkanimProxy> _pinIconAnimProxy;
		private CHandle<inkanimProxy> _distanceMarkerAnimProxy;
		private CHandle<QuestListItemData> _data;
		private wCHandle<gameJournalQuest> _openedQuest;
		private CBool _hovered;
		private CBool _toggled;
		private CBool _tracked;
		private wCHandle<inkWidget> _rootWidget;

		[Ordinal(18)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(19)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(20)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetProperty(ref _typeIcon);
			set => SetProperty(ref _typeIcon, value);
		}

		[Ordinal(21)] 
		[RED("difficultIcon")] 
		public inkImageWidgetReference DifficultIcon
		{
			get => GetProperty(ref _difficultIcon);
			set => SetProperty(ref _difficultIcon, value);
		}

		[Ordinal(22)] 
		[RED("fixerIcon")] 
		public inkImageWidgetReference FixerIcon
		{
			get => GetProperty(ref _fixerIcon);
			set => SetProperty(ref _fixerIcon, value);
		}

		[Ordinal(23)] 
		[RED("ep1Icon")] 
		public inkImageWidgetReference Ep1Icon
		{
			get => GetProperty(ref _ep1Icon);
			set => SetProperty(ref _ep1Icon, value);
		}

		[Ordinal(24)] 
		[RED("toggleAnimatedIndicator")] 
		public inkWidgetReference ToggleAnimatedIndicator
		{
			get => GetProperty(ref _toggleAnimatedIndicator);
			set => SetProperty(ref _toggleAnimatedIndicator, value);
		}

		[Ordinal(25)] 
		[RED("hoverIndicator")] 
		public inkWidgetReference HoverIndicator
		{
			get => GetProperty(ref _hoverIndicator);
			set => SetProperty(ref _hoverIndicator, value);
		}

		[Ordinal(26)] 
		[RED("questItemFrame")] 
		public inkWidgetReference QuestItemFrame
		{
			get => GetProperty(ref _questItemFrame);
			set => SetProperty(ref _questItemFrame, value);
		}

		[Ordinal(27)] 
		[RED("questItemBg")] 
		public inkWidgetReference QuestItemBg
		{
			get => GetProperty(ref _questItemBg);
			set => SetProperty(ref _questItemBg, value);
		}

		[Ordinal(28)] 
		[RED("questItemBgButton")] 
		public inkWidgetReference QuestItemBgButton
		{
			get => GetProperty(ref _questItemBgButton);
			set => SetProperty(ref _questItemBgButton, value);
		}

		[Ordinal(29)] 
		[RED("distanceContainer")] 
		public inkWidgetReference DistanceContainer
		{
			get => GetProperty(ref _distanceContainer);
			set => SetProperty(ref _distanceContainer, value);
		}

		[Ordinal(30)] 
		[RED("defaultDistance")] 
		public inkTextWidgetReference DefaultDistance
		{
			get => GetProperty(ref _defaultDistance);
			set => SetProperty(ref _defaultDistance, value);
		}

		[Ordinal(31)] 
		[RED("trackedDistance")] 
		public inkTextWidgetReference TrackedDistance
		{
			get => GetProperty(ref _trackedDistance);
			set => SetProperty(ref _trackedDistance, value);
		}

		[Ordinal(32)] 
		[RED("isNewMarker")] 
		public inkWidgetReference IsNewMarker
		{
			get => GetProperty(ref _isNewMarker);
			set => SetProperty(ref _isNewMarker, value);
		}

		[Ordinal(33)] 
		[RED("toggleMarkAnimation")] 
		public CName ToggleMarkAnimation
		{
			get => GetProperty(ref _toggleMarkAnimation);
			set => SetProperty(ref _toggleMarkAnimation, value);
		}

		[Ordinal(34)] 
		[RED("trackMarkAnimation")] 
		public CName TrackMarkAnimation
		{
			get => GetProperty(ref _trackMarkAnimation);
			set => SetProperty(ref _trackMarkAnimation, value);
		}

		[Ordinal(35)] 
		[RED("distanceAnim_toDefault")] 
		public CName DistanceAnim_toDefault
		{
			get => GetProperty(ref _distanceAnim_toDefault);
			set => SetProperty(ref _distanceAnim_toDefault, value);
		}

		[Ordinal(36)] 
		[RED("distanceAnim_toHover")] 
		public CName DistanceAnim_toHover
		{
			get => GetProperty(ref _distanceAnim_toHover);
			set => SetProperty(ref _distanceAnim_toHover, value);
		}

		[Ordinal(37)] 
		[RED("distanceAnim_toTracked")] 
		public CName DistanceAnim_toTracked
		{
			get => GetProperty(ref _distanceAnim_toTracked);
			set => SetProperty(ref _distanceAnim_toTracked, value);
		}

		[Ordinal(38)] 
		[RED("distanceAnim_toHover_delay")] 
		public CFloat DistanceAnim_toHover_delay
		{
			get => GetProperty(ref _distanceAnim_toHover_delay);
			set => SetProperty(ref _distanceAnim_toHover_delay, value);
		}

		[Ordinal(39)] 
		[RED("pinIcon_toHover")] 
		public CName PinIcon_toHover
		{
			get => GetProperty(ref _pinIcon_toHover);
			set => SetProperty(ref _pinIcon_toHover, value);
		}

		[Ordinal(40)] 
		[RED("pinIcon_toDefault")] 
		public CName PinIcon_toDefault
		{
			get => GetProperty(ref _pinIcon_toDefault);
			set => SetProperty(ref _pinIcon_toDefault, value);
		}

		[Ordinal(41)] 
		[RED("toggleOnAnimProxy")] 
		public CHandle<inkanimProxy> ToggleOnAnimProxy
		{
			get => GetProperty(ref _toggleOnAnimProxy);
			set => SetProperty(ref _toggleOnAnimProxy, value);
		}

		[Ordinal(42)] 
		[RED("toggleOffAnimProxy")] 
		public CHandle<inkanimProxy> ToggleOffAnimProxy
		{
			get => GetProperty(ref _toggleOffAnimProxy);
			set => SetProperty(ref _toggleOffAnimProxy, value);
		}

		[Ordinal(43)] 
		[RED("pinIconAnimProxy")] 
		public CHandle<inkanimProxy> PinIconAnimProxy
		{
			get => GetProperty(ref _pinIconAnimProxy);
			set => SetProperty(ref _pinIconAnimProxy, value);
		}

		[Ordinal(44)] 
		[RED("distanceMarkerAnimProxy")] 
		public CHandle<inkanimProxy> DistanceMarkerAnimProxy
		{
			get => GetProperty(ref _distanceMarkerAnimProxy);
			set => SetProperty(ref _distanceMarkerAnimProxy, value);
		}

		[Ordinal(45)] 
		[RED("data")] 
		public CHandle<QuestListItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(46)] 
		[RED("openedQuest")] 
		public wCHandle<gameJournalQuest> OpenedQuest
		{
			get => GetProperty(ref _openedQuest);
			set => SetProperty(ref _openedQuest, value);
		}

		[Ordinal(47)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(48)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get => GetProperty(ref _toggled);
			set => SetProperty(ref _toggled, value);
		}

		[Ordinal(49)] 
		[RED("tracked")] 
		public CBool Tracked
		{
			get => GetProperty(ref _tracked);
			set => SetProperty(ref _tracked, value);
		}

		[Ordinal(50)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		public SimpleQuestListItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
