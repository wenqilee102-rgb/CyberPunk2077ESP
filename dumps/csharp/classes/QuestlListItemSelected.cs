using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestlListItemSelected : redEvent
	{
		private wCHandle<gameJournalQuest> _questData;
		private CBool _skipAnimation;
		private CInt32 _hash;
		private CUInt32 _selectionIndex;

		[Ordinal(0)] 
		[RED("questData")] 
		public wCHandle<gameJournalQuest> QuestData
		{
			get => GetProperty(ref _questData);
			set => SetProperty(ref _questData, value);
		}

		[Ordinal(1)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get => GetProperty(ref _skipAnimation);
			set => SetProperty(ref _skipAnimation, value);
		}

		[Ordinal(2)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(3)] 
		[RED("selectionIndex")] 
		public CUInt32 SelectionIndex
		{
			get => GetProperty(ref _selectionIndex);
			set => SetProperty(ref _selectionIndex, value);
		}

		public QuestlListItemSelected(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
