using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDeathMenuGameController : gameuiMenuItemListGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<inkanimProxy> _animIntro;
		private CBool _axisInputReceived;
		private CBool _dpadInputReceived;

		[Ordinal(6)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(8)] 
		[RED("animIntro")] 
		public CHandle<inkanimProxy> AnimIntro
		{
			get => GetProperty(ref _animIntro);
			set => SetProperty(ref _animIntro, value);
		}

		[Ordinal(9)] 
		[RED("axisInputReceived")] 
		public CBool AxisInputReceived
		{
			get => GetProperty(ref _axisInputReceived);
			set => SetProperty(ref _axisInputReceived, value);
		}

		[Ordinal(10)] 
		[RED("dpadInputReceived")] 
		public CBool DpadInputReceived
		{
			get => GetProperty(ref _dpadInputReceived);
			set => SetProperty(ref _dpadInputReceived, value);
		}

		public gameuiDeathMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
