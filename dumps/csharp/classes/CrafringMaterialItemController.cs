using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrafringMaterialItemController : BaseButtonView
	{
		private inkTextWidgetReference _nameText;
		private inkTextWidgetReference _quantityText;
		private inkTextWidgetReference _quantityChangeText;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _frame;
		private inkWidgetReference _tooltipAnchor;
		private CHandle<CachedCraftingMaterial> _data;
		private CInt32 _quantity;
		private CBool _hovered;
		private CEnum<CrafringMaterialItemHighlight> _lastState;
		private CBool _shouldBeHighlighted;
		private CBool _useSimpleFromat;
		private CBool _hideIfZero;
		private CBool _isCollapsed;

		[Ordinal(5)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
		}

		[Ordinal(6)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetProperty(ref _quantityText);
			set => SetProperty(ref _quantityText, value);
		}

		[Ordinal(7)] 
		[RED("quantityChangeText")] 
		public inkTextWidgetReference QuantityChangeText
		{
			get => GetProperty(ref _quantityChangeText);
			set => SetProperty(ref _quantityChangeText, value);
		}

		[Ordinal(8)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(9)] 
		[RED("frame")] 
		public inkWidgetReference Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(10)] 
		[RED("tooltipAnchor")] 
		public inkWidgetReference TooltipAnchor
		{
			get => GetProperty(ref _tooltipAnchor);
			set => SetProperty(ref _tooltipAnchor, value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<CachedCraftingMaterial> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(12)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(13)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(14)] 
		[RED("lastState")] 
		public CEnum<CrafringMaterialItemHighlight> LastState
		{
			get => GetProperty(ref _lastState);
			set => SetProperty(ref _lastState, value);
		}

		[Ordinal(15)] 
		[RED("shouldBeHighlighted")] 
		public CBool ShouldBeHighlighted
		{
			get => GetProperty(ref _shouldBeHighlighted);
			set => SetProperty(ref _shouldBeHighlighted, value);
		}

		[Ordinal(16)] 
		[RED("useSimpleFromat")] 
		public CBool UseSimpleFromat
		{
			get => GetProperty(ref _useSimpleFromat);
			set => SetProperty(ref _useSimpleFromat, value);
		}

		[Ordinal(17)] 
		[RED("hideIfZero")] 
		public CBool HideIfZero
		{
			get => GetProperty(ref _hideIfZero);
			set => SetProperty(ref _hideIfZero, value);
		}

		[Ordinal(18)] 
		[RED("isCollapsed")] 
		public CBool IsCollapsed
		{
			get => GetProperty(ref _isCollapsed);
			set => SetProperty(ref _isCollapsed, value);
		}

		public CrafringMaterialItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
