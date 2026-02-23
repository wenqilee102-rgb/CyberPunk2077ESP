using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RagdollControl : animAnimNode_Base
	{
		private CFloat _blendInDuration;
		private CFloat _blendOutDuration;
		private animPoseLink _inputPoseNode;

		[Ordinal(11)] 
		[RED("blendInDuration")] 
		public CFloat BlendInDuration
		{
			get => GetProperty(ref _blendInDuration);
			set => SetProperty(ref _blendInDuration, value);
		}

		[Ordinal(12)] 
		[RED("blendOutDuration")] 
		public CFloat BlendOutDuration
		{
			get => GetProperty(ref _blendOutDuration);
			set => SetProperty(ref _blendOutDuration, value);
		}

		[Ordinal(13)] 
		[RED("inputPoseNode")] 
		public animPoseLink InputPoseNode
		{
			get => GetProperty(ref _inputPoseNode);
			set => SetProperty(ref _inputPoseNode, value);
		}

		public animAnimNode_RagdollControl(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
