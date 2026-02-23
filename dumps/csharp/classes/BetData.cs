using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BetData : CVariable
	{
		private CUInt32 _chipsAmount;
		private CUInt32 _betAmount;
		private CEnum<CasinoTableBet> _betOn;

		[Ordinal(0)] 
		[RED("chipsAmount")] 
		public CUInt32 ChipsAmount
		{
			get => GetProperty(ref _chipsAmount);
			set => SetProperty(ref _chipsAmount, value);
		}

		[Ordinal(1)] 
		[RED("betAmount")] 
		public CUInt32 BetAmount
		{
			get => GetProperty(ref _betAmount);
			set => SetProperty(ref _betAmount, value);
		}

		[Ordinal(2)] 
		[RED("betOn")] 
		public CEnum<CasinoTableBet> BetOn
		{
			get => GetProperty(ref _betOn);
			set => SetProperty(ref _betOn, value);
		}

		public BetData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
