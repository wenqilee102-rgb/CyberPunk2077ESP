using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTrainLineListInkController : NcartTrainInkControllerBase
	{
		private CArray<ncartLineListDef> _linesList;
		private CName _activeMetroLineNumberFactName;
		private CName _activeMetroStationNumberFactName;
		private CName _metroStoppingFactName;
		private CName _metroReverseDirectionFact;
		private wCHandle<inkCompoundWidget> _root;
		private wCHandle<questQuestsSystem> _questsSystem;
		private CUInt32 _activeStationListenerId;
		private CUInt32 _activeLineListenerId;
		private CUInt32 _stopListenerId;
		private CBool _stationListSetUp;
		private CInt32 _lastDestination;
		private CInt32 _currentActiveStation;
		private CInt32 _activeStationWidget;
		private inkImageWidgetReference _ncartLogo;
		private inkImageWidgetReference _ncartLogoDeco;
		private inkImageWidgetReference _ncartLogoDecoFrame1;
		private inkImageWidgetReference _ncartLogoDecoFrame2;
		private inkImageWidgetReference _ncartLogoDecoFrame3;
		private inkImageWidgetReference _ncartLogoDecoFrame4;
		private inkImageWidgetReference _line_loop_symbol;
		private inkImageWidgetReference _ncartDecoAccent1;
		private inkImageWidgetReference _ncartDecoAccent2;
		private inkImageWidgetReference _ncartDecoAccent3;
		private inkImageWidgetReference _ncartDecoAccent4;
		private inkImageWidgetReference _ncartTextLogo;
		private inkHorizontalPanelWidgetReference _ncartDirectionArrowsList;
		private inkHorizontalPanelWidgetReference _ncartLineStationList;
		private CUInt32 _cachedLine;

		[Ordinal(16)] 
		[RED("LinesList")] 
		public CArray<ncartLineListDef> LinesList
		{
			get => GetProperty(ref _linesList);
			set => SetProperty(ref _linesList, value);
		}

		[Ordinal(17)] 
		[RED("ActiveMetroLineNumberFactName")] 
		public CName ActiveMetroLineNumberFactName
		{
			get => GetProperty(ref _activeMetroLineNumberFactName);
			set => SetProperty(ref _activeMetroLineNumberFactName, value);
		}

		[Ordinal(18)] 
		[RED("ActiveMetroStationNumberFactName")] 
		public CName ActiveMetroStationNumberFactName
		{
			get => GetProperty(ref _activeMetroStationNumberFactName);
			set => SetProperty(ref _activeMetroStationNumberFactName, value);
		}

		[Ordinal(19)] 
		[RED("MetroStoppingFactName")] 
		public CName MetroStoppingFactName
		{
			get => GetProperty(ref _metroStoppingFactName);
			set => SetProperty(ref _metroStoppingFactName, value);
		}

		[Ordinal(20)] 
		[RED("MetroReverseDirectionFact")] 
		public CName MetroReverseDirectionFact
		{
			get => GetProperty(ref _metroReverseDirectionFact);
			set => SetProperty(ref _metroReverseDirectionFact, value);
		}

		[Ordinal(21)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(22)] 
		[RED("questsSystem")] 
		public wCHandle<questQuestsSystem> QuestsSystem
		{
			get => GetProperty(ref _questsSystem);
			set => SetProperty(ref _questsSystem, value);
		}

		[Ordinal(23)] 
		[RED("activeStationListenerId")] 
		public CUInt32 ActiveStationListenerId
		{
			get => GetProperty(ref _activeStationListenerId);
			set => SetProperty(ref _activeStationListenerId, value);
		}

		[Ordinal(24)] 
		[RED("activeLineListenerId")] 
		public CUInt32 ActiveLineListenerId
		{
			get => GetProperty(ref _activeLineListenerId);
			set => SetProperty(ref _activeLineListenerId, value);
		}

		[Ordinal(25)] 
		[RED("StopListenerId")] 
		public CUInt32 StopListenerId
		{
			get => GetProperty(ref _stopListenerId);
			set => SetProperty(ref _stopListenerId, value);
		}

		[Ordinal(26)] 
		[RED("StationListSetUp")] 
		public CBool StationListSetUp
		{
			get => GetProperty(ref _stationListSetUp);
			set => SetProperty(ref _stationListSetUp, value);
		}

		[Ordinal(27)] 
		[RED("lastDestination")] 
		public CInt32 LastDestination
		{
			get => GetProperty(ref _lastDestination);
			set => SetProperty(ref _lastDestination, value);
		}

		[Ordinal(28)] 
		[RED("currentActiveStation")] 
		public CInt32 CurrentActiveStation
		{
			get => GetProperty(ref _currentActiveStation);
			set => SetProperty(ref _currentActiveStation, value);
		}

		[Ordinal(29)] 
		[RED("activeStationWidget")] 
		public CInt32 ActiveStationWidget
		{
			get => GetProperty(ref _activeStationWidget);
			set => SetProperty(ref _activeStationWidget, value);
		}

		[Ordinal(30)] 
		[RED("ncartLogo")] 
		public inkImageWidgetReference NcartLogo
		{
			get => GetProperty(ref _ncartLogo);
			set => SetProperty(ref _ncartLogo, value);
		}

		[Ordinal(31)] 
		[RED("ncartLogoDeco")] 
		public inkImageWidgetReference NcartLogoDeco
		{
			get => GetProperty(ref _ncartLogoDeco);
			set => SetProperty(ref _ncartLogoDeco, value);
		}

		[Ordinal(32)] 
		[RED("ncartLogoDecoFrame1")] 
		public inkImageWidgetReference NcartLogoDecoFrame1
		{
			get => GetProperty(ref _ncartLogoDecoFrame1);
			set => SetProperty(ref _ncartLogoDecoFrame1, value);
		}

		[Ordinal(33)] 
		[RED("ncartLogoDecoFrame2")] 
		public inkImageWidgetReference NcartLogoDecoFrame2
		{
			get => GetProperty(ref _ncartLogoDecoFrame2);
			set => SetProperty(ref _ncartLogoDecoFrame2, value);
		}

		[Ordinal(34)] 
		[RED("ncartLogoDecoFrame3")] 
		public inkImageWidgetReference NcartLogoDecoFrame3
		{
			get => GetProperty(ref _ncartLogoDecoFrame3);
			set => SetProperty(ref _ncartLogoDecoFrame3, value);
		}

		[Ordinal(35)] 
		[RED("ncartLogoDecoFrame4")] 
		public inkImageWidgetReference NcartLogoDecoFrame4
		{
			get => GetProperty(ref _ncartLogoDecoFrame4);
			set => SetProperty(ref _ncartLogoDecoFrame4, value);
		}

		[Ordinal(36)] 
		[RED("line_loop_symbol")] 
		public inkImageWidgetReference Line_loop_symbol
		{
			get => GetProperty(ref _line_loop_symbol);
			set => SetProperty(ref _line_loop_symbol, value);
		}

		[Ordinal(37)] 
		[RED("ncartDecoAccent1")] 
		public inkImageWidgetReference NcartDecoAccent1
		{
			get => GetProperty(ref _ncartDecoAccent1);
			set => SetProperty(ref _ncartDecoAccent1, value);
		}

		[Ordinal(38)] 
		[RED("ncartDecoAccent2")] 
		public inkImageWidgetReference NcartDecoAccent2
		{
			get => GetProperty(ref _ncartDecoAccent2);
			set => SetProperty(ref _ncartDecoAccent2, value);
		}

		[Ordinal(39)] 
		[RED("ncartDecoAccent3")] 
		public inkImageWidgetReference NcartDecoAccent3
		{
			get => GetProperty(ref _ncartDecoAccent3);
			set => SetProperty(ref _ncartDecoAccent3, value);
		}

		[Ordinal(40)] 
		[RED("ncartDecoAccent4")] 
		public inkImageWidgetReference NcartDecoAccent4
		{
			get => GetProperty(ref _ncartDecoAccent4);
			set => SetProperty(ref _ncartDecoAccent4, value);
		}

		[Ordinal(41)] 
		[RED("ncartTextLogo")] 
		public inkImageWidgetReference NcartTextLogo
		{
			get => GetProperty(ref _ncartTextLogo);
			set => SetProperty(ref _ncartTextLogo, value);
		}

		[Ordinal(42)] 
		[RED("ncartDirectionArrowsList")] 
		public inkHorizontalPanelWidgetReference NcartDirectionArrowsList
		{
			get => GetProperty(ref _ncartDirectionArrowsList);
			set => SetProperty(ref _ncartDirectionArrowsList, value);
		}

		[Ordinal(43)] 
		[RED("ncartLineStationList")] 
		public inkHorizontalPanelWidgetReference NcartLineStationList
		{
			get => GetProperty(ref _ncartLineStationList);
			set => SetProperty(ref _ncartLineStationList, value);
		}

		[Ordinal(44)] 
		[RED("cachedLine")] 
		public CUInt32 CachedLine
		{
			get => GetProperty(ref _cachedLine);
			set => SetProperty(ref _cachedLine, value);
		}

		public NcartTrainLineListInkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
