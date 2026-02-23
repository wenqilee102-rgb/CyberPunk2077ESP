using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BetOnMark : CVariable
	{
		private CEnum<CasinoTableBet> _betOn;
		private inkWidgetReference _mark;

		[Ordinal(0)] 
		[RED("betOn")] 
		public CEnum<CasinoTableBet> BetOn
		{
			get => GetProperty(ref _betOn);
			set => SetProperty(ref _betOn, value);
		}

		[Ordinal(1)] 
		[RED("mark")] 
		public inkWidgetReference Mark
		{
			get => GetProperty(ref _mark);
			set => SetProperty(ref _mark, value);
		}

		public BetOnMark(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
