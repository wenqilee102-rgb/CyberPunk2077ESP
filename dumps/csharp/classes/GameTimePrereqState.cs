using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameTimePrereqState : gamePrereqState
	{
		private CUInt32 _listener;
		private CBool _repeated;

		[Ordinal(0)] 
		[RED("listener")] 
		public CUInt32 Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("repeated")] 
		public CBool Repeated
		{
			get => GetProperty(ref _repeated);
			set => SetProperty(ref _repeated, value);
		}

		public GameTimePrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
