using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoverActionTransition : LocomotionTransition
	{
		private ScriptGameInstance _gameInstance;
		private CHandle<redCallbackObject> _locomotionStateCallbackID;
		private CFloat _lastSlidingTime;
		private CBool _isSliding;

		[Ordinal(3)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(4)] 
		[RED("locomotionStateCallbackID")] 
		public CHandle<redCallbackObject> LocomotionStateCallbackID
		{
			get => GetProperty(ref _locomotionStateCallbackID);
			set => SetProperty(ref _locomotionStateCallbackID, value);
		}

		[Ordinal(5)] 
		[RED("lastSlidingTime")] 
		public CFloat LastSlidingTime
		{
			get => GetProperty(ref _lastSlidingTime);
			set => SetProperty(ref _lastSlidingTime, value);
		}

		[Ordinal(6)] 
		[RED("isSliding")] 
		public CBool IsSliding
		{
			get => GetProperty(ref _isSliding);
			set => SetProperty(ref _isSliding, value);
		}

		public CoverActionTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
