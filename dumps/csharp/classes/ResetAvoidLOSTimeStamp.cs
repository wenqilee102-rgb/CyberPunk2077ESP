using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResetAvoidLOSTimeStamp : AIbehaviortaskScript
	{
		private CBool _onDeactivation;
		private CBool _initialized;
		private wCHandle<gameIBlackboard> _actionBBoard;

		[Ordinal(0)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetProperty(ref _onDeactivation);
			set => SetProperty(ref _onDeactivation, value);
		}

		[Ordinal(1)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(2)] 
		[RED("actionBBoard")] 
		public wCHandle<gameIBlackboard> ActionBBoard
		{
			get => GetProperty(ref _actionBBoard);
			set => SetProperty(ref _actionBBoard, value);
		}

		public ResetAvoidLOSTimeStamp(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
