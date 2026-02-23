using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationVoiceOverSwitcher : CharacterCreationBodyMorphBaseOption
	{
		private inkTextWidgetReference _selectedLabel;
		private inkWidgetReference _selectorNextBtn;
		private inkWidgetReference _selectorPrevBtn;
		private inkTextWidgetReference _warningLabel;
		private CBool _isMale;
		private CString _male;
		private CString _female;
		private inkImageWidgetReference _selectorTexture;
		private inkImageWidgetReference _arrowsTexture;
		private inkWidgetReference _optionSwitchHint;
		private wCHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private wCHandle<inkWidget> _selector;
		private CBool _inputDisabled;

		[Ordinal(2)] 
		[RED("selectedLabel")] 
		public inkTextWidgetReference SelectedLabel
		{
			get => GetProperty(ref _selectedLabel);
			set => SetProperty(ref _selectedLabel, value);
		}

		[Ordinal(3)] 
		[RED("selectorNextBtn")] 
		public inkWidgetReference SelectorNextBtn
		{
			get => GetProperty(ref _selectorNextBtn);
			set => SetProperty(ref _selectorNextBtn, value);
		}

		[Ordinal(4)] 
		[RED("selectorPrevBtn")] 
		public inkWidgetReference SelectorPrevBtn
		{
			get => GetProperty(ref _selectorPrevBtn);
			set => SetProperty(ref _selectorPrevBtn, value);
		}

		[Ordinal(5)] 
		[RED("warningLabel")] 
		public inkTextWidgetReference WarningLabel
		{
			get => GetProperty(ref _warningLabel);
			set => SetProperty(ref _warningLabel, value);
		}

		[Ordinal(6)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get => GetProperty(ref _isMale);
			set => SetProperty(ref _isMale, value);
		}

		[Ordinal(7)] 
		[RED("male")] 
		public CString Male
		{
			get => GetProperty(ref _male);
			set => SetProperty(ref _male, value);
		}

		[Ordinal(8)] 
		[RED("female")] 
		public CString Female
		{
			get => GetProperty(ref _female);
			set => SetProperty(ref _female, value);
		}

		[Ordinal(9)] 
		[RED("selectorTexture")] 
		public inkImageWidgetReference SelectorTexture
		{
			get => GetProperty(ref _selectorTexture);
			set => SetProperty(ref _selectorTexture, value);
		}

		[Ordinal(10)] 
		[RED("arrowsTexture")] 
		public inkImageWidgetReference ArrowsTexture
		{
			get => GetProperty(ref _arrowsTexture);
			set => SetProperty(ref _arrowsTexture, value);
		}

		[Ordinal(11)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetProperty(ref _optionSwitchHint);
			set => SetProperty(ref _optionSwitchHint, value);
		}

		[Ordinal(12)] 
		[RED("translationAnimationCtrl")] 
		public wCHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get => GetProperty(ref _translationAnimationCtrl);
			set => SetProperty(ref _translationAnimationCtrl, value);
		}

		[Ordinal(13)] 
		[RED("selector")] 
		public wCHandle<inkWidget> Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(14)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetProperty(ref _inputDisabled);
			set => SetProperty(ref _inputDisabled, value);
		}

		public characterCreationVoiceOverSwitcher(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
