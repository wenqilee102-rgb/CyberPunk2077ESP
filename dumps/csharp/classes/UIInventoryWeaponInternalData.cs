using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryWeaponInternalData : IScriptable
	{
		private CInt32 _fetchedFlags;
		private CEnum<WeaponType> _weaponType;
		private CEnum<gamedataWeaponEvolution> _evolution;
		private CEnum<gamedataPerkWeaponGroupType> _perkGroup;
		private CString _gameplayDescription;
		private CArray<TweakDBID> _emptySlots;
		private CArray<TweakDBID> _usedSlots;
		private CBool _hasSilencerSlot;
		private CBool _hasScopeSlot;
		private CBool _hasSilencerInstalled;
		private CBool _hasScopeInstalled;
		private CFloat _damageMin;
		private CFloat _damageMax;
		private CFloat _attackSpeed;
		private CInt32 _numberOfPellets;
		private CInt32 _ammo;

		[Ordinal(0)] 
		[RED("fetchedFlags")] 
		public CInt32 FetchedFlags
		{
			get => GetProperty(ref _fetchedFlags);
			set => SetProperty(ref _fetchedFlags, value);
		}

		[Ordinal(1)] 
		[RED("WeaponType")] 
		public CEnum<WeaponType> WeaponType
		{
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}

		[Ordinal(2)] 
		[RED("Evolution")] 
		public CEnum<gamedataWeaponEvolution> Evolution
		{
			get => GetProperty(ref _evolution);
			set => SetProperty(ref _evolution, value);
		}

		[Ordinal(3)] 
		[RED("PerkGroup")] 
		public CEnum<gamedataPerkWeaponGroupType> PerkGroup
		{
			get => GetProperty(ref _perkGroup);
			set => SetProperty(ref _perkGroup, value);
		}

		[Ordinal(4)] 
		[RED("GameplayDescription")] 
		public CString GameplayDescription
		{
			get => GetProperty(ref _gameplayDescription);
			set => SetProperty(ref _gameplayDescription, value);
		}

		[Ordinal(5)] 
		[RED("EmptySlots")] 
		public CArray<TweakDBID> EmptySlots
		{
			get => GetProperty(ref _emptySlots);
			set => SetProperty(ref _emptySlots, value);
		}

		[Ordinal(6)] 
		[RED("UsedSlots")] 
		public CArray<TweakDBID> UsedSlots
		{
			get => GetProperty(ref _usedSlots);
			set => SetProperty(ref _usedSlots, value);
		}

		[Ordinal(7)] 
		[RED("HasSilencerSlot")] 
		public CBool HasSilencerSlot
		{
			get => GetProperty(ref _hasSilencerSlot);
			set => SetProperty(ref _hasSilencerSlot, value);
		}

		[Ordinal(8)] 
		[RED("HasScopeSlot")] 
		public CBool HasScopeSlot
		{
			get => GetProperty(ref _hasScopeSlot);
			set => SetProperty(ref _hasScopeSlot, value);
		}

		[Ordinal(9)] 
		[RED("HasSilencerInstalled")] 
		public CBool HasSilencerInstalled
		{
			get => GetProperty(ref _hasSilencerInstalled);
			set => SetProperty(ref _hasSilencerInstalled, value);
		}

		[Ordinal(10)] 
		[RED("HasScopeInstalled")] 
		public CBool HasScopeInstalled
		{
			get => GetProperty(ref _hasScopeInstalled);
			set => SetProperty(ref _hasScopeInstalled, value);
		}

		[Ordinal(11)] 
		[RED("DamageMin")] 
		public CFloat DamageMin
		{
			get => GetProperty(ref _damageMin);
			set => SetProperty(ref _damageMin, value);
		}

		[Ordinal(12)] 
		[RED("DamageMax")] 
		public CFloat DamageMax
		{
			get => GetProperty(ref _damageMax);
			set => SetProperty(ref _damageMax, value);
		}

		[Ordinal(13)] 
		[RED("AttackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetProperty(ref _attackSpeed);
			set => SetProperty(ref _attackSpeed, value);
		}

		[Ordinal(14)] 
		[RED("NumberOfPellets")] 
		public CInt32 NumberOfPellets
		{
			get => GetProperty(ref _numberOfPellets);
			set => SetProperty(ref _numberOfPellets, value);
		}

		[Ordinal(15)] 
		[RED("Ammo")] 
		public CInt32 Ammo
		{
			get => GetProperty(ref _ammo);
			set => SetProperty(ref _ammo, value);
		}

		public UIInventoryWeaponInternalData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
