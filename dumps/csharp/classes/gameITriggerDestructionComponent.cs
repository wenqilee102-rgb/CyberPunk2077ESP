using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameITriggerDestructionComponent : entIComponent
	{
		private CBool _startActive;

		[Ordinal(3)] 
		[RED("startActive")] 
		public CBool StartActive
		{
			get => GetProperty(ref _startActive);
			set => SetProperty(ref _startActive, value);
		}

		public gameITriggerDestructionComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
