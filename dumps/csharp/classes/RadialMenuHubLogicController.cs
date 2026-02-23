using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialMenuHubLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _menuObject;
		private inkWidgetReference _btnCrafting;
		private inkWidgetReference _btnPerks;
		private inkWidgetReference _btnStats;
		private inkWidgetReference _btnInventory;
		private inkWidgetReference _btnBackpack;
		private inkWidgetReference _btnCyberware;
		private inkWidgetReference _btnMap;
		private inkWidgetReference _btnJournal;
		private inkWidgetReference _btnPhone;
		private inkWidgetReference _btnTarot;
		private inkWidgetReference _btnShard;
		private inkWidgetReference _btnCodex;
		private inkWidgetReference _panelInventory;
		private inkWidgetReference _panelMap;
		private inkWidgetReference _panelJournal;
		private inkWidgetReference _panelCharacter;
		private inkWidgetReference _mouseCollider;
		private inkTextWidgetReference _debugText;
		private CHandle<MenuDataBuilder> _menusData;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private inkWidgetReference _tooltipsManagerRef;
		private Vector2 _windowSize;
		private CEnum<RadialHubMenuElement> _previousMenuElement;
		private CArray<CInt32> _hoveredButtons;
		private CBool _isActive;
		private CBool _timeSkipOpened;
		private CHandle<inkanimProxy> _panelHoverOverAnimProxy;
		private CHandle<inkanimProxy> _panelHoverOutAnimProxy;

		[Ordinal(1)] 
		[RED("menuObject")] 
		public inkWidgetReference MenuObject
		{
			get => GetProperty(ref _menuObject);
			set => SetProperty(ref _menuObject, value);
		}

		[Ordinal(2)] 
		[RED("btnCrafting")] 
		public inkWidgetReference BtnCrafting
		{
			get => GetProperty(ref _btnCrafting);
			set => SetProperty(ref _btnCrafting, value);
		}

		[Ordinal(3)] 
		[RED("btnPerks")] 
		public inkWidgetReference BtnPerks
		{
			get => GetProperty(ref _btnPerks);
			set => SetProperty(ref _btnPerks, value);
		}

		[Ordinal(4)] 
		[RED("btnStats")] 
		public inkWidgetReference BtnStats
		{
			get => GetProperty(ref _btnStats);
			set => SetProperty(ref _btnStats, value);
		}

		[Ordinal(5)] 
		[RED("btnInventory")] 
		public inkWidgetReference BtnInventory
		{
			get => GetProperty(ref _btnInventory);
			set => SetProperty(ref _btnInventory, value);
		}

		[Ordinal(6)] 
		[RED("btnBackpack")] 
		public inkWidgetReference BtnBackpack
		{
			get => GetProperty(ref _btnBackpack);
			set => SetProperty(ref _btnBackpack, value);
		}

		[Ordinal(7)] 
		[RED("btnCyberware")] 
		public inkWidgetReference BtnCyberware
		{
			get => GetProperty(ref _btnCyberware);
			set => SetProperty(ref _btnCyberware, value);
		}

		[Ordinal(8)] 
		[RED("btnMap")] 
		public inkWidgetReference BtnMap
		{
			get => GetProperty(ref _btnMap);
			set => SetProperty(ref _btnMap, value);
		}

		[Ordinal(9)] 
		[RED("btnJournal")] 
		public inkWidgetReference BtnJournal
		{
			get => GetProperty(ref _btnJournal);
			set => SetProperty(ref _btnJournal, value);
		}

		[Ordinal(10)] 
		[RED("btnPhone")] 
		public inkWidgetReference BtnPhone
		{
			get => GetProperty(ref _btnPhone);
			set => SetProperty(ref _btnPhone, value);
		}

		[Ordinal(11)] 
		[RED("btnTarot")] 
		public inkWidgetReference BtnTarot
		{
			get => GetProperty(ref _btnTarot);
			set => SetProperty(ref _btnTarot, value);
		}

		[Ordinal(12)] 
		[RED("btnShard")] 
		public inkWidgetReference BtnShard
		{
			get => GetProperty(ref _btnShard);
			set => SetProperty(ref _btnShard, value);
		}

		[Ordinal(13)] 
		[RED("btnCodex")] 
		public inkWidgetReference BtnCodex
		{
			get => GetProperty(ref _btnCodex);
			set => SetProperty(ref _btnCodex, value);
		}

		[Ordinal(14)] 
		[RED("panelInventory")] 
		public inkWidgetReference PanelInventory
		{
			get => GetProperty(ref _panelInventory);
			set => SetProperty(ref _panelInventory, value);
		}

		[Ordinal(15)] 
		[RED("panelMap")] 
		public inkWidgetReference PanelMap
		{
			get => GetProperty(ref _panelMap);
			set => SetProperty(ref _panelMap, value);
		}

		[Ordinal(16)] 
		[RED("panelJournal")] 
		public inkWidgetReference PanelJournal
		{
			get => GetProperty(ref _panelJournal);
			set => SetProperty(ref _panelJournal, value);
		}

		[Ordinal(17)] 
		[RED("panelCharacter")] 
		public inkWidgetReference PanelCharacter
		{
			get => GetProperty(ref _panelCharacter);
			set => SetProperty(ref _panelCharacter, value);
		}

		[Ordinal(18)] 
		[RED("mouseCollider")] 
		public inkWidgetReference MouseCollider
		{
			get => GetProperty(ref _mouseCollider);
			set => SetProperty(ref _mouseCollider, value);
		}

		[Ordinal(19)] 
		[RED("debugText")] 
		public inkTextWidgetReference DebugText
		{
			get => GetProperty(ref _debugText);
			set => SetProperty(ref _debugText, value);
		}

		[Ordinal(20)] 
		[RED("menusData")] 
		public CHandle<MenuDataBuilder> MenusData
		{
			get => GetProperty(ref _menusData);
			set => SetProperty(ref _menusData, value);
		}

		[Ordinal(21)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(22)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(23)] 
		[RED("windowSize")] 
		public Vector2 WindowSize
		{
			get => GetProperty(ref _windowSize);
			set => SetProperty(ref _windowSize, value);
		}

		[Ordinal(24)] 
		[RED("previousMenuElement")] 
		public CEnum<RadialHubMenuElement> PreviousMenuElement
		{
			get => GetProperty(ref _previousMenuElement);
			set => SetProperty(ref _previousMenuElement, value);
		}

		[Ordinal(25)] 
		[RED("hoveredButtons")] 
		public CArray<CInt32> HoveredButtons
		{
			get => GetProperty(ref _hoveredButtons);
			set => SetProperty(ref _hoveredButtons, value);
		}

		[Ordinal(26)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(27)] 
		[RED("timeSkipOpened")] 
		public CBool TimeSkipOpened
		{
			get => GetProperty(ref _timeSkipOpened);
			set => SetProperty(ref _timeSkipOpened, value);
		}

		[Ordinal(28)] 
		[RED("panelHoverOverAnimProxy")] 
		public CHandle<inkanimProxy> PanelHoverOverAnimProxy
		{
			get => GetProperty(ref _panelHoverOverAnimProxy);
			set => SetProperty(ref _panelHoverOverAnimProxy, value);
		}

		[Ordinal(29)] 
		[RED("panelHoverOutAnimProxy")] 
		public CHandle<inkanimProxy> PanelHoverOutAnimProxy
		{
			get => GetProperty(ref _panelHoverOutAnimProxy);
			set => SetProperty(ref _panelHoverOutAnimProxy, value);
		}

		public RadialMenuHubLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
