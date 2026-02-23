using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FelledEvents : LocomotionGroundEvents
	{
		private CHandle<AnimFeature_Felled> _animFeatureFelled;

		[Ordinal(6)] 
		[RED("animFeatureFelled")] 
		public CHandle<AnimFeature_Felled> AnimFeatureFelled
		{
			get => GetProperty(ref _animFeatureFelled);
			set => SetProperty(ref _animFeatureFelled, value);
		}

		public FelledEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
