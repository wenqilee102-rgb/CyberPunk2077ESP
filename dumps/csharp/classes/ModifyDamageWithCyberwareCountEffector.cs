using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithCyberwareCountEffector : ModifyDamageEffector
	{
		private CFloat _minPlayerHealthPercentage;
		private CFloat _playerIncomingDamageMultiplier;
		private CFloat _playerMaxIncomingDamage;
		private CFloat _damageBuffAmount;
		private CFloat _damageBuffRarity;
		private CName _playVFXOnHitTargets;
		private wCHandle<gamedataStatusEffect_Record> _statusEffectRecord;

		[Ordinal(6)] 
		[RED("minPlayerHealthPercentage")] 
		public CFloat MinPlayerHealthPercentage
		{
			get => GetProperty(ref _minPlayerHealthPercentage);
			set => SetProperty(ref _minPlayerHealthPercentage, value);
		}

		[Ordinal(7)] 
		[RED("playerIncomingDamageMultiplier")] 
		public CFloat PlayerIncomingDamageMultiplier
		{
			get => GetProperty(ref _playerIncomingDamageMultiplier);
			set => SetProperty(ref _playerIncomingDamageMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("playerMaxIncomingDamage")] 
		public CFloat PlayerMaxIncomingDamage
		{
			get => GetProperty(ref _playerMaxIncomingDamage);
			set => SetProperty(ref _playerMaxIncomingDamage, value);
		}

		[Ordinal(9)] 
		[RED("damageBuffAmount")] 
		public CFloat DamageBuffAmount
		{
			get => GetProperty(ref _damageBuffAmount);
			set => SetProperty(ref _damageBuffAmount, value);
		}

		[Ordinal(10)] 
		[RED("damageBuffRarity")] 
		public CFloat DamageBuffRarity
		{
			get => GetProperty(ref _damageBuffRarity);
			set => SetProperty(ref _damageBuffRarity, value);
		}

		[Ordinal(11)] 
		[RED("playVFXOnHitTargets")] 
		public CName PlayVFXOnHitTargets
		{
			get => GetProperty(ref _playVFXOnHitTargets);
			set => SetProperty(ref _playVFXOnHitTargets, value);
		}

		[Ordinal(12)] 
		[RED("statusEffectRecord")] 
		public wCHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetProperty(ref _statusEffectRecord);
			set => SetProperty(ref _statusEffectRecord, value);
		}

		public ModifyDamageWithCyberwareCountEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
