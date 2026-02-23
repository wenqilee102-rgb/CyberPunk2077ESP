using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetCanvas : gameJournalInternetBase
	{
		private CBool _isHidden;

		[Ordinal(4)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		public gameJournalInternetCanvas(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
