using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FrameSwitcherMenuGameController : GalleryMenuGameController
	{
		private inkImageWidgetReference _frameDisplay;
		private inkWidgetReference _frameCanvas;
		private inkWidgetReference _frameWrapper;
		private inkImageWidgetReference _defaultImageRef;
		private inkWidgetReference _adjustButtonHintsManagerRef;
		private CFloat _movementGlobalScale;
		private CFloat _zoomScale;
		private CFloat _maxZoom;
		private CHandle<inkFrameNotificationData> _data;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<ButtonHints> _adjustButtonHintsController;
		private CEnum<EFrameState> _frameState;
		private CBool _isPressing;
		private CBool _readyToZoom;
		private CBool _isHoveringScreenshot;
		private CBool _isHoveringFilter;
		private Vector2 _lastPressingPoint;
		private Vector2 _movementScale;
		private CString _timeDilationProfile;
		private Vector2 _lastMovementInput;
		private CHandle<inkanimProxy> _transitionAnimproxy;

		[Ordinal(39)] 
		[RED("frameDisplay")] 
		public inkImageWidgetReference FrameDisplay
		{
			get => GetProperty(ref _frameDisplay);
			set => SetProperty(ref _frameDisplay, value);
		}

		[Ordinal(40)] 
		[RED("frameCanvas")] 
		public inkWidgetReference FrameCanvas
		{
			get => GetProperty(ref _frameCanvas);
			set => SetProperty(ref _frameCanvas, value);
		}

		[Ordinal(41)] 
		[RED("frameWrapper")] 
		public inkWidgetReference FrameWrapper
		{
			get => GetProperty(ref _frameWrapper);
			set => SetProperty(ref _frameWrapper, value);
		}

		[Ordinal(42)] 
		[RED("defaultImageRef")] 
		public inkImageWidgetReference DefaultImageRef
		{
			get => GetProperty(ref _defaultImageRef);
			set => SetProperty(ref _defaultImageRef, value);
		}

		[Ordinal(43)] 
		[RED("adjustButtonHintsManagerRef")] 
		public inkWidgetReference AdjustButtonHintsManagerRef
		{
			get => GetProperty(ref _adjustButtonHintsManagerRef);
			set => SetProperty(ref _adjustButtonHintsManagerRef, value);
		}

		[Ordinal(44)] 
		[RED("movementGlobalScale")] 
		public CFloat MovementGlobalScale
		{
			get => GetProperty(ref _movementGlobalScale);
			set => SetProperty(ref _movementGlobalScale, value);
		}

		[Ordinal(45)] 
		[RED("zoomScale")] 
		public CFloat ZoomScale
		{
			get => GetProperty(ref _zoomScale);
			set => SetProperty(ref _zoomScale, value);
		}

		[Ordinal(46)] 
		[RED("maxZoom")] 
		public CFloat MaxZoom
		{
			get => GetProperty(ref _maxZoom);
			set => SetProperty(ref _maxZoom, value);
		}

		[Ordinal(47)] 
		[RED("data")] 
		public CHandle<inkFrameNotificationData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(48)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(49)] 
		[RED("adjustButtonHintsController")] 
		public wCHandle<ButtonHints> AdjustButtonHintsController
		{
			get => GetProperty(ref _adjustButtonHintsController);
			set => SetProperty(ref _adjustButtonHintsController, value);
		}

		[Ordinal(50)] 
		[RED("frameState")] 
		public CEnum<EFrameState> FrameState
		{
			get => GetProperty(ref _frameState);
			set => SetProperty(ref _frameState, value);
		}

		[Ordinal(51)] 
		[RED("isPressing")] 
		public CBool IsPressing
		{
			get => GetProperty(ref _isPressing);
			set => SetProperty(ref _isPressing, value);
		}

		[Ordinal(52)] 
		[RED("readyToZoom")] 
		public CBool ReadyToZoom
		{
			get => GetProperty(ref _readyToZoom);
			set => SetProperty(ref _readyToZoom, value);
		}

		[Ordinal(53)] 
		[RED("isHoveringScreenshot")] 
		public CBool IsHoveringScreenshot
		{
			get => GetProperty(ref _isHoveringScreenshot);
			set => SetProperty(ref _isHoveringScreenshot, value);
		}

		[Ordinal(54)] 
		[RED("isHoveringFilter")] 
		public CBool IsHoveringFilter
		{
			get => GetProperty(ref _isHoveringFilter);
			set => SetProperty(ref _isHoveringFilter, value);
		}

		[Ordinal(55)] 
		[RED("lastPressingPoint")] 
		public Vector2 LastPressingPoint
		{
			get => GetProperty(ref _lastPressingPoint);
			set => SetProperty(ref _lastPressingPoint, value);
		}

		[Ordinal(56)] 
		[RED("movementScale")] 
		public Vector2 MovementScale
		{
			get => GetProperty(ref _movementScale);
			set => SetProperty(ref _movementScale, value);
		}

		[Ordinal(57)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetProperty(ref _timeDilationProfile);
			set => SetProperty(ref _timeDilationProfile, value);
		}

		[Ordinal(58)] 
		[RED("lastMovementInput")] 
		public Vector2 LastMovementInput
		{
			get => GetProperty(ref _lastMovementInput);
			set => SetProperty(ref _lastMovementInput, value);
		}

		[Ordinal(59)] 
		[RED("transitionAnimproxy")] 
		public CHandle<inkanimProxy> TransitionAnimproxy
		{
			get => GetProperty(ref _transitionAnimproxy);
			set => SetProperty(ref _transitionAnimproxy, value);
		}

		public FrameSwitcherMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
