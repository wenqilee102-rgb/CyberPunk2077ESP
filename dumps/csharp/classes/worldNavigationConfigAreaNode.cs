using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationConfigAreaNode : worldAreaShapeNode
	{
		private CBool _generateVariantsNavmesh;
		private CEnum<NavGenSamplingDensity> _detailSamplingDensity;
		private CBool _smoothWalkableAreas;
		private CBool _generateCrouchableAreas;

		[Ordinal(6)] 
		[RED("generateVariantsNavmesh")] 
		public CBool GenerateVariantsNavmesh
		{
			get => GetProperty(ref _generateVariantsNavmesh);
			set => SetProperty(ref _generateVariantsNavmesh, value);
		}

		[Ordinal(7)] 
		[RED("detailSamplingDensity")] 
		public CEnum<NavGenSamplingDensity> DetailSamplingDensity
		{
			get => GetProperty(ref _detailSamplingDensity);
			set => SetProperty(ref _detailSamplingDensity, value);
		}

		[Ordinal(8)] 
		[RED("smoothWalkableAreas")] 
		public CBool SmoothWalkableAreas
		{
			get => GetProperty(ref _smoothWalkableAreas);
			set => SetProperty(ref _smoothWalkableAreas, value);
		}

		[Ordinal(9)] 
		[RED("generateCrouchableAreas")] 
		public CBool GenerateCrouchableAreas
		{
			get => GetProperty(ref _generateCrouchableAreas);
			set => SetProperty(ref _generateCrouchableAreas, value);
		}

		public worldNavigationConfigAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
