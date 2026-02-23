using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _mainIcon;
		private inkImageWidgetReference _questIcon;
		private inkImageWidgetReference _callIcon;
		private inkWidgetReference _messageCounterLabel;
		private inkWidgetReference _messageCounterLabelCircle;
		private inkTextWidgetReference _messageCounter;
		private inkTextWidgetReference _messageCounterCircle;
		private wCHandle<gameJournalManager> _journalManager;
		private CString _phoneIconAtlas;
		private CName _phoneIconName;
		private CHandle<inkanimProxy> _proxy;
		private CHandle<inkanimProxy> _questImportantAnimProxy;
		private wCHandle<gameIBlackboard> _comDeviceBB;
		private wCHandle<gameIBlackboard> _quickSlotBB;
		private CHandle<redCallbackObject> _phoneEnabledBBId;
		private CHandle<redCallbackObject> _isVehiclesPopupVisibleBBId;
		private CHandle<redCallbackObject> _isRadioPopupVisibleBBId;
		private CHandle<redCallbackObject> _isRadialMenuVisibleBBId;
		private CHandle<redCallbackObject> _cinematicCameraBBId;

		[Ordinal(25)] 
		[RED("mainIcon")] 
		public inkImageWidgetReference MainIcon
		{
			get => GetProperty(ref _mainIcon);
			set => SetProperty(ref _mainIcon, value);
		}

		[Ordinal(26)] 
		[RED("questIcon")] 
		public inkImageWidgetReference QuestIcon
		{
			get => GetProperty(ref _questIcon);
			set => SetProperty(ref _questIcon, value);
		}

		[Ordinal(27)] 
		[RED("callIcon")] 
		public inkImageWidgetReference CallIcon
		{
			get => GetProperty(ref _callIcon);
			set => SetProperty(ref _callIcon, value);
		}

		[Ordinal(28)] 
		[RED("messageCounterLabel")] 
		public inkWidgetReference MessageCounterLabel
		{
			get => GetProperty(ref _messageCounterLabel);
			set => SetProperty(ref _messageCounterLabel, value);
		}

		[Ordinal(29)] 
		[RED("messageCounterLabelCircle")] 
		public inkWidgetReference MessageCounterLabelCircle
		{
			get => GetProperty(ref _messageCounterLabelCircle);
			set => SetProperty(ref _messageCounterLabelCircle, value);
		}

		[Ordinal(30)] 
		[RED("messageCounter")] 
		public inkTextWidgetReference MessageCounter
		{
			get => GetProperty(ref _messageCounter);
			set => SetProperty(ref _messageCounter, value);
		}

		[Ordinal(31)] 
		[RED("messageCounterCircle")] 
		public inkTextWidgetReference MessageCounterCircle
		{
			get => GetProperty(ref _messageCounterCircle);
			set => SetProperty(ref _messageCounterCircle, value);
		}

		[Ordinal(32)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(33)] 
		[RED("phoneIconAtlas")] 
		public CString PhoneIconAtlas
		{
			get => GetProperty(ref _phoneIconAtlas);
			set => SetProperty(ref _phoneIconAtlas, value);
		}

		[Ordinal(34)] 
		[RED("phoneIconName")] 
		public CName PhoneIconName
		{
			get => GetProperty(ref _phoneIconName);
			set => SetProperty(ref _phoneIconName, value);
		}

		[Ordinal(35)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetProperty(ref _proxy);
			set => SetProperty(ref _proxy, value);
		}

		[Ordinal(36)] 
		[RED("questImportantAnimProxy")] 
		public CHandle<inkanimProxy> QuestImportantAnimProxy
		{
			get => GetProperty(ref _questImportantAnimProxy);
			set => SetProperty(ref _questImportantAnimProxy, value);
		}

		[Ordinal(37)] 
		[RED("comDeviceBB")] 
		public wCHandle<gameIBlackboard> ComDeviceBB
		{
			get => GetProperty(ref _comDeviceBB);
			set => SetProperty(ref _comDeviceBB, value);
		}

		[Ordinal(38)] 
		[RED("quickSlotBB")] 
		public wCHandle<gameIBlackboard> QuickSlotBB
		{
			get => GetProperty(ref _quickSlotBB);
			set => SetProperty(ref _quickSlotBB, value);
		}

		[Ordinal(39)] 
		[RED("phoneEnabledBBId")] 
		public CHandle<redCallbackObject> PhoneEnabledBBId
		{
			get => GetProperty(ref _phoneEnabledBBId);
			set => SetProperty(ref _phoneEnabledBBId, value);
		}

		[Ordinal(40)] 
		[RED("isVehiclesPopupVisibleBBId")] 
		public CHandle<redCallbackObject> IsVehiclesPopupVisibleBBId
		{
			get => GetProperty(ref _isVehiclesPopupVisibleBBId);
			set => SetProperty(ref _isVehiclesPopupVisibleBBId, value);
		}

		[Ordinal(41)] 
		[RED("isRadioPopupVisibleBBId")] 
		public CHandle<redCallbackObject> IsRadioPopupVisibleBBId
		{
			get => GetProperty(ref _isRadioPopupVisibleBBId);
			set => SetProperty(ref _isRadioPopupVisibleBBId, value);
		}

		[Ordinal(42)] 
		[RED("isRadialMenuVisibleBBId")] 
		public CHandle<redCallbackObject> IsRadialMenuVisibleBBId
		{
			get => GetProperty(ref _isRadialMenuVisibleBBId);
			set => SetProperty(ref _isRadialMenuVisibleBBId, value);
		}

		[Ordinal(43)] 
		[RED("cinematicCameraBBId")] 
		public CHandle<redCallbackObject> CinematicCameraBBId
		{
			get => GetProperty(ref _cinematicCameraBBId);
			set => SetProperty(ref _cinematicCameraBBId, value);
		}

		public PhoneHotkeyController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
