using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitRepresentation_Capsule : gameEffectObjectFilter_HitRepresentation
	{
		private CBool _flattenCapsuleToHeight;

		[Ordinal(0)] 
		[RED("flattenCapsuleToHeight")] 
		public CBool FlattenCapsuleToHeight
		{
			get => GetProperty(ref _flattenCapsuleToHeight);
			set => SetProperty(ref _flattenCapsuleToHeight, value);
		}

		public gameEffectObjectFilter_HitRepresentation_Capsule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
