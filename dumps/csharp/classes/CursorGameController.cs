using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CursorGameController : gameuiWidgetGameController
	{
		private wCHandle<CursorRootController> _cursorRoot;
		private CName _currentContext;
		private inkMargin _margin;
		private CHandle<MenuCursorUserData> _data;
		private CBool _isCursorVisible;
		private CName _cursorType;
		private CName _cursorForDevice;
		private CHandle<inkanimProxy> _dpadAnimProxy;
		private CHandle<inkanimProxy> _clickAnimProxy;

		[Ordinal(2)] 
		[RED("cursorRoot")] 
		public wCHandle<CursorRootController> CursorRoot
		{
			get => GetProperty(ref _cursorRoot);
			set => SetProperty(ref _cursorRoot, value);
		}

		[Ordinal(3)] 
		[RED("currentContext")] 
		public CName CurrentContext
		{
			get => GetProperty(ref _currentContext);
			set => SetProperty(ref _currentContext, value);
		}

		[Ordinal(4)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<MenuCursorUserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(6)] 
		[RED("isCursorVisible")] 
		public CBool IsCursorVisible
		{
			get => GetProperty(ref _isCursorVisible);
			set => SetProperty(ref _isCursorVisible, value);
		}

		[Ordinal(7)] 
		[RED("cursorType")] 
		public CName CursorType
		{
			get => GetProperty(ref _cursorType);
			set => SetProperty(ref _cursorType, value);
		}

		[Ordinal(8)] 
		[RED("cursorForDevice")] 
		public CName CursorForDevice
		{
			get => GetProperty(ref _cursorForDevice);
			set => SetProperty(ref _cursorForDevice, value);
		}

		[Ordinal(9)] 
		[RED("dpadAnimProxy")] 
		public CHandle<inkanimProxy> DpadAnimProxy
		{
			get => GetProperty(ref _dpadAnimProxy);
			set => SetProperty(ref _dpadAnimProxy, value);
		}

		[Ordinal(10)] 
		[RED("clickAnimProxy")] 
		public CHandle<inkanimProxy> ClickAnimProxy
		{
			get => GetProperty(ref _clickAnimProxy);
			set => SetProperty(ref _clickAnimProxy, value);
		}

		public CursorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
