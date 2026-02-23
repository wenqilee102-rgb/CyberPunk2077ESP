using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocFillLabel : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private CBool _useMargin;
		private wCHandle<inkWidget> _root;
		private wCHandle<inkTextValueProgressAnimationController> _labelAnimator;
		private CFloat _height;
		private Vector2 _startSize;
		private CHandle<inkanimProxy> _positionAnimation;
		private CHandle<inkanimProxy> _labelAnimation;
		private CFloat _labelValue;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("useMargin")] 
		public CBool UseMargin
		{
			get => GetProperty(ref _useMargin);
			set => SetProperty(ref _useMargin, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(4)] 
		[RED("labelAnimator")] 
		public wCHandle<inkTextValueProgressAnimationController> LabelAnimator
		{
			get => GetProperty(ref _labelAnimator);
			set => SetProperty(ref _labelAnimator, value);
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(6)] 
		[RED("startSize")] 
		public Vector2 StartSize
		{
			get => GetProperty(ref _startSize);
			set => SetProperty(ref _startSize, value);
		}

		[Ordinal(7)] 
		[RED("positionAnimation")] 
		public CHandle<inkanimProxy> PositionAnimation
		{
			get => GetProperty(ref _positionAnimation);
			set => SetProperty(ref _positionAnimation, value);
		}

		[Ordinal(8)] 
		[RED("labelAnimation")] 
		public CHandle<inkanimProxy> LabelAnimation
		{
			get => GetProperty(ref _labelAnimation);
			set => SetProperty(ref _labelAnimation, value);
		}

		[Ordinal(9)] 
		[RED("labelValue")] 
		public CFloat LabelValue
		{
			get => GetProperty(ref _labelValue);
			set => SetProperty(ref _labelValue, value);
		}

		public RipperdocFillLabel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
