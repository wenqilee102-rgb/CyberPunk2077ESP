using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsVehicleMeleeCleaveEvent : redEvent
	{
		private CHandle<gamedamageAttackData> _attackData;
		private Vector4 _hitPosition;
		private Vector4 _hitDirection;
		private wCHandle<entIPlacedComponent> _hitComponent;

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
		[RED("hitComponent")] 
		public wCHandle<entIPlacedComponent> HitComponent
		{
			get => GetProperty(ref _hitComponent);
			set => SetProperty(ref _hitComponent, value);
		}

		public gameeventsVehicleMeleeCleaveEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
