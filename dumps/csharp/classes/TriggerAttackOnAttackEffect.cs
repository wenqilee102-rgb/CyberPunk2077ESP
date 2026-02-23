using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnAttackEffect : ModifyAttackEffector
	{
		private wCHandle<gameObject> _owner;
		private CHandle<gameAttack_GameEffect> _attack;
		private TweakDBID _attackTDBID;
		private wCHandle<gameObject> _target;
		private CName _attackPositionSlotName;
		private CBool _playerAsInstigator;
		private CBool _triggerHitReaction;
		private CBool _isRandom;
		private CFloat _applicationChance;
		private CBool _useHitPosition;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}

		[Ordinal(2)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetProperty(ref _attackTDBID);
			set => SetProperty(ref _attackTDBID, value);
		}

		[Ordinal(3)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(4)] 
		[RED("attackPositionSlotName")] 
		public CName AttackPositionSlotName
		{
			get => GetProperty(ref _attackPositionSlotName);
			set => SetProperty(ref _attackPositionSlotName, value);
		}

		[Ordinal(5)] 
		[RED("playerAsInstigator")] 
		public CBool PlayerAsInstigator
		{
			get => GetProperty(ref _playerAsInstigator);
			set => SetProperty(ref _playerAsInstigator, value);
		}

		[Ordinal(6)] 
		[RED("triggerHitReaction")] 
		public CBool TriggerHitReaction
		{
			get => GetProperty(ref _triggerHitReaction);
			set => SetProperty(ref _triggerHitReaction, value);
		}

		[Ordinal(7)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get => GetProperty(ref _isRandom);
			set => SetProperty(ref _isRandom, value);
		}

		[Ordinal(8)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get => GetProperty(ref _applicationChance);
			set => SetProperty(ref _applicationChance, value);
		}

		[Ordinal(9)] 
		[RED("useHitPosition")] 
		public CBool UseHitPosition
		{
			get => GetProperty(ref _useHitPosition);
			set => SetProperty(ref _useHitPosition, value);
		}

		public TriggerAttackOnAttackEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
