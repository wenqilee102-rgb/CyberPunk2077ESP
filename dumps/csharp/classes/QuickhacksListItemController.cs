using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhacksListItemController : inkListItemController
	{
		private CFloat _expandAnimationDuration;
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _memoryValue;
		private inkCompoundWidgetReference _memoryCells;
		private inkWidgetReference _actionStateRoot;
		private inkTextWidgetReference _actionStateText;
		private inkWidgetReference _categoryRoot;
		private inkTextWidgetReference _categoryText;
		private inkWidgetReference _revealRoot;
		private inkTextWidgetReference _revealText;
		private inkWidgetReference _cooldownIcon;
		private inkTextWidgetReference _cooldownValue;
		private inkWidgetReference _descriptionSize;
		private inkImageWidgetReference _costReductionArrow;
		private CFloat _curveRadius;
		private CBool _categorizedHacks;
		private CBool _colorCodedHacks;
		private CName _hackColorDamage;
		private CName _hackColorControl;
		private CName _hackColorCovert;
		private CName _hackColorUltimate;
		private CName _hackColorDefault;
		private CHandle<inkanimProxy> _selectedLoop;
		private CName _currentAnimationName;
		private CHandle<inkanimProxy> _choiceAccepted;
		private CHandle<inkanimController> _resizeAnim;
		private wCHandle<inkWidget> _root;
		private CHandle<QuickhackData> _data;
		private CBool _isSelected;
		private CBool _expanded;
		private Vector2 _cachedDescriptionSize;
		private inkMargin _defaultMargin;

		[Ordinal(19)] 
		[RED("expandAnimationDuration")] 
		public CFloat ExpandAnimationDuration
		{
			get => GetProperty(ref _expandAnimationDuration);
			set => SetProperty(ref _expandAnimationDuration, value);
		}

		[Ordinal(20)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(21)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(22)] 
		[RED("memoryValue")] 
		public inkTextWidgetReference MemoryValue
		{
			get => GetProperty(ref _memoryValue);
			set => SetProperty(ref _memoryValue, value);
		}

		[Ordinal(23)] 
		[RED("memoryCells")] 
		public inkCompoundWidgetReference MemoryCells
		{
			get => GetProperty(ref _memoryCells);
			set => SetProperty(ref _memoryCells, value);
		}

		[Ordinal(24)] 
		[RED("actionStateRoot")] 
		public inkWidgetReference ActionStateRoot
		{
			get => GetProperty(ref _actionStateRoot);
			set => SetProperty(ref _actionStateRoot, value);
		}

		[Ordinal(25)] 
		[RED("actionStateText")] 
		public inkTextWidgetReference ActionStateText
		{
			get => GetProperty(ref _actionStateText);
			set => SetProperty(ref _actionStateText, value);
		}

		[Ordinal(26)] 
		[RED("categoryRoot")] 
		public inkWidgetReference CategoryRoot
		{
			get => GetProperty(ref _categoryRoot);
			set => SetProperty(ref _categoryRoot, value);
		}

		[Ordinal(27)] 
		[RED("categoryText")] 
		public inkTextWidgetReference CategoryText
		{
			get => GetProperty(ref _categoryText);
			set => SetProperty(ref _categoryText, value);
		}

		[Ordinal(28)] 
		[RED("revealRoot")] 
		public inkWidgetReference RevealRoot
		{
			get => GetProperty(ref _revealRoot);
			set => SetProperty(ref _revealRoot, value);
		}

		[Ordinal(29)] 
		[RED("revealText")] 
		public inkTextWidgetReference RevealText
		{
			get => GetProperty(ref _revealText);
			set => SetProperty(ref _revealText, value);
		}

		[Ordinal(30)] 
		[RED("cooldownIcon")] 
		public inkWidgetReference CooldownIcon
		{
			get => GetProperty(ref _cooldownIcon);
			set => SetProperty(ref _cooldownIcon, value);
		}

		[Ordinal(31)] 
		[RED("cooldownValue")] 
		public inkTextWidgetReference CooldownValue
		{
			get => GetProperty(ref _cooldownValue);
			set => SetProperty(ref _cooldownValue, value);
		}

		[Ordinal(32)] 
		[RED("descriptionSize")] 
		public inkWidgetReference DescriptionSize
		{
			get => GetProperty(ref _descriptionSize);
			set => SetProperty(ref _descriptionSize, value);
		}

		[Ordinal(33)] 
		[RED("costReductionArrow")] 
		public inkImageWidgetReference CostReductionArrow
		{
			get => GetProperty(ref _costReductionArrow);
			set => SetProperty(ref _costReductionArrow, value);
		}

		[Ordinal(34)] 
		[RED("curveRadius")] 
		public CFloat CurveRadius
		{
			get => GetProperty(ref _curveRadius);
			set => SetProperty(ref _curveRadius, value);
		}

		[Ordinal(35)] 
		[RED("categorizedHacks")] 
		public CBool CategorizedHacks
		{
			get => GetProperty(ref _categorizedHacks);
			set => SetProperty(ref _categorizedHacks, value);
		}

		[Ordinal(36)] 
		[RED("colorCodedHacks")] 
		public CBool ColorCodedHacks
		{
			get => GetProperty(ref _colorCodedHacks);
			set => SetProperty(ref _colorCodedHacks, value);
		}

		[Ordinal(37)] 
		[RED("hackColorDamage")] 
		public CName HackColorDamage
		{
			get => GetProperty(ref _hackColorDamage);
			set => SetProperty(ref _hackColorDamage, value);
		}

		[Ordinal(38)] 
		[RED("hackColorControl")] 
		public CName HackColorControl
		{
			get => GetProperty(ref _hackColorControl);
			set => SetProperty(ref _hackColorControl, value);
		}

		[Ordinal(39)] 
		[RED("hackColorCovert")] 
		public CName HackColorCovert
		{
			get => GetProperty(ref _hackColorCovert);
			set => SetProperty(ref _hackColorCovert, value);
		}

		[Ordinal(40)] 
		[RED("hackColorUltimate")] 
		public CName HackColorUltimate
		{
			get => GetProperty(ref _hackColorUltimate);
			set => SetProperty(ref _hackColorUltimate, value);
		}

		[Ordinal(41)] 
		[RED("hackColorDefault")] 
		public CName HackColorDefault
		{
			get => GetProperty(ref _hackColorDefault);
			set => SetProperty(ref _hackColorDefault, value);
		}

		[Ordinal(42)] 
		[RED("selectedLoop")] 
		public CHandle<inkanimProxy> SelectedLoop
		{
			get => GetProperty(ref _selectedLoop);
			set => SetProperty(ref _selectedLoop, value);
		}

		[Ordinal(43)] 
		[RED("currentAnimationName")] 
		public CName CurrentAnimationName
		{
			get => GetProperty(ref _currentAnimationName);
			set => SetProperty(ref _currentAnimationName, value);
		}

		[Ordinal(44)] 
		[RED("choiceAccepted")] 
		public CHandle<inkanimProxy> ChoiceAccepted
		{
			get => GetProperty(ref _choiceAccepted);
			set => SetProperty(ref _choiceAccepted, value);
		}

		[Ordinal(45)] 
		[RED("resizeAnim")] 
		public CHandle<inkanimController> ResizeAnim
		{
			get => GetProperty(ref _resizeAnim);
			set => SetProperty(ref _resizeAnim, value);
		}

		[Ordinal(46)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(47)] 
		[RED("data")] 
		public CHandle<QuickhackData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(48)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(49)] 
		[RED("expanded")] 
		public CBool Expanded
		{
			get => GetProperty(ref _expanded);
			set => SetProperty(ref _expanded, value);
		}

		[Ordinal(50)] 
		[RED("cachedDescriptionSize")] 
		public Vector2 CachedDescriptionSize
		{
			get => GetProperty(ref _cachedDescriptionSize);
			set => SetProperty(ref _cachedDescriptionSize, value);
		}

		[Ordinal(51)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get => GetProperty(ref _defaultMargin);
			set => SetProperty(ref _defaultMargin, value);
		}

		public QuickhacksListItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
