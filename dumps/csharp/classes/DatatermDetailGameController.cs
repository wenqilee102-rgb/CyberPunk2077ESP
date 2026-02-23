using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DatatermDetailGameController : BaseBunkerComputerGameController
	{
		private AuthorizationFactsSet _authFactsSet;
		private AttemptedToStopFactsSet _attemptedFactsSet;
		private inkWidgetReference _systemStatusHeaderPannel;
		private inkWidgetReference _systemStatusLeftPannel;
		private inkWidgetReference _systemStatusRightPannel;
		private CName _loopAnimName;
		private CInt32 _popup01Counter;
		private CInt32 _popup02Counter;
		private CName _popup01LoopAnimName;
		private CName _popup02LoopAnimName;
		private CName _popup031LoopAnimName;
		private CName _popup032LoopAnimName;
		private CName _popup04LoopAnimName;
		private CName _popup05LoopAnimName;
		private inkWidgetReference _shutdownButton;
		private inkWidgetReference _transitionToMinigame;
		private CHandle<inkanimProxy> _popup01LoopAnimProxy;
		private CBool _isAuthStep;
		private CBool _isHackingStep;
		private CBool _isPostHackingStep;
		private CBool _isOffline;
		private CBool _isAttemptedToStop;

		[Ordinal(4)] 
		[RED("authFactsSet")] 
		public AuthorizationFactsSet AuthFactsSet
		{
			get => GetProperty(ref _authFactsSet);
			set => SetProperty(ref _authFactsSet, value);
		}

		[Ordinal(5)] 
		[RED("attemptedFactsSet")] 
		public AttemptedToStopFactsSet AttemptedFactsSet
		{
			get => GetProperty(ref _attemptedFactsSet);
			set => SetProperty(ref _attemptedFactsSet, value);
		}

		[Ordinal(6)] 
		[RED("systemStatusHeaderPannel")] 
		public inkWidgetReference SystemStatusHeaderPannel
		{
			get => GetProperty(ref _systemStatusHeaderPannel);
			set => SetProperty(ref _systemStatusHeaderPannel, value);
		}

		[Ordinal(7)] 
		[RED("systemStatusLeftPannel")] 
		public inkWidgetReference SystemStatusLeftPannel
		{
			get => GetProperty(ref _systemStatusLeftPannel);
			set => SetProperty(ref _systemStatusLeftPannel, value);
		}

		[Ordinal(8)] 
		[RED("systemStatusRightPannel")] 
		public inkWidgetReference SystemStatusRightPannel
		{
			get => GetProperty(ref _systemStatusRightPannel);
			set => SetProperty(ref _systemStatusRightPannel, value);
		}

		[Ordinal(9)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetProperty(ref _loopAnimName);
			set => SetProperty(ref _loopAnimName, value);
		}

		[Ordinal(10)] 
		[RED("popup01Counter")] 
		public CInt32 Popup01Counter
		{
			get => GetProperty(ref _popup01Counter);
			set => SetProperty(ref _popup01Counter, value);
		}

		[Ordinal(11)] 
		[RED("popup02Counter")] 
		public CInt32 Popup02Counter
		{
			get => GetProperty(ref _popup02Counter);
			set => SetProperty(ref _popup02Counter, value);
		}

		[Ordinal(12)] 
		[RED("popup01LoopAnimName")] 
		public CName Popup01LoopAnimName
		{
			get => GetProperty(ref _popup01LoopAnimName);
			set => SetProperty(ref _popup01LoopAnimName, value);
		}

		[Ordinal(13)] 
		[RED("popup02LoopAnimName")] 
		public CName Popup02LoopAnimName
		{
			get => GetProperty(ref _popup02LoopAnimName);
			set => SetProperty(ref _popup02LoopAnimName, value);
		}

		[Ordinal(14)] 
		[RED("popup031LoopAnimName")] 
		public CName Popup031LoopAnimName
		{
			get => GetProperty(ref _popup031LoopAnimName);
			set => SetProperty(ref _popup031LoopAnimName, value);
		}

		[Ordinal(15)] 
		[RED("popup032LoopAnimName")] 
		public CName Popup032LoopAnimName
		{
			get => GetProperty(ref _popup032LoopAnimName);
			set => SetProperty(ref _popup032LoopAnimName, value);
		}

		[Ordinal(16)] 
		[RED("popup04LoopAnimName")] 
		public CName Popup04LoopAnimName
		{
			get => GetProperty(ref _popup04LoopAnimName);
			set => SetProperty(ref _popup04LoopAnimName, value);
		}

		[Ordinal(17)] 
		[RED("popup05LoopAnimName")] 
		public CName Popup05LoopAnimName
		{
			get => GetProperty(ref _popup05LoopAnimName);
			set => SetProperty(ref _popup05LoopAnimName, value);
		}

		[Ordinal(18)] 
		[RED("shutdownButton")] 
		public inkWidgetReference ShutdownButton
		{
			get => GetProperty(ref _shutdownButton);
			set => SetProperty(ref _shutdownButton, value);
		}

		[Ordinal(19)] 
		[RED("transitionToMinigame")] 
		public inkWidgetReference TransitionToMinigame
		{
			get => GetProperty(ref _transitionToMinigame);
			set => SetProperty(ref _transitionToMinigame, value);
		}

		[Ordinal(20)] 
		[RED("popup01LoopAnimProxy")] 
		public CHandle<inkanimProxy> Popup01LoopAnimProxy
		{
			get => GetProperty(ref _popup01LoopAnimProxy);
			set => SetProperty(ref _popup01LoopAnimProxy, value);
		}

		[Ordinal(21)] 
		[RED("isAuthStep")] 
		public CBool IsAuthStep
		{
			get => GetProperty(ref _isAuthStep);
			set => SetProperty(ref _isAuthStep, value);
		}

		[Ordinal(22)] 
		[RED("isHackingStep")] 
		public CBool IsHackingStep
		{
			get => GetProperty(ref _isHackingStep);
			set => SetProperty(ref _isHackingStep, value);
		}

		[Ordinal(23)] 
		[RED("isPostHackingStep")] 
		public CBool IsPostHackingStep
		{
			get => GetProperty(ref _isPostHackingStep);
			set => SetProperty(ref _isPostHackingStep, value);
		}

		[Ordinal(24)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetProperty(ref _isOffline);
			set => SetProperty(ref _isOffline, value);
		}

		[Ordinal(25)] 
		[RED("isAttemptedToStop")] 
		public CBool IsAttemptedToStop
		{
			get => GetProperty(ref _isAttemptedToStop);
			set => SetProperty(ref _isAttemptedToStop, value);
		}

		public DatatermDetailGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
