using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceIgnoreTargets : ActionBool
	{
		private CBool _repeat;
		private CEnum<EAIAttitude> _attitude;

		[Ordinal(39)] 
		[RED("Repeat")] 
		public CBool Repeat
		{
			get => GetProperty(ref _repeat);
			set => SetProperty(ref _repeat, value);
		}

		[Ordinal(40)] 
		[RED("Attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		public ForceIgnoreTargets(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
