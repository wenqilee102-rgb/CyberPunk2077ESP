using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsMissEvent : redEvent
	{
		private CHandle<gamedamageAttackData> _attackData;
		private Vector4 _hitPosition;
		private Vector4 _hitDirection;
		private CFloat _attackPentration;
		private CBool _hasPiercedTechSurface;
		private CHandle<gameAttackComputed> _attackComputed;

		[Ordinal(0)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get => GetProperty(ref _attackData);
			set => SetProperty(ref _attackData, value);
		}

		[Ordinal(1)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(2)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(3)] 
		[RED("attackPentration")] 
		public CFloat AttackPentration
		{
			get => GetProperty(ref _attackPentration);
			set => SetProperty(ref _attackPentration, value);
		}

		[Ordinal(4)] 
		[RED("hasPiercedTechSurface")] 
		public CBool HasPiercedTechSurface
		{
			get => GetProperty(ref _hasPiercedTechSurface);
			set => SetProperty(ref _hasPiercedTechSurface, value);
		}

		[Ordinal(5)] 
		[RED("attackComputed")] 
		public CHandle<gameAttackComputed> AttackComputed
		{
			get => GetProperty(ref _attackComputed);
			set => SetProperty(ref _attackComputed, value);
		}

		public gameeventsMissEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
