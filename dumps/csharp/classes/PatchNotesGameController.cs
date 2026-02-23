using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PatchNotesGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _notesContainerRef;
		private inkWidgetReference _patch20TitleContainerRef;
		private inkWidgetReference _patch21TitleContainerRef;
		private inkWidgetReference _patch22TitleContainerRef;
		private inkWidgetReference _patch23TitleContainerRef;
		private CName _itemLibraryName;
		private CName _introAnimationName;
		private CName _outroAnimationName;
		private inkWidgetReference _closeButtonRef;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CHandle<inkanimProxy> _introAnimProxy;
		private CBool _isInputBlocked;
		private CHandle<PatchNotesPopupData> _data;
		private wCHandle<inkISystemRequestsHandler> _requestHandler;

		[Ordinal(2)] 
		[RED("notesContainerRef")] 
		public inkCompoundWidgetReference NotesContainerRef
		{
			get => GetProperty(ref _notesContainerRef);
			set => SetProperty(ref _notesContainerRef, value);
		}

		[Ordinal(3)] 
		[RED("patch20TitleContainerRef")] 
		public inkWidgetReference Patch20TitleContainerRef
		{
			get => GetProperty(ref _patch20TitleContainerRef);
			set => SetProperty(ref _patch20TitleContainerRef, value);
		}

		[Ordinal(4)] 
		[RED("patch21TitleContainerRef")] 
		public inkWidgetReference Patch21TitleContainerRef
		{
			get => GetProperty(ref _patch21TitleContainerRef);
			set => SetProperty(ref _patch21TitleContainerRef, value);
		}

		[Ordinal(5)] 
		[RED("patch22TitleContainerRef")] 
		public inkWidgetReference Patch22TitleContainerRef
		{
			get => GetProperty(ref _patch22TitleContainerRef);
			set => SetProperty(ref _patch22TitleContainerRef, value);
		}

		[Ordinal(6)] 
		[RED("patch23TitleContainerRef")] 
		public inkWidgetReference Patch23TitleContainerRef
		{
			get => GetProperty(ref _patch23TitleContainerRef);
			set => SetProperty(ref _patch23TitleContainerRef, value);
		}

		[Ordinal(7)] 
		[RED("itemLibraryName")] 
		public CName ItemLibraryName
		{
			get => GetProperty(ref _itemLibraryName);
			set => SetProperty(ref _itemLibraryName, value);
		}

		[Ordinal(8)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(9)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetProperty(ref _outroAnimationName);
			set => SetProperty(ref _outroAnimationName, value);
		}

		[Ordinal(10)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetProperty(ref _closeButtonRef);
			set => SetProperty(ref _closeButtonRef, value);
		}

		[Ordinal(11)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(12)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(13)] 
		[RED("isInputBlocked")] 
		public CBool IsInputBlocked
		{
			get => GetProperty(ref _isInputBlocked);
			set => SetProperty(ref _isInputBlocked, value);
		}

		[Ordinal(14)] 
		[RED("data")] 
		public CHandle<PatchNotesPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(15)] 
		[RED("requestHandler")] 
		public wCHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetProperty(ref _requestHandler);
			set => SetProperty(ref _requestHandler, value);
		}

		public PatchNotesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
