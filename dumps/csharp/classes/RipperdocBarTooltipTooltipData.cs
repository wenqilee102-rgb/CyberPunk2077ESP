using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocBarTooltipTooltipData : ATooltipData
	{
		private CEnum<BarType> _barType;
		private CInt32 _totalValue;
		private CInt32 _maxValue;
		private CFloat _maxDamageReduction;
		private CBool _capacityPerk1Bought;
		private CBool _capacityPerk2Bought;
		private CBool _armorPerk1Bought;
		private CArray<gameStatViewData> _statsData;
		private CInt32 _statValue;
		private CFloat _health;

		[Ordinal(0)] 
		[RED("barType")] 
		public CEnum<BarType> BarType
		{
			get => GetProperty(ref _barType);
			set => SetProperty(ref _barType, value);
		}

		[Ordinal(1)] 
		[RED("totalValue")] 
		public CInt32 TotalValue
		{
			get => GetProperty(ref _totalValue);
			set => SetProperty(ref _totalValue, value);
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(3)] 
		[RED("maxDamageReduction")] 
		public CFloat MaxDamageReduction
		{
			get => GetProperty(ref _maxDamageReduction);
			set => SetProperty(ref _maxDamageReduction, value);
		}

		[Ordinal(4)] 
		[RED("capacityPerk1Bought")] 
		public CBool CapacityPerk1Bought
		{
			get => GetProperty(ref _capacityPerk1Bought);
			set => SetProperty(ref _capacityPerk1Bought, value);
		}

		[Ordinal(5)] 
		[RED("capacityPerk2Bought")] 
		public CBool CapacityPerk2Bought
		{
			get => GetProperty(ref _capacityPerk2Bought);
			set => SetProperty(ref _capacityPerk2Bought, value);
		}

		[Ordinal(6)] 
		[RED("armorPerk1Bought")] 
		public CBool ArmorPerk1Bought
		{
			get => GetProperty(ref _armorPerk1Bought);
			set => SetProperty(ref _armorPerk1Bought, value);
		}

		[Ordinal(7)] 
		[RED("statsData")] 
		public CArray<gameStatViewData> StatsData
		{
			get => GetProperty(ref _statsData);
			set => SetProperty(ref _statsData, value);
		}

		[Ordinal(8)] 
		[RED("statValue")] 
		public CInt32 StatValue
		{
			get => GetProperty(ref _statValue);
			set => SetProperty(ref _statValue, value);
		}

		[Ordinal(9)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		public RipperdocBarTooltipTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
