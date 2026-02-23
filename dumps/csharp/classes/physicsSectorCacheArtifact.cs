using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSectorCacheArtifact : CResource
	{
		private CArray<physicsGeometryKey> _sectorGeometryKeys;
		private CHandle<physicsGeometryCacheArtifact> _sectorInPlaceGeometry;
		private Box _sectorBounds;

		[Ordinal(1)] 
		[RED("sectorGeometryKeys")] 
		public CArray<physicsGeometryKey> SectorGeometryKeys
		{
			get => GetProperty(ref _sectorGeometryKeys);
			set => SetProperty(ref _sectorGeometryKeys, value);
		}

		[Ordinal(2)] 
		[RED("sectorInPlaceGeometry")] 
		public CHandle<physicsGeometryCacheArtifact> SectorInPlaceGeometry
		{
			get => GetProperty(ref _sectorInPlaceGeometry);
			set => SetProperty(ref _sectorInPlaceGeometry, value);
		}

		[Ordinal(3)] 
		[RED("sectorBounds")] 
		public Box SectorBounds
		{
			get => GetProperty(ref _sectorBounds);
			set => SetProperty(ref _sectorBounds, value);
		}

		public physicsSectorCacheArtifact(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
