using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExpansionErrorPopupController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _errorCodeText;
		private inkWidgetReference _closeButtonRef;
		private CName _introAnimationName;
		private CName _outroAnimationName;
		private CHandle<ExpansionErrorPopuppData> _data;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(4)] 
		[RED("errorCodeText")] 
		public inkTextWidgetReference ErrorCodeText
		{
			get => GetProperty(ref _errorCodeText);
			set => SetProperty(ref _errorCodeText, value);
		}

		[Ordinal(5)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetProperty(ref _closeButtonRef);
			set => SetProperty(ref _closeButtonRef, value);
		}

		[Ordinal(6)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(7)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetProperty(ref _outroAnimationName);
			set => SetProperty(ref _outroAnimationName, value);
		}

		[Ordinal(8)] 
		[RED("data")] 
		public CHandle<ExpansionErrorPopuppData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(9)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public ExpansionErrorPopupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
