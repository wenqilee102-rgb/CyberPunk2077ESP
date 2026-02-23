using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBreachControllerComponent : entIComponent
	{
		private CBool _canHaveBreaches;
		private CBool _allowNormalBreachesAfterWeakspotsAreDestroyed;
		private CBool _debugAllowBreachesAfterDestruction;
		private CFloat _breachesScale;

		[Ordinal(3)] 
		[RED("canHaveBreaches")] 
		public CBool CanHaveBreaches
		{
			get => GetProperty(ref _canHaveBreaches);
			set => SetProperty(ref _canHaveBreaches, value);
		}

		[Ordinal(4)] 
		[RED("allowNormalBreachesAfterWeakspotsAreDestroyed")] 
		public CBool AllowNormalBreachesAfterWeakspotsAreDestroyed
		{
			get => GetProperty(ref _allowNormalBreachesAfterWeakspotsAreDestroyed);
			set => SetProperty(ref _allowNormalBreachesAfterWeakspotsAreDestroyed, value);
		}

		[Ordinal(5)] 
		[RED("debugAllowBreachesAfterDestruction")] 
		public CBool DebugAllowBreachesAfterDestruction
		{
			get => GetProperty(ref _debugAllowBreachesAfterDestruction);
			set => SetProperty(ref _debugAllowBreachesAfterDestruction, value);
		}

		[Ordinal(6)] 
		[RED("breachesScale")] 
		public CFloat BreachesScale
		{
			get => GetProperty(ref _breachesScale);
			set => SetProperty(ref _breachesScale, value);
		}

		public gameBreachControllerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
