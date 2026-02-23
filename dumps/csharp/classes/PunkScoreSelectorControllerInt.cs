using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PunkScoreSelectorControllerInt : inkWidgetLogicController
	{
		private inkWidgetReference _sliderWidget;
		private inkWidgetReference _labelMinWidget;
		private inkWidgetReference _labelMaxWidget;
		private wCHandle<inkWidget> _rootWidget;
		private CInt32 _newValue;
		private CInt32 _localValue;
		private CBool _inputDisabled;
		private wCHandle<inkSliderController> _sliderController;
		private wCHandle<inkButtonController> _sliderButtonController;
		private inkWidgetReference _sliderAreaWidget;
		private inkWidgetReference _sliderHandleWidget;
		private inkTextWidgetReference _valueText;
		private inkWidgetReference _leftArrow;
		private inkWidgetReference _rightArrow;
		private inkWidgetReference _hintsContainer;

		[Ordinal(1)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetProperty(ref _sliderWidget);
			set => SetProperty(ref _sliderWidget, value);
		}

		[Ordinal(2)] 
		[RED("labelMinWidget")] 
		public inkWidgetReference LabelMinWidget
		{
			get => GetProperty(ref _labelMinWidget);
			set => SetProperty(ref _labelMinWidget, value);
		}

		[Ordinal(3)] 
		[RED("labelMaxWidget")] 
		public inkWidgetReference LabelMaxWidget
		{
			get => GetProperty(ref _labelMaxWidget);
			set => SetProperty(ref _labelMaxWidget, value);
		}

		[Ordinal(4)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(5)] 
		[RED("newValue")] 
		public CInt32 NewValue
		{
			get => GetProperty(ref _newValue);
			set => SetProperty(ref _newValue, value);
		}

		[Ordinal(6)] 
		[RED("localValue")] 
		public CInt32 LocalValue
		{
			get => GetProperty(ref _localValue);
			set => SetProperty(ref _localValue, value);
		}

		[Ordinal(7)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetProperty(ref _inputDisabled);
			set => SetProperty(ref _inputDisabled, value);
		}

		[Ordinal(8)] 
		[RED("sliderController")] 
		public wCHandle<inkSliderController> SliderController
		{
			get => GetProperty(ref _sliderController);
			set => SetProperty(ref _sliderController, value);
		}

		[Ordinal(9)] 
		[RED("sliderButtonController")] 
		public wCHandle<inkButtonController> SliderButtonController
		{
			get => GetProperty(ref _sliderButtonController);
			set => SetProperty(ref _sliderButtonController, value);
		}

		[Ordinal(10)] 
		[RED("sliderAreaWidget")] 
		public inkWidgetReference SliderAreaWidget
		{
			get => GetProperty(ref _sliderAreaWidget);
			set => SetProperty(ref _sliderAreaWidget, value);
		}

		[Ordinal(11)] 
		[RED("sliderHandleWidget")] 
		public inkWidgetReference SliderHandleWidget
		{
			get => GetProperty(ref _sliderHandleWidget);
			set => SetProperty(ref _sliderHandleWidget, value);
		}

		[Ordinal(12)] 
		[RED("ValueText")] 
		public inkTextWidgetReference ValueText
		{
			get => GetProperty(ref _valueText);
			set => SetProperty(ref _valueText, value);
		}

		[Ordinal(13)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetProperty(ref _leftArrow);
			set => SetProperty(ref _leftArrow, value);
		}

		[Ordinal(14)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetProperty(ref _rightArrow);
			set => SetProperty(ref _rightArrow, value);
		}

		[Ordinal(15)] 
		[RED("HintsContainer")] 
		public inkWidgetReference HintsContainer
		{
			get => GetProperty(ref _hintsContainer);
			set => SetProperty(ref _hintsContainer, value);
		}

		public PunkScoreSelectorControllerInt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
