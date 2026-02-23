using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPlayerReachablePrereq : gameIScriptablePrereq
	{
		private CBool _invert;
		private CBool _checkRMA;
		private CBool _checkOnlyRMA;
		private CFloat _minRMADistance;
		private CBool _canCheckProxy;
		private CFloat _horTolerance;
		private CFloat _verTolerance;

		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(1)] 
		[RED("checkRMA")] 
		public CBool CheckRMA
		{
			get => GetProperty(ref _checkRMA);
			set => SetProperty(ref _checkRMA, value);
		}

		[Ordinal(2)] 
		[RED("checkOnlyRMA")] 
		public CBool CheckOnlyRMA
		{
			get => GetProperty(ref _checkOnlyRMA);
			set => SetProperty(ref _checkOnlyRMA, value);
		}

		[Ordinal(3)] 
		[RED("minRMADistance")] 
		public CFloat MinRMADistance
		{
			get => GetProperty(ref _minRMADistance);
			set => SetProperty(ref _minRMADistance, value);
		}

		[Ordinal(4)] 
		[RED("canCheckProxy")] 
		public CBool CanCheckProxy
		{
			get => GetProperty(ref _canCheckProxy);
			set => SetProperty(ref _canCheckProxy, value);
		}

		[Ordinal(5)] 
		[RED("horTolerance")] 
		public CFloat HorTolerance
		{
			get => GetProperty(ref _horTolerance);
			set => SetProperty(ref _horTolerance, value);
		}

		[Ordinal(6)] 
		[RED("verTolerance")] 
		public CFloat VerTolerance
		{
			get => GetProperty(ref _verTolerance);
			set => SetProperty(ref _verTolerance, value);
		}

		public IsPlayerReachablePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
