using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KerenzikovDecisions : TimeDilationTransitions
	{
		private CHandle<DefaultTransitionStatListener> _statListener;
		private CFloat _activationGracePeriod;

		[Ordinal(0)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(1)] 
		[RED("activationGracePeriod")] 
		public CFloat ActivationGracePeriod
		{
			get => GetProperty(ref _activationGracePeriod);
			set => SetProperty(ref _activationGracePeriod, value);
		}

		public KerenzikovDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
