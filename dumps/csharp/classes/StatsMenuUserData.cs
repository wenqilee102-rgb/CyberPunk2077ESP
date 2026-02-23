using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsMenuUserData : inkUserData
	{
		private CBool _menuVisited;

		[Ordinal(0)] 
		[RED("menuVisited")] 
		public CBool MenuVisited
		{
			get => GetProperty(ref _menuVisited);
			set => SetProperty(ref _menuVisited, value);
		}

		public StatsMenuUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
