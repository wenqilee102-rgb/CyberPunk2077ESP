using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponTraining : InteractiveDevice
	{
		private TweakDBID _rewardRecord;
		private CArray<CEnum<gamedataItemType>> _weaponTypes;
		private CInt32 _limitOfHits;
		private CInt32 _amountOfHits;

		[Ordinal(98)] 
		[RED("rewardRecord")] 
		public TweakDBID RewardRecord
		{
			get => GetProperty(ref _rewardRecord);
			set => SetProperty(ref _rewardRecord, value);
		}

		[Ordinal(99)] 
		[RED("weaponTypes")] 
		public CArray<CEnum<gamedataItemType>> WeaponTypes
		{
			get => GetProperty(ref _weaponTypes);
			set => SetProperty(ref _weaponTypes, value);
		}

		[Ordinal(100)] 
		[RED("limitOfHits")] 
		public CInt32 LimitOfHits
		{
			get => GetProperty(ref _limitOfHits);
			set => SetProperty(ref _limitOfHits, value);
		}

		[Ordinal(101)] 
		[RED("amountOfHits")] 
		public CInt32 AmountOfHits
		{
			get => GetProperty(ref _amountOfHits);
			set => SetProperty(ref _amountOfHits, value);
		}

		public WeaponTraining(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
