using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocMetersCapacity : RipperdocMetersBase
	{
		private CFloat _defaultRightBarScale;
		private CFloat _overchargeGapSize;
		private inkWidgetReference _curCapacityLabelContainer;
		private inkWidgetReference _curCapacityLabelBackground;
		private inkWidgetReference _costLabelContainer;
		private inkTextWidgetReference _costLabelText;
		private inkWidgetReference _maxCapacityLabelContainer;
		private inkTextWidgetReference _maxCapacityLabelText;
		private inkWidgetReference _overchargeBox;
		private inkWidgetReference _thresholdLine;
		private inkWidgetReference _edgrunnerLock;
		private inkWidgetReference _overchargeGlow;
		private CName _overchargeGlowAnimName;
		private CFloat _overchargeVisibilityThreshold;
		private CInt32 _currentCapacity;
		private CInt32 _maxCapacity;
		private CFloat _maxCapacityPossible;
		private CInt32 _overchargeMaxCapacity;
		private CInt32 _overchargeValue;
		private CBool _isEdgerunner;
		private wCHandle<RipperdocFillLabel> _curCapacityLabel;
		private CHandle<inkanimProxy> _capacityLabelAnimation;
		private CHandle<inkanimProxy> _costLabelAnimation;
		private CHandle<PulseAnimation> _capacityPulseAnimation;
		private CHandle<PulseAnimation> _costLabelPulseAnimation;
		private CHandle<inkanimProxy> _overchargeGlowAnimProxy;
		private inkanimPlaybackOptions _overchargeGlowAnimOptions;
		private CName _overchargeBoxState;
		private CInt32 _maxBaseBar;
		private CInt32 _overBars;
		private CBool _barsSpawned;
		private CBool _showOverchargeBox;
		private CBool _isHoverdCyberwareEquipped;
		private Vector2 _c_costLabelAnchorPoint_ADD;
		private Vector2 _c_costLabelAnchorPoint_SUBTRACT;
		private Vector2 _c_costLabelAnchorPoint_EQUIPPED;
		private Vector2 _c_costLabelAnchorPoint_EQUIPPED_EDGRUNNER;

		[Ordinal(24)] 
		[RED("defaultRightBarScale")] 
		public CFloat DefaultRightBarScale
		{
			get => GetProperty(ref _defaultRightBarScale);
			set => SetProperty(ref _defaultRightBarScale, value);
		}

		[Ordinal(25)] 
		[RED("overchargeGapSize")] 
		public CFloat OverchargeGapSize
		{
			get => GetProperty(ref _overchargeGapSize);
			set => SetProperty(ref _overchargeGapSize, value);
		}

		[Ordinal(26)] 
		[RED("curCapacityLabelContainer")] 
		public inkWidgetReference CurCapacityLabelContainer
		{
			get => GetProperty(ref _curCapacityLabelContainer);
			set => SetProperty(ref _curCapacityLabelContainer, value);
		}

		[Ordinal(27)] 
		[RED("curCapacityLabelBackground")] 
		public inkWidgetReference CurCapacityLabelBackground
		{
			get => GetProperty(ref _curCapacityLabelBackground);
			set => SetProperty(ref _curCapacityLabelBackground, value);
		}

		[Ordinal(28)] 
		[RED("costLabelContainer")] 
		public inkWidgetReference CostLabelContainer
		{
			get => GetProperty(ref _costLabelContainer);
			set => SetProperty(ref _costLabelContainer, value);
		}

		[Ordinal(29)] 
		[RED("costLabelText")] 
		public inkTextWidgetReference CostLabelText
		{
			get => GetProperty(ref _costLabelText);
			set => SetProperty(ref _costLabelText, value);
		}

		[Ordinal(30)] 
		[RED("maxCapacityLabelContainer")] 
		public inkWidgetReference MaxCapacityLabelContainer
		{
			get => GetProperty(ref _maxCapacityLabelContainer);
			set => SetProperty(ref _maxCapacityLabelContainer, value);
		}

		[Ordinal(31)] 
		[RED("maxCapacityLabelText")] 
		public inkTextWidgetReference MaxCapacityLabelText
		{
			get => GetProperty(ref _maxCapacityLabelText);
			set => SetProperty(ref _maxCapacityLabelText, value);
		}

		[Ordinal(32)] 
		[RED("overchargeBox")] 
		public inkWidgetReference OverchargeBox
		{
			get => GetProperty(ref _overchargeBox);
			set => SetProperty(ref _overchargeBox, value);
		}

		[Ordinal(33)] 
		[RED("thresholdLine")] 
		public inkWidgetReference ThresholdLine
		{
			get => GetProperty(ref _thresholdLine);
			set => SetProperty(ref _thresholdLine, value);
		}

		[Ordinal(34)] 
		[RED("edgrunnerLock")] 
		public inkWidgetReference EdgrunnerLock
		{
			get => GetProperty(ref _edgrunnerLock);
			set => SetProperty(ref _edgrunnerLock, value);
		}

		[Ordinal(35)] 
		[RED("overchargeGlow")] 
		public inkWidgetReference OverchargeGlow
		{
			get => GetProperty(ref _overchargeGlow);
			set => SetProperty(ref _overchargeGlow, value);
		}

		[Ordinal(36)] 
		[RED("overchargeGlowAnimName")] 
		public CName OverchargeGlowAnimName
		{
			get => GetProperty(ref _overchargeGlowAnimName);
			set => SetProperty(ref _overchargeGlowAnimName, value);
		}

		[Ordinal(37)] 
		[RED("overchargeVisibilityThreshold")] 
		public CFloat OverchargeVisibilityThreshold
		{
			get => GetProperty(ref _overchargeVisibilityThreshold);
			set => SetProperty(ref _overchargeVisibilityThreshold, value);
		}

		[Ordinal(38)] 
		[RED("currentCapacity")] 
		public CInt32 CurrentCapacity
		{
			get => GetProperty(ref _currentCapacity);
			set => SetProperty(ref _currentCapacity, value);
		}

		[Ordinal(39)] 
		[RED("maxCapacity")] 
		public CInt32 MaxCapacity
		{
			get => GetProperty(ref _maxCapacity);
			set => SetProperty(ref _maxCapacity, value);
		}

		[Ordinal(40)] 
		[RED("maxCapacityPossible")] 
		public CFloat MaxCapacityPossible
		{
			get => GetProperty(ref _maxCapacityPossible);
			set => SetProperty(ref _maxCapacityPossible, value);
		}

		[Ordinal(41)] 
		[RED("overchargeMaxCapacity")] 
		public CInt32 OverchargeMaxCapacity
		{
			get => GetProperty(ref _overchargeMaxCapacity);
			set => SetProperty(ref _overchargeMaxCapacity, value);
		}

		[Ordinal(42)] 
		[RED("overchargeValue")] 
		public CInt32 OverchargeValue
		{
			get => GetProperty(ref _overchargeValue);
			set => SetProperty(ref _overchargeValue, value);
		}

		[Ordinal(43)] 
		[RED("isEdgerunner")] 
		public CBool IsEdgerunner
		{
			get => GetProperty(ref _isEdgerunner);
			set => SetProperty(ref _isEdgerunner, value);
		}

		[Ordinal(44)] 
		[RED("curCapacityLabel")] 
		public wCHandle<RipperdocFillLabel> CurCapacityLabel
		{
			get => GetProperty(ref _curCapacityLabel);
			set => SetProperty(ref _curCapacityLabel, value);
		}

		[Ordinal(45)] 
		[RED("capacityLabelAnimation")] 
		public CHandle<inkanimProxy> CapacityLabelAnimation
		{
			get => GetProperty(ref _capacityLabelAnimation);
			set => SetProperty(ref _capacityLabelAnimation, value);
		}

		[Ordinal(46)] 
		[RED("costLabelAnimation")] 
		public CHandle<inkanimProxy> CostLabelAnimation
		{
			get => GetProperty(ref _costLabelAnimation);
			set => SetProperty(ref _costLabelAnimation, value);
		}

		[Ordinal(47)] 
		[RED("capacityPulseAnimation")] 
		public CHandle<PulseAnimation> CapacityPulseAnimation
		{
			get => GetProperty(ref _capacityPulseAnimation);
			set => SetProperty(ref _capacityPulseAnimation, value);
		}

		[Ordinal(48)] 
		[RED("costLabelPulseAnimation")] 
		public CHandle<PulseAnimation> CostLabelPulseAnimation
		{
			get => GetProperty(ref _costLabelPulseAnimation);
			set => SetProperty(ref _costLabelPulseAnimation, value);
		}

		[Ordinal(49)] 
		[RED("overchargeGlowAnimProxy")] 
		public CHandle<inkanimProxy> OverchargeGlowAnimProxy
		{
			get => GetProperty(ref _overchargeGlowAnimProxy);
			set => SetProperty(ref _overchargeGlowAnimProxy, value);
		}

		[Ordinal(50)] 
		[RED("overchargeGlowAnimOptions")] 
		public inkanimPlaybackOptions OverchargeGlowAnimOptions
		{
			get => GetProperty(ref _overchargeGlowAnimOptions);
			set => SetProperty(ref _overchargeGlowAnimOptions, value);
		}

		[Ordinal(51)] 
		[RED("overchargeBoxState")] 
		public CName OverchargeBoxState
		{
			get => GetProperty(ref _overchargeBoxState);
			set => SetProperty(ref _overchargeBoxState, value);
		}

		[Ordinal(52)] 
		[RED("maxBaseBar")] 
		public CInt32 MaxBaseBar
		{
			get => GetProperty(ref _maxBaseBar);
			set => SetProperty(ref _maxBaseBar, value);
		}

		[Ordinal(53)] 
		[RED("overBars")] 
		public CInt32 OverBars
		{
			get => GetProperty(ref _overBars);
			set => SetProperty(ref _overBars, value);
		}

		[Ordinal(54)] 
		[RED("barsSpawned")] 
		public CBool BarsSpawned
		{
			get => GetProperty(ref _barsSpawned);
			set => SetProperty(ref _barsSpawned, value);
		}

		[Ordinal(55)] 
		[RED("showOverchargeBox")] 
		public CBool ShowOverchargeBox
		{
			get => GetProperty(ref _showOverchargeBox);
			set => SetProperty(ref _showOverchargeBox, value);
		}

		[Ordinal(56)] 
		[RED("isHoverdCyberwareEquipped")] 
		public CBool IsHoverdCyberwareEquipped
		{
			get => GetProperty(ref _isHoverdCyberwareEquipped);
			set => SetProperty(ref _isHoverdCyberwareEquipped, value);
		}

		[Ordinal(57)] 
		[RED("C_costLabelAnchorPoint_ADD")] 
		public Vector2 C_costLabelAnchorPoint_ADD
		{
			get => GetProperty(ref _c_costLabelAnchorPoint_ADD);
			set => SetProperty(ref _c_costLabelAnchorPoint_ADD, value);
		}

		[Ordinal(58)] 
		[RED("C_costLabelAnchorPoint_SUBTRACT")] 
		public Vector2 C_costLabelAnchorPoint_SUBTRACT
		{
			get => GetProperty(ref _c_costLabelAnchorPoint_SUBTRACT);
			set => SetProperty(ref _c_costLabelAnchorPoint_SUBTRACT, value);
		}

		[Ordinal(59)] 
		[RED("C_costLabelAnchorPoint_EQUIPPED")] 
		public Vector2 C_costLabelAnchorPoint_EQUIPPED
		{
			get => GetProperty(ref _c_costLabelAnchorPoint_EQUIPPED);
			set => SetProperty(ref _c_costLabelAnchorPoint_EQUIPPED, value);
		}

		[Ordinal(60)] 
		[RED("C_costLabelAnchorPoint_EQUIPPED_EDGRUNNER")] 
		public Vector2 C_costLabelAnchorPoint_EQUIPPED_EDGRUNNER
		{
			get => GetProperty(ref _c_costLabelAnchorPoint_EQUIPPED_EDGRUNNER);
			set => SetProperty(ref _c_costLabelAnchorPoint_EQUIPPED_EDGRUNNER, value);
		}

		public RipperdocMetersCapacity(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
