using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JumpPod : gameObject
	{
		private CHandle<entIVisualComponent> _activationLight;
		private CHandle<entIComponent> _activationTrigger;
		private CFloat _impulseForward;
		private CFloat _impulseRight;
		private CFloat _impulseUp;

		[Ordinal(36)] 
		[RED("activationLight")] 
		public CHandle<entIVisualComponent> ActivationLight
		{
			get => GetProperty(ref _activationLight);
			set => SetProperty(ref _activationLight, value);
		}

		[Ordinal(37)] 
		[RED("activationTrigger")] 
		public CHandle<entIComponent> ActivationTrigger
		{
			get => GetProperty(ref _activationTrigger);
			set => SetProperty(ref _activationTrigger, value);
		}

		[Ordinal(38)] 
		[RED("impulseForward")] 
		public CFloat ImpulseForward
		{
			get => GetProperty(ref _impulseForward);
			set => SetProperty(ref _impulseForward, value);
		}

		[Ordinal(39)] 
		[RED("impulseRight")] 
		public CFloat ImpulseRight
		{
			get => GetProperty(ref _impulseRight);
			set => SetProperty(ref _impulseRight, value);
		}

		[Ordinal(40)] 
		[RED("impulseUp")] 
		public CFloat ImpulseUp
		{
			get => GetProperty(ref _impulseUp);
			set => SetProperty(ref _impulseUp, value);
		}

		public JumpPod(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
