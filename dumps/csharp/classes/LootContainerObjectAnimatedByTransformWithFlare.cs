using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootContainerObjectAnimatedByTransformWithFlare : LootContainerObjectAnimatedByTransform
	{
		private CHandle<entIComponent> _colliderWithInteraction;
		private CHandle<entIComponent> _colliderWithoutInteraction;
		private CHandle<entIComponent> _lightComponent1;
		private CHandle<entIComponent> _lightComponent2;

		[Ordinal(50)] 
		[RED("colliderWithInteraction")] 
		public CHandle<entIComponent> ColliderWithInteraction
		{
			get => GetProperty(ref _colliderWithInteraction);
			set => SetProperty(ref _colliderWithInteraction, value);
		}

		[Ordinal(51)] 
		[RED("colliderWithoutInteraction")] 
		public CHandle<entIComponent> ColliderWithoutInteraction
		{
			get => GetProperty(ref _colliderWithoutInteraction);
			set => SetProperty(ref _colliderWithoutInteraction, value);
		}

		[Ordinal(52)] 
		[RED("lightComponent1")] 
		public CHandle<entIComponent> LightComponent1
		{
			get => GetProperty(ref _lightComponent1);
			set => SetProperty(ref _lightComponent1, value);
		}

		[Ordinal(53)] 
		[RED("lightComponent2")] 
		public CHandle<entIComponent> LightComponent2
		{
			get => GetProperty(ref _lightComponent2);
			set => SetProperty(ref _lightComponent2, value);
		}

		public LootContainerObjectAnimatedByTransformWithFlare(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
