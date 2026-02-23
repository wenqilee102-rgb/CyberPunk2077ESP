using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointSystemLock : CVariable
	{
		private CName _lockReason;

		[Ordinal(0)] 
		[RED("lockReason")] 
		public CName LockReason
		{
			get => GetProperty(ref _lockReason);
			set => SetProperty(ref _lockReason, value);
		}

		public DropPointSystemLock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
