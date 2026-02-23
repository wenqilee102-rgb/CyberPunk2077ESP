using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectNearlyHitAgentData : CVariable
	{
		private Vector4 _hitPosition;
		private Vector4 _hitDirection;
		private wCHandle<entEntity> _entity;
		private CBool _isPlayer;
		private CBool _wasHit;

		[Ordinal(0)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(1)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(4)] 
		[RED("wasHit")] 
		public CBool WasHit
		{
			get => GetProperty(ref _wasHit);
			set => SetProperty(ref _wasHit, value);
		}

		public gameEffectNearlyHitAgentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
