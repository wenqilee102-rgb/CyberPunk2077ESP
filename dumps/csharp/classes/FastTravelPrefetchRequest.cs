using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelPrefetchRequest : gameScriptableSystemRequest
	{
		private NodeRef _destinationRef;

		[Ordinal(0)] 
		[RED("destinationRef")] 
		public NodeRef DestinationRef
		{
			get => GetProperty(ref _destinationRef);
			set => SetProperty(ref _destinationRef, value);
		}

		public FastTravelPrefetchRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
