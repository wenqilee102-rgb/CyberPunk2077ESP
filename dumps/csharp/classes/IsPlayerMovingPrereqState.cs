using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPlayerMovingPrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CBool _isMovingVertically;
		private CHandle<redCallbackObject> _listenerVertical;
		private CBool _isMovingHorizontally;
		private CHandle<redCallbackObject> _listenerHorizontal;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("isMovingVertically")] 
		public CBool IsMovingVertically
		{
			get => GetProperty(ref _isMovingVertically);
			set => SetProperty(ref _isMovingVertically, value);
		}

		[Ordinal(2)] 
		[RED("listenerVertical")] 
		public CHandle<redCallbackObject> ListenerVertical
		{
			get => GetProperty(ref _listenerVertical);
			set => SetProperty(ref _listenerVertical, value);
		}

		[Ordinal(3)] 
		[RED("isMovingHorizontally")] 
		public CBool IsMovingHorizontally
		{
			get => GetProperty(ref _isMovingHorizontally);
			set => SetProperty(ref _isMovingHorizontally, value);
		}

		[Ordinal(4)] 
		[RED("listenerHorizontal")] 
		public CHandle<redCallbackObject> ListenerHorizontal
		{
			get => GetProperty(ref _listenerHorizontal);
			set => SetProperty(ref _listenerHorizontal, value);
		}

		public IsPlayerMovingPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
