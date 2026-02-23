using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTargetingQueryRange_NodeType : questISceneManagerNodeType
	{
		private CFloat _targetingQueryRange;
		private CBool _resetToDefault;

		[Ordinal(0)] 
		[RED("targetingQueryRange")] 
		public CFloat TargetingQueryRange
		{
			get => GetProperty(ref _targetingQueryRange);
			set => SetProperty(ref _targetingQueryRange, value);
		}

		[Ordinal(1)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetProperty(ref _resetToDefault);
			set => SetProperty(ref _resetToDefault, value);
		}

		public questSetTargetingQueryRange_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
