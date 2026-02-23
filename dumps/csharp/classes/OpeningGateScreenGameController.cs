using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpeningGateScreenGameController : BaseBunkerComputerGameController
	{
		private inkWidgetReference _systemConsole;
		private inkWidgetReference _gateScheme;
		private inkWidgetReference _backButton;
		private CName _idleAnimName;
		private CName _loopAnimName;
		private CName _failureAnimName;
		private CName _successAnimName;
		private CName _failurePopupIntroAnimName;
		private CName _successPopupIntroAnimName;
		private CName _failurePopupAnimName;
		private CName _successPopupAnimName;
		private CName _gateIsOpenedFact;
		private CName _gateChainBeginningFact;
		private CFloat _gotoLoopDelay;
		private CFloat _goBackDelay;
		private CBool _isGateOpened;
		private CArray<CBool> _systemsStatus;
		private CInt32 _currentLoopIndex;
		private CInt32 _currentSystemIndex;
		private CInt32 _phasesCount;
		private CEnum<OpeningGateScreenState> _state;
		private CHandle<inkanimProxy> _idleAnimProxy;
		private CHandle<inkanimProxy> _loopAnimProxy;
		private CHandle<inkanimProxy> _resultAnimProxy;
		private CHandle<inkanimProxy> _resultPopupIntroAnimProxy;
		private CHandle<inkanimProxy> _resultPopupAnimProxy;

		[Ordinal(4)] 
		[RED("systemConsole")] 
		public inkWidgetReference SystemConsole
		{
			get => GetProperty(ref _systemConsole);
			set => SetProperty(ref _systemConsole, value);
		}

		[Ordinal(5)] 
		[RED("gateScheme")] 
		public inkWidgetReference GateScheme
		{
			get => GetProperty(ref _gateScheme);
			set => SetProperty(ref _gateScheme, value);
		}

		[Ordinal(6)] 
		[RED("backButton")] 
		public inkWidgetReference BackButton
		{
			get => GetProperty(ref _backButton);
			set => SetProperty(ref _backButton, value);
		}

		[Ordinal(7)] 
		[RED("idleAnimName")] 
		public CName IdleAnimName
		{
			get => GetProperty(ref _idleAnimName);
			set => SetProperty(ref _idleAnimName, value);
		}

		[Ordinal(8)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetProperty(ref _loopAnimName);
			set => SetProperty(ref _loopAnimName, value);
		}

		[Ordinal(9)] 
		[RED("failureAnimName")] 
		public CName FailureAnimName
		{
			get => GetProperty(ref _failureAnimName);
			set => SetProperty(ref _failureAnimName, value);
		}

		[Ordinal(10)] 
		[RED("successAnimName")] 
		public CName SuccessAnimName
		{
			get => GetProperty(ref _successAnimName);
			set => SetProperty(ref _successAnimName, value);
		}

		[Ordinal(11)] 
		[RED("failurePopupIntroAnimName")] 
		public CName FailurePopupIntroAnimName
		{
			get => GetProperty(ref _failurePopupIntroAnimName);
			set => SetProperty(ref _failurePopupIntroAnimName, value);
		}

		[Ordinal(12)] 
		[RED("successPopupIntroAnimName")] 
		public CName SuccessPopupIntroAnimName
		{
			get => GetProperty(ref _successPopupIntroAnimName);
			set => SetProperty(ref _successPopupIntroAnimName, value);
		}

		[Ordinal(13)] 
		[RED("failurePopupAnimName")] 
		public CName FailurePopupAnimName
		{
			get => GetProperty(ref _failurePopupAnimName);
			set => SetProperty(ref _failurePopupAnimName, value);
		}

		[Ordinal(14)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetProperty(ref _successPopupAnimName);
			set => SetProperty(ref _successPopupAnimName, value);
		}

		[Ordinal(15)] 
		[RED("gateIsOpenedFact")] 
		public CName GateIsOpenedFact
		{
			get => GetProperty(ref _gateIsOpenedFact);
			set => SetProperty(ref _gateIsOpenedFact, value);
		}

		[Ordinal(16)] 
		[RED("gateChainBeginningFact")] 
		public CName GateChainBeginningFact
		{
			get => GetProperty(ref _gateChainBeginningFact);
			set => SetProperty(ref _gateChainBeginningFact, value);
		}

		[Ordinal(17)] 
		[RED("gotoLoopDelay")] 
		public CFloat GotoLoopDelay
		{
			get => GetProperty(ref _gotoLoopDelay);
			set => SetProperty(ref _gotoLoopDelay, value);
		}

		[Ordinal(18)] 
		[RED("goBackDelay")] 
		public CFloat GoBackDelay
		{
			get => GetProperty(ref _goBackDelay);
			set => SetProperty(ref _goBackDelay, value);
		}

		[Ordinal(19)] 
		[RED("isGateOpened")] 
		public CBool IsGateOpened
		{
			get => GetProperty(ref _isGateOpened);
			set => SetProperty(ref _isGateOpened, value);
		}

		[Ordinal(20)] 
		[RED("systemsStatus")] 
		public CArray<CBool> SystemsStatus
		{
			get => GetProperty(ref _systemsStatus);
			set => SetProperty(ref _systemsStatus, value);
		}

		[Ordinal(21)] 
		[RED("currentLoopIndex")] 
		public CInt32 CurrentLoopIndex
		{
			get => GetProperty(ref _currentLoopIndex);
			set => SetProperty(ref _currentLoopIndex, value);
		}

		[Ordinal(22)] 
		[RED("currentSystemIndex")] 
		public CInt32 CurrentSystemIndex
		{
			get => GetProperty(ref _currentSystemIndex);
			set => SetProperty(ref _currentSystemIndex, value);
		}

		[Ordinal(23)] 
		[RED("phasesCount")] 
		public CInt32 PhasesCount
		{
			get => GetProperty(ref _phasesCount);
			set => SetProperty(ref _phasesCount, value);
		}

		[Ordinal(24)] 
		[RED("state")] 
		public CEnum<OpeningGateScreenState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(25)] 
		[RED("idleAnimProxy")] 
		public CHandle<inkanimProxy> IdleAnimProxy
		{
			get => GetProperty(ref _idleAnimProxy);
			set => SetProperty(ref _idleAnimProxy, value);
		}

		[Ordinal(26)] 
		[RED("loopAnimProxy")] 
		public CHandle<inkanimProxy> LoopAnimProxy
		{
			get => GetProperty(ref _loopAnimProxy);
			set => SetProperty(ref _loopAnimProxy, value);
		}

		[Ordinal(27)] 
		[RED("resultAnimProxy")] 
		public CHandle<inkanimProxy> ResultAnimProxy
		{
			get => GetProperty(ref _resultAnimProxy);
			set => SetProperty(ref _resultAnimProxy, value);
		}

		[Ordinal(28)] 
		[RED("resultPopupIntroAnimProxy")] 
		public CHandle<inkanimProxy> ResultPopupIntroAnimProxy
		{
			get => GetProperty(ref _resultPopupIntroAnimProxy);
			set => SetProperty(ref _resultPopupIntroAnimProxy, value);
		}

		[Ordinal(29)] 
		[RED("resultPopupAnimProxy")] 
		public CHandle<inkanimProxy> ResultPopupAnimProxy
		{
			get => GetProperty(ref _resultPopupAnimProxy);
			set => SetProperty(ref _resultPopupAnimProxy, value);
		}

		public OpeningGateScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
