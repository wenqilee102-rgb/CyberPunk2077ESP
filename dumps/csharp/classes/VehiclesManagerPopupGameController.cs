using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerPopupGameController : BaseModalListPopupGameController
	{
		private inkWidgetReference _repairOverlay;
		private inkWidgetReference _vehicleIconContainer;
		private inkImageWidgetReference _vehicleIcon;
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _scrollControllerWidget;
		private inkWidgetReference _confirmButton;
		private inkTextWidgetReference _favoriteInputHint;
		private CHandle<VehiclesManagerDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private wCHandle<QuickSlotsManager> _quickSlotsManager;
		private wCHandle<inkScrollController> _scrollController;
		private CHandle<inkanimProxy> _selectAnimProxy;
		private CUInt32 _initialIndex;

		[Ordinal(15)] 
		[RED("repairOverlay")] 
		public inkWidgetReference RepairOverlay
		{
			get => GetProperty(ref _repairOverlay);
			set => SetProperty(ref _repairOverlay, value);
		}

		[Ordinal(16)] 
		[RED("vehicleIconContainer")] 
		public inkWidgetReference VehicleIconContainer
		{
			get => GetProperty(ref _vehicleIconContainer);
			set => SetProperty(ref _vehicleIconContainer, value);
		}

		[Ordinal(17)] 
		[RED("vehicleIcon")] 
		public inkImageWidgetReference VehicleIcon
		{
			get => GetProperty(ref _vehicleIcon);
			set => SetProperty(ref _vehicleIcon, value);
		}

		[Ordinal(18)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(19)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetProperty(ref _scrollControllerWidget);
			set => SetProperty(ref _scrollControllerWidget, value);
		}

		[Ordinal(20)] 
		[RED("confirmButton")] 
		public inkWidgetReference ConfirmButton
		{
			get => GetProperty(ref _confirmButton);
			set => SetProperty(ref _confirmButton, value);
		}

		[Ordinal(21)] 
		[RED("favoriteInputHint")] 
		public inkTextWidgetReference FavoriteInputHint
		{
			get => GetProperty(ref _favoriteInputHint);
			set => SetProperty(ref _favoriteInputHint, value);
		}

		[Ordinal(22)] 
		[RED("dataView")] 
		public CHandle<VehiclesManagerDataView> DataView
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
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(26)] 
		[RED("selectAnimProxy")] 
		public CHandle<inkanimProxy> SelectAnimProxy
		{
			get => GetProperty(ref _selectAnimProxy);
			set => SetProperty(ref _selectAnimProxy, value);
		}

		[Ordinal(27)] 
		[RED("initialIndex")] 
		public CUInt32 InitialIndex
		{
			get => GetProperty(ref _initialIndex);
			set => SetProperty(ref _initialIndex, value);
		}

		public VehiclesManagerPopupGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
