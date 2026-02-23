using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NumericDispalyUIController : DeviceInkGameControllerBase
	{
		private inkTextWidgetReference _currentNumberTextWidget;
		private inkWidgetReference _upArrowWidget;
		private inkWidgetReference _downArrowWidget;
		private CName _idleAnimName;
		private CName _goingUpAnimName;
		private CName _goingDownAnimName;
		private CHandle<inkanimProxy> _idleAnim;
		private CHandle<inkanimProxy> _goingDownAnim;
		private CHandle<inkanimProxy> _goingUpAnim;
		private CHandle<redCallbackObject> _onNumberChangedListener;
		private CHandle<redCallbackObject> _onDirectionChangedListener;

		[Ordinal(16)] 
		[RED("currentNumberTextWidget")] 
		public inkTextWidgetReference CurrentNumberTextWidget
		{
			get => GetProperty(ref _currentNumberTextWidget);
			set => SetProperty(ref _currentNumberTextWidget, value);
		}

		[Ordinal(17)] 
		[RED("upArrowWidget")] 
		public inkWidgetReference UpArrowWidget
		{
			get => GetProperty(ref _upArrowWidget);
			set => SetProperty(ref _upArrowWidget, value);
		}

		[Ordinal(18)] 
		[RED("downArrowWidget")] 
		public inkWidgetReference DownArrowWidget
		{
			get => GetProperty(ref _downArrowWidget);
			set => SetProperty(ref _downArrowWidget, value);
		}

		[Ordinal(19)] 
		[RED("idleAnimName")] 
		public CName IdleAnimName
		{
			get => GetProperty(ref _idleAnimName);
			set => SetProperty(ref _idleAnimName, value);
		}

		[Ordinal(20)] 
		[RED("goingUpAnimName")] 
		public CName GoingUpAnimName
		{
			get => GetProperty(ref _goingUpAnimName);
			set => SetProperty(ref _goingUpAnimName, value);
		}

		[Ordinal(21)] 
		[RED("goingDownAnimName")] 
		public CName GoingDownAnimName
		{
			get => GetProperty(ref _goingDownAnimName);
			set => SetProperty(ref _goingDownAnimName, value);
		}

		[Ordinal(22)] 
		[RED("idleAnim")] 
		public CHandle<inkanimProxy> IdleAnim
		{
			get => GetProperty(ref _idleAnim);
			set => SetProperty(ref _idleAnim, value);
		}

		[Ordinal(23)] 
		[RED("goingDownAnim")] 
		public CHandle<inkanimProxy> GoingDownAnim
		{
			get => GetProperty(ref _goingDownAnim);
			set => SetProperty(ref _goingDownAnim, value);
		}

		[Ordinal(24)] 
		[RED("goingUpAnim")] 
		public CHandle<inkanimProxy> GoingUpAnim
		{
			get => GetProperty(ref _goingUpAnim);
			set => SetProperty(ref _goingUpAnim, value);
		}

		[Ordinal(25)] 
		[RED("onNumberChangedListener")] 
		public CHandle<redCallbackObject> OnNumberChangedListener
		{
			get => GetProperty(ref _onNumberChangedListener);
			set => SetProperty(ref _onNumberChangedListener, value);
		}

		[Ordinal(26)] 
		[RED("onDirectionChangedListener")] 
		public CHandle<redCallbackObject> OnDirectionChangedListener
		{
			get => GetProperty(ref _onDirectionChangedListener);
			set => SetProperty(ref _onDirectionChangedListener, value);
		}

		public NumericDispalyUIController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
