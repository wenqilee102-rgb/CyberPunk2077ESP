using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AbstractApplyQuickhackEffector : ModifyAttackEffector
	{
		private wCHandle<gameIBlackboard> _blackboard;
		private CFloat _applyQuickhackDelayConst;

		[Ordinal(0)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(1)] 
		[RED("applyQuickhackDelayConst")] 
		public CFloat ApplyQuickhackDelayConst
		{
			get => GetProperty(ref _applyQuickhackDelayConst);
			set => SetProperty(ref _applyQuickhackDelayConst, value);
		}

		public AbstractApplyQuickhackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
