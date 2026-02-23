using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarButton : inkWidgetLogicController
	{
		private inkWidgetReference _craftingFill;
		private inkTextWidgetReference _craftingLabel;
		private inkWidgetReference _craftingIconGlyph;
		private wCHandle<inkButtonController> _buttonController;
		private wCHandle<ProgressBarsController> _progressController;
		private CBool _available;
		private CFloat _progress;
		private CBool _isLocked;
		private CBool _justFinished;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("craftingFill")] 
		public inkWidgetReference CraftingFill
		{
			get => GetProperty(ref _craftingFill);
			set => SetProperty(ref _craftingFill, value);
		}

		[Ordinal(2)] 
		[RED("craftingLabel")] 
		public inkTextWidgetReference CraftingLabel
		{
			get => GetProperty(ref _craftingLabel);
			set => SetProperty(ref _craftingLabel, value);
		}

		[Ordinal(3)] 
		[RED("craftingIconGlyph")] 
		public inkWidgetReference CraftingIconGlyph
		{
			get => GetProperty(ref _craftingIconGlyph);
			set => SetProperty(ref _craftingIconGlyph, value);
		}

		[Ordinal(4)] 
		[RED("ButtonController")] 
		public wCHandle<inkButtonController> ButtonController
		{
			get => GetProperty(ref _buttonController);
			set => SetProperty(ref _buttonController, value);
		}

		[Ordinal(5)] 
		[RED("progressController")] 
		public wCHandle<ProgressBarsController> ProgressController
		{
			get => GetProperty(ref _progressController);
			set => SetProperty(ref _progressController, value);
		}

		[Ordinal(6)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetProperty(ref _available);
			set => SetProperty(ref _available, value);
		}

		[Ordinal(7)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(8)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(9)] 
		[RED("justFinished")] 
		public CBool JustFinished
		{
			get => GetProperty(ref _justFinished);
			set => SetProperty(ref _justFinished, value);
		}

		[Ordinal(10)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public ProgressBarButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
