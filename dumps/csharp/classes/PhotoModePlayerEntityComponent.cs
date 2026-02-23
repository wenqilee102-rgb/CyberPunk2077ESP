using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModePlayerEntityComponent : gameScriptableComponent
	{
		private gameItemID _usedWeaponItemId;
		private gameItemID _currentWeaponInSlot;
		private gameItemID _swapMeleeWeaponItemId;
		private gameItemID _swapHangunWeaponItemId;
		private gameItemID _swapRifleWeaponItemId;
		private gameItemID _swapShootgunWeaponItemId;
		private wCHandle<gamePuppet> _fakePuppet;
		private wCHandle<PlayerPuppet> _mainPuppet;
		private wCHandle<PlayerPuppet> _currentPuppet;
		private CHandle<gameTransactionSystem> _tS;
		private CArray<gameItemID> _loadingItems;
		private CArray<gameItemID> _loadingVisualItems;
		private CFloat _itemsLoadingTime;
		private CBool _muzzleEffectEnabled;
		private CBool _customizable;
		private CBool _holsteredArmsShouldBeVisible;
		private CBool _holsteredArmsBeingSpawned;
		private CBool _holsteredArmsVisible;
		private gameItemID _holsteredArmsItem;
		private CBool _cyberwareArmsBeingSpawned;
		private CBool _cyberwareArmsVisible;
		private gameItemID _cyberwareArmsItem;

		[Ordinal(5)] 
		[RED("usedWeaponItemId")] 
		public gameItemID UsedWeaponItemId
		{
			get => GetProperty(ref _usedWeaponItemId);
			set => SetProperty(ref _usedWeaponItemId, value);
		}

		[Ordinal(6)] 
		[RED("currentWeaponInSlot")] 
		public gameItemID CurrentWeaponInSlot
		{
			get => GetProperty(ref _currentWeaponInSlot);
			set => SetProperty(ref _currentWeaponInSlot, value);
		}

		[Ordinal(7)] 
		[RED("swapMeleeWeaponItemId")] 
		public gameItemID SwapMeleeWeaponItemId
		{
			get => GetProperty(ref _swapMeleeWeaponItemId);
			set => SetProperty(ref _swapMeleeWeaponItemId, value);
		}

		[Ordinal(8)] 
		[RED("swapHangunWeaponItemId")] 
		public gameItemID SwapHangunWeaponItemId
		{
			get => GetProperty(ref _swapHangunWeaponItemId);
			set => SetProperty(ref _swapHangunWeaponItemId, value);
		}

		[Ordinal(9)] 
		[RED("swapRifleWeaponItemId")] 
		public gameItemID SwapRifleWeaponItemId
		{
			get => GetProperty(ref _swapRifleWeaponItemId);
			set => SetProperty(ref _swapRifleWeaponItemId, value);
		}

		[Ordinal(10)] 
		[RED("swapShootgunWeaponItemId")] 
		public gameItemID SwapShootgunWeaponItemId
		{
			get => GetProperty(ref _swapShootgunWeaponItemId);
			set => SetProperty(ref _swapShootgunWeaponItemId, value);
		}

		[Ordinal(11)] 
		[RED("fakePuppet")] 
		public wCHandle<gamePuppet> FakePuppet
		{
			get => GetProperty(ref _fakePuppet);
			set => SetProperty(ref _fakePuppet, value);
		}

		[Ordinal(12)] 
		[RED("mainPuppet")] 
		public wCHandle<PlayerPuppet> MainPuppet
		{
			get => GetProperty(ref _mainPuppet);
			set => SetProperty(ref _mainPuppet, value);
		}

		[Ordinal(13)] 
		[RED("currentPuppet")] 
		public wCHandle<PlayerPuppet> CurrentPuppet
		{
			get => GetProperty(ref _currentPuppet);
			set => SetProperty(ref _currentPuppet, value);
		}

		[Ordinal(14)] 
		[RED("TS")] 
		public CHandle<gameTransactionSystem> TS
		{
			get => GetProperty(ref _tS);
			set => SetProperty(ref _tS, value);
		}

		[Ordinal(15)] 
		[RED("loadingItems")] 
		public CArray<gameItemID> LoadingItems
		{
			get => GetProperty(ref _loadingItems);
			set => SetProperty(ref _loadingItems, value);
		}

		[Ordinal(16)] 
		[RED("loadingVisualItems")] 
		public CArray<gameItemID> LoadingVisualItems
		{
			get => GetProperty(ref _loadingVisualItems);
			set => SetProperty(ref _loadingVisualItems, value);
		}

		[Ordinal(17)] 
		[RED("itemsLoadingTime")] 
		public CFloat ItemsLoadingTime
		{
			get => GetProperty(ref _itemsLoadingTime);
			set => SetProperty(ref _itemsLoadingTime, value);
		}

		[Ordinal(18)] 
		[RED("muzzleEffectEnabled")] 
		public CBool MuzzleEffectEnabled
		{
			get => GetProperty(ref _muzzleEffectEnabled);
			set => SetProperty(ref _muzzleEffectEnabled, value);
		}

		[Ordinal(19)] 
		[RED("customizable")] 
		public CBool Customizable
		{
			get => GetProperty(ref _customizable);
			set => SetProperty(ref _customizable, value);
		}

		[Ordinal(20)] 
		[RED("holsteredArmsShouldBeVisible")] 
		public CBool HolsteredArmsShouldBeVisible
		{
			get => GetProperty(ref _holsteredArmsShouldBeVisible);
			set => SetProperty(ref _holsteredArmsShouldBeVisible, value);
		}

		[Ordinal(21)] 
		[RED("holsteredArmsBeingSpawned")] 
		public CBool HolsteredArmsBeingSpawned
		{
			get => GetProperty(ref _holsteredArmsBeingSpawned);
			set => SetProperty(ref _holsteredArmsBeingSpawned, value);
		}

		[Ordinal(22)] 
		[RED("holsteredArmsVisible")] 
		public CBool HolsteredArmsVisible
		{
			get => GetProperty(ref _holsteredArmsVisible);
			set => SetProperty(ref _holsteredArmsVisible, value);
		}

		[Ordinal(23)] 
		[RED("holsteredArmsItem")] 
		public gameItemID HolsteredArmsItem
		{
			get => GetProperty(ref _holsteredArmsItem);
			set => SetProperty(ref _holsteredArmsItem, value);
		}

		[Ordinal(24)] 
		[RED("cyberwareArmsBeingSpawned")] 
		public CBool CyberwareArmsBeingSpawned
		{
			get => GetProperty(ref _cyberwareArmsBeingSpawned);
			set => SetProperty(ref _cyberwareArmsBeingSpawned, value);
		}

		[Ordinal(25)] 
		[RED("cyberwareArmsVisible")] 
		public CBool CyberwareArmsVisible
		{
			get => GetProperty(ref _cyberwareArmsVisible);
			set => SetProperty(ref _cyberwareArmsVisible, value);
		}

		[Ordinal(26)] 
		[RED("cyberwareArmsItem")] 
		public gameItemID CyberwareArmsItem
		{
			get => GetProperty(ref _cyberwareArmsItem);
			set => SetProperty(ref _cyberwareArmsItem, value);
		}

		public PhotoModePlayerEntityComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
