using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocFillBar : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _root;
		private CFloat _fillStart;
		private CFloat _fillEnd;
		private Vector2 _maxSize;
		private CHandle<inkanimProxy> _sizeAnimation;
		private CHandle<inkanimProxy> _marginAnimation;

		[Ordinal(1)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("fillStart")] 
		public CFloat FillStart
		{
			get => GetProperty(ref _fillStart);
			set => SetProperty(ref _fillStart, value);
		}

		[Ordinal(3)] 
		[RED("fillEnd")] 
		public CFloat FillEnd
		{
			get => GetProperty(ref _fillEnd);
			set => SetProperty(ref _fillEnd, value);
		}

		[Ordinal(4)] 
		[RED("maxSize")] 
		public Vector2 MaxSize
		{
			get => GetProperty(ref _maxSize);
			set => SetProperty(ref _maxSize, value);
		}

		[Ordinal(5)] 
		[RED("sizeAnimation")] 
		public CHandle<inkanimProxy> SizeAnimation
		{
			get => GetProperty(ref _sizeAnimation);
			set => SetProperty(ref _sizeAnimation, value);
		}

		[Ordinal(6)] 
		[RED("marginAnimation")] 
		public CHandle<inkanimProxy> MarginAnimation
		{
			get => GetProperty(ref _marginAnimation);
			set => SetProperty(ref _marginAnimation, value);
		}

		public RipperdocFillBar(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
