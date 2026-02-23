using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneFirstEquipState : redEvent
	{
		private CBool _prevented;

		[Ordinal(0)] 
		[RED("prevented")] 
		public CBool Prevented
		{
			get => GetProperty(ref _prevented);
			set => SetProperty(ref _prevented, value);
		}

		public SceneFirstEquipState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
