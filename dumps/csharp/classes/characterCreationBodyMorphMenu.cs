using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphMenu : gameuiBaseCharacterCreationController
	{
		private CName _defaultPreviewSlot;
		private inkCompoundWidgetReference _optionsList;
		private inkWidgetReference _colorPicker;
		private inkWidgetReference _colorPickerContentWrapper;
		private inkWidgetReference _colorPickerBG;
		private inkWidgetReference _colorPickerClose;
		private inkWidgetReference _scrollWidget;
		private inkScrollAreaWidgetReference _scrollArea;
		private wCHandle<inkCompoundWidget> _optionList;
		private inkWidgetReference _slider;
		private inkWidgetReference _previousPageBtn;
		private inkImageWidgetReference _previousPageBtnBg;
		private inkTextWidgetReference _previousPageBtnText;
		private inkImageWidgetReference _nextPageBtnBg;
		private inkTextWidgetReference _nextPageBtnText;
		private inkWidgetReference _backConfirmation;
		private inkWidgetReference _backConfirmationWidget;
		private inkWidgetReference _confirmationConfirmBtn;
		private inkWidgetReference _confirmationCloseBtn;
		private inkWidgetReference _preset1Group;
		private inkWidgetReference _preset2Group;
		private inkWidgetReference _preset3Group;
		private inkWidgetReference _randomizeGroup;
		private inkWidgetReference _presetsLabel;
		private inkWidgetReference _preset1;
		private inkWidgetReference _preset2;
		private inkWidgetReference _preset3;
		private inkWidgetReference _randomize;
		private inkImageWidgetReference _randomizeBg;
		private inkWidgetReference _randomizationSettingsButton;
		private inkWidgetReference _randomizationSettingsWidget;
		private wCHandle<gameuiCharacterRandomizationController> _randomizationSettingsController;
		private inkImageWidgetReference _randomizationSettingsButtonBg;
		private inkImageWidgetReference _preset1Thumbnail;
		private inkImageWidgetReference _preset2Thumbnail;
		private inkImageWidgetReference _preset3Thumbnail;
		private inkImageWidgetReference _preset1Bg;
		private inkImageWidgetReference _preset2Bg;
		private inkImageWidgetReference _preset3Bg;
		private inkWidgetReference _navigationButtons;
		private CBool _hideColorPickerNextFrame;
		private wCHandle<inkWidget> _colorPickerOwner;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _confirmAnimationProxy;
		private CHandle<inkanimProxy> _optionListAnimationProxy;
		private CBool _optionsListInitialized;
		private CBool _introPlayed;
		private CArray<wCHandle<inkDiscreteNavigationController>> _navigationControllers;
		private CArray<wCHandle<inkDiscreteNavigationController>> _presetsNavigationControllers;
		private wCHandle<inkListController> _menuListController;
		private wCHandle<inkWidget> _cachedCursor;
		private CBool _updatingFinalizedState;
		private CEnum<gameuiCharacterCustomizationEditTag> _editMode;
		private CEnum<BusySwitchingReason> _busySwitchingAppearance;
		private wCHandle<inkScrollController> _scrollController;
		private wCHandle<inkSliderController> _sliderController;
		private CBool _inputDisabled;
		private CBool _introComplete;
		private CBool _isPresetHoveredOver;
		private wCHandle<inkDiscreteNavigationController> _randomizationSettingsNavController;
		private wCHandle<inkDiscreteNavigationController> _randomizationNavController;
		private CFloat _maxColorPickerHeight;
		private CFloat _minColorPickerHeight;
		private CFloat _colorPickerHeightPerRow;

		[Ordinal(6)] 
		[RED("defaultPreviewSlot")] 
		public CName DefaultPreviewSlot
		{
			get => GetProperty(ref _defaultPreviewSlot);
			set => SetProperty(ref _defaultPreviewSlot, value);
		}

		[Ordinal(7)] 
		[RED("optionsList")] 
		public inkCompoundWidgetReference OptionsList
		{
			get => GetProperty(ref _optionsList);
			set => SetProperty(ref _optionsList, value);
		}

		[Ordinal(8)] 
		[RED("colorPicker")] 
		public inkWidgetReference ColorPicker
		{
			get => GetProperty(ref _colorPicker);
			set => SetProperty(ref _colorPicker, value);
		}

		[Ordinal(9)] 
		[RED("colorPickerContentWrapper")] 
		public inkWidgetReference ColorPickerContentWrapper
		{
			get => GetProperty(ref _colorPickerContentWrapper);
			set => SetProperty(ref _colorPickerContentWrapper, value);
		}

		[Ordinal(10)] 
		[RED("colorPickerBG")] 
		public inkWidgetReference ColorPickerBG
		{
			get => GetProperty(ref _colorPickerBG);
			set => SetProperty(ref _colorPickerBG, value);
		}

		[Ordinal(11)] 
		[RED("colorPickerClose")] 
		public inkWidgetReference ColorPickerClose
		{
			get => GetProperty(ref _colorPickerClose);
			set => SetProperty(ref _colorPickerClose, value);
		}

		[Ordinal(12)] 
		[RED("scrollWidget")] 
		public inkWidgetReference ScrollWidget
		{
			get => GetProperty(ref _scrollWidget);
			set => SetProperty(ref _scrollWidget, value);
		}

		[Ordinal(13)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(14)] 
		[RED("optionList")] 
		public wCHandle<inkCompoundWidget> OptionList
		{
			get => GetProperty(ref _optionList);
			set => SetProperty(ref _optionList, value);
		}

		[Ordinal(15)] 
		[RED("slider")] 
		public inkWidgetReference Slider
		{
			get => GetProperty(ref _slider);
			set => SetProperty(ref _slider, value);
		}

		[Ordinal(16)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get => GetProperty(ref _previousPageBtn);
			set => SetProperty(ref _previousPageBtn, value);
		}

		[Ordinal(17)] 
		[RED("previousPageBtnBg")] 
		public inkImageWidgetReference PreviousPageBtnBg
		{
			get => GetProperty(ref _previousPageBtnBg);
			set => SetProperty(ref _previousPageBtnBg, value);
		}

		[Ordinal(18)] 
		[RED("previousPageBtnText")] 
		public inkTextWidgetReference PreviousPageBtnText
		{
			get => GetProperty(ref _previousPageBtnText);
			set => SetProperty(ref _previousPageBtnText, value);
		}

		[Ordinal(19)] 
		[RED("nextPageBtnBg")] 
		public inkImageWidgetReference NextPageBtnBg
		{
			get => GetProperty(ref _nextPageBtnBg);
			set => SetProperty(ref _nextPageBtnBg, value);
		}

		[Ordinal(20)] 
		[RED("nextPageBtnText")] 
		public inkTextWidgetReference NextPageBtnText
		{
			get => GetProperty(ref _nextPageBtnText);
			set => SetProperty(ref _nextPageBtnText, value);
		}

		[Ordinal(21)] 
		[RED("backConfirmation")] 
		public inkWidgetReference BackConfirmation
		{
			get => GetProperty(ref _backConfirmation);
			set => SetProperty(ref _backConfirmation, value);
		}

		[Ordinal(22)] 
		[RED("backConfirmationWidget")] 
		public inkWidgetReference BackConfirmationWidget
		{
			get => GetProperty(ref _backConfirmationWidget);
			set => SetProperty(ref _backConfirmationWidget, value);
		}

		[Ordinal(23)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get => GetProperty(ref _confirmationConfirmBtn);
			set => SetProperty(ref _confirmationConfirmBtn, value);
		}

		[Ordinal(24)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get => GetProperty(ref _confirmationCloseBtn);
			set => SetProperty(ref _confirmationCloseBtn, value);
		}

		[Ordinal(25)] 
		[RED("preset1Group")] 
		public inkWidgetReference Preset1Group
		{
			get => GetProperty(ref _preset1Group);
			set => SetProperty(ref _preset1Group, value);
		}

		[Ordinal(26)] 
		[RED("preset2Group")] 
		public inkWidgetReference Preset2Group
		{
			get => GetProperty(ref _preset2Group);
			set => SetProperty(ref _preset2Group, value);
		}

		[Ordinal(27)] 
		[RED("preset3Group")] 
		public inkWidgetReference Preset3Group
		{
			get => GetProperty(ref _preset3Group);
			set => SetProperty(ref _preset3Group, value);
		}

		[Ordinal(28)] 
		[RED("randomizeGroup")] 
		public inkWidgetReference RandomizeGroup
		{
			get => GetProperty(ref _randomizeGroup);
			set => SetProperty(ref _randomizeGroup, value);
		}

		[Ordinal(29)] 
		[RED("presetsLabel")] 
		public inkWidgetReference PresetsLabel
		{
			get => GetProperty(ref _presetsLabel);
			set => SetProperty(ref _presetsLabel, value);
		}

		[Ordinal(30)] 
		[RED("preset1")] 
		public inkWidgetReference Preset1
		{
			get => GetProperty(ref _preset1);
			set => SetProperty(ref _preset1, value);
		}

		[Ordinal(31)] 
		[RED("preset2")] 
		public inkWidgetReference Preset2
		{
			get => GetProperty(ref _preset2);
			set => SetProperty(ref _preset2, value);
		}

		[Ordinal(32)] 
		[RED("preset3")] 
		public inkWidgetReference Preset3
		{
			get => GetProperty(ref _preset3);
			set => SetProperty(ref _preset3, value);
		}

		[Ordinal(33)] 
		[RED("randomize")] 
		public inkWidgetReference Randomize
		{
			get => GetProperty(ref _randomize);
			set => SetProperty(ref _randomize, value);
		}

		[Ordinal(34)] 
		[RED("randomizeBg")] 
		public inkImageWidgetReference RandomizeBg
		{
			get => GetProperty(ref _randomizeBg);
			set => SetProperty(ref _randomizeBg, value);
		}

		[Ordinal(35)] 
		[RED("randomizationSettingsButton")] 
		public inkWidgetReference RandomizationSettingsButton
		{
			get => GetProperty(ref _randomizationSettingsButton);
			set => SetProperty(ref _randomizationSettingsButton, value);
		}

		[Ordinal(36)] 
		[RED("randomizationSettingsWidget")] 
		public inkWidgetReference RandomizationSettingsWidget
		{
			get => GetProperty(ref _randomizationSettingsWidget);
			set => SetProperty(ref _randomizationSettingsWidget, value);
		}

		[Ordinal(37)] 
		[RED("randomizationSettingsController")] 
		public wCHandle<gameuiCharacterRandomizationController> RandomizationSettingsController
		{
			get => GetProperty(ref _randomizationSettingsController);
			set => SetProperty(ref _randomizationSettingsController, value);
		}

		[Ordinal(38)] 
		[RED("randomizationSettingsButtonBg")] 
		public inkImageWidgetReference RandomizationSettingsButtonBg
		{
			get => GetProperty(ref _randomizationSettingsButtonBg);
			set => SetProperty(ref _randomizationSettingsButtonBg, value);
		}

		[Ordinal(39)] 
		[RED("preset1Thumbnail")] 
		public inkImageWidgetReference Preset1Thumbnail
		{
			get => GetProperty(ref _preset1Thumbnail);
			set => SetProperty(ref _preset1Thumbnail, value);
		}

		[Ordinal(40)] 
		[RED("preset2Thumbnail")] 
		public inkImageWidgetReference Preset2Thumbnail
		{
			get => GetProperty(ref _preset2Thumbnail);
			set => SetProperty(ref _preset2Thumbnail, value);
		}

		[Ordinal(41)] 
		[RED("preset3Thumbnail")] 
		public inkImageWidgetReference Preset3Thumbnail
		{
			get => GetProperty(ref _preset3Thumbnail);
			set => SetProperty(ref _preset3Thumbnail, value);
		}

		[Ordinal(42)] 
		[RED("preset1Bg")] 
		public inkImageWidgetReference Preset1Bg
		{
			get => GetProperty(ref _preset1Bg);
			set => SetProperty(ref _preset1Bg, value);
		}

		[Ordinal(43)] 
		[RED("preset2Bg")] 
		public inkImageWidgetReference Preset2Bg
		{
			get => GetProperty(ref _preset2Bg);
			set => SetProperty(ref _preset2Bg, value);
		}

		[Ordinal(44)] 
		[RED("preset3Bg")] 
		public inkImageWidgetReference Preset3Bg
		{
			get => GetProperty(ref _preset3Bg);
			set => SetProperty(ref _preset3Bg, value);
		}

		[Ordinal(45)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get => GetProperty(ref _navigationButtons);
			set => SetProperty(ref _navigationButtons, value);
		}

		[Ordinal(46)] 
		[RED("hideColorPickerNextFrame")] 
		public CBool HideColorPickerNextFrame
		{
			get => GetProperty(ref _hideColorPickerNextFrame);
			set => SetProperty(ref _hideColorPickerNextFrame, value);
		}

		[Ordinal(47)] 
		[RED("colorPickerOwner")] 
		public wCHandle<inkWidget> ColorPickerOwner
		{
			get => GetProperty(ref _colorPickerOwner);
			set => SetProperty(ref _colorPickerOwner, value);
		}

		[Ordinal(48)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(49)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get => GetProperty(ref _confirmAnimationProxy);
			set => SetProperty(ref _confirmAnimationProxy, value);
		}

		[Ordinal(50)] 
		[RED("optionListAnimationProxy")] 
		public CHandle<inkanimProxy> OptionListAnimationProxy
		{
			get => GetProperty(ref _optionListAnimationProxy);
			set => SetProperty(ref _optionListAnimationProxy, value);
		}

		[Ordinal(51)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get => GetProperty(ref _optionsListInitialized);
			set => SetProperty(ref _optionsListInitialized, value);
		}

		[Ordinal(52)] 
		[RED("introPlayed")] 
		public CBool IntroPlayed
		{
			get => GetProperty(ref _introPlayed);
			set => SetProperty(ref _introPlayed, value);
		}

		[Ordinal(53)] 
		[RED("navigationControllers")] 
		public CArray<wCHandle<inkDiscreteNavigationController>> NavigationControllers
		{
			get => GetProperty(ref _navigationControllers);
			set => SetProperty(ref _navigationControllers, value);
		}

		[Ordinal(54)] 
		[RED("presetsNavigationControllers")] 
		public CArray<wCHandle<inkDiscreteNavigationController>> PresetsNavigationControllers
		{
			get => GetProperty(ref _presetsNavigationControllers);
			set => SetProperty(ref _presetsNavigationControllers, value);
		}

		[Ordinal(55)] 
		[RED("menuListController")] 
		public wCHandle<inkListController> MenuListController
		{
			get => GetProperty(ref _menuListController);
			set => SetProperty(ref _menuListController, value);
		}

		[Ordinal(56)] 
		[RED("cachedCursor")] 
		public wCHandle<inkWidget> CachedCursor
		{
			get => GetProperty(ref _cachedCursor);
			set => SetProperty(ref _cachedCursor, value);
		}

		[Ordinal(57)] 
		[RED("updatingFinalizedState")] 
		public CBool UpdatingFinalizedState
		{
			get => GetProperty(ref _updatingFinalizedState);
			set => SetProperty(ref _updatingFinalizedState, value);
		}

		[Ordinal(58)] 
		[RED("editMode")] 
		public CEnum<gameuiCharacterCustomizationEditTag> EditMode
		{
			get => GetProperty(ref _editMode);
			set => SetProperty(ref _editMode, value);
		}

		[Ordinal(59)] 
		[RED("busySwitchingAppearance")] 
		public CEnum<BusySwitchingReason> BusySwitchingAppearance
		{
			get => GetProperty(ref _busySwitchingAppearance);
			set => SetProperty(ref _busySwitchingAppearance, value);
		}

		[Ordinal(60)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(61)] 
		[RED("sliderController")] 
		public wCHandle<inkSliderController> SliderController
		{
			get => GetProperty(ref _sliderController);
			set => SetProperty(ref _sliderController, value);
		}

		[Ordinal(62)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetProperty(ref _inputDisabled);
			set => SetProperty(ref _inputDisabled, value);
		}

		[Ordinal(63)] 
		[RED("introComplete")] 
		public CBool IntroComplete
		{
			get => GetProperty(ref _introComplete);
			set => SetProperty(ref _introComplete, value);
		}

		[Ordinal(64)] 
		[RED("isPresetHoveredOver")] 
		public CBool IsPresetHoveredOver
		{
			get => GetProperty(ref _isPresetHoveredOver);
			set => SetProperty(ref _isPresetHoveredOver, value);
		}

		[Ordinal(65)] 
		[RED("randomizationSettingsNavController")] 
		public wCHandle<inkDiscreteNavigationController> RandomizationSettingsNavController
		{
			get => GetProperty(ref _randomizationSettingsNavController);
			set => SetProperty(ref _randomizationSettingsNavController, value);
		}

		[Ordinal(66)] 
		[RED("randomizationNavController")] 
		public wCHandle<inkDiscreteNavigationController> RandomizationNavController
		{
			get => GetProperty(ref _randomizationNavController);
			set => SetProperty(ref _randomizationNavController, value);
		}

		[Ordinal(67)] 
		[RED("maxColorPickerHeight")] 
		public CFloat MaxColorPickerHeight
		{
			get => GetProperty(ref _maxColorPickerHeight);
			set => SetProperty(ref _maxColorPickerHeight, value);
		}

		[Ordinal(68)] 
		[RED("minColorPickerHeight")] 
		public CFloat MinColorPickerHeight
		{
			get => GetProperty(ref _minColorPickerHeight);
			set => SetProperty(ref _minColorPickerHeight, value);
		}

		[Ordinal(69)] 
		[RED("colorPickerHeightPerRow")] 
		public CFloat ColorPickerHeightPerRow
		{
			get => GetProperty(ref _colorPickerHeightPerRow);
			set => SetProperty(ref _colorPickerHeightPerRow, value);
		}

		public characterCreationBodyMorphMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
