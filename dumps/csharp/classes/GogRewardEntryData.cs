using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRewardEntryData : IScriptable
	{
		private CString _title;
		private CString _description;
		private CName _icon;
		private CName _group;
		private CName _slotType;
		private CBool _isUnlocked;
		private wCHandle<gamedataGOGReward_Record> _record;

		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("group")] 
		public CName Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(4)] 
		[RED("slotType")] 
		public CName SlotType
		{
			get => GetProperty(ref _slotType);
			set => SetProperty(ref _slotType, value);
		}

		[Ordinal(5)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetProperty(ref _isUnlocked);
			set => SetProperty(ref _isUnlocked, value);
		}

		[Ordinal(6)] 
		[RED("record")] 
		public wCHandle<gamedataGOGReward_Record> Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		public GogRewardEntryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
