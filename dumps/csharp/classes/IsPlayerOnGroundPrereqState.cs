using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPlayerOnGroundPrereqState : gamePrereqState
	{
		private CBool _bbValue;
		private CHandle<redCallbackObject> _isOnGroundListener;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("bbValue")] 
		public CBool BbValue
		{
			get => GetProperty(ref _bbValue);
			set => SetProperty(ref _bbValue, value);
		}

		[Ordinal(1)] 
		[RED("isOnGroundListener")] 
		public CHandle<redCallbackObject> IsOnGroundListener
		{
			get => GetProperty(ref _isOnGroundListener);
			set => SetProperty(ref _isOnGroundListener, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public IsPlayerOnGroundPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
