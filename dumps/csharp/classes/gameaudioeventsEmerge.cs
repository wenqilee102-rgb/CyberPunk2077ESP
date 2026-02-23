using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsEmerge : redEvent
	{
		private CFloat _oxygen;

		[Ordinal(0)] 
		[RED("oxygen")] 
		public CFloat Oxygen
		{
			get => GetProperty(ref _oxygen);
			set => SetProperty(ref _oxygen, value);
		}

		public gameaudioeventsEmerge(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
