using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseBullet : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _acceleration;
		private CFloat _lifetime_412;
		private CBool _alive;

		[Ordinal(48)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(49)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetProperty(ref _countTime);
			set => SetProperty(ref _countTime, value);
		}

		[Ordinal(50)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(51)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get => GetProperty(ref _acceleration);
			set => SetProperty(ref _acceleration, value);
		}

		[Ordinal(52)] 
		[RED("lifetime")] 
		public CFloat Lifetime_412
		{
			get => GetProperty(ref _lifetime_412);
			set => SetProperty(ref _lifetime_412, value);
		}

		[Ordinal(53)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		public BaseBullet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
