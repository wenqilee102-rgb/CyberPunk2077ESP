using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleColorSelectorPointerDef : CVariable
	{
		private inkWidgetReference _pointerRoot;
		private CFloat _pointerCircleRadius;
		private CFloat _selectionMargin;
		private CBool _paintOnSelection;
		private inkWidgetReference _partToPaint;

		[Ordinal(0)] 
		[RED("pointerRoot")] 
		public inkWidgetReference PointerRoot
		{
			get => GetProperty(ref _pointerRoot);
			set => SetProperty(ref _pointerRoot, value);
		}

		[Ordinal(1)] 
		[RED("pointerCircleRadius")] 
		public CFloat PointerCircleRadius
		{
			get => GetProperty(ref _pointerCircleRadius);
			set => SetProperty(ref _pointerCircleRadius, value);
		}

		[Ordinal(2)] 
		[RED("selectionMargin")] 
		public CFloat SelectionMargin
		{
			get => GetProperty(ref _selectionMargin);
			set => SetProperty(ref _selectionMargin, value);
		}

		[Ordinal(3)] 
		[RED("paintOnSelection")] 
		public CBool PaintOnSelection
		{
			get => GetProperty(ref _paintOnSelection);
			set => SetProperty(ref _paintOnSelection, value);
		}

		[Ordinal(4)] 
		[RED("partToPaint")] 
		public inkWidgetReference PartToPaint
		{
			get => GetProperty(ref _partToPaint);
			set => SetProperty(ref _partToPaint, value);
		}

		public vehicleColorSelectorPointerDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
