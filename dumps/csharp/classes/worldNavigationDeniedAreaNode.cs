using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationDeniedAreaNode : worldAreaShapeNode
	{
		private CBool _human;
		private CBool _vehicle;

		[Ordinal(6)] 
		[RED("human")] 
		public CBool Human
		{
			get => GetProperty(ref _human);
			set => SetProperty(ref _human, value);
		}

		[Ordinal(7)] 
		[RED("vehicle")] 
		public CBool Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		public worldNavigationDeniedAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
