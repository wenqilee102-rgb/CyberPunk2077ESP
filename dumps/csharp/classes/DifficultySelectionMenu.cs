using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DifficultySelectionMenu : gameuiBaseCharacterCreationController
	{
		private inkTextWidgetReference _difficultyTitle;
		private inkImageWidgetReference _textureTop;
		private inkImageWidgetReference _textureBottom;
		private CName _hoverAnimation;
		private inkWidgetReference _difficulty0;
		private inkWidgetReference _difficulty1;
		private inkWidgetReference _difficulty2;
		private inkWidgetReference _difficulty3;
		private CHandle<inkanimProxy> _animationProxy;
		private CName _lastShownPart;
		private redResourceReferenceScriptToken _lastAtlas;
		private wCHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CString _localizedText;
		private redResourceReferenceScriptToken _c_atlas1;
		private redResourceReferenceScriptToken _c_atlas2;
		private CBool _isInputLocked;

		[Ordinal(6)] 
		[RED("difficultyTitle")] 
		public inkTextWidgetReference DifficultyTitle
		{
			get => GetProperty(ref _difficultyTitle);
			set => SetProperty(ref _difficultyTitle, value);
		}

		[Ordinal(7)] 
		[RED("textureTop")] 
		public inkImageWidgetReference TextureTop
		{
			get => GetProperty(ref _textureTop);
			set => SetProperty(ref _textureTop, value);
		}

		[Ordinal(8)] 
		[RED("textureBottom")] 
		public inkImageWidgetReference TextureBottom
		{
			get => GetProperty(ref _textureBottom);
			set => SetProperty(ref _textureBottom, value);
		}

		[Ordinal(9)] 
		[RED("hoverAnimation")] 
		public CName HoverAnimation
		{
			get => GetProperty(ref _hoverAnimation);
			set => SetProperty(ref _hoverAnimation, value);
		}

		[Ordinal(10)] 
		[RED("difficulty0")] 
		public inkWidgetReference Difficulty0
		{
			get => GetProperty(ref _difficulty0);
			set => SetProperty(ref _difficulty0, value);
		}

		[Ordinal(11)] 
		[RED("difficulty1")] 
		public inkWidgetReference Difficulty1
		{
			get => GetProperty(ref _difficulty1);
			set => SetProperty(ref _difficulty1, value);
		}

		[Ordinal(12)] 
		[RED("difficulty2")] 
		public inkWidgetReference Difficulty2
		{
			get => GetProperty(ref _difficulty2);
			set => SetProperty(ref _difficulty2, value);
		}

		[Ordinal(13)] 
		[RED("difficulty3")] 
		public inkWidgetReference Difficulty3
		{
			get => GetProperty(ref _difficulty3);
			set => SetProperty(ref _difficulty3, value);
		}

		[Ordinal(14)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(15)] 
		[RED("lastShownPart")] 
		public CName LastShownPart
		{
			get => GetProperty(ref _lastShownPart);
			set => SetProperty(ref _lastShownPart, value);
		}

		[Ordinal(16)] 
		[RED("lastAtlas")] 
		public redResourceReferenceScriptToken LastAtlas
		{
			get => GetProperty(ref _lastAtlas);
			set => SetProperty(ref _lastAtlas, value);
		}

		[Ordinal(17)] 
		[RED("translationAnimationCtrl")] 
		public wCHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetProperty(ref _translationAnimationCtrl);
			set => SetProperty(ref _translationAnimationCtrl, value);
		}

		[Ordinal(18)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get => GetProperty(ref _localizedText);
			set => SetProperty(ref _localizedText, value);
		}

		[Ordinal(19)] 
		[RED("c_atlas1")] 
		public redResourceReferenceScriptToken C_atlas1
		{
			get => GetProperty(ref _c_atlas1);
			set => SetProperty(ref _c_atlas1, value);
		}

		[Ordinal(20)] 
		[RED("c_atlas2")] 
		public redResourceReferenceScriptToken C_atlas2
		{
			get => GetProperty(ref _c_atlas2);
			set => SetProperty(ref _c_atlas2, value);
		}

		[Ordinal(21)] 
		[RED("isInputLocked")] 
		public CBool IsInputLocked
		{
			get => GetProperty(ref _isInputLocked);
			set => SetProperty(ref _isInputLocked, value);
		}

		public DifficultySelectionMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
