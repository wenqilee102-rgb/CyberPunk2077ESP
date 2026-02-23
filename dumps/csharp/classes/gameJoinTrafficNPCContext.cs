using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJoinTrafficNPCContext : CVariable
	{
		private Vector3 _startPosition;
		private Vector3 _threatPosition;
		private CFloat _threatRadius;
		private CBool _checkRoadIntersection;
		private CBool _usePreviousPosition;

		[Ordinal(0)] 
		[RED("startPosition")] 
		public Vector3 StartPosition
		{
			get => GetProperty(ref _startPosition);
			set => SetProperty(ref _startPosition, value);
		}

		[Ordinal(1)] 
		[RED("threatPosition")] 
		public Vector3 ThreatPosition
		{
			get => GetProperty(ref _threatPosition);
			set => SetProperty(ref _threatPosition, value);
		}

		[Ordinal(2)] 
		[RED("threatRadius")] 
		public CFloat ThreatRadius
		{
			get => GetProperty(ref _threatRadius);
			set => SetProperty(ref _threatRadius, value);
		}

		[Ordinal(3)] 
		[RED("checkRoadIntersection")] 
		public CBool CheckRoadIntersection
		{
			get => GetProperty(ref _checkRoadIntersection);
			set => SetProperty(ref _checkRoadIntersection, value);
		}

		[Ordinal(4)] 
		[RED("usePreviousPosition")] 
		public CBool UsePreviousPosition
		{
			get => GetProperty(ref _usePreviousPosition);
			set => SetProperty(ref _usePreviousPosition, value);
		}

		public gameJoinTrafficNPCContext(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
