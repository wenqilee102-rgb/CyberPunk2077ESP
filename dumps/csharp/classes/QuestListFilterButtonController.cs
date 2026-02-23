using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListFilterButtonController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _counter;
		private CEnum<QuestListItemType> _filterType;
		private CBool _hovered;
		private CBool _active;

		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("counter")] 
		public inkTextWidgetReference Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		[Ordinal(3)] 
		[RED("filterType")] 
		public CEnum<QuestListItemType> FilterType
		{
			get => GetProperty(ref _filterType);
			set => SetProperty(ref _filterType, value);
		}

		[Ordinal(4)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(5)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		public QuestListFilterButtonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
