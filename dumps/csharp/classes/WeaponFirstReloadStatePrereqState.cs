using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponFirstReloadStatePrereqState : gamePrereqState
	{
		private CHandle<redCallbackObject> _listenerWeaponInt;
		private CHandle<redCallbackObject> _listenerActiveWeaponVariant;
		private wCHandle<gameweaponObject> _weaponObj;
		private wCHandle<gameObject> _owner;
		private CBool _reloaded;

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
		[RED("weaponObj")] 
		public wCHandle<gameweaponObject> WeaponObj
		{
			get => GetProperty(ref _weaponObj);
			set => SetProperty(ref _weaponObj, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(4)] 
		[RED("reloaded")] 
		public CBool Reloaded
		{
			get => GetProperty(ref _reloaded);
			set => SetProperty(ref _reloaded, value);
		}

		public WeaponFirstReloadStatePrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
