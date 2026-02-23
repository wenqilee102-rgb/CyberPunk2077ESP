using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PhotomodeBodyPartRotate : animAnimFeature
	{
		private CFloat _rotateDegree;

		[Ordinal(0)] 
		[RED("rotateDegree")] 
		public CFloat RotateDegree
		{
			get => GetProperty(ref _rotateDegree);
			set => SetProperty(ref _rotateDegree, value);
		}

		public AnimFeature_PhotomodeBodyPartRotate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
