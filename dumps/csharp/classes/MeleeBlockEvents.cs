using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeBlockEvents : MeleeRumblingEvents
	{
		private CHandle<gameStatModifierData_Deprecated> _blockStatFlag;

		[Ordinal(2)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> BlockStatFlag
		{
			get => GetProperty(ref _blockStatFlag);
			set => SetProperty(ref _blockStatFlag, value);
		}

		public MeleeBlockEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
