using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDisableWardrobeSetRequest : gamePlayerScriptableSystemRequest
	{
		private CBool _blockReequipping;

		[Ordinal(1)] 
		[RED("blockReequipping")] 
		public CBool BlockReequipping
		{
			get => GetProperty(ref _blockReequipping);
			set => SetProperty(ref _blockReequipping, value);
		}

		public QuestDisableWardrobeSetRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
