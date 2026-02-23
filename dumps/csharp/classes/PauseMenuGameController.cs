using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PauseMenuGameController : gameuiMenuItemListGameController
	{
		private inkCompoundWidgetReference _baseLogoContainer;
		private inkCompoundWidgetReference _ep1LogoContainer;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _expansionNotyficationRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private ScriptGameInstance _gameInstance;
		private CInt32 _savesCount;
		private CBool _quickSaveInProgress;
		private CBool _setCursorOnInit;
		private CBool _axisInputReceived;
		private CBool _dpadInputReceived;

		[Ordinal(6)] 
		[RED("baseLogoContainer")] 
		public inkCompoundWidgetReference BaseLogoContainer
		{
			get => GetProperty(ref _baseLogoContainer);
			set => SetProperty(ref _baseLogoContainer, value);
		}

		[Ordinal(7)] 
		[RED("ep1LogoContainer")] 
		public inkCompoundWidgetReference Ep1LogoContainer
		{
			get => GetProperty(ref _ep1LogoContainer);
			set => SetProperty(ref _ep1LogoContainer, value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(9)] 
		[RED("expansionNotyficationRef")] 
		public inkWidgetReference ExpansionNotyficationRef
		{
			get => GetProperty(ref _expansionNotyficationRef);
			set => SetProperty(ref _expansionNotyficationRef, value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(11)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(12)] 
		[RED("savesCount")] 
		public CInt32 SavesCount
		{
			get => GetProperty(ref _savesCount);
			set => SetProperty(ref _savesCount, value);
		}

		[Ordinal(13)] 
		[RED("quickSaveInProgress")] 
		public CBool QuickSaveInProgress
		{
			get => GetProperty(ref _quickSaveInProgress);
			set => SetProperty(ref _quickSaveInProgress, value);
		}

		[Ordinal(14)] 
		[RED("setCursorOnInit")] 
		public CBool SetCursorOnInit
		{
			get => GetProperty(ref _setCursorOnInit);
			set => SetProperty(ref _setCursorOnInit, value);
		}

		[Ordinal(15)] 
		[RED("axisInputReceived")] 
		public CBool AxisInputReceived
		{
			get => GetProperty(ref _axisInputReceived);
			set => SetProperty(ref _axisInputReceived, value);
		}

		[Ordinal(16)] 
		[RED("dpadInputReceived")] 
		public CBool DpadInputReceived
		{
			get => GetProperty(ref _dpadInputReceived);
			set => SetProperty(ref _dpadInputReceived, value);
		}

		public PauseMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
