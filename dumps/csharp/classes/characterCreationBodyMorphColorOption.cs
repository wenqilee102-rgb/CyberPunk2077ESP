using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphColorOption : CharacterCreationBodyMorphBaseOption
	{
		private inkTextWidgetReference _optionLabel;
		private inkWidgetReference _colorPickerBtn;
		private inkWidgetReference _selectorNextBtn;
		private inkWidgetReference _selectorPrevBtn;
		private inkImageWidgetReference _selectorTexture;
		private inkImageWidgetReference _arrowsTexture;
		private inkWidgetReference _optionSwitchHint;
		private wCHandle<gameuiCharacterCustomizationOption> _colorPickerOption;
		private wCHandle<gameuiAppearanceInfo> _appearanceInfo;
		private CInt32 _currColorIndex;
		private wCHandle<inkWidget> _selector;
		private CBool _inputDisabled;
		private CBool _isVisible;

		[Ordinal(2)] 
		[RED("optionLabel")] 
		public inkTextWidgetReference OptionLabel
		{
			get => GetProperty(ref _optionLabel);
			set => SetProperty(ref _optionLabel, value);
		}

		[Ordinal(3)] 
		[RED("colorPickerBtn")] 
		public inkWidgetReference ColorPickerBtn
		{
			get => GetProperty(ref _colorPickerBtn);
			set => SetProperty(ref _colorPickerBtn, value);
		}

		[Ordinal(4)] 
		[RED("selectorNextBtn")] 
		public inkWidgetReference SelectorNextBtn
		{
			get => GetProperty(ref _selectorNextBtn);
			set => SetProperty(ref _selectorNextBtn, value);
		}

		[Ordinal(5)] 
		[RED("selectorPrevBtn")] 
		public inkWidgetReference SelectorPrevBtn
		{
			get => GetProperty(ref _selectorPrevBtn);
			set => SetProperty(ref _selectorPrevBtn, value);
		}

		[Ordinal(6)] 
		[RED("selectorTexture")] 
		public inkImageWidgetReference SelectorTexture
		{
			get => GetProperty(ref _selectorTexture);
			set => SetProperty(ref _selectorTexture, value);
		}

		[Ordinal(7)] 
		[RED("arrowsTexture")] 
		public inkImageWidgetReference ArrowsTexture
		{
			get => GetProperty(ref _arrowsTexture);
			set => SetProperty(ref _arrowsTexture, value);
		}

		[Ordinal(8)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get => GetProperty(ref _optionSwitchHint);
			set => SetProperty(ref _optionSwitchHint, value);
		}

		[Ordinal(9)] 
		[RED("colorPickerOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> ColorPickerOption
		{
			get => GetProperty(ref _colorPickerOption);
			set => SetProperty(ref _colorPickerOption, value);
		}

		[Ordinal(10)] 
		[RED("appearanceInfo")] 
		public wCHandle<gameuiAppearanceInfo> AppearanceInfo
		{
			get => GetProperty(ref _appearanceInfo);
			set => SetProperty(ref _appearanceInfo, value);
		}

		[Ordinal(11)] 
		[RED("currColorIndex")] 
		public CInt32 CurrColorIndex
		{
			get => GetProperty(ref _currColorIndex);
			set => SetProperty(ref _currColorIndex, value);
		}

		[Ordinal(12)] 
		[RED("selector")] 
		public wCHandle<inkWidget> Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(13)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetProperty(ref _inputDisabled);
			set => SetProperty(ref _inputDisabled, value);
		}

		[Ordinal(14)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}

		public characterCreationBodyMorphColorOption(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
