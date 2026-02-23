using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WantedBarGameController : gameuiHUDGameController
	{
		private CArray<inkWidgetReference> _starsWidget;
		private wCHandle<gameIBlackboard> _wantedBlackboard;
		private CHandle<UI_WantedBarDef> _wantedBlackboardDef;
		private CHandle<redCallbackObject> _wantedDataCallbackID;
		private CHandle<redCallbackObject> _wantedStateCallbackID;
		private CHandle<redCallbackObject> _wantedZoneCallbackID;
		private CHandle<inkanimProxy> _introAnimProxy;
		private CArray<CHandle<inkanimProxy>> _bountyStarAnimProxy;
		private CHandle<inkanimProxy> _bountyAnimProxy;
		private inkanimPlaybackOptions _animOptionsLoop;
		private CInt32 _currentState;
		private CInt32 _numOfStar;
		private CInt32 _wantedLevel;
		private wCHandle<inkWidget> _rootWidget;
		private CBool _isDogtown;
		private CFloat _wANTED_TIER_1;
		private CFloat _wANTED_MIN;

		[Ordinal(9)] 
		[RED("starsWidget")] 
		public CArray<inkWidgetReference> StarsWidget
		{
			get => GetProperty(ref _starsWidget);
			set => SetProperty(ref _starsWidget, value);
		}

		[Ordinal(10)] 
		[RED("wantedBlackboard")] 
		public wCHandle<gameIBlackboard> WantedBlackboard
		{
			get => GetProperty(ref _wantedBlackboard);
			set => SetProperty(ref _wantedBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("wantedBlackboardDef")] 
		public CHandle<UI_WantedBarDef> WantedBlackboardDef
		{
			get => GetProperty(ref _wantedBlackboardDef);
			set => SetProperty(ref _wantedBlackboardDef, value);
		}

		[Ordinal(12)] 
		[RED("wantedDataCallbackID")] 
		public CHandle<redCallbackObject> WantedDataCallbackID
		{
			get => GetProperty(ref _wantedDataCallbackID);
			set => SetProperty(ref _wantedDataCallbackID, value);
		}

		[Ordinal(13)] 
		[RED("wantedStateCallbackID")] 
		public CHandle<redCallbackObject> WantedStateCallbackID
		{
			get => GetProperty(ref _wantedStateCallbackID);
			set => SetProperty(ref _wantedStateCallbackID, value);
		}

		[Ordinal(14)] 
		[RED("wantedZoneCallbackID")] 
		public CHandle<redCallbackObject> WantedZoneCallbackID
		{
			get => GetProperty(ref _wantedZoneCallbackID);
			set => SetProperty(ref _wantedZoneCallbackID, value);
		}

		[Ordinal(15)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(16)] 
		[RED("bountyStarAnimProxy")] 
		public CArray<CHandle<inkanimProxy>> BountyStarAnimProxy
		{
			get => GetProperty(ref _bountyStarAnimProxy);
			set => SetProperty(ref _bountyStarAnimProxy, value);
		}

		[Ordinal(17)] 
		[RED("bountyAnimProxy")] 
		public CHandle<inkanimProxy> BountyAnimProxy
		{
			get => GetProperty(ref _bountyAnimProxy);
			set => SetProperty(ref _bountyAnimProxy, value);
		}

		[Ordinal(18)] 
		[RED("animOptionsLoop")] 
		public inkanimPlaybackOptions AnimOptionsLoop
		{
			get => GetProperty(ref _animOptionsLoop);
			set => SetProperty(ref _animOptionsLoop, value);
		}

		[Ordinal(19)] 
		[RED("currentState")] 
		public CInt32 CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		[Ordinal(20)] 
		[RED("numOfStar")] 
		public CInt32 NumOfStar
		{
			get => GetProperty(ref _numOfStar);
			set => SetProperty(ref _numOfStar, value);
		}

		[Ordinal(21)] 
		[RED("wantedLevel")] 
		public CInt32 WantedLevel
		{
			get => GetProperty(ref _wantedLevel);
			set => SetProperty(ref _wantedLevel, value);
		}

		[Ordinal(22)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(23)] 
		[RED("isDogtown")] 
		public CBool IsDogtown
		{
			get => GetProperty(ref _isDogtown);
			set => SetProperty(ref _isDogtown, value);
		}

		[Ordinal(24)] 
		[RED("WANTED_TIER_1")] 
		public CFloat WANTED_TIER_1
		{
			get => GetProperty(ref _wANTED_TIER_1);
			set => SetProperty(ref _wANTED_TIER_1, value);
		}

		[Ordinal(25)] 
		[RED("WANTED_MIN")] 
		public CFloat WANTED_MIN
		{
			get => GetProperty(ref _wANTED_MIN);
			set => SetProperty(ref _wANTED_MIN, value);
		}

		public WantedBarGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
