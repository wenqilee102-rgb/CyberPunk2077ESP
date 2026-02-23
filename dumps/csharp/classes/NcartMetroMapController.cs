using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartMetroMapController : CustomAnimationsHudGameController
	{
		private inkWidgetReference _playerMarkerPane;
		private CArray<metroMapPlayerPositionReferences> _playerCurrentPositionReferences;
		private CHandle<questQuestsSystem> _questsSystem;
		private CUInt32 _selectedDestinationButtonListner;
		private CUInt32 _selectionMenuShouldBeActiveListener;
		private CInt32 _previousAnimatioNumber;
		private CHandle<inkanimProxy> _directionAnimProxy;
		private CHandle<inkanimProxy> _startupAnimProxy;
		private CHandle<inkanimProxy> _playerPostionMarkerAnimProxy;
		private CBool _mapOpen;
		private CFloat _lineOffOpacity;
		private CFloat _lineOnOpacity;

		[Ordinal(19)] 
		[RED("playerMarkerPane")] 
		public inkWidgetReference PlayerMarkerPane
		{
			get => GetProperty(ref _playerMarkerPane);
			set => SetProperty(ref _playerMarkerPane, value);
		}

		[Ordinal(20)] 
		[RED("playerCurrentPositionReferences")] 
		public CArray<metroMapPlayerPositionReferences> PlayerCurrentPositionReferences
		{
			get => GetProperty(ref _playerCurrentPositionReferences);
			set => SetProperty(ref _playerCurrentPositionReferences, value);
		}

		[Ordinal(21)] 
		[RED("questsSystem")] 
		public CHandle<questQuestsSystem> QuestsSystem
		{
			get => GetProperty(ref _questsSystem);
			set => SetProperty(ref _questsSystem, value);
		}

		[Ordinal(22)] 
		[RED("selectedDestinationButtonListner")] 
		public CUInt32 SelectedDestinationButtonListner
		{
			get => GetProperty(ref _selectedDestinationButtonListner);
			set => SetProperty(ref _selectedDestinationButtonListner, value);
		}

		[Ordinal(23)] 
		[RED("selectionMenuShouldBeActiveListener")] 
		public CUInt32 SelectionMenuShouldBeActiveListener
		{
			get => GetProperty(ref _selectionMenuShouldBeActiveListener);
			set => SetProperty(ref _selectionMenuShouldBeActiveListener, value);
		}

		[Ordinal(24)] 
		[RED("previousAnimatioNumber")] 
		public CInt32 PreviousAnimatioNumber
		{
			get => GetProperty(ref _previousAnimatioNumber);
			set => SetProperty(ref _previousAnimatioNumber, value);
		}

		[Ordinal(25)] 
		[RED("directionAnimProxy")] 
		public CHandle<inkanimProxy> DirectionAnimProxy
		{
			get => GetProperty(ref _directionAnimProxy);
			set => SetProperty(ref _directionAnimProxy, value);
		}

		[Ordinal(26)] 
		[RED("startupAnimProxy")] 
		public CHandle<inkanimProxy> StartupAnimProxy
		{
			get => GetProperty(ref _startupAnimProxy);
			set => SetProperty(ref _startupAnimProxy, value);
		}

		[Ordinal(27)] 
		[RED("playerPostionMarkerAnimProxy")] 
		public CHandle<inkanimProxy> PlayerPostionMarkerAnimProxy
		{
			get => GetProperty(ref _playerPostionMarkerAnimProxy);
			set => SetProperty(ref _playerPostionMarkerAnimProxy, value);
		}

		[Ordinal(28)] 
		[RED("mapOpen")] 
		public CBool MapOpen
		{
			get => GetProperty(ref _mapOpen);
			set => SetProperty(ref _mapOpen, value);
		}

		[Ordinal(29)] 
		[RED("LineOffOpacity")] 
		public CFloat LineOffOpacity
		{
			get => GetProperty(ref _lineOffOpacity);
			set => SetProperty(ref _lineOffOpacity, value);
		}

		[Ordinal(30)] 
		[RED("LineOnOpacity")] 
		public CFloat LineOnOpacity
		{
			get => GetProperty(ref _lineOnOpacity);
			set => SetProperty(ref _lineOnOpacity, value);
		}

		public NcartMetroMapController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
