using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaginationController : inkWidgetLogicController
	{
		private inkHorizontalPanelWidgetReference _paginationRoot;
		private inkWidgetReference _nextArrow;
		private inkWidgetReference _previousArrow;
		private CArray<wCHandle<PaginationNumberController>> _paginationNumbers;
		private CInt32 _halfPaginationDisplay;
		private CInt32 _fullPaginationDisplay;

		[Ordinal(1)] 
		[RED("paginationRoot")] 
		public inkHorizontalPanelWidgetReference PaginationRoot
		{
			get => GetProperty(ref _paginationRoot);
			set => SetProperty(ref _paginationRoot, value);
		}

		[Ordinal(2)] 
		[RED("nextArrow")] 
		public inkWidgetReference NextArrow
		{
			get => GetProperty(ref _nextArrow);
			set => SetProperty(ref _nextArrow, value);
		}

		[Ordinal(3)] 
		[RED("previousArrow")] 
		public inkWidgetReference PreviousArrow
		{
			get => GetProperty(ref _previousArrow);
			set => SetProperty(ref _previousArrow, value);
		}

		[Ordinal(4)] 
		[RED("paginationNumbers")] 
		public CArray<wCHandle<PaginationNumberController>> PaginationNumbers
		{
			get => GetProperty(ref _paginationNumbers);
			set => SetProperty(ref _paginationNumbers, value);
		}

		[Ordinal(5)] 
		[RED("halfPaginationDisplay")] 
		public CInt32 HalfPaginationDisplay
		{
			get => GetProperty(ref _halfPaginationDisplay);
			set => SetProperty(ref _halfPaginationDisplay, value);
		}

		[Ordinal(6)] 
		[RED("fullPaginationDisplay")] 
		public CInt32 FullPaginationDisplay
		{
			get => GetProperty(ref _fullPaginationDisplay);
			set => SetProperty(ref _fullPaginationDisplay, value);
		}

		public PaginationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
