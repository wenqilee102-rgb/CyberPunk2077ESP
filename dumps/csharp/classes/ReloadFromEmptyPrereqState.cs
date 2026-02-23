using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReloadFromEmptyPrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CInt32 _minAmountOfAmmoReloaded;
		private CHandle<redCallbackObject> _listenerWeaponInt;
		private CHandle<redCallbackObject> _listenerActiveWeaponVariant;
		private CBool _reloadingInProgress;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("minAmountOfAmmoReloaded")] 
		public CInt32 MinAmountOfAmmoReloaded
		{
			get => GetProperty(ref _minAmountOfAmmoReloaded);
			set => SetProperty(ref _minAmountOfAmmoReloaded, value);
		}

		[Ordinal(2)] 
		[RED("listenerWeaponInt")] 
		public CHandle<redCallbackObject> ListenerWeaponInt
		{
			get => GetProperty(ref _listenerWeaponInt);
			set => SetProperty(ref _listenerWeaponInt, value);
		}

		[Ordinal(3)] 
		[RED("listenerActiveWeaponVariant")] 
		public CHandle<redCallbackObject> ListenerActiveWeaponVariant
		{
			get => GetProperty(ref _listenerActiveWeaponVariant);
			set => SetProperty(ref _listenerActiveWeaponVariant, value);
		}

		[Ordinal(4)] 
		[RED("reloadingInProgress")] 
		public CBool ReloadingInProgress
		{
			get => GetProperty(ref _reloadingInProgress);
			set => SetProperty(ref _reloadingInProgress, value);
		}

		public ReloadFromEmptyPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
