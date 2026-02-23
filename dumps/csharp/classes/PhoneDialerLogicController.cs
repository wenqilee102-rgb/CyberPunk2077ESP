using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneDialerLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _tabsContainer;
		private inkWidgetReference _titleContainer;
		private inkTextWidgetReference _titleTextWidget;
		private inkTextWidgetReference _acceptButtonLabel;
		private inkTextWidgetReference _action2ButtonLabel;
		private inkWidgetReference _inputHintsPanel;
		private inkWidgetReference _threadPanel;
		private inkWidgetReference _threadList;
		private inkWidgetReference _callsQuestFlag;
		private inkWidgetReference _arrow;
		private inkWidgetReference _threadTab;
		private inkWidgetReference _unreadTab;
		private inkTextWidgetReference _threadTabLabel;
		private inkWidgetReference _contactsList;
		private inkImageWidgetReference _avatarImage;
		private inkWidgetReference _contactAvatarsFluff;
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _scrollControllerWidget;
		private inkWidgetReference _acceptButtonWidget;
		private inkWidgetReference _action2ButtonWidget;
		private inkWidgetReference _showAllButtonWidget;
		private inkTextWidgetReference _showAllLabel;
		private inkWidgetReference _nothingToReadMessageWidget;
		private inkWidgetReference _scrollBarWidget;
		private wCHandle<inkVirtualListController> _listController;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private CHandle<DialerContactDataView> _dataView;
		private CHandle<DialerContactTemplateClassifier> _templateClassifier;
		private wCHandle<inkScrollController> _scrollController;
		private CHandle<inkanimProxy> _switchAnimProxy;
		private CHandle<inkanimProxy> _transitionAnimProxy;
		private CHandle<inkanimProxy> _horizontalMoveAnimProxy;
		private wCHandle<inkVirtualListController> _threadsController;
		private CHandle<inkScriptableDataSourceWrapper> _dataSourceCache;
		private CHandle<DialerContactDataView> _dataViewCache;
		private CHandle<inkanimProxy> _moveBehindAnimProxy;
		private CHandle<inkanimProxy> _hideContactAnimProxy;
		private CUInt32 _contactIndexCache;
		private wCHandle<PhoneDialerSelectionController> _menuSelectorCtrl;
		private CBool _firstInit;
		private CUInt32 _indexToSelect;
		private CUInt32 _hidingIndex;
		private CHandle<PulseAnimation> _pulseAnim;
		private inkMargin _leftMargin;
		private inkMargin _rightMargin;
		private CEnum<PhoneDialerTabs> _currentTab;
		private CBool _callingEnabled;

		[Ordinal(1)] 
		[RED("tabsContainer")] 
		public inkWidgetReference TabsContainer
		{
			get => GetProperty(ref _tabsContainer);
			set => SetProperty(ref _tabsContainer, value);
		}

		[Ordinal(2)] 
		[RED("titleContainer")] 
		public inkWidgetReference TitleContainer
		{
			get => GetProperty(ref _titleContainer);
			set => SetProperty(ref _titleContainer, value);
		}

		[Ordinal(3)] 
		[RED("titleTextWidget")] 
		public inkTextWidgetReference TitleTextWidget
		{
			get => GetProperty(ref _titleTextWidget);
			set => SetProperty(ref _titleTextWidget, value);
		}

		[Ordinal(4)] 
		[RED("acceptButtonLabel")] 
		public inkTextWidgetReference AcceptButtonLabel
		{
			get => GetProperty(ref _acceptButtonLabel);
			set => SetProperty(ref _acceptButtonLabel, value);
		}

		[Ordinal(5)] 
		[RED("action2ButtonLabel")] 
		public inkTextWidgetReference Action2ButtonLabel
		{
			get => GetProperty(ref _action2ButtonLabel);
			set => SetProperty(ref _action2ButtonLabel, value);
		}

		[Ordinal(6)] 
		[RED("inputHintsPanel")] 
		public inkWidgetReference InputHintsPanel
		{
			get => GetProperty(ref _inputHintsPanel);
			set => SetProperty(ref _inputHintsPanel, value);
		}

		[Ordinal(7)] 
		[RED("threadPanel")] 
		public inkWidgetReference ThreadPanel
		{
			get => GetProperty(ref _threadPanel);
			set => SetProperty(ref _threadPanel, value);
		}

		[Ordinal(8)] 
		[RED("threadList")] 
		public inkWidgetReference ThreadList
		{
			get => GetProperty(ref _threadList);
			set => SetProperty(ref _threadList, value);
		}

		[Ordinal(9)] 
		[RED("callsQuestFlag")] 
		public inkWidgetReference CallsQuestFlag
		{
			get => GetProperty(ref _callsQuestFlag);
			set => SetProperty(ref _callsQuestFlag, value);
		}

		[Ordinal(10)] 
		[RED("arrow")] 
		public inkWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(11)] 
		[RED("threadTab")] 
		public inkWidgetReference ThreadTab
		{
			get => GetProperty(ref _threadTab);
			set => SetProperty(ref _threadTab, value);
		}

		[Ordinal(12)] 
		[RED("unreadTab")] 
		public inkWidgetReference UnreadTab
		{
			get => GetProperty(ref _unreadTab);
			set => SetProperty(ref _unreadTab, value);
		}

		[Ordinal(13)] 
		[RED("threadTabLabel")] 
		public inkTextWidgetReference ThreadTabLabel
		{
			get => GetProperty(ref _threadTabLabel);
			set => SetProperty(ref _threadTabLabel, value);
		}

		[Ordinal(14)] 
		[RED("contactsList")] 
		public inkWidgetReference ContactsList
		{
			get => GetProperty(ref _contactsList);
			set => SetProperty(ref _contactsList, value);
		}

		[Ordinal(15)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get => GetProperty(ref _avatarImage);
			set => SetProperty(ref _avatarImage, value);
		}

		[Ordinal(16)] 
		[RED("contactAvatarsFluff")] 
		public inkWidgetReference ContactAvatarsFluff
		{
			get => GetProperty(ref _contactAvatarsFluff);
			set => SetProperty(ref _contactAvatarsFluff, value);
		}

		[Ordinal(17)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(18)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetProperty(ref _scrollControllerWidget);
			set => SetProperty(ref _scrollControllerWidget, value);
		}

		[Ordinal(19)] 
		[RED("acceptButtonWidget")] 
		public inkWidgetReference AcceptButtonWidget
		{
			get => GetProperty(ref _acceptButtonWidget);
			set => SetProperty(ref _acceptButtonWidget, value);
		}

		[Ordinal(20)] 
		[RED("action2ButtonWidget")] 
		public inkWidgetReference Action2ButtonWidget
		{
			get => GetProperty(ref _action2ButtonWidget);
			set => SetProperty(ref _action2ButtonWidget, value);
		}

		[Ordinal(21)] 
		[RED("showAllButtonWidget")] 
		public inkWidgetReference ShowAllButtonWidget
		{
			get => GetProperty(ref _showAllButtonWidget);
			set => SetProperty(ref _showAllButtonWidget, value);
		}

		[Ordinal(22)] 
		[RED("showAllLabel")] 
		public inkTextWidgetReference ShowAllLabel
		{
			get => GetProperty(ref _showAllLabel);
			set => SetProperty(ref _showAllLabel, value);
		}

		[Ordinal(23)] 
		[RED("nothingToReadMessageWidget")] 
		public inkWidgetReference NothingToReadMessageWidget
		{
			get => GetProperty(ref _nothingToReadMessageWidget);
			set => SetProperty(ref _nothingToReadMessageWidget, value);
		}

		[Ordinal(24)] 
		[RED("scrollBarWidget")] 
		public inkWidgetReference ScrollBarWidget
		{
			get => GetProperty(ref _scrollBarWidget);
			set => SetProperty(ref _scrollBarWidget, value);
		}

		[Ordinal(25)] 
		[RED("listController")] 
		public wCHandle<inkVirtualListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(26)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(27)] 
		[RED("dataView")] 
		public CHandle<DialerContactDataView> DataView
		{
			get => GetProperty(ref _dataView);
			set => SetProperty(ref _dataView, value);
		}

		[Ordinal(28)] 
		[RED("templateClassifier")] 
		public CHandle<DialerContactTemplateClassifier> TemplateClassifier
		{
			get => GetProperty(ref _templateClassifier);
			set => SetProperty(ref _templateClassifier, value);
		}

		[Ordinal(29)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(30)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get => GetProperty(ref _switchAnimProxy);
			set => SetProperty(ref _switchAnimProxy, value);
		}

		[Ordinal(31)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetProperty(ref _transitionAnimProxy);
			set => SetProperty(ref _transitionAnimProxy, value);
		}

		[Ordinal(32)] 
		[RED("horizontalMoveAnimProxy")] 
		public CHandle<inkanimProxy> HorizontalMoveAnimProxy
		{
			get => GetProperty(ref _horizontalMoveAnimProxy);
			set => SetProperty(ref _horizontalMoveAnimProxy, value);
		}

		[Ordinal(33)] 
		[RED("threadsController")] 
		public wCHandle<inkVirtualListController> ThreadsController
		{
			get => GetProperty(ref _threadsController);
			set => SetProperty(ref _threadsController, value);
		}

		[Ordinal(34)] 
		[RED("dataSourceCache")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSourceCache
		{
			get => GetProperty(ref _dataSourceCache);
			set => SetProperty(ref _dataSourceCache, value);
		}

		[Ordinal(35)] 
		[RED("dataViewCache")] 
		public CHandle<DialerContactDataView> DataViewCache
		{
			get => GetProperty(ref _dataViewCache);
			set => SetProperty(ref _dataViewCache, value);
		}

		[Ordinal(36)] 
		[RED("moveBehindAnimProxy")] 
		public CHandle<inkanimProxy> MoveBehindAnimProxy
		{
			get => GetProperty(ref _moveBehindAnimProxy);
			set => SetProperty(ref _moveBehindAnimProxy, value);
		}

		[Ordinal(37)] 
		[RED("hideContactAnimProxy")] 
		public CHandle<inkanimProxy> HideContactAnimProxy
		{
			get => GetProperty(ref _hideContactAnimProxy);
			set => SetProperty(ref _hideContactAnimProxy, value);
		}

		[Ordinal(38)] 
		[RED("contactIndexCache")] 
		public CUInt32 ContactIndexCache
		{
			get => GetProperty(ref _contactIndexCache);
			set => SetProperty(ref _contactIndexCache, value);
		}

		[Ordinal(39)] 
		[RED("menuSelectorCtrl")] 
		public wCHandle<PhoneDialerSelectionController> MenuSelectorCtrl
		{
			get => GetProperty(ref _menuSelectorCtrl);
			set => SetProperty(ref _menuSelectorCtrl, value);
		}

		[Ordinal(40)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetProperty(ref _firstInit);
			set => SetProperty(ref _firstInit, value);
		}

		[Ordinal(41)] 
		[RED("indexToSelect")] 
		public CUInt32 IndexToSelect
		{
			get => GetProperty(ref _indexToSelect);
			set => SetProperty(ref _indexToSelect, value);
		}

		[Ordinal(42)] 
		[RED("hidingIndex")] 
		public CUInt32 HidingIndex
		{
			get => GetProperty(ref _hidingIndex);
			set => SetProperty(ref _hidingIndex, value);
		}

		[Ordinal(43)] 
		[RED("pulseAnim")] 
		public CHandle<PulseAnimation> PulseAnim
		{
			get => GetProperty(ref _pulseAnim);
			set => SetProperty(ref _pulseAnim, value);
		}

		[Ordinal(44)] 
		[RED("leftMargin")] 
		public inkMargin LeftMargin
		{
			get => GetProperty(ref _leftMargin);
			set => SetProperty(ref _leftMargin, value);
		}

		[Ordinal(45)] 
		[RED("rightMargin")] 
		public inkMargin RightMargin
		{
			get => GetProperty(ref _rightMargin);
			set => SetProperty(ref _rightMargin, value);
		}

		[Ordinal(46)] 
		[RED("currentTab")] 
		public CEnum<PhoneDialerTabs> CurrentTab
		{
			get => GetProperty(ref _currentTab);
			set => SetProperty(ref _currentTab, value);
		}

		[Ordinal(47)] 
		[RED("callingEnabled")] 
		public CBool CallingEnabled
		{
			get => GetProperty(ref _callingEnabled);
			set => SetProperty(ref _callingEnabled, value);
		}

		public PhoneDialerLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
