using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankPlayerController : gameuiarcadeArcadePlayerController
	{
		private inkWidgetReference _avatarRef;
		private inkWidgetReference _health;
		private inkWidgetReference _lives;
		private inkWidgetReference _aeams;
		private inkWidgetReference _projectileSpawner;

		[Ordinal(2)] 
		[RED("avatarRef")] 
		public inkWidgetReference AvatarRef
		{
			get => GetProperty(ref _avatarRef);
			set => SetProperty(ref _avatarRef, value);
		}

		[Ordinal(3)] 
		[RED("health")] 
		public inkWidgetReference Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		[Ordinal(4)] 
		[RED("lives")] 
		public inkWidgetReference Lives
		{
			get => GetProperty(ref _lives);
			set => SetProperty(ref _lives, value);
		}

		[Ordinal(5)] 
		[RED("aeams")] 
		public inkWidgetReference Aeams
		{
			get => GetProperty(ref _aeams);
			set => SetProperty(ref _aeams, value);
		}

		[Ordinal(6)] 
		[RED("projectileSpawner")] 
		public inkWidgetReference ProjectileSpawner
		{
			get => GetProperty(ref _projectileSpawner);
			set => SetProperty(ref _projectileSpawner, value);
		}

		public gameuiarcadeTankPlayerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
