using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SniperNest : SensorDevice
	{
		private CHandle<AnimFeature_SecurityTurretData> _animFeature;
		private CName _animFeatureName;
		private wCHandle<gameweaponObject> _weapon;
		private gameItemID _itemID;
		private NodeRef _teleportAfterEnter;
		private gameDelayID _burstDelayEvtID;
		private CBool _isBurstDelayOngoing;
		private gameDelayID _nextShootCycleDelayEvtID;
		private CBool _isShootingOngoing;
		private CFloat _timeToNextShot;
		private wCHandle<PlayerPuppet> _player;
		private CFloat _targetZoom;
		private CFloat _startZoom;
		private CFloat _zoomLerpTimeStamp;
		private CFloat _zoomLerpDuration;

		[Ordinal(200)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SecurityTurretData> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(201)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(202)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(203)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(204)] 
		[RED("teleportAfterEnter")] 
		public NodeRef TeleportAfterEnter
		{
			get => GetProperty(ref _teleportAfterEnter);
			set => SetProperty(ref _teleportAfterEnter, value);
		}

		[Ordinal(205)] 
		[RED("burstDelayEvtID")] 
		public gameDelayID BurstDelayEvtID
		{
			get => GetProperty(ref _burstDelayEvtID);
			set => SetProperty(ref _burstDelayEvtID, value);
		}

		[Ordinal(206)] 
		[RED("isBurstDelayOngoing")] 
		public CBool IsBurstDelayOngoing
		{
			get => GetProperty(ref _isBurstDelayOngoing);
			set => SetProperty(ref _isBurstDelayOngoing, value);
		}

		[Ordinal(207)] 
		[RED("nextShootCycleDelayEvtID")] 
		public gameDelayID NextShootCycleDelayEvtID
		{
			get => GetProperty(ref _nextShootCycleDelayEvtID);
			set => SetProperty(ref _nextShootCycleDelayEvtID, value);
		}

		[Ordinal(208)] 
		[RED("isShootingOngoing")] 
		public CBool IsShootingOngoing
		{
			get => GetProperty(ref _isShootingOngoing);
			set => SetProperty(ref _isShootingOngoing, value);
		}

		[Ordinal(209)] 
		[RED("timeToNextShot")] 
		public CFloat TimeToNextShot
		{
			get => GetProperty(ref _timeToNextShot);
			set => SetProperty(ref _timeToNextShot, value);
		}

		[Ordinal(210)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(211)] 
		[RED("targetZoom")] 
		public CFloat TargetZoom
		{
			get => GetProperty(ref _targetZoom);
			set => SetProperty(ref _targetZoom, value);
		}

		[Ordinal(212)] 
		[RED("startZoom")] 
		public CFloat StartZoom
		{
			get => GetProperty(ref _startZoom);
			set => SetProperty(ref _startZoom, value);
		}

		[Ordinal(213)] 
		[RED("zoomLerpTimeStamp")] 
		public CFloat ZoomLerpTimeStamp
		{
			get => GetProperty(ref _zoomLerpTimeStamp);
			set => SetProperty(ref _zoomLerpTimeStamp, value);
		}

		[Ordinal(214)] 
		[RED("zoomLerpDuration")] 
		public CFloat ZoomLerpDuration
		{
			get => GetProperty(ref _zoomLerpDuration);
			set => SetProperty(ref _zoomLerpDuration, value);
		}

		public SniperNest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
