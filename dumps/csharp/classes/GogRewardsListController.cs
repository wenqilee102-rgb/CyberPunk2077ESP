using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRewardsListController : inkWidgetLogicController
	{
		private inkWidgetReference _containerWidget;
		private inkWidgetReference _scrollArea;
		private inkWidgetReference _sizeRefWrapper;
		private CInt32 _scrollBarRequiredHeight;
		private CBool _shouldUpdateLayout;

		[Ordinal(1)] 
		[RED("containerWidget")] 
		public inkWidgetReference ContainerWidget
		{
			get => GetProperty(ref _containerWidget);
			set => SetProperty(ref _containerWidget, value);
		}

		[Ordinal(2)] 
		[RED("scrollArea")] 
		public inkWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(3)] 
		[RED("sizeRefWrapper")] 
		public inkWidgetReference SizeRefWrapper
		{
			get => GetProperty(ref _sizeRefWrapper);
			set => SetProperty(ref _sizeRefWrapper, value);
		}

		[Ordinal(4)] 
		[RED("scrollBarRequiredHeight")] 
		public CInt32 ScrollBarRequiredHeight
		{
			get => GetProperty(ref _scrollBarRequiredHeight);
			set => SetProperty(ref _scrollBarRequiredHeight, value);
		}

		[Ordinal(5)] 
		[RED("shouldUpdateLayout")] 
		public CBool ShouldUpdateLayout
		{
			get => GetProperty(ref _shouldUpdateLayout);
			set => SetProperty(ref _shouldUpdateLayout, value);
		}

		public GogRewardsListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
