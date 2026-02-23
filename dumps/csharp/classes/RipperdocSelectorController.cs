using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocSelectorController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkWidgetReference _leftArrowAnchor;
		private inkWidgetReference _rightArrowAnchor;
		private CArray<inkWidgetReference> _indicatorAnchors;
		private wCHandle<inkButtonController> _leftArrow;
		private wCHandle<inkButtonController> _rightArrow;
		private CInt32 _indicatorIndex;
		private CHandle<inkanimProxy> _indicatorShowAnim;
		private CHandle<inkanimProxy> _indicatorHideAnim;
		private CBool _isInTutorial;
		private CArray<CString> _names;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("leftArrowAnchor")] 
		public inkWidgetReference LeftArrowAnchor
		{
			get => GetProperty(ref _leftArrowAnchor);
			set => SetProperty(ref _leftArrowAnchor, value);
		}

		[Ordinal(3)] 
		[RED("rightArrowAnchor")] 
		public inkWidgetReference RightArrowAnchor
		{
			get => GetProperty(ref _rightArrowAnchor);
			set => SetProperty(ref _rightArrowAnchor, value);
		}

		[Ordinal(4)] 
		[RED("indicatorAnchors")] 
		public CArray<inkWidgetReference> IndicatorAnchors
		{
			get => GetProperty(ref _indicatorAnchors);
			set => SetProperty(ref _indicatorAnchors, value);
		}

		[Ordinal(5)] 
		[RED("leftArrow")] 
		public wCHandle<inkButtonController> LeftArrow
		{
			get => GetProperty(ref _leftArrow);
			set => SetProperty(ref _leftArrow, value);
		}

		[Ordinal(6)] 
		[RED("rightArrow")] 
		public wCHandle<inkButtonController> RightArrow
		{
			get => GetProperty(ref _rightArrow);
			set => SetProperty(ref _rightArrow, value);
		}

		[Ordinal(7)] 
		[RED("indicatorIndex")] 
		public CInt32 IndicatorIndex
		{
			get => GetProperty(ref _indicatorIndex);
			set => SetProperty(ref _indicatorIndex, value);
		}

		[Ordinal(8)] 
		[RED("indicatorShowAnim")] 
		public CHandle<inkanimProxy> IndicatorShowAnim
		{
			get => GetProperty(ref _indicatorShowAnim);
			set => SetProperty(ref _indicatorShowAnim, value);
		}

		[Ordinal(9)] 
		[RED("indicatorHideAnim")] 
		public CHandle<inkanimProxy> IndicatorHideAnim
		{
			get => GetProperty(ref _indicatorHideAnim);
			set => SetProperty(ref _indicatorHideAnim, value);
		}

		[Ordinal(10)] 
		[RED("isInTutorial")] 
		public CBool IsInTutorial
		{
			get => GetProperty(ref _isInTutorial);
			set => SetProperty(ref _isInTutorial, value);
		}

		[Ordinal(11)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		public RipperdocSelectorController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
