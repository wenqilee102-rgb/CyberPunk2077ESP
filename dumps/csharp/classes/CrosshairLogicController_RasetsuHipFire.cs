using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairLogicController_RasetsuHipFire : inkWidgetLogicController
	{
		private CFloat _offsetLeftRight;
		private CFloat _latchVertical;
		private inkWidgetReference _topPart;
		private inkWidgetReference _bottomPart;
		private inkWidgetReference _horiPart;
		private inkWidgetReference _vertPart;
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private inkWidgetReference _targetColorChange;

		[Ordinal(1)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetProperty(ref _offsetLeftRight);
			set => SetProperty(ref _offsetLeftRight, value);
		}

		[Ordinal(2)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetProperty(ref _latchVertical);
			set => SetProperty(ref _latchVertical, value);
		}

		[Ordinal(3)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(4)] 
		[RED("bottomPart")] 
		public inkWidgetReference BottomPart
		{
			get => GetProperty(ref _bottomPart);
			set => SetProperty(ref _bottomPart, value);
		}

		[Ordinal(5)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetProperty(ref _horiPart);
			set => SetProperty(ref _horiPart, value);
		}

		[Ordinal(6)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetProperty(ref _vertPart);
			set => SetProperty(ref _vertPart, value);
		}

		[Ordinal(7)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(8)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(9)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		public CrosshairLogicController_RasetsuHipFire(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
