using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioPopupGameController : BaseModalListPopupGameController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _trackName;
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _scrollControllerWidget;
		private inkWidgetReference _radioVolumeSettings;
		private CName _volumeSettingGroupName;
		private CName _volumeSettingVarName;
		private CHandle<RadioStationsDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private wCHandle<QuickSlotsManager> _quickSlotsManager;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<vehicleBaseObject> _playerVehicle;
		private CUInt32 _startupIndex;
		private CInt32 _currentRadioId;
		private wCHandle<RadioStationListItemController> _selectedItem;
		private wCHandle<inkScrollController> _scrollController;
		private CBool _canVolumeDown;
		private CBool _canVolumeUp;
		private wCHandle<RadioVolumeSettingsController> _radioVolumeSettingsController;

		[Ordinal(15)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(16)] 
		[RED("trackName")] 
		public inkTextWidgetReference TrackName
		{
			get => GetProperty(ref _trackName);
			set => SetProperty(ref _trackName, value);
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
		[RED("radioVolumeSettings")] 
		public inkWidgetReference RadioVolumeSettings
		{
			get => GetProperty(ref _radioVolumeSettings);
			set => SetProperty(ref _radioVolumeSettings, value);
		}

		[Ordinal(20)] 
		[RED("volumeSettingGroupName")] 
		public CName VolumeSettingGroupName
		{
			get => GetProperty(ref _volumeSettingGroupName);
			set => SetProperty(ref _volumeSettingGroupName, value);
		}

		[Ordinal(21)] 
		[RED("volumeSettingVarName")] 
		public CName VolumeSettingVarName
		{
			get => GetProperty(ref _volumeSettingVarName);
			set => SetProperty(ref _volumeSettingVarName, value);
		}

		[Ordinal(22)] 
		[RED("dataView")] 
		public CHandle<RadioStationsDataView> DataView
		{
			get => GetProperty(ref _dataView);
			set => SetProperty(ref _dataView, value);
		}

		[Ordinal(23)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(24)] 
		[RED("quickSlotsManager")] 
		public wCHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(25)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(26)] 
		[RED("playerVehicle")] 
		public wCHandle<vehicleBaseObject> PlayerVehicle
		{
			get => GetProperty(ref _playerVehicle);
			set => SetProperty(ref _playerVehicle, value);
		}

		[Ordinal(27)] 
		[RED("startupIndex")] 
		public CUInt32 StartupIndex
		{
			get => GetProperty(ref _startupIndex);
			set => SetProperty(ref _startupIndex, value);
		}

		[Ordinal(28)] 
		[RED("currentRadioId")] 
		public CInt32 CurrentRadioId
		{
			get => GetProperty(ref _currentRadioId);
			set => SetProperty(ref _currentRadioId, value);
		}

		[Ordinal(29)] 
		[RED("selectedItem")] 
		public wCHandle<RadioStationListItemController> SelectedItem
		{
			get => GetProperty(ref _selectedItem);
			set => SetProperty(ref _selectedItem, value);
		}

		[Ordinal(30)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(31)] 
		[RED("canVolumeDown")] 
		public CBool CanVolumeDown
		{
			get => GetProperty(ref _canVolumeDown);
			set => SetProperty(ref _canVolumeDown, value);
		}

		[Ordinal(32)] 
		[RED("canVolumeUp")] 
		public CBool CanVolumeUp
		{
			get => GetProperty(ref _canVolumeUp);
			set => SetProperty(ref _canVolumeUp, value);
		}

		[Ordinal(33)] 
		[RED("radioVolumeSettingsController")] 
		public wCHandle<RadioVolumeSettingsController> RadioVolumeSettingsController
		{
			get => GetProperty(ref _radioVolumeSettingsController);
			set => SetProperty(ref _radioVolumeSettingsController, value);
		}

		public VehicleRadioPopupGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
