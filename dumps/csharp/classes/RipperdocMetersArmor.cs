using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocMetersArmor : RipperdocMetersBase
	{
		private CFloat _barScale;
		private inkWidgetReference _currentArmorLabelContainer;
		private inkWidgetReference _currentArmorLabelBackground;
		private inkWidgetReference _costArmorLabelContainer;
		private inkWidgetReference _costArmorLabelBackground;
		private inkTextWidgetReference _costArmorLabelValue;
		private inkWidgetReference _maxArmorLabel;
		private inkWidgetReference _maxArmorLabelContainer;
		private inkTextWidgetReference _maxArmorLabelValue;
		private CFloat _maxArmor;
		private CFloat _curEquippedArmor;
		private CFloat _newEquippedArmor;
		private CFloat _maxArmorPossible;
		private CFloat _maxDamageReduction;
		private wCHandle<RipperdocFillLabel> _currentArmorLabel;
		private CHandle<inkanimProxy> _currentArmorLabelAnimation;
		private CHandle<inkanimProxy> _costArmorLabelAnimation;
		private CHandle<PulseAnimation> _currentArmorLabelPulseAnimation;
		private CHandle<PulseAnimation> _costArmorLabelPulseAnimation;
		private CInt32 _maxBaseBar;
		private CInt32 _currentBars;
		private CBool _barsSpawned;
		private Vector2 _c_costLabelAnchorPoint_ADD;
		private Vector2 _c_costLabelAnchorPoint_SUBTRACT;
		private Vector2 _c_costLabelAnchorPoint_EQUIPPED;

		[Ordinal(24)] 
		[RED("barScale")] 
		public CFloat BarScale
		{
			get => GetProperty(ref _barScale);
			set => SetProperty(ref _barScale, value);
		}

		[Ordinal(25)] 
		[RED("currentArmorLabelContainer")] 
		public inkWidgetReference CurrentArmorLabelContainer
		{
			get => GetProperty(ref _currentArmorLabelContainer);
			set => SetProperty(ref _currentArmorLabelContainer, value);
		}

		[Ordinal(26)] 
		[RED("currentArmorLabelBackground")] 
		public inkWidgetReference CurrentArmorLabelBackground
		{
			get => GetProperty(ref _currentArmorLabelBackground);
			set => SetProperty(ref _currentArmorLabelBackground, value);
		}

		[Ordinal(27)] 
		[RED("costArmorLabelContainer")] 
		public inkWidgetReference CostArmorLabelContainer
		{
			get => GetProperty(ref _costArmorLabelContainer);
			set => SetProperty(ref _costArmorLabelContainer, value);
		}

		[Ordinal(28)] 
		[RED("costArmorLabelBackground")] 
		public inkWidgetReference CostArmorLabelBackground
		{
			get => GetProperty(ref _costArmorLabelBackground);
			set => SetProperty(ref _costArmorLabelBackground, value);
		}

		[Ordinal(29)] 
		[RED("costArmorLabelValue")] 
		public inkTextWidgetReference CostArmorLabelValue
		{
			get => GetProperty(ref _costArmorLabelValue);
			set => SetProperty(ref _costArmorLabelValue, value);
		}

		[Ordinal(30)] 
		[RED("maxArmorLabel")] 
		public inkWidgetReference MaxArmorLabel
		{
			get => GetProperty(ref _maxArmorLabel);
			set => SetProperty(ref _maxArmorLabel, value);
		}

		[Ordinal(31)] 
		[RED("maxArmorLabelContainer")] 
		public inkWidgetReference MaxArmorLabelContainer
		{
			get => GetProperty(ref _maxArmorLabelContainer);
			set => SetProperty(ref _maxArmorLabelContainer, value);
		}

		[Ordinal(32)] 
		[RED("maxArmorLabelValue")] 
		public inkTextWidgetReference MaxArmorLabelValue
		{
			get => GetProperty(ref _maxArmorLabelValue);
			set => SetProperty(ref _maxArmorLabelValue, value);
		}

		[Ordinal(33)] 
		[RED("maxArmor")] 
		public CFloat MaxArmor
		{
			get => GetProperty(ref _maxArmor);
			set => SetProperty(ref _maxArmor, value);
		}

		[Ordinal(34)] 
		[RED("curEquippedArmor")] 
		public CFloat CurEquippedArmor
		{
			get => GetProperty(ref _curEquippedArmor);
			set => SetProperty(ref _curEquippedArmor, value);
		}

		[Ordinal(35)] 
		[RED("newEquippedArmor")] 
		public CFloat NewEquippedArmor
		{
			get => GetProperty(ref _newEquippedArmor);
			set => SetProperty(ref _newEquippedArmor, value);
		}

		[Ordinal(36)] 
		[RED("maxArmorPossible")] 
		public CFloat MaxArmorPossible
		{
			get => GetProperty(ref _maxArmorPossible);
			set => SetProperty(ref _maxArmorPossible, value);
		}

		[Ordinal(37)] 
		[RED("maxDamageReduction")] 
		public CFloat MaxDamageReduction
		{
			get => GetProperty(ref _maxDamageReduction);
			set => SetProperty(ref _maxDamageReduction, value);
		}

		[Ordinal(38)] 
		[RED("currentArmorLabel")] 
		public wCHandle<RipperdocFillLabel> CurrentArmorLabel
		{
			get => GetProperty(ref _currentArmorLabel);
			set => SetProperty(ref _currentArmorLabel, value);
		}

		[Ordinal(39)] 
		[RED("currentArmorLabelAnimation")] 
		public CHandle<inkanimProxy> CurrentArmorLabelAnimation
		{
			get => GetProperty(ref _currentArmorLabelAnimation);
			set => SetProperty(ref _currentArmorLabelAnimation, value);
		}

		[Ordinal(40)] 
		[RED("costArmorLabelAnimation")] 
		public CHandle<inkanimProxy> CostArmorLabelAnimation
		{
			get => GetProperty(ref _costArmorLabelAnimation);
			set => SetProperty(ref _costArmorLabelAnimation, value);
		}

		[Ordinal(41)] 
		[RED("currentArmorLabelPulseAnimation")] 
		public CHandle<PulseAnimation> CurrentArmorLabelPulseAnimation
		{
			get => GetProperty(ref _currentArmorLabelPulseAnimation);
			set => SetProperty(ref _currentArmorLabelPulseAnimation, value);
		}

		[Ordinal(42)] 
		[RED("costArmorLabelPulseAnimation")] 
		public CHandle<PulseAnimation> CostArmorLabelPulseAnimation
		{
			get => GetProperty(ref _costArmorLabelPulseAnimation);
			set => SetProperty(ref _costArmorLabelPulseAnimation, value);
		}

		[Ordinal(43)] 
		[RED("maxBaseBar")] 
		public CInt32 MaxBaseBar
		{
			get => GetProperty(ref _maxBaseBar);
			set => SetProperty(ref _maxBaseBar, value);
		}

		[Ordinal(44)] 
		[RED("currentBars")] 
		public CInt32 CurrentBars
		{
			get => GetProperty(ref _currentBars);
			set => SetProperty(ref _currentBars, value);
		}

		[Ordinal(45)] 
		[RED("barsSpawned")] 
		public CBool BarsSpawned
		{
			get => GetProperty(ref _barsSpawned);
			set => SetProperty(ref _barsSpawned, value);
		}

		[Ordinal(46)] 
		[RED("C_costLabelAnchorPoint_ADD")] 
		public Vector2 C_costLabelAnchorPoint_ADD
		{
			get => GetProperty(ref _c_costLabelAnchorPoint_ADD);
			set => SetProperty(ref _c_costLabelAnchorPoint_ADD, value);
		}

		[Ordinal(47)] 
		[RED("C_costLabelAnchorPoint_SUBTRACT")] 
		public Vector2 C_costLabelAnchorPoint_SUBTRACT
		{
			get => GetProperty(ref _c_costLabelAnchorPoint_SUBTRACT);
			set => SetProperty(ref _c_costLabelAnchorPoint_SUBTRACT, value);
		}

		[Ordinal(48)] 
		[RED("C_costLabelAnchorPoint_EQUIPPED")] 
		public Vector2 C_costLabelAnchorPoint_EQUIPPED
		{
			get => GetProperty(ref _c_costLabelAnchorPoint_EQUIPPED);
			set => SetProperty(ref _c_costLabelAnchorPoint_EQUIPPED, value);
		}

		public RipperdocMetersArmor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
