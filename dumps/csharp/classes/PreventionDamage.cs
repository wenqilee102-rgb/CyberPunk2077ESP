using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDamage : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _target;
		private CFloat _attackTime;
		private CEnum<gamedataAttackType> _attackType;
		private CFloat _damageDealtPercent;
		private CBool _isTargetKilled;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("attackTime")] 
		public CFloat AttackTime
		{
			get => GetProperty(ref _attackTime);
			set => SetProperty(ref _attackTime, value);
		}

		[Ordinal(2)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(3)] 
		[RED("damageDealtPercent")] 
		public CFloat DamageDealtPercent
		{
			get => GetProperty(ref _damageDealtPercent);
			set => SetProperty(ref _damageDealtPercent, value);
		}

		[Ordinal(4)] 
		[RED("isTargetKilled")] 
		public CBool IsTargetKilled
		{
			get => GetProperty(ref _isTargetKilled);
			set => SetProperty(ref _isTargetKilled, value);
		}

		public PreventionDamage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
