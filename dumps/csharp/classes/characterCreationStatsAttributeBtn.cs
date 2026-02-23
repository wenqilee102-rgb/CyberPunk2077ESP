using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationStatsAttributeBtn : inkWidgetLogicController
	{
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _buttons;
		private inkImageWidgetReference _selector;
		private inkWidgetReference _addBtnhitArea;
		private inkWidgetReference _minusBtnhitArea;
		private inkWidgetReference _minMaxLabel;
		private inkTextWidgetReference _minMaxLabelText;
		private CHandle<CharacterCreationAttributeData> _data;
		private CBool _animating;
		private CBool _minusEnabled;
		private CBool _addEnabled;
		private CBool _maxed;
		private CBool _isPlusOrMinusBtnHoveredOver;
		private CBool _inputDisabled;

		[Ordinal(1)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(4)] 
		[RED("buttons")] 
		public inkImageWidgetReference Buttons
		{
			get => GetProperty(ref _buttons);
			set => SetProperty(ref _buttons, value);
		}

		[Ordinal(5)] 
		[RED("selector")] 
		public inkImageWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(6)] 
		[RED("addBtnhitArea")] 
		public inkWidgetReference AddBtnhitArea
		{
			get => GetProperty(ref _addBtnhitArea);
			set => SetProperty(ref _addBtnhitArea, value);
		}

		[Ordinal(7)] 
		[RED("minusBtnhitArea")] 
		public inkWidgetReference MinusBtnhitArea
		{
			get => GetProperty(ref _minusBtnhitArea);
			set => SetProperty(ref _minusBtnhitArea, value);
		}

		[Ordinal(8)] 
		[RED("minMaxLabel")] 
		public inkWidgetReference MinMaxLabel
		{
			get => GetProperty(ref _minMaxLabel);
			set => SetProperty(ref _minMaxLabel, value);
		}

		[Ordinal(9)] 
		[RED("minMaxLabelText")] 
		public inkTextWidgetReference MinMaxLabelText
		{
			get => GetProperty(ref _minMaxLabelText);
			set => SetProperty(ref _minMaxLabelText, value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<CharacterCreationAttributeData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(11)] 
		[RED("animating")] 
		public CBool Animating
		{
			get => GetProperty(ref _animating);
			set => SetProperty(ref _animating, value);
		}

		[Ordinal(12)] 
		[RED("minusEnabled")] 
		public CBool MinusEnabled
		{
			get => GetProperty(ref _minusEnabled);
			set => SetProperty(ref _minusEnabled, value);
		}

		[Ordinal(13)] 
		[RED("addEnabled")] 
		public CBool AddEnabled
		{
			get => GetProperty(ref _addEnabled);
			set => SetProperty(ref _addEnabled, value);
		}

		[Ordinal(14)] 
		[RED("maxed")] 
		public CBool Maxed
		{
			get => GetProperty(ref _maxed);
			set => SetProperty(ref _maxed, value);
		}

		[Ordinal(15)] 
		[RED("isPlusOrMinusBtnHoveredOver")] 
		public CBool IsPlusOrMinusBtnHoveredOver
		{
			get => GetProperty(ref _isPlusOrMinusBtnHoveredOver);
			set => SetProperty(ref _isPlusOrMinusBtnHoveredOver, value);
		}

		[Ordinal(16)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetProperty(ref _inputDisabled);
			set => SetProperty(ref _inputDisabled, value);
		}

		public characterCreationStatsAttributeBtn(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
