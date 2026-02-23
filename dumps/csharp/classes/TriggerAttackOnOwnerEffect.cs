using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnOwnerEffect : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private TweakDBID _attackTDBID;
		private CName _attackPositionSlotName;
		private CBool _playerAsInstigator;
		private CBool _triggerHitReaction;
		private CBool _isRandom;
		private CFloat _applicationChance;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetProperty(ref _attackTDBID);
			set => SetProperty(ref _attackTDBID, value);
		}

		[Ordinal(2)] 
		[RED("attackPositionSlotName")] 
		public CName AttackPositionSlotName
		{
			get => GetProperty(ref _attackPositionSlotName);
			set => SetProperty(ref _attackPositionSlotName, value);
		}

		[Ordinal(3)] 
		[RED("playerAsInstigator")] 
		public CBool PlayerAsInstigator
		{
			get => GetProperty(ref _playerAsInstigator);
			set => SetProperty(ref _playerAsInstigator, value);
		}

		[Ordinal(4)] 
		[RED("triggerHitReaction")] 
		public CBool TriggerHitReaction
		{
			get => GetProperty(ref _triggerHitReaction);
			set => SetProperty(ref _triggerHitReaction, value);
		}

		[Ordinal(5)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get => GetProperty(ref _isRandom);
			set => SetProperty(ref _isRandom, value);
		}

		[Ordinal(6)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get => GetProperty(ref _applicationChance);
			set => SetProperty(ref _applicationChance, value);
		}

		public TriggerAttackOnOwnerEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
