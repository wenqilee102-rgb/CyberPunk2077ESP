using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyRelicMeleewareDamageOnNPCEvent : redEvent
	{
		private CHandle<gameeventsHitEvent> _newHitEvent;
		private Vector4 _hitPosition;
		private wCHandle<NPCPuppet> _target;
		private wCHandle<gameweaponObject> _weapon;
		private CEnum<gamedataItemType> _weaponType;

		[Ordinal(0)] 
		[RED("newHitEvent")] 
		public CHandle<gameeventsHitEvent> NewHitEvent
		{
			get => GetProperty(ref _newHitEvent);
			set => SetProperty(ref _newHitEvent, value);
		}

		[Ordinal(1)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public wCHandle<NPCPuppet> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(3)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(4)] 
		[RED("weaponType")] 
		public CEnum<gamedataItemType> WeaponType
		{
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}

		public ApplyRelicMeleewareDamageOnNPCEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
