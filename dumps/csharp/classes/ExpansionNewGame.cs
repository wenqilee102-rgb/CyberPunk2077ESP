using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExpansionNewGame : gameuiBaseCharacterCreationController
	{
		private inkTextWidgetReference _newGameDescription;
		private inkImageWidgetReference _textureTop;
		private inkImageWidgetReference _textureBottom;
		private inkImageWidgetReference _creditsBaseTexture;
		private inkImageWidgetReference _creditsExpansionTexture;
		private inkWidgetReference _creditsBase;
		private inkWidgetReference _creditsExpansion;
		private inkWidgetReference _creditsHoverFrameLeft;
		private inkWidgetReference _creditsHoverFrameRight;
		private CName _introAnimation;
		private CName _outroAnimation;
		private CName _hoverAnimation;
		private CHandle<inkanimProxy> _animationProxy;
		private wCHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CString _localizedText;
		private CName _lastShownPart;
		private inkWidgetReference _baseGameButton;
		private inkWidgetReference _standaloneButton;
		private CBool _isInputLocked;

		[Ordinal(6)] 
		[RED("newGameDescription")] 
		public inkTextWidgetReference NewGameDescription
		{
			get => GetProperty(ref _newGameDescription);
			set => SetProperty(ref _newGameDescription, value);
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
		[RED("creditsBaseTexture")] 
		public inkImageWidgetReference CreditsBaseTexture
		{
			get => GetProperty(ref _creditsBaseTexture);
			set => SetProperty(ref _creditsBaseTexture, value);
		}

		[Ordinal(10)] 
		[RED("creditsExpansionTexture")] 
		public inkImageWidgetReference CreditsExpansionTexture
		{
			get => GetProperty(ref _creditsExpansionTexture);
			set => SetProperty(ref _creditsExpansionTexture, value);
		}

		[Ordinal(11)] 
		[RED("creditsBase")] 
		public inkWidgetReference CreditsBase
		{
			get => GetProperty(ref _creditsBase);
			set => SetProperty(ref _creditsBase, value);
		}

		[Ordinal(12)] 
		[RED("creditsExpansion")] 
		public inkWidgetReference CreditsExpansion
		{
			get => GetProperty(ref _creditsExpansion);
			set => SetProperty(ref _creditsExpansion, value);
		}

		[Ordinal(13)] 
		[RED("creditsHoverFrameLeft")] 
		public inkWidgetReference CreditsHoverFrameLeft
		{
			get => GetProperty(ref _creditsHoverFrameLeft);
			set => SetProperty(ref _creditsHoverFrameLeft, value);
		}

		[Ordinal(14)] 
		[RED("creditsHoverFrameRight")] 
		public inkWidgetReference CreditsHoverFrameRight
		{
			get => GetProperty(ref _creditsHoverFrameRight);
			set => SetProperty(ref _creditsHoverFrameRight, value);
		}

		[Ordinal(15)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(16)] 
		[RED("outroAnimation")] 
		public CName OutroAnimation
		{
			get => GetProperty(ref _outroAnimation);
			set => SetProperty(ref _outroAnimation, value);
		}

		[Ordinal(17)] 
		[RED("hoverAnimation")] 
		public CName HoverAnimation
		{
			get => GetProperty(ref _hoverAnimation);
			set => SetProperty(ref _hoverAnimation, value);
		}

		[Ordinal(18)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(19)] 
		[RED("translationAnimationCtrl")] 
		public wCHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetProperty(ref _translationAnimationCtrl);
			set => SetProperty(ref _translationAnimationCtrl, value);
		}

		[Ordinal(20)] 
		[RED("localizedText")] 
		public CString LocalizedText
		{
			get => GetProperty(ref _localizedText);
			set => SetProperty(ref _localizedText, value);
		}

		[Ordinal(21)] 
		[RED("lastShownPart")] 
		public CName LastShownPart
		{
			get => GetProperty(ref _lastShownPart);
			set => SetProperty(ref _lastShownPart, value);
		}

		[Ordinal(22)] 
		[RED("baseGameButton")] 
		public inkWidgetReference BaseGameButton
		{
			get => GetProperty(ref _baseGameButton);
			set => SetProperty(ref _baseGameButton, value);
		}

		[Ordinal(23)] 
		[RED("standaloneButton")] 
		public inkWidgetReference StandaloneButton
		{
			get => GetProperty(ref _standaloneButton);
			set => SetProperty(ref _standaloneButton, value);
		}

		[Ordinal(24)] 
		[RED("isInputLocked")] 
		public CBool IsInputLocked
		{
			get => GetProperty(ref _isInputLocked);
			set => SetProperty(ref _isInputLocked, value);
		}

		public ExpansionNewGame(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
