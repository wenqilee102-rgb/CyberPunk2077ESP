using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Undead : animAnimFeature
	{
		private CBool _active;

		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		public AnimFeature_Undead(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
