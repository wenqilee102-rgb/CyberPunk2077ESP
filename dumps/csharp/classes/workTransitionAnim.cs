using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workTransitionAnim : CVariable
	{
		private CName _idleA;
		private CName _idleB;
		private CName _transitionAtoB;
		private CName _transitionBtoA;

		[Ordinal(0)] 
		[RED("idleA")] 
		public CName IdleA
		{
			get => GetProperty(ref _idleA);
			set => SetProperty(ref _idleA, value);
		}

		[Ordinal(1)] 
		[RED("idleB")] 
		public CName IdleB
		{
			get => GetProperty(ref _idleB);
			set => SetProperty(ref _idleB, value);
		}

		[Ordinal(2)] 
		[RED("transitionAtoB")] 
		public CName TransitionAtoB
		{
			get => GetProperty(ref _transitionAtoB);
			set => SetProperty(ref _transitionAtoB, value);
		}

		[Ordinal(3)] 
		[RED("transitionBtoA")] 
		public CName TransitionBtoA
		{
			get => GetProperty(ref _transitionBtoA);
			set => SetProperty(ref _transitionBtoA, value);
		}

		public workTransitionAnim(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
