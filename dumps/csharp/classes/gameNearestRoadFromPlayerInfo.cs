using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNearestRoadFromPlayerInfo : CVariable
	{
		private CFloat _pathLength;
		private Vector4 _point;

		[Ordinal(0)] 
		[RED("pathLength")] 
		public CFloat PathLength
		{
			get => GetProperty(ref _pathLength);
			set => SetProperty(ref _pathLength, value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector4 Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		public gameNearestRoadFromPlayerInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
