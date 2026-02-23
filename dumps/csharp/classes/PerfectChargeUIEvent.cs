using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerfectChargeUIEvent : redEvent
	{
		private CName _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CName Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public PerfectChargeUIEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
