using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameOverrideMissShotOffset : redEvent
	{
		private CString _overrideRecord;

		[Ordinal(0)] 
		[RED("overrideRecord")] 
		public CString OverrideRecord
		{
			get => GetProperty(ref _overrideRecord);
			set => SetProperty(ref _overrideRecord, value);
		}

		public gameOverrideMissShotOffset(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
