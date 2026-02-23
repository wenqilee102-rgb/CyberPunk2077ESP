using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CasinoTableGamePageLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _cash;
		private inkTextWidgetReference _bet;
		private CArray<BetOnMark> _marks;

		[Ordinal(1)] 
		[RED("cash")] 
		public inkTextWidgetReference Cash
		{
			get => GetProperty(ref _cash);
			set => SetProperty(ref _cash, value);
		}

		[Ordinal(2)] 
		[RED("bet")] 
		public inkTextWidgetReference Bet
		{
			get => GetProperty(ref _bet);
			set => SetProperty(ref _bet, value);
		}

		[Ordinal(3)] 
		[RED("marks")] 
		public CArray<BetOnMark> Marks
		{
			get => GetProperty(ref _marks);
			set => SetProperty(ref _marks, value);
		}

		public CasinoTableGamePageLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
