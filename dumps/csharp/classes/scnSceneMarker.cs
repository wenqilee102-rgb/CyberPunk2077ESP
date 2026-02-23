using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarker : worldIMarker
	{
		private CArray<scnSceneMarkerInternalsAnimEventEntry> _markers;
		private CArray<scnSceneMarkerInternalsWorkspotEntry> _workspotMarkers;

		[Ordinal(0)] 
		[RED("markers")] 
		public CArray<scnSceneMarkerInternalsAnimEventEntry> Markers
		{
			get => GetProperty(ref _markers);
			set => SetProperty(ref _markers, value);
		}

		[Ordinal(1)] 
		[RED("workspotMarkers")] 
		public CArray<scnSceneMarkerInternalsWorkspotEntry> WorkspotMarkers
		{
			get => GetProperty(ref _workspotMarkers);
			set => SetProperty(ref _workspotMarkers, value);
		}

		public scnSceneMarker(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
