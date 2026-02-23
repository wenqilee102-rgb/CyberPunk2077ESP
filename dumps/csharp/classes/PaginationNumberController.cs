using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaginationNumberController : inkWidgetLogicController
	{
		private inkTextWidgetReference _numberText;
		private inkWidgetReference _line;
		private CInt32 _pageNumber;
		private CBool _isActiveNumber;

		[Ordinal(1)] 
		[RED("numberText")] 
		public inkTextWidgetReference NumberText
		{
			get => GetProperty(ref _numberText);
			set => SetProperty(ref _numberText, value);
		}

		[Ordinal(2)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetProperty(ref _line);
			set => SetProperty(ref _line, value);
		}

		[Ordinal(3)] 
		[RED("pageNumber")] 
		public CInt32 PageNumber
		{
			get => GetProperty(ref _pageNumber);
			set => SetProperty(ref _pageNumber, value);
		}

		[Ordinal(4)] 
		[RED("isActiveNumber")] 
		public CBool IsActiveNumber
		{
			get => GetProperty(ref _isActiveNumber);
			set => SetProperty(ref _isActiveNumber, value);
		}

		public PaginationNumberController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
