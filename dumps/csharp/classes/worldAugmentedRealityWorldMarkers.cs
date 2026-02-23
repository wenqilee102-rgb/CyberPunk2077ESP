using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAugmentedRealityWorldMarkers : ISerializable
	{
		private CArray<Transform> _transforms;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<Transform> Transforms
		{
			get => GetProperty(ref _transforms);
			set => SetProperty(ref _transforms, value);
		}

		public worldAugmentedRealityWorldMarkers(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
