using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapMenuGameController : gameuiMappinsContainerController
	{
		private TweakDBID _settingsRecordID;
		private wCHandle<gameuiBaseWorldMapMappinController> _selectedMappin;
		private CBool _playerOnTop;
		private CName _entityPreviewLibraryID;
		private inkCompoundWidgetReference _entityPreviewSpawnContainer;
		private inkCompoundWidgetReference _floorPlanSpawnContainer;
		private inkWidgetReference _compassWidget;
		private inkCompoundWidgetReference _districtsContainer;
		private inkCompoundWidgetReference _subdistrictsContainer;
		private inkCompoundWidgetReference _mappinOutlinesContainer;
		private inkCompoundWidgetReference _groupOutlinesContainer;
		private inkCompoundWidgetReference _tooltipContainer;
		private inkMargin _tooltipOffset;
		private inkMargin _tooltipDistrictOffset;
		private CEnum<gameuiEWorldMapDistrictView> _districtView;
		private CEnum<gamedataDistrict> _hoveredDistrict;
		private CEnum<gamedataDistrict> _hoveredSubDistrict;
		private CEnum<gamedataDistrict> _selectedDistrict;
		private CBool _canChangeCustomFilter;
		private CBool _isZoomToMappinEnabled;
		private gameNewMappinID _delamainTaxiMappinID;
		private inkWidgetReference _preloaderWidget;
		private inkTextWidgetReference _gameTimeText;
		private inkWidgetReference _fastTravelInstructions;
		private inkWidgetReference _delamainTaxiInstructions;
		private inkWidgetReference _filterSelector;
		private inkWidgetReference _filterSelectorWarning;
		private inkTextWidgetReference _filterText;
		private inkWidgetReference _districtIconImageContainer;
		private inkImageWidgetReference _districtIconImage;
		private inkTextWidgetReference _districtNameText;
		private inkTextWidgetReference _subdistrictNameText;
		private inkWidgetReference _locationAndGangsContainer;
		private inkWidgetReference _gangsInfoContainer;
		private inkCompoundWidgetReference _gangsList;
		private inkWidgetReference _questContainer;
		private inkTextWidgetReference _questName;
		private inkWidgetReference _openInJournalButton;
		private inkTextWidgetReference _objectiveName;
		private inkWidgetReference _objectiveBackground;
		private inkWidgetReference _objectiveFrame;
		private inkWidgetReference _topShadow;
		private CFloat _rightAxisZoomThreshold;
		private inkWidgetReference _customFilters;
		private inkVerticalPanelWidgetReference _filtersList;
		private inkWidgetReference _filterLeftArrow;
		private inkWidgetReference _filterRightArrow;
		private CArray<inkWidgetReference> _quickFilterIndicators;
		private CFloat _customFiltersListAnimationDelay;
		private CEnum<gameuiEWorldMapCameraMode> _cameraMode;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<WorldMapTooltipContainer> _tooltipController;
		private CHandle<textTextParameterSet> _gameTimeTextParams;
		private CEnum<gamedataDistrict> _previousHoveredDistrict;
		private CEnum<gamedataDistrict> _currentHoveredDistrict;
		private CBool _showedSubdistrictGangs;
		private wCHandle<gameObject> _player;
		private wCHandle<gameGameAudioSystem> _audioSystem;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;
		private wCHandle<gameIBlackboard> _mapBlackboard;
		private CHandle<UI_MapDef> _mapDefinition;
		private wCHandle<gameJournalQuestObjectiveBase> _trackedObjective;
		private wCHandle<gameJournalQuest> _trackedQuest;
		private CArray<Vector3> _mappinsPositions;
		private CFloat _lastRightAxisYAmount;
		private CBool _justOpenedQuestJournal;
		private CHandle<MapMenuUserData> _initMappinFocus;
		private CInt32 _currentQuickFilterIndex;
		private CInt32 _currentCustomFilterIndex;
		private CInt32 _spawnedCustomFilterIndex;
		private CArray<wCHandle<inkAsyncSpawnRequest>> _gangsAsyncSpawnRequests;
		private CArray<wCHandle<WorldMapFiltersListItem>> _customFiltersList;
		private CHandle<inkanimProxy> _animationProxy;
		private CBool _entityAttached;
		private CBool _readyToZoom;
		private CBool _isHoveringOverFilters;
		private CBool _isPanning;
		private CBool _isZooming;
		private CBool _pressedRMB;
		private CBool _startedFastTraveling;

		[Ordinal(18)] 
		[RED("settingsRecordID")] 
		public TweakDBID SettingsRecordID
		{
			get => GetProperty(ref _settingsRecordID);
			set => SetProperty(ref _settingsRecordID, value);
		}

		[Ordinal(19)] 
		[RED("selectedMappin")] 
		public wCHandle<gameuiBaseWorldMapMappinController> SelectedMappin
		{
			get => GetProperty(ref _selectedMappin);
			set => SetProperty(ref _selectedMappin, value);
		}

		[Ordinal(20)] 
		[RED("playerOnTop")] 
		public CBool PlayerOnTop
		{
			get => GetProperty(ref _playerOnTop);
			set => SetProperty(ref _playerOnTop, value);
		}

		[Ordinal(21)] 
		[RED("entityPreviewLibraryID")] 
		public CName EntityPreviewLibraryID
		{
			get => GetProperty(ref _entityPreviewLibraryID);
			set => SetProperty(ref _entityPreviewLibraryID, value);
		}

		[Ordinal(22)] 
		[RED("entityPreviewSpawnContainer")] 
		public inkCompoundWidgetReference EntityPreviewSpawnContainer
		{
			get => GetProperty(ref _entityPreviewSpawnContainer);
			set => SetProperty(ref _entityPreviewSpawnContainer, value);
		}

		[Ordinal(23)] 
		[RED("floorPlanSpawnContainer")] 
		public inkCompoundWidgetReference FloorPlanSpawnContainer
		{
			get => GetProperty(ref _floorPlanSpawnContainer);
			set => SetProperty(ref _floorPlanSpawnContainer, value);
		}

		[Ordinal(24)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetProperty(ref _compassWidget);
			set => SetProperty(ref _compassWidget, value);
		}

		[Ordinal(25)] 
		[RED("districtsContainer")] 
		public inkCompoundWidgetReference DistrictsContainer
		{
			get => GetProperty(ref _districtsContainer);
			set => SetProperty(ref _districtsContainer, value);
		}

		[Ordinal(26)] 
		[RED("subdistrictsContainer")] 
		public inkCompoundWidgetReference SubdistrictsContainer
		{
			get => GetProperty(ref _subdistrictsContainer);
			set => SetProperty(ref _subdistrictsContainer, value);
		}

		[Ordinal(27)] 
		[RED("mappinOutlinesContainer")] 
		public inkCompoundWidgetReference MappinOutlinesContainer
		{
			get => GetProperty(ref _mappinOutlinesContainer);
			set => SetProperty(ref _mappinOutlinesContainer, value);
		}

		[Ordinal(28)] 
		[RED("groupOutlinesContainer")] 
		public inkCompoundWidgetReference GroupOutlinesContainer
		{
			get => GetProperty(ref _groupOutlinesContainer);
			set => SetProperty(ref _groupOutlinesContainer, value);
		}

		[Ordinal(29)] 
		[RED("tooltipContainer")] 
		public inkCompoundWidgetReference TooltipContainer
		{
			get => GetProperty(ref _tooltipContainer);
			set => SetProperty(ref _tooltipContainer, value);
		}

		[Ordinal(30)] 
		[RED("tooltipOffset")] 
		public inkMargin TooltipOffset
		{
			get => GetProperty(ref _tooltipOffset);
			set => SetProperty(ref _tooltipOffset, value);
		}

		[Ordinal(31)] 
		[RED("tooltipDistrictOffset")] 
		public inkMargin TooltipDistrictOffset
		{
			get => GetProperty(ref _tooltipDistrictOffset);
			set => SetProperty(ref _tooltipDistrictOffset, value);
		}

		[Ordinal(32)] 
		[RED("districtView")] 
		public CEnum<gameuiEWorldMapDistrictView> DistrictView
		{
			get => GetProperty(ref _districtView);
			set => SetProperty(ref _districtView, value);
		}

		[Ordinal(33)] 
		[RED("hoveredDistrict")] 
		public CEnum<gamedataDistrict> HoveredDistrict
		{
			get => GetProperty(ref _hoveredDistrict);
			set => SetProperty(ref _hoveredDistrict, value);
		}

		[Ordinal(34)] 
		[RED("hoveredSubDistrict")] 
		public CEnum<gamedataDistrict> HoveredSubDistrict
		{
			get => GetProperty(ref _hoveredSubDistrict);
			set => SetProperty(ref _hoveredSubDistrict, value);
		}

		[Ordinal(35)] 
		[RED("selectedDistrict")] 
		public CEnum<gamedataDistrict> SelectedDistrict
		{
			get => GetProperty(ref _selectedDistrict);
			set => SetProperty(ref _selectedDistrict, value);
		}

		[Ordinal(36)] 
		[RED("canChangeCustomFilter")] 
		public CBool CanChangeCustomFilter
		{
			get => GetProperty(ref _canChangeCustomFilter);
			set => SetProperty(ref _canChangeCustomFilter, value);
		}

		[Ordinal(37)] 
		[RED("isZoomToMappinEnabled")] 
		public CBool IsZoomToMappinEnabled
		{
			get => GetProperty(ref _isZoomToMappinEnabled);
			set => SetProperty(ref _isZoomToMappinEnabled, value);
		}

		[Ordinal(38)] 
		[RED("delamainTaxiMappinID")] 
		public gameNewMappinID DelamainTaxiMappinID
		{
			get => GetProperty(ref _delamainTaxiMappinID);
			set => SetProperty(ref _delamainTaxiMappinID, value);
		}

		[Ordinal(39)] 
		[RED("preloaderWidget")] 
		public inkWidgetReference PreloaderWidget
		{
			get => GetProperty(ref _preloaderWidget);
			set => SetProperty(ref _preloaderWidget, value);
		}

		[Ordinal(40)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get => GetProperty(ref _gameTimeText);
			set => SetProperty(ref _gameTimeText, value);
		}

		[Ordinal(41)] 
		[RED("fastTravelInstructions")] 
		public inkWidgetReference FastTravelInstructions
		{
			get => GetProperty(ref _fastTravelInstructions);
			set => SetProperty(ref _fastTravelInstructions, value);
		}

		[Ordinal(42)] 
		[RED("delamainTaxiInstructions")] 
		public inkWidgetReference DelamainTaxiInstructions
		{
			get => GetProperty(ref _delamainTaxiInstructions);
			set => SetProperty(ref _delamainTaxiInstructions, value);
		}

		[Ordinal(43)] 
		[RED("filterSelector")] 
		public inkWidgetReference FilterSelector
		{
			get => GetProperty(ref _filterSelector);
			set => SetProperty(ref _filterSelector, value);
		}

		[Ordinal(44)] 
		[RED("filterSelectorWarning")] 
		public inkWidgetReference FilterSelectorWarning
		{
			get => GetProperty(ref _filterSelectorWarning);
			set => SetProperty(ref _filterSelectorWarning, value);
		}

		[Ordinal(45)] 
		[RED("filterText")] 
		public inkTextWidgetReference FilterText
		{
			get => GetProperty(ref _filterText);
			set => SetProperty(ref _filterText, value);
		}

		[Ordinal(46)] 
		[RED("districtIconImageContainer")] 
		public inkWidgetReference DistrictIconImageContainer
		{
			get => GetProperty(ref _districtIconImageContainer);
			set => SetProperty(ref _districtIconImageContainer, value);
		}

		[Ordinal(47)] 
		[RED("districtIconImage")] 
		public inkImageWidgetReference DistrictIconImage
		{
			get => GetProperty(ref _districtIconImage);
			set => SetProperty(ref _districtIconImage, value);
		}

		[Ordinal(48)] 
		[RED("districtNameText")] 
		public inkTextWidgetReference DistrictNameText
		{
			get => GetProperty(ref _districtNameText);
			set => SetProperty(ref _districtNameText, value);
		}

		[Ordinal(49)] 
		[RED("subdistrictNameText")] 
		public inkTextWidgetReference SubdistrictNameText
		{
			get => GetProperty(ref _subdistrictNameText);
			set => SetProperty(ref _subdistrictNameText, value);
		}

		[Ordinal(50)] 
		[RED("locationAndGangsContainer")] 
		public inkWidgetReference LocationAndGangsContainer
		{
			get => GetProperty(ref _locationAndGangsContainer);
			set => SetProperty(ref _locationAndGangsContainer, value);
		}

		[Ordinal(51)] 
		[RED("gangsInfoContainer")] 
		public inkWidgetReference GangsInfoContainer
		{
			get => GetProperty(ref _gangsInfoContainer);
			set => SetProperty(ref _gangsInfoContainer, value);
		}

		[Ordinal(52)] 
		[RED("gangsList")] 
		public inkCompoundWidgetReference GangsList
		{
			get => GetProperty(ref _gangsList);
			set => SetProperty(ref _gangsList, value);
		}

		[Ordinal(53)] 
		[RED("questContainer")] 
		public inkWidgetReference QuestContainer
		{
			get => GetProperty(ref _questContainer);
			set => SetProperty(ref _questContainer, value);
		}

		[Ordinal(54)] 
		[RED("questName")] 
		public inkTextWidgetReference QuestName
		{
			get => GetProperty(ref _questName);
			set => SetProperty(ref _questName, value);
		}

		[Ordinal(55)] 
		[RED("openInJournalButton")] 
		public inkWidgetReference OpenInJournalButton
		{
			get => GetProperty(ref _openInJournalButton);
			set => SetProperty(ref _openInJournalButton, value);
		}

		[Ordinal(56)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get => GetProperty(ref _objectiveName);
			set => SetProperty(ref _objectiveName, value);
		}

		[Ordinal(57)] 
		[RED("objectiveBackground")] 
		public inkWidgetReference ObjectiveBackground
		{
			get => GetProperty(ref _objectiveBackground);
			set => SetProperty(ref _objectiveBackground, value);
		}

		[Ordinal(58)] 
		[RED("objectiveFrame")] 
		public inkWidgetReference ObjectiveFrame
		{
			get => GetProperty(ref _objectiveFrame);
			set => SetProperty(ref _objectiveFrame, value);
		}

		[Ordinal(59)] 
		[RED("topShadow")] 
		public inkWidgetReference TopShadow
		{
			get => GetProperty(ref _topShadow);
			set => SetProperty(ref _topShadow, value);
		}

		[Ordinal(60)] 
		[RED("rightAxisZoomThreshold")] 
		public CFloat RightAxisZoomThreshold
		{
			get => GetProperty(ref _rightAxisZoomThreshold);
			set => SetProperty(ref _rightAxisZoomThreshold, value);
		}

		[Ordinal(61)] 
		[RED("customFilters")] 
		public inkWidgetReference CustomFilters
		{
			get => GetProperty(ref _customFilters);
			set => SetProperty(ref _customFilters, value);
		}

		[Ordinal(62)] 
		[RED("filtersList")] 
		public inkVerticalPanelWidgetReference FiltersList
		{
			get => GetProperty(ref _filtersList);
			set => SetProperty(ref _filtersList, value);
		}

		[Ordinal(63)] 
		[RED("filterLeftArrow")] 
		public inkWidgetReference FilterLeftArrow
		{
			get => GetProperty(ref _filterLeftArrow);
			set => SetProperty(ref _filterLeftArrow, value);
		}

		[Ordinal(64)] 
		[RED("filterRightArrow")] 
		public inkWidgetReference FilterRightArrow
		{
			get => GetProperty(ref _filterRightArrow);
			set => SetProperty(ref _filterRightArrow, value);
		}

		[Ordinal(65)] 
		[RED("quickFilterIndicators")] 
		public CArray<inkWidgetReference> QuickFilterIndicators
		{
			get => GetProperty(ref _quickFilterIndicators);
			set => SetProperty(ref _quickFilterIndicators, value);
		}

		[Ordinal(66)] 
		[RED("customFiltersListAnimationDelay")] 
		public CFloat CustomFiltersListAnimationDelay
		{
			get => GetProperty(ref _customFiltersListAnimationDelay);
			set => SetProperty(ref _customFiltersListAnimationDelay, value);
		}

		[Ordinal(67)] 
		[RED("cameraMode")] 
		public CEnum<gameuiEWorldMapCameraMode> CameraMode
		{
			get => GetProperty(ref _cameraMode);
			set => SetProperty(ref _cameraMode, value);
		}

		[Ordinal(68)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(69)] 
		[RED("tooltipController")] 
		public wCHandle<WorldMapTooltipContainer> TooltipController
		{
			get => GetProperty(ref _tooltipController);
			set => SetProperty(ref _tooltipController, value);
		}

		[Ordinal(70)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get => GetProperty(ref _gameTimeTextParams);
			set => SetProperty(ref _gameTimeTextParams, value);
		}

		[Ordinal(71)] 
		[RED("previousHoveredDistrict")] 
		public CEnum<gamedataDistrict> PreviousHoveredDistrict
		{
			get => GetProperty(ref _previousHoveredDistrict);
			set => SetProperty(ref _previousHoveredDistrict, value);
		}

		[Ordinal(72)] 
		[RED("currentHoveredDistrict")] 
		public CEnum<gamedataDistrict> CurrentHoveredDistrict
		{
			get => GetProperty(ref _currentHoveredDistrict);
			set => SetProperty(ref _currentHoveredDistrict, value);
		}

		[Ordinal(73)] 
		[RED("showedSubdistrictGangs")] 
		public CBool ShowedSubdistrictGangs
		{
			get => GetProperty(ref _showedSubdistrictGangs);
			set => SetProperty(ref _showedSubdistrictGangs, value);
		}

		[Ordinal(74)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(75)] 
		[RED("audioSystem")] 
		public wCHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetProperty(ref _audioSystem);
			set => SetProperty(ref _audioSystem, value);
		}

		[Ordinal(76)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(77)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetProperty(ref _mappinSystem);
			set => SetProperty(ref _mappinSystem, value);
		}

		[Ordinal(78)] 
		[RED("mapBlackboard")] 
		public wCHandle<gameIBlackboard> MapBlackboard
		{
			get => GetProperty(ref _mapBlackboard);
			set => SetProperty(ref _mapBlackboard, value);
		}

		[Ordinal(79)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetProperty(ref _mapDefinition);
			set => SetProperty(ref _mapDefinition, value);
		}

		[Ordinal(80)] 
		[RED("trackedObjective")] 
		public wCHandle<gameJournalQuestObjectiveBase> TrackedObjective
		{
			get => GetProperty(ref _trackedObjective);
			set => SetProperty(ref _trackedObjective, value);
		}

		[Ordinal(81)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(82)] 
		[RED("mappinsPositions")] 
		public CArray<Vector3> MappinsPositions
		{
			get => GetProperty(ref _mappinsPositions);
			set => SetProperty(ref _mappinsPositions, value);
		}

		[Ordinal(83)] 
		[RED("lastRightAxisYAmount")] 
		public CFloat LastRightAxisYAmount
		{
			get => GetProperty(ref _lastRightAxisYAmount);
			set => SetProperty(ref _lastRightAxisYAmount, value);
		}

		[Ordinal(84)] 
		[RED("justOpenedQuestJournal")] 
		public CBool JustOpenedQuestJournal
		{
			get => GetProperty(ref _justOpenedQuestJournal);
			set => SetProperty(ref _justOpenedQuestJournal, value);
		}

		[Ordinal(85)] 
		[RED("initMappinFocus")] 
		public CHandle<MapMenuUserData> InitMappinFocus
		{
			get => GetProperty(ref _initMappinFocus);
			set => SetProperty(ref _initMappinFocus, value);
		}

		[Ordinal(86)] 
		[RED("currentQuickFilterIndex")] 
		public CInt32 CurrentQuickFilterIndex
		{
			get => GetProperty(ref _currentQuickFilterIndex);
			set => SetProperty(ref _currentQuickFilterIndex, value);
		}

		[Ordinal(87)] 
		[RED("currentCustomFilterIndex")] 
		public CInt32 CurrentCustomFilterIndex
		{
			get => GetProperty(ref _currentCustomFilterIndex);
			set => SetProperty(ref _currentCustomFilterIndex, value);
		}

		[Ordinal(88)] 
		[RED("spawnedCustomFilterIndex")] 
		public CInt32 SpawnedCustomFilterIndex
		{
			get => GetProperty(ref _spawnedCustomFilterIndex);
			set => SetProperty(ref _spawnedCustomFilterIndex, value);
		}

		[Ordinal(89)] 
		[RED("gangsAsyncSpawnRequests")] 
		public CArray<wCHandle<inkAsyncSpawnRequest>> GangsAsyncSpawnRequests
		{
			get => GetProperty(ref _gangsAsyncSpawnRequests);
			set => SetProperty(ref _gangsAsyncSpawnRequests, value);
		}

		[Ordinal(90)] 
		[RED("customFiltersList")] 
		public CArray<wCHandle<WorldMapFiltersListItem>> CustomFiltersList
		{
			get => GetProperty(ref _customFiltersList);
			set => SetProperty(ref _customFiltersList, value);
		}

		[Ordinal(91)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(92)] 
		[RED("entityAttached")] 
		public CBool EntityAttached
		{
			get => GetProperty(ref _entityAttached);
			set => SetProperty(ref _entityAttached, value);
		}

		[Ordinal(93)] 
		[RED("readyToZoom")] 
		public CBool ReadyToZoom
		{
			get => GetProperty(ref _readyToZoom);
			set => SetProperty(ref _readyToZoom, value);
		}

		[Ordinal(94)] 
		[RED("isHoveringOverFilters")] 
		public CBool IsHoveringOverFilters
		{
			get => GetProperty(ref _isHoveringOverFilters);
			set => SetProperty(ref _isHoveringOverFilters, value);
		}

		[Ordinal(95)] 
		[RED("isPanning")] 
		public CBool IsPanning
		{
			get => GetProperty(ref _isPanning);
			set => SetProperty(ref _isPanning, value);
		}

		[Ordinal(96)] 
		[RED("isZooming")] 
		public CBool IsZooming
		{
			get => GetProperty(ref _isZooming);
			set => SetProperty(ref _isZooming, value);
		}

		[Ordinal(97)] 
		[RED("pressedRMB")] 
		public CBool PressedRMB
		{
			get => GetProperty(ref _pressedRMB);
			set => SetProperty(ref _pressedRMB, value);
		}

		[Ordinal(98)] 
		[RED("startedFastTraveling")] 
		public CBool StartedFastTraveling
		{
			get => GetProperty(ref _startedFastTraveling);
			set => SetProperty(ref _startedFastTraveling, value);
		}

		public gameuiWorldMapMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
