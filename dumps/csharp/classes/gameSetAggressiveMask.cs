using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetAggressiveMask : redEvent
	{
		private CBool _isAggressive;

		[Ordinal(0)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetProperty(ref _isAggressive);
			set => SetProperty(ref _isAggressive, value);
		}

		public gameSetAggressiveMask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
