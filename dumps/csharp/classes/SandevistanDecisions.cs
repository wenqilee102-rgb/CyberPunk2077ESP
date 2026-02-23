using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SandevistanDecisions : TimeDilationTransitions
	{
		private CHandle<DefaultTransitionStatListener> _statListener;

		[Ordinal(0)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		public SandevistanDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
