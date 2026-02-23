using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanTransitionToThrowDecisions : CarriedObjectDecisions
	{
		private CName _throwNPCActionReleasedName;
		private CFloat _throwNPCActionReleasedTime;
		private CBool _canThrow;
		private CBool _canThrowInitialized;

		[Ordinal(0)] 
		[RED("throwNPCActionReleasedName")] 
		public CName ThrowNPCActionReleasedName
		{
			get => GetProperty(ref _throwNPCActionReleasedName);
			set => SetProperty(ref _throwNPCActionReleasedName, value);
		}

		[Ordinal(1)] 
		[RED("throwNPCActionReleasedTime")] 
		public CFloat ThrowNPCActionReleasedTime
		{
			get => GetProperty(ref _throwNPCActionReleasedTime);
			set => SetProperty(ref _throwNPCActionReleasedTime, value);
		}

		[Ordinal(2)] 
		[RED("canThrow")] 
		public CBool CanThrow
		{
			get => GetProperty(ref _canThrow);
			set => SetProperty(ref _canThrow, value);
		}

		[Ordinal(3)] 
		[RED("canThrowInitialized")] 
		public CBool CanThrowInitialized
		{
			get => GetProperty(ref _canThrowInitialized);
			set => SetProperty(ref _canThrowInitialized, value);
		}

		public CanTransitionToThrowDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
