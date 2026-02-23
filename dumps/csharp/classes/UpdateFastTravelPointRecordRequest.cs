using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateFastTravelPointRecordRequest : gameScriptableSystemRequest
	{
		private NodeRef _markerRef;

		[Ordinal(0)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get => GetProperty(ref _markerRef);
			set => SetProperty(ref _markerRef, value);
		}

		public UpdateFastTravelPointRecordRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
