using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Bounty : CVariable
	{
		private CArray<TweakDBID> _transgressions;
		private TweakDBID _bountySetter;
		private TweakDBID _bountID;
		private CInt32 _moneyAmount;
		private CInt32 _streetCredAmount;
		private CBool _awarded;
		private CInt32 _wantedStars;
		private CBool _filteredOut;

		[Ordinal(0)] 
		[RED("transgressions")] 
		public CArray<TweakDBID> Transgressions
		{
			get => GetProperty(ref _transgressions);
			set => SetProperty(ref _transgressions, value);
		}

		[Ordinal(1)] 
		[RED("bountySetter")] 
		public TweakDBID BountySetter
		{
			get => GetProperty(ref _bountySetter);
			set => SetProperty(ref _bountySetter, value);
		}

		[Ordinal(2)] 
		[RED("bountID")] 
		public TweakDBID BountID
		{
			get => GetProperty(ref _bountID);
			set => SetProperty(ref _bountID, value);
		}

		[Ordinal(3)] 
		[RED("moneyAmount")] 
		public CInt32 MoneyAmount
		{
			get => GetProperty(ref _moneyAmount);
			set => SetProperty(ref _moneyAmount, value);
		}

		[Ordinal(4)] 
		[RED("streetCredAmount")] 
		public CInt32 StreetCredAmount
		{
			get => GetProperty(ref _streetCredAmount);
			set => SetProperty(ref _streetCredAmount, value);
		}

		[Ordinal(5)] 
		[RED("awarded")] 
		public CBool Awarded
		{
			get => GetProperty(ref _awarded);
			set => SetProperty(ref _awarded, value);
		}

		[Ordinal(6)] 
		[RED("wantedStars")] 
		public CInt32 WantedStars
		{
			get => GetProperty(ref _wantedStars);
			set => SetProperty(ref _wantedStars, value);
		}

		[Ordinal(7)] 
		[RED("filteredOut")] 
		public CBool FilteredOut
		{
			get => GetProperty(ref _filteredOut);
			set => SetProperty(ref _filteredOut, value);
		}

		public Bounty(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
