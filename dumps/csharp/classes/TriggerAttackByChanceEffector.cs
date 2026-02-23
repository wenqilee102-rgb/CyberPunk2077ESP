using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackByChanceEffector : gameEffector
	{
		private TweakDBID _attackTDBID;
		private TweakDBID _selfStatusEffectID;
		private CFloat _chance;
		private CEnum<gamedataStatType> _statType;
		private entEntityID _ownerID;
		private CHandle<TriggerAttackByChanceStatListener> _statListener;
		private CFloat _statBasedChance;

		[Ordinal(0)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetProperty(ref _attackTDBID);
			set => SetProperty(ref _attackTDBID, value);
		}

		[Ordinal(1)] 
		[RED("selfStatusEffectID")] 
		public TweakDBID SelfStatusEffectID
		{
			get => GetProperty(ref _selfStatusEffectID);
			set => SetProperty(ref _selfStatusEffectID, value);
		}

		[Ordinal(2)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get => GetProperty(ref _chance);
			set => SetProperty(ref _chance, value);
		}

		[Ordinal(3)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(5)] 
		[RED("statListener")] 
		public CHandle<TriggerAttackByChanceStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(6)] 
		[RED("statBasedChance")] 
		public CFloat StatBasedChance
		{
			get => GetProperty(ref _statBasedChance);
			set => SetProperty(ref _statBasedChance, value);
		}

		public TriggerAttackByChanceEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
