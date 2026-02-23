using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModificationSystem : gameScriptableSystem
	{
		private wCHandle<gameIBlackboard> _blackboard;
		private CBool _cYBMETA1695;

		[Ordinal(0)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(1)] 
		[RED("CYBMETA1695")] 
		public CBool CYBMETA1695
		{
			get => GetProperty(ref _cYBMETA1695);
			set => SetProperty(ref _cYBMETA1695, value);
		}

		public ItemModificationSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
