using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleApplyZOffsetFromGroundEvent : redEvent
	{
		private CBool _sampleNavmesh;

		[Ordinal(0)] 
		[RED("sampleNavmesh")] 
		public CBool SampleNavmesh
		{
			get => GetProperty(ref _sampleNavmesh);
			set => SetProperty(ref _sampleNavmesh, value);
		}

		public vehicleApplyZOffsetFromGroundEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
