using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocScreenAnimationController : inkWidgetLogicController
	{
		private inkWidgetReference _doll;
		private inkWidgetReference _defaultAnimationTab;
		private inkWidgetReference _itemAnimationTab;
		private inkWidgetReference _femaleHovers;
		private inkWidgetReference _maleHovers;
		private inkWidgetReference _f_immuneHoverTexture;
		private inkWidgetReference _f_systemReplacementHoverTexture;
		private inkWidgetReference _f_integumentaryHoverTexture;
		private inkWidgetReference _f_musculoskeletalHoverTexture;
		private inkWidgetReference _f_nervousHoverTexture;
		private inkImageWidgetReference _f_eyesHoverTexture;
		private inkWidgetReference _f_legsHoverTexture;
		private inkWidgetReference _f_frontalCortexHoverTexture;
		private inkWidgetReference _f_handsHoverTexture;
		private inkWidgetReference _f_cardiovascularHoverTexture;
		private inkWidgetReference _f_armsHoverTexture;
		private inkWidgetReference _m_integumentaryHoverTexture;
		private inkWidgetReference _m_armsHoverTexture;
		private inkWidgetReference _m_cardiovascularHoverTexture;
		private inkWidgetReference _m_handsHoverTexture;
		private inkWidgetReference _m_frontalCortexHoverTexture;
		private inkWidgetReference _m_immuneHoverTexture;
		private inkWidgetReference _m_legsHoverTexture;
		private inkWidgetReference _m_systemReplacementHoverTexture;
		private inkWidgetReference _m_musculoskeletalHoverTexture;
		private inkWidgetReference _m_nervousHoverTexture;
		private inkImageWidgetReference _m_eyesHoverTexture;
		private inkWidgetReference _man_wiresTexture;
		private inkWidgetReference _woman_wiresTexture;
		private CHandle<inkanimProxy> _hoverAnimation;
		private CHandle<inkanimProxy> _hoverOverAnimation;
		private CHandle<inkanimProxy> _introDefaultAnimation;
		private CHandle<inkanimProxy> _outroDefaultAnimation;
		private CHandle<inkanimProxy> _introPaperdollAnimation;
		private CHandle<inkanimProxy> _outroPaperdollAnimation;
		private CHandle<inkanimProxy> _slideAnimation;
		private CEnum<gamedataEquipmentArea> _hoveredArea;
		private CEnum<gamedataEquipmentArea> _introArea;
		private CBool _isFemale;
		private CEnum<gamedataEquipmentArea> _area;
		private CHandle<inkanimProxy> _anim;
		private CHandle<inkanimProxy> _animHover;
		private CHandle<inkanimProxy> _animCancel;
		private CBool _isHovering;
		private CBool _isSelected;
		private CName _animName;
		private inkMargin _position;
		private CFloat _positionOffset;
		private wCHandle<inkWidget> _root;
		private CBool _isSlidingOut;
		private CHandle<inkanimProxy> _zoomOutAnim;
		private CHandle<inkanimProxy> _zoomInAnim;
		private CHandle<inkanimProxy> _slideOutAnim;
		private CHandle<inkanimProxy> _slideInAnim;
		private CBool _slideDirection;
		private CBool _cancelSlideIn;
		private CBool _isInside;
		private CEnum<gamedataEquipmentArea> _currentArea;
		private CEnum<gamedataEquipmentArea> _nextArea;
		private CEnum<gamedataEquipmentArea> _midArea;
		private CFloat _sLIDE_DURATION;

		[Ordinal(1)] 
		[RED("doll")] 
		public inkWidgetReference Doll
		{
			get => GetProperty(ref _doll);
			set => SetProperty(ref _doll, value);
		}

		[Ordinal(2)] 
		[RED("defaultAnimationTab")] 
		public inkWidgetReference DefaultAnimationTab
		{
			get => GetProperty(ref _defaultAnimationTab);
			set => SetProperty(ref _defaultAnimationTab, value);
		}

		[Ordinal(3)] 
		[RED("itemAnimationTab")] 
		public inkWidgetReference ItemAnimationTab
		{
			get => GetProperty(ref _itemAnimationTab);
			set => SetProperty(ref _itemAnimationTab, value);
		}

		[Ordinal(4)] 
		[RED("femaleHovers")] 
		public inkWidgetReference FemaleHovers
		{
			get => GetProperty(ref _femaleHovers);
			set => SetProperty(ref _femaleHovers, value);
		}

		[Ordinal(5)] 
		[RED("maleHovers")] 
		public inkWidgetReference MaleHovers
		{
			get => GetProperty(ref _maleHovers);
			set => SetProperty(ref _maleHovers, value);
		}

		[Ordinal(6)] 
		[RED("F_immuneHoverTexture")] 
		public inkWidgetReference F_immuneHoverTexture
		{
			get => GetProperty(ref _f_immuneHoverTexture);
			set => SetProperty(ref _f_immuneHoverTexture, value);
		}

		[Ordinal(7)] 
		[RED("F_systemReplacementHoverTexture")] 
		public inkWidgetReference F_systemReplacementHoverTexture
		{
			get => GetProperty(ref _f_systemReplacementHoverTexture);
			set => SetProperty(ref _f_systemReplacementHoverTexture, value);
		}

		[Ordinal(8)] 
		[RED("F_integumentaryHoverTexture")] 
		public inkWidgetReference F_integumentaryHoverTexture
		{
			get => GetProperty(ref _f_integumentaryHoverTexture);
			set => SetProperty(ref _f_integumentaryHoverTexture, value);
		}

		[Ordinal(9)] 
		[RED("F_musculoskeletalHoverTexture")] 
		public inkWidgetReference F_musculoskeletalHoverTexture
		{
			get => GetProperty(ref _f_musculoskeletalHoverTexture);
			set => SetProperty(ref _f_musculoskeletalHoverTexture, value);
		}

		[Ordinal(10)] 
		[RED("F_nervousHoverTexture")] 
		public inkWidgetReference F_nervousHoverTexture
		{
			get => GetProperty(ref _f_nervousHoverTexture);
			set => SetProperty(ref _f_nervousHoverTexture, value);
		}

		[Ordinal(11)] 
		[RED("F_eyesHoverTexture")] 
		public inkImageWidgetReference F_eyesHoverTexture
		{
			get => GetProperty(ref _f_eyesHoverTexture);
			set => SetProperty(ref _f_eyesHoverTexture, value);
		}

		[Ordinal(12)] 
		[RED("F_legsHoverTexture")] 
		public inkWidgetReference F_legsHoverTexture
		{
			get => GetProperty(ref _f_legsHoverTexture);
			set => SetProperty(ref _f_legsHoverTexture, value);
		}

		[Ordinal(13)] 
		[RED("F_frontalCortexHoverTexture")] 
		public inkWidgetReference F_frontalCortexHoverTexture
		{
			get => GetProperty(ref _f_frontalCortexHoverTexture);
			set => SetProperty(ref _f_frontalCortexHoverTexture, value);
		}

		[Ordinal(14)] 
		[RED("F_handsHoverTexture")] 
		public inkWidgetReference F_handsHoverTexture
		{
			get => GetProperty(ref _f_handsHoverTexture);
			set => SetProperty(ref _f_handsHoverTexture, value);
		}

		[Ordinal(15)] 
		[RED("F_cardiovascularHoverTexture")] 
		public inkWidgetReference F_cardiovascularHoverTexture
		{
			get => GetProperty(ref _f_cardiovascularHoverTexture);
			set => SetProperty(ref _f_cardiovascularHoverTexture, value);
		}

		[Ordinal(16)] 
		[RED("F_armsHoverTexture")] 
		public inkWidgetReference F_armsHoverTexture
		{
			get => GetProperty(ref _f_armsHoverTexture);
			set => SetProperty(ref _f_armsHoverTexture, value);
		}

		[Ordinal(17)] 
		[RED("M_integumentaryHoverTexture")] 
		public inkWidgetReference M_integumentaryHoverTexture
		{
			get => GetProperty(ref _m_integumentaryHoverTexture);
			set => SetProperty(ref _m_integumentaryHoverTexture, value);
		}

		[Ordinal(18)] 
		[RED("M_armsHoverTexture")] 
		public inkWidgetReference M_armsHoverTexture
		{
			get => GetProperty(ref _m_armsHoverTexture);
			set => SetProperty(ref _m_armsHoverTexture, value);
		}

		[Ordinal(19)] 
		[RED("M_cardiovascularHoverTexture")] 
		public inkWidgetReference M_cardiovascularHoverTexture
		{
			get => GetProperty(ref _m_cardiovascularHoverTexture);
			set => SetProperty(ref _m_cardiovascularHoverTexture, value);
		}

		[Ordinal(20)] 
		[RED("M_handsHoverTexture")] 
		public inkWidgetReference M_handsHoverTexture
		{
			get => GetProperty(ref _m_handsHoverTexture);
			set => SetProperty(ref _m_handsHoverTexture, value);
		}

		[Ordinal(21)] 
		[RED("M_frontalCortexHoverTexture")] 
		public inkWidgetReference M_frontalCortexHoverTexture
		{
			get => GetProperty(ref _m_frontalCortexHoverTexture);
			set => SetProperty(ref _m_frontalCortexHoverTexture, value);
		}

		[Ordinal(22)] 
		[RED("M_immuneHoverTexture")] 
		public inkWidgetReference M_immuneHoverTexture
		{
			get => GetProperty(ref _m_immuneHoverTexture);
			set => SetProperty(ref _m_immuneHoverTexture, value);
		}

		[Ordinal(23)] 
		[RED("M_legsHoverTexture")] 
		public inkWidgetReference M_legsHoverTexture
		{
			get => GetProperty(ref _m_legsHoverTexture);
			set => SetProperty(ref _m_legsHoverTexture, value);
		}

		[Ordinal(24)] 
		[RED("M_systemReplacementHoverTexture")] 
		public inkWidgetReference M_systemReplacementHoverTexture
		{
			get => GetProperty(ref _m_systemReplacementHoverTexture);
			set => SetProperty(ref _m_systemReplacementHoverTexture, value);
		}

		[Ordinal(25)] 
		[RED("M_musculoskeletalHoverTexture")] 
		public inkWidgetReference M_musculoskeletalHoverTexture
		{
			get => GetProperty(ref _m_musculoskeletalHoverTexture);
			set => SetProperty(ref _m_musculoskeletalHoverTexture, value);
		}

		[Ordinal(26)] 
		[RED("M_nervousHoverTexture")] 
		public inkWidgetReference M_nervousHoverTexture
		{
			get => GetProperty(ref _m_nervousHoverTexture);
			set => SetProperty(ref _m_nervousHoverTexture, value);
		}

		[Ordinal(27)] 
		[RED("M_eyesHoverTexture")] 
		public inkImageWidgetReference M_eyesHoverTexture
		{
			get => GetProperty(ref _m_eyesHoverTexture);
			set => SetProperty(ref _m_eyesHoverTexture, value);
		}

		[Ordinal(28)] 
		[RED("man_wiresTexture")] 
		public inkWidgetReference Man_wiresTexture
		{
			get => GetProperty(ref _man_wiresTexture);
			set => SetProperty(ref _man_wiresTexture, value);
		}

		[Ordinal(29)] 
		[RED("woman_wiresTexture")] 
		public inkWidgetReference Woman_wiresTexture
		{
			get => GetProperty(ref _woman_wiresTexture);
			set => SetProperty(ref _woman_wiresTexture, value);
		}

		[Ordinal(30)] 
		[RED("hoverAnimation")] 
		public CHandle<inkanimProxy> HoverAnimation
		{
			get => GetProperty(ref _hoverAnimation);
			set => SetProperty(ref _hoverAnimation, value);
		}

		[Ordinal(31)] 
		[RED("hoverOverAnimation")] 
		public CHandle<inkanimProxy> HoverOverAnimation
		{
			get => GetProperty(ref _hoverOverAnimation);
			set => SetProperty(ref _hoverOverAnimation, value);
		}

		[Ordinal(32)] 
		[RED("introDefaultAnimation")] 
		public CHandle<inkanimProxy> IntroDefaultAnimation
		{
			get => GetProperty(ref _introDefaultAnimation);
			set => SetProperty(ref _introDefaultAnimation, value);
		}

		[Ordinal(33)] 
		[RED("outroDefaultAnimation")] 
		public CHandle<inkanimProxy> OutroDefaultAnimation
		{
			get => GetProperty(ref _outroDefaultAnimation);
			set => SetProperty(ref _outroDefaultAnimation, value);
		}

		[Ordinal(34)] 
		[RED("introPaperdollAnimation")] 
		public CHandle<inkanimProxy> IntroPaperdollAnimation
		{
			get => GetProperty(ref _introPaperdollAnimation);
			set => SetProperty(ref _introPaperdollAnimation, value);
		}

		[Ordinal(35)] 
		[RED("outroPaperdollAnimation")] 
		public CHandle<inkanimProxy> OutroPaperdollAnimation
		{
			get => GetProperty(ref _outroPaperdollAnimation);
			set => SetProperty(ref _outroPaperdollAnimation, value);
		}

		[Ordinal(36)] 
		[RED("slideAnimation")] 
		public CHandle<inkanimProxy> SlideAnimation
		{
			get => GetProperty(ref _slideAnimation);
			set => SetProperty(ref _slideAnimation, value);
		}

		[Ordinal(37)] 
		[RED("hoveredArea")] 
		public CEnum<gamedataEquipmentArea> HoveredArea
		{
			get => GetProperty(ref _hoveredArea);
			set => SetProperty(ref _hoveredArea, value);
		}

		[Ordinal(38)] 
		[RED("introArea")] 
		public CEnum<gamedataEquipmentArea> IntroArea
		{
			get => GetProperty(ref _introArea);
			set => SetProperty(ref _introArea, value);
		}

		[Ordinal(39)] 
		[RED("isFemale")] 
		public CBool IsFemale
		{
			get => GetProperty(ref _isFemale);
			set => SetProperty(ref _isFemale, value);
		}

		[Ordinal(40)] 
		[RED("area")] 
		public CEnum<gamedataEquipmentArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(41)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		[Ordinal(42)] 
		[RED("animHover")] 
		public CHandle<inkanimProxy> AnimHover
		{
			get => GetProperty(ref _animHover);
			set => SetProperty(ref _animHover, value);
		}

		[Ordinal(43)] 
		[RED("animCancel")] 
		public CHandle<inkanimProxy> AnimCancel
		{
			get => GetProperty(ref _animCancel);
			set => SetProperty(ref _animCancel, value);
		}

		[Ordinal(44)] 
		[RED("isHovering")] 
		public CBool IsHovering
		{
			get => GetProperty(ref _isHovering);
			set => SetProperty(ref _isHovering, value);
		}

		[Ordinal(45)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(46)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(47)] 
		[RED("position")] 
		public inkMargin Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(48)] 
		[RED("positionOffset")] 
		public CFloat PositionOffset
		{
			get => GetProperty(ref _positionOffset);
			set => SetProperty(ref _positionOffset, value);
		}

		[Ordinal(49)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(50)] 
		[RED("isSlidingOut")] 
		public CBool IsSlidingOut
		{
			get => GetProperty(ref _isSlidingOut);
			set => SetProperty(ref _isSlidingOut, value);
		}

		[Ordinal(51)] 
		[RED("zoomOutAnim")] 
		public CHandle<inkanimProxy> ZoomOutAnim
		{
			get => GetProperty(ref _zoomOutAnim);
			set => SetProperty(ref _zoomOutAnim, value);
		}

		[Ordinal(52)] 
		[RED("zoomInAnim")] 
		public CHandle<inkanimProxy> ZoomInAnim
		{
			get => GetProperty(ref _zoomInAnim);
			set => SetProperty(ref _zoomInAnim, value);
		}

		[Ordinal(53)] 
		[RED("slideOutAnim")] 
		public CHandle<inkanimProxy> SlideOutAnim
		{
			get => GetProperty(ref _slideOutAnim);
			set => SetProperty(ref _slideOutAnim, value);
		}

		[Ordinal(54)] 
		[RED("slideInAnim")] 
		public CHandle<inkanimProxy> SlideInAnim
		{
			get => GetProperty(ref _slideInAnim);
			set => SetProperty(ref _slideInAnim, value);
		}

		[Ordinal(55)] 
		[RED("slideDirection")] 
		public CBool SlideDirection
		{
			get => GetProperty(ref _slideDirection);
			set => SetProperty(ref _slideDirection, value);
		}

		[Ordinal(56)] 
		[RED("cancelSlideIn")] 
		public CBool CancelSlideIn
		{
			get => GetProperty(ref _cancelSlideIn);
			set => SetProperty(ref _cancelSlideIn, value);
		}

		[Ordinal(57)] 
		[RED("isInside")] 
		public CBool IsInside
		{
			get => GetProperty(ref _isInside);
			set => SetProperty(ref _isInside, value);
		}

		[Ordinal(58)] 
		[RED("currentArea")] 
		public CEnum<gamedataEquipmentArea> CurrentArea
		{
			get => GetProperty(ref _currentArea);
			set => SetProperty(ref _currentArea, value);
		}

		[Ordinal(59)] 
		[RED("nextArea")] 
		public CEnum<gamedataEquipmentArea> NextArea
		{
			get => GetProperty(ref _nextArea);
			set => SetProperty(ref _nextArea, value);
		}

		[Ordinal(60)] 
		[RED("midArea")] 
		public CEnum<gamedataEquipmentArea> MidArea
		{
			get => GetProperty(ref _midArea);
			set => SetProperty(ref _midArea, value);
		}

		[Ordinal(61)] 
		[RED("SLIDE_DURATION")] 
		public CFloat SLIDE_DURATION
		{
			get => GetProperty(ref _sLIDE_DURATION);
			set => SetProperty(ref _sLIDE_DURATION, value);
		}

		public RipperdocScreenAnimationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
