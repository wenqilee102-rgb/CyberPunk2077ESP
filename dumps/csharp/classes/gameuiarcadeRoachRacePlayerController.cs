using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeRoachRacePlayerController : inkWidgetLogicController
	{
		private gameuiarcadeBoundingRect _collider;
		private Vector2 _singleJumpBoost;
		private Vector2 _doubleJumpBoost;
		private Vector2 _gravity;
		private CFloat _teleportLockoutTime;
		private CFloat _carrotPowerupVelocityBoostModifier;
		private Vector2 _runningBoundingRectangleRelativeSize;
		private Vector2 _jumpingboundingRectangleRelativeSize;
		private Vector2 _poweredupboundingRectangleRelativeSize;
		private CFloat _invincibilityTime;
		private CFloat _invincibilityWarningTime;
		private CFloat _roachDeathAnimationTime;
		private CFloat _roachDeathAnimationDisplacement;
		private inkImageWidgetReference _image;
		private CName _jumpSFX;
		private CName _doubleJumpSFX;
		private CName _teleportSFX;
		private CName _invincibilityStartSFX;
		private CName _invincibilityStopSFX;
		private CName _carrotPowerupStartSFX;
		private CName _carrotPowerupStopSFX;

		[Ordinal(1)] 
		[RED("collider")] 
		public gameuiarcadeBoundingRect Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		[Ordinal(2)] 
		[RED("singleJumpBoost")] 
		public Vector2 SingleJumpBoost
		{
			get => GetProperty(ref _singleJumpBoost);
			set => SetProperty(ref _singleJumpBoost, value);
		}

		[Ordinal(3)] 
		[RED("doubleJumpBoost")] 
		public Vector2 DoubleJumpBoost
		{
			get => GetProperty(ref _doubleJumpBoost);
			set => SetProperty(ref _doubleJumpBoost, value);
		}

		[Ordinal(4)] 
		[RED("gravity")] 
		public Vector2 Gravity
		{
			get => GetProperty(ref _gravity);
			set => SetProperty(ref _gravity, value);
		}

		[Ordinal(5)] 
		[RED("teleportLockoutTime")] 
		public CFloat TeleportLockoutTime
		{
			get => GetProperty(ref _teleportLockoutTime);
			set => SetProperty(ref _teleportLockoutTime, value);
		}

		[Ordinal(6)] 
		[RED("carrotPowerupVelocityBoostModifier")] 
		public CFloat CarrotPowerupVelocityBoostModifier
		{
			get => GetProperty(ref _carrotPowerupVelocityBoostModifier);
			set => SetProperty(ref _carrotPowerupVelocityBoostModifier, value);
		}

		[Ordinal(7)] 
		[RED("runningBoundingRectangleRelativeSize")] 
		public Vector2 RunningBoundingRectangleRelativeSize
		{
			get => GetProperty(ref _runningBoundingRectangleRelativeSize);
			set => SetProperty(ref _runningBoundingRectangleRelativeSize, value);
		}

		[Ordinal(8)] 
		[RED("jumpingboundingRectangleRelativeSize")] 
		public Vector2 JumpingboundingRectangleRelativeSize
		{
			get => GetProperty(ref _jumpingboundingRectangleRelativeSize);
			set => SetProperty(ref _jumpingboundingRectangleRelativeSize, value);
		}

		[Ordinal(9)] 
		[RED("poweredupboundingRectangleRelativeSize")] 
		public Vector2 PoweredupboundingRectangleRelativeSize
		{
			get => GetProperty(ref _poweredupboundingRectangleRelativeSize);
			set => SetProperty(ref _poweredupboundingRectangleRelativeSize, value);
		}

		[Ordinal(10)] 
		[RED("invincibilityTime")] 
		public CFloat InvincibilityTime
		{
			get => GetProperty(ref _invincibilityTime);
			set => SetProperty(ref _invincibilityTime, value);
		}

		[Ordinal(11)] 
		[RED("invincibilityWarningTime")] 
		public CFloat InvincibilityWarningTime
		{
			get => GetProperty(ref _invincibilityWarningTime);
			set => SetProperty(ref _invincibilityWarningTime, value);
		}

		[Ordinal(12)] 
		[RED("roachDeathAnimationTime")] 
		public CFloat RoachDeathAnimationTime
		{
			get => GetProperty(ref _roachDeathAnimationTime);
			set => SetProperty(ref _roachDeathAnimationTime, value);
		}

		[Ordinal(13)] 
		[RED("roachDeathAnimationDisplacement")] 
		public CFloat RoachDeathAnimationDisplacement
		{
			get => GetProperty(ref _roachDeathAnimationDisplacement);
			set => SetProperty(ref _roachDeathAnimationDisplacement, value);
		}

		[Ordinal(14)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(15)] 
		[RED("jumpSFX")] 
		public CName JumpSFX
		{
			get => GetProperty(ref _jumpSFX);
			set => SetProperty(ref _jumpSFX, value);
		}

		[Ordinal(16)] 
		[RED("doubleJumpSFX")] 
		public CName DoubleJumpSFX
		{
			get => GetProperty(ref _doubleJumpSFX);
			set => SetProperty(ref _doubleJumpSFX, value);
		}

		[Ordinal(17)] 
		[RED("teleportSFX")] 
		public CName TeleportSFX
		{
			get => GetProperty(ref _teleportSFX);
			set => SetProperty(ref _teleportSFX, value);
		}

		[Ordinal(18)] 
		[RED("invincibilityStartSFX")] 
		public CName InvincibilityStartSFX
		{
			get => GetProperty(ref _invincibilityStartSFX);
			set => SetProperty(ref _invincibilityStartSFX, value);
		}

		[Ordinal(19)] 
		[RED("invincibilityStopSFX")] 
		public CName InvincibilityStopSFX
		{
			get => GetProperty(ref _invincibilityStopSFX);
			set => SetProperty(ref _invincibilityStopSFX, value);
		}

		[Ordinal(20)] 
		[RED("carrotPowerupStartSFX")] 
		public CName CarrotPowerupStartSFX
		{
			get => GetProperty(ref _carrotPowerupStartSFX);
			set => SetProperty(ref _carrotPowerupStartSFX, value);
		}

		[Ordinal(21)] 
		[RED("carrotPowerupStopSFX")] 
		public CName CarrotPowerupStopSFX
		{
			get => GetProperty(ref _carrotPowerupStopSFX);
			set => SetProperty(ref _carrotPowerupStopSFX, value);
		}

		public gameuiarcadeRoachRacePlayerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
