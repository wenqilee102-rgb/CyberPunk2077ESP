using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoboticArms : InteractiveDevice
	{
		private CName _workSFX;
		private CName _distractSFX;
		private CHandle<entAnimationControllerComponent> _animationController;
		private CHandle<AnimFeature_RoboticArm> _animFeature;

		[Ordinal(98)] 
		[RED("workSFX")] 
		public CName WorkSFX
		{
			get => GetProperty(ref _workSFX);
			set => SetProperty(ref _workSFX, value);
		}

		[Ordinal(99)] 
		[RED("distractSFX")] 
		public CName DistractSFX
		{
			get => GetProperty(ref _distractSFX);
			set => SetProperty(ref _distractSFX, value);
		}

		[Ordinal(100)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		[Ordinal(101)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoboticArm> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		public RoboticArms(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
