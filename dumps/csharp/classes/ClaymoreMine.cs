using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClaymoreMine : gameweaponObject
	{
		private CHandle<entMeshComponent> _visualComponent;
		private CHandle<entMeshComponent> _triggerAreaIndicator;
		private CHandle<entSimpleColliderComponent> _shootCollision;
		private CHandle<gameStaticTriggerAreaComponent> _triggerComponent;
		private CBool _alive;
		private CBool _armed;

		[Ordinal(66)] 
		[RED("visualComponent")] 
		public CHandle<entMeshComponent> VisualComponent
		{
			get => GetProperty(ref _visualComponent);
			set => SetProperty(ref _visualComponent, value);
		}

		[Ordinal(67)] 
		[RED("triggerAreaIndicator")] 
		public CHandle<entMeshComponent> TriggerAreaIndicator
		{
			get => GetProperty(ref _triggerAreaIndicator);
			set => SetProperty(ref _triggerAreaIndicator, value);
		}

		[Ordinal(68)] 
		[RED("shootCollision")] 
		public CHandle<entSimpleColliderComponent> ShootCollision
		{
			get => GetProperty(ref _shootCollision);
			set => SetProperty(ref _shootCollision, value);
		}

		[Ordinal(69)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get => GetProperty(ref _triggerComponent);
			set => SetProperty(ref _triggerComponent, value);
		}

		[Ordinal(70)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(71)] 
		[RED("armed")] 
		public CBool Armed
		{
			get => GetProperty(ref _armed);
			set => SetProperty(ref _armed, value);
		}

		public ClaymoreMine(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
