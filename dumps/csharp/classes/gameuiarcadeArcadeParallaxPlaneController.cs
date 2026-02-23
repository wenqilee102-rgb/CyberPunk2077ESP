using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeParallaxPlaneController : inkWidgetLogicController
	{
		private CEnum<gameuiarcadeArcadeParallaxPlaneControllerDisplacementAxis> _displacementAxis;
		private CEnum<gameuiarcadeArcadeParallaxPlaneControllerLoopType> _loopType;
		private CArray<inkWidgetReference> _segmentList;

		[Ordinal(1)] 
		[RED("displacementAxis")] 
		public CEnum<gameuiarcadeArcadeParallaxPlaneControllerDisplacementAxis> DisplacementAxis
		{
			get => GetProperty(ref _displacementAxis);
			set => SetProperty(ref _displacementAxis, value);
		}

		[Ordinal(2)] 
		[RED("loopType")] 
		public CEnum<gameuiarcadeArcadeParallaxPlaneControllerLoopType> LoopType
		{
			get => GetProperty(ref _loopType);
			set => SetProperty(ref _loopType, value);
		}

		[Ordinal(3)] 
		[RED("segmentList")] 
		public CArray<inkWidgetReference> SegmentList
		{
			get => GetProperty(ref _segmentList);
			set => SetProperty(ref _segmentList, value);
		}

		public gameuiarcadeArcadeParallaxPlaneController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
