using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MineBarrageProjectile : BaseProjectile
	{
		private gameFxResource _landIndicatorFX;
		private CHandle<gameFxInstance> _fxInstance;
		private CHandle<entMeshComponent> _visualComponent;
		private CBool _onGround;
		private CFloat _onGroundTimer;
		private wCHandle<gameweaponObject> _weapon;
		private CHandle<gamedataAttack_Record> _attack_record;
		private CFloat _detonationTimer;
		private CFloat _explosionRadius;
		private wCHandle<PlayerPuppet> _playerPuppet;
		private gameNewMappinID _mappinID;

		[Ordinal(48)] 
		[RED("landIndicatorFX")] 
		public gameFxResource LandIndicatorFX
		{
			get => GetProperty(ref _landIndicatorFX);
			set => SetProperty(ref _landIndicatorFX, value);
		}

		[Ordinal(49)] 
		[RED("fxInstance")] 
		public CHandle<gameFxInstance> FxInstance
		{
			get => GetProperty(ref _fxInstance);
			set => SetProperty(ref _fxInstance, value);
		}

		[Ordinal(50)] 
		[RED("visualComponent")] 
		public CHandle<entMeshComponent> VisualComponent
		{
			get => GetProperty(ref _visualComponent);
			set => SetProperty(ref _visualComponent, value);
		}

		[Ordinal(51)] 
		[RED("onGround")] 
		public CBool OnGround
		{
			get => GetProperty(ref _onGround);
			set => SetProperty(ref _onGround, value);
		}

		[Ordinal(52)] 
		[RED("onGroundTimer")] 
		public CFloat OnGroundTimer
		{
			get => GetProperty(ref _onGroundTimer);
			set => SetProperty(ref _onGroundTimer, value);
		}

		[Ordinal(53)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(54)] 
		[RED("attack_record")] 
		public CHandle<gamedataAttack_Record> Attack_record
		{
			get => GetProperty(ref _attack_record);
			set => SetProperty(ref _attack_record, value);
		}

		[Ordinal(55)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetProperty(ref _detonationTimer);
			set => SetProperty(ref _detonationTimer, value);
		}

		[Ordinal(56)] 
		[RED("explosionRadius")] 
		public CFloat ExplosionRadius
		{
			get => GetProperty(ref _explosionRadius);
			set => SetProperty(ref _explosionRadius, value);
		}

		[Ordinal(57)] 
		[RED("playerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(58)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		public MineBarrageProjectile(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
