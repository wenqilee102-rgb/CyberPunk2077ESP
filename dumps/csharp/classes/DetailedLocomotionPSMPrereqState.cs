using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DetailedLocomotionPSMPrereqState : PlayerStateMachinePrereqState
	{
		private gamebbScriptID_Int32 _locomotionID;
		private CUInt32 _playerAttachedCallbackID;

		[Ordinal(3)] 
		[RED("locomotionID")] 
		public gamebbScriptID_Int32 LocomotionID
		{
			get => GetProperty(ref _locomotionID);
			set => SetProperty(ref _locomotionID, value);
		}

		[Ordinal(4)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		public DetailedLocomotionPSMPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
