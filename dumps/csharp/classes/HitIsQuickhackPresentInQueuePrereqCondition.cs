using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsQuickhackPresentInQueuePrereqCondition : BaseHitPrereqCondition
	{
		private wCHandle<gamedataHackCategory_Record> _hackCategory;
		private CBool _isTheNextQhInQueue;

		[Ordinal(3)] 
		[RED("hackCategory")] 
		public wCHandle<gamedataHackCategory_Record> HackCategory
		{
			get => GetProperty(ref _hackCategory);
			set => SetProperty(ref _hackCategory, value);
		}

		[Ordinal(4)] 
		[RED("isTheNextQhInQueue")] 
		public CBool IsTheNextQhInQueue
		{
			get => GetProperty(ref _isTheNextQhInQueue);
			set => SetProperty(ref _isTheNextQhInQueue, value);
		}

		public HitIsQuickhackPresentInQueuePrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
