using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponShootPrereqState : gamePrereqState
	{
		private CHandle<redCallbackObject> _listenerWeaponInt;
		private CHandle<redCallbackObject> _listenerActiveWeaponVariant;
		private CHandle<redCallbackObject> _listenerOnShootVariant;
		private wCHandle<gameweaponObject> _weaponObj;
		private wCHandle<gameObject> _owner;
		private CInt32 _howManyAttacks;
		private CInt32 _remainingAttacks;

		[Ordinal(0)] 
		[RED("listenerWeaponInt")] 
		public CHandle<redCallbackObject> ListenerWeaponInt
		{
			get => GetProperty(ref _listenerWeaponInt);
			set => SetProperty(ref _listenerWeaponInt, value);
		}

		[Ordinal(1)] 
		[RED("listenerActiveWeaponVariant")] 
		public CHandle<redCallbackObject> ListenerActiveWeaponVariant
		{
			get => GetProperty(ref _listenerActiveWeaponVariant);
			set => SetProperty(ref _listenerActiveWeaponVariant, value);
		}

		[Ordinal(2)] 
		[RED("listenerOnShootVariant")] 
		public CHandle<redCallbackObject> ListenerOnShootVariant
		{
			get => GetProperty(ref _listenerOnShootVariant);
			set => SetProperty(ref _listenerOnShootVariant, value);
		}

		[Ordinal(3)] 
		[RED("weaponObj")] 
		public wCHandle<gameweaponObject> WeaponObj
		{
			get => GetProperty(ref _weaponObj);
			set => SetProperty(ref _weaponObj, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(5)] 
		[RED("howManyAttacks")] 
		public CInt32 HowManyAttacks
		{
			get => GetProperty(ref _howManyAttacks);
			set => SetProperty(ref _howManyAttacks, value);
		}

		[Ordinal(6)] 
		[RED("remainingAttacks")] 
		public CInt32 RemainingAttacks
		{
			get => GetProperty(ref _remainingAttacks);
			set => SetProperty(ref _remainingAttacks, value);
		}

		public WeaponShootPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
